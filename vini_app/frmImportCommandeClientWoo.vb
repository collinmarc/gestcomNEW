Imports System.IO
Imports System.Linq
Imports vini_DB

Public Class frmImportcommandeClientWoo


    Private m_oImportPrestashop As ImportPrestashop
    Public Overrides Function getResume() As String
        Return "Import des commandes clients crées sur le site internet"
    End Function

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(True)
    End Sub


    Private Sub cbImporter_Click(sender As System.Object, e As System.EventArgs)
        importCmd()
    End Sub

    Private Sub frmImportcommandeClientPrestashop_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub


    Private Sub importCmd()
        Me.Cursor = Cursors.WaitCursor
        Dim olst As List(Of CommandeClient)
        olst = m_oImportPrestashop.Import(True)
        Me.Cursor = Cursors.Default

        MessageBox.Show(olst.Count & " Commandes importées")

    End Sub


    Private Sub formLoad()
        ckTous.Checked = True
        dtDateFin.Value = Now().Date
        dtDateDeb.Value = Now().Date
        ChargementLogs()
    End Sub

    Private Sub ChargementLogs()
        cmdwoo.LoadLogImportWoo()
        m_bsrcLog.Clear()
        Dim dDeb As DateTime = dtDateDeb.Value.Date
        Dim dfin As DateTime = dtDateFin.Value.Date.AddDays(1)


        LogImportWoo.ListItems.ListItems.ForEach(Sub(i)
                                                     If CDate(i.DateImport) >= dDeb And CDate(i.DateImport) <= dfin Then
                                                         If ckTous.Checked Or (Not i.PImport And Not ckTous.Checked) Then
                                                             m_bsrcLog.Add(i)
                                                         End If
                                                     End If
                                                 End Sub)
    End Sub
    Private Sub PurgerLogs()
        Dim dDeb As DateTime = dtDateDeb.Value.Date
        Dim dfin As DateTime = dtDateFin.Value.Date.AddDays(1)
        LogImportWoo.ListItems.ListItems.RemoveAll(Function(i)
                                                       Dim bReturn As Boolean = False
                                                       If CDate(i.DateImport) >= dDeb And CDate(i.DateImport) <= dfin Then
                                                           If ckTous.Checked Or (Not i.PImport And Not ckTous.Checked) Then
                                                               bReturn = True
                                                           End If
                                                       End If
                                                       Return bReturn
                                                   End Function)
        LogImportWoo.writeXml()

    End Sub
    Private Class Param
        Public m_ftpHost As String
        Public m_ftpuser As String
        Public m_ftpPassword As String
        Public m_ftpRepDistant As String
        Public m_ftpRepLocal As String
        Public m_ftpCommandesTraitees As String
    End Class

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim o As New Param()
        o.m_ftpHost = tbFTPHostName.Text
        o.m_ftpuser = tbFTPUser.Text
        o.m_ftpPassword = tbFTPPassword.Text
        o.m_ftpRepDistant = tbRepDistant.Text
        o.m_ftpRepLocal = tbRepLocal.Text
        o.m_ftpCommandesTraitees = tbCommandesTraitees.Text
        Me.Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync(o)
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim pDossierLocal As String
        Dim o As Param = CType(e.Argument, Param)
        pDossierLocal = o.m_ftpRepLocal & Now.ToString("yyyyMMddHHmmss")

        cmdwoo.SetFTP(o.m_ftpHost, o.m_ftpuser, o.m_ftpPassword, o.m_ftpRepDistant)
        cmdwoo.dossiercmdtraitees = o.m_ftpCommandesTraitees
        cmdwoo.Import(pDossierLocal)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ChargementLogs()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        ChargementLogs()
    End Sub

    Private Sub btnPurger_Click(sender As Object, e As EventArgs) Handles btnPurger.Click
        If MsgBox("Etes-vous sur de vouloir supprimer les traces entre le [" & dtDateDeb.Value.ToShortDateString & "] et le [ " & dtDateFin.Value.ToShortDateString() & "] ?", MsgBoxStyle.YesNo, "Suppression des logs d'import") = MsgBoxResult.Yes Then
            PurgerLogs()
            ChargementLogs()
        End If
    End Sub
End Class

