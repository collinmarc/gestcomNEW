Imports System.IO
Imports vini_DB
Imports System.Net.Mail

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
        ChargementLogs()
    End Sub

    Private Sub ChargementLogs()
        cmdwoo.LoadLogImportWoo()
        m_bsrcLog.Clear()
        LogImportWoo.ListItems.ListItems.ForEach(Sub(i)
                                                     m_bsrcLog.Add(i)
                                                 End Sub)
    End Sub
    Private Class Param
        Public m_ftpHost As String
        Public m_ftpuser As String
        Public m_ftpPassword As String
        Public m_ftpRepDistant As String
        Public m_ftpRepLocal As String
    End Class

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim o As New Param()
        o.m_ftpHost = tbFTPHostName.Text
        o.m_ftpuser = tbFTPUser.Text
        o.m_ftpPassword = tbFTPPassword.Text
        o.m_ftpRepDistant = tbRepDistant.Text
        o.m_ftpRepLocal = tbRepLocal.Text
        BackgroundWorker1.RunWorkerAsync(o)
    End Sub
        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim pDossierLocal As String
        Dim o As Param = CType(e.Argument, Param)
        pDossierLocal = o.m_ftpRepLocal & Now.ToString("yyyyMMddHHmmss")

        cmdwoo.SetFTP(o.m_ftpHost, o.m_ftpuser, o.m_ftpPassword, o.m_ftpRepDistant)

        cmdwoo.Import(pDossierLocal)

        End Sub

        Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            ChargementLogs()
        End Sub
    End Class

