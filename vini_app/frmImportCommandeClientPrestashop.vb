Imports System.IO
Imports vini_DB
Imports System.Net.Mail

Public Class frmImportcommandeClientPrestashop

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

    Private Sub cbRecharger_Click(sender As Object, e As EventArgs)
        ChargerFichierLog()
    End Sub

    Private Sub importCmd()
        Me.Cursor = Cursors.WaitCursor
        Dim olst As List(Of CommandeClient)
        olst = m_oImportPrestashop.Import(True)
        Me.Cursor = Cursors.Default

        MessageBox.Show(olst.Count & " Commandes importées")
        ChargerFichierLog()

    End Sub


    Private Sub ChargerFichierLog()
        Timer1.Enabled = False
        'Chargement du fichier de Log
        Me.Cursor = Cursors.WaitCursor
        lbMessages.Items.Clear()
        Dim oEntry As EventLogEntry
        Dim n As Integer
        Dim oEventLoag As EventLog = New EventLog("Application", System.Environment.MachineName)
        For n = (oEventLoag.Entries.Count - 1) To 0 Step -1
            oEntry = oEventLoag.Entries(n)
            If oEntry.Source = "vini_service" Then
                lbMessages.Items.Add(oEntry.TimeWritten & " " & oEntry.Message)
            End If
        Next
        Me.Cursor = Cursors.Default

        'If System.IO.File.Exists(ImportPrestashop.IMPORTLOGFILE) Then
        '    Dim st As StreamReader = New StreamReader(ImportPrestashop.IMPORTLOGFILE)
        '    Do While st.Peek() >= 0
        '        lbMessages.Items.Add(st.ReadLine())
        '    Loop
        '    st.Close()
        'End If
        Timer1.Enabled = True

    End Sub
    Private Sub formLoad()
        ChargerFichierLog()
        Timer1.Interval = 30000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ChargerFichierLog()
    End Sub
End Class

