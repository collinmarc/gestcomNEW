Imports vini_DB
Imports System.ServiceProcess
Imports MailKit.Net.Smtp
Imports MimeKit

Partial Public Class frmConstantes
    Inherits vini_app.FrmVinicom
    Private CONSTANTESTableAdapter As New vini_DB.dsVinicomTableAdapters.CONSTANTESTableAdapter()
    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(True)
    End Sub

    Protected Overrides Function frmSave() As Boolean

        Me.Validate()
        Me.DsVinicom1.CONSTANTES(0).CST_DATE_UPDATE = DateTime.Now
        Me.BindingSource1.EndEdit()
        Me.CONSTANTESTableAdapter.Update(Me.DsVinicom1.CONSTANTES)

        Param.LoadcolParams()
    End Function

    Private Sub frmConstantes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmConstantes_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmConstantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'DsVinicom.CONSTANTES'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CONSTANTESTableAdapter.Connection = Persist.oleDBConnection
        Me.CONSTANTESTableAdapter.Fill(Me.DsVinicom1.CONSTANTES)


        Call init_vini_service()

    End Sub

    Private Sub cbTestWebEdi_Click(sender As System.Object, e As System.EventArgs) Handles cbTestWebEdi.Click


        Try
            frmSave()
            Me.Cursor = Cursors.WaitCursor

            Dim strTempDir As String = Param.SMTP_TEMP + "/" + currentuser.code
            If Not My.Computer.FileSystem.DirectoryExists(strTempDir) Then
                My.Computer.FileSystem.CreateDirectory(strTempDir)
            End If

            DisplayStatus("Ajout d'une pièce attachée de test")
            My.Computer.FileSystem.WriteAllText(strTempDir + "/test.txt", "Ceci est un test", True)

            Dim bReturn As Boolean = ExportMail.SendMail(Param.SMTP_HOST,
                                Param.SMTP_PORT,
                                Param.SMTP_SSL,
                                Param.SMTP_USER,
                                Param.SMTP_PWD,
                                Param.SMTP_FROM,
                                tbWEBEDI_Destinataire.Text,
                                "TEST",
                                "Ceci est un message de test",
                                strTempDir + "/test.txt")
            If bReturn Then
                MessageBox.Show("Message envoyé")
            Else
                MessageBox.Show("ERREUR : " & ExportMail.Message)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If ex.InnerException IsNot Nothing Then
                MessageBox.Show(ex.InnerException.Message)
            End If
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub CONSTANTESBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub testFTPSERES()

        Dim oftp As clsFTPVinicom
        DisplayStatus("")

        setcursorWait()
        oftp = New clsFTPVinicom(Me.tbFTPVNCHost.Text, Me.tbFTPVNCUser.Text, Me.tbftpvnd_password.Text)

        If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
            My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory("./TESTFTP")

        Dim nFile As Integer
        Dim objSCMD As SousCommande
        Dim strSCMD_CSV As String
        Dim strPDFFileName As String
        nFile = FreeFile()
        FileOpen(nFile, "./TESTFTP/test.csv", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
        objSCMD = SousCommande.createandload(Persist.GetSCMDMinID())
        DisplayStatus("Chargement de " & objSCMD.code)
        objSCMD.load()
        objSCMD.loadcolLignes()
        DisplayStatus("Chargement de " & objSCMD.code & " CSV")
        strSCMD_CSV = objSCMD.toCSV()
        Print(nFile, strSCMD_CSV)
        FileClose(nFile)
        DisplayStatus("Chargement de " & objSCMD.code & " PDF")
        strPDFFileName = "./TESTFTP/" & objSCMD.code & ".PDF"
        objSCMD.genererPDF(PATHTOREPORTS, strPDFFileName)

        'Envoi du fichier par FTP
        DisplayStatus("Envoi du fichier par FTP ")

        If oftp.uploadFromDir("./TESTFTP") Then
            DisplayStatus("Envoi du fichier OK")
            'Suppression et recréation du répertoire de test
            If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
                My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory("./TESTFTP")
            strPDFFileName = objSCMD.code & ".PDF"

            DisplayStatus("Reception du fichier par FTP ")
            If (oftp.downloadToDir("./TESTFTP", strPDFFileName)) Then
                If My.Computer.FileSystem.FileExists("./TESTFTP/" & strPDFFileName) Then
                    DisplayStatus("Réception du fichier OK")
                Else
                    DisplayError("TESTFTP", "Le Fichier ./TESTFTP/" & strPDFFileName & " n'existe pas")
                End If
            Else
                DisplayError("TESTFTP", "Erreur en récupération de fichier")
            End If
        Else
            MsgBox("Erreur en Envoi de fichier")
        End If

        restoreCursor()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Dim myService As New ServiceController("vini_service")
        Dim n As Integer

        Me.Cursor = Cursors.WaitCursor
        ' Si le service n'est pas démarré, alors on le démarre
        If Not myService.Status = ServiceControllerStatus.Running Then
            myService.Start()
        End If
        n = 0
        Do While myService.Status <> ServiceControllerStatus.Running And n < 100
            Threading.Thread.Sleep(1000) 'Attends 10 Secondes avant
            n = n + 1
            myService.Refresh()
            init_vini_service()
        Loop
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbStopService_Click(sender As System.Object, e As System.EventArgs)
        Dim myService As New ServiceController("vini_service")

        Dim n As Integer
        ' Suspend l'exécution du service
        Try
            Me.Cursor = Cursors.WaitCursor
            ' Si le service peut être arrêté, alors on l'arrête
            If myService.CanStop Then
                myService.Stop()
                n = 0
                Do While myService.Status <> ServiceControllerStatus.Stopped And n < 100
                    Threading.Thread.Sleep(1000) 'Attends 10 Secondes avant
                    n = n + 1
                    myService.Refresh()
                    init_vini_service()
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show("Impossible de suspendre le service")
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub init_vini_service()
        ' Instanciation d'un objet ServiceController
        'Dim myService As New ServiceController("vini_service")


        'cbStartService.Enabled = False
        'cbStopService.Enabled = False
        'tbCST_SRVCE_NBSEC.Enabled = False
        'tbCST_SRVCE_PATH.Enabled = False
        'tbCST_SRVCE_PATHERROR.Enabled = False

        '' Récupération de l'état actuel du service
        'If myService.Status = ServiceProcess.ServiceControllerStatus.Running Then
        '    cbStartService.Enabled = False
        '    cbStopService.Enabled = True
        'End If
        'If myService.Status = ServiceProcess.ServiceControllerStatus.Stopped Then
        '    cbStartService.Enabled = True
        '    cbStopService.Enabled = False
        '    tbCST_SRVCE_NBSEC.Enabled = True
        '    tbCST_SRVCE_PATH.Enabled = True
        '    tbCST_SRVCE_PATHERROR.Enabled = True
        'End If

    End Sub

    Private Sub tbImport_Click(sender As Object, e As EventArgs) Handles tbImport.Click
        Me.Cursor = Cursors.WaitCursor
        frmSave()
        'Envoi d'une commande fictive
        EnvoiCommandePrestashop()

        Dim olst As List(Of CommandeClient)
        Dim oImport As New ImportPrestashop(Param.IMAP_HOST, Param.IMAP_USER, Param.IMAP_PWD, Param.IMAP_PORT, Param.IMAP_SSL)
        oImport.MSGFolderName = Param.IMAP_MSGFOLDER
        olst = oImport.Import(False, ckCheck.Checked)
        Dim str As String = ""
        For Each oCmd As CommandeClient In olst
            If Not String.IsNullOrEmpty(str) Then
                str = str & ","
            End If
            str = str & oCmd.code & "(" & oCmd.NamePrestashop & ")"
        Next
        Me.Cursor = Cursors.Default
        MessageBox.Show(olst.Count & " Commandes Traitées mais non sauvegardées : " & str)

    End Sub
    Private Sub EnvoiCommandePrestashop()
        Dim strBody As String = ""
        strBody = ""
        strBody = strBody & "[?xml version = ""1.0"" encoding=""utf-8"" standalone=""yes"" ?]" & vbCrLf
        strBody = strBody & "[cmdprestashop]" & vbCrLf
        strBody = strBody & "[id]36[/id]" & vbCrLf
        strBody = strBody & "[name]ESZARIWUG[/name]" & vbCrLf
        strBody = strBody & "[customer_id][/customer_id]" & vbCrLf
        strBody = strBody & "[livraison_company]MCII[/livraison_company]" & vbCrLf
        strBody = strBody & "[livraison_name]MCII[/livraison_name]" & vbCrLf
        strBody = strBody & "[livraison_firstname]MCII[/livraison_firstname]" & vbCrLf
        strBody = strBody & "[livraison_adress1]23, la mettrie[/livraison_adress1]" & vbCrLf
        strBody = strBody & "[livraison_adress2][/livraison_adress2]" & vbCrLf
        strBody = strBody & "[livraison_postalcode]35250[/livraison_postalcode]" & vbCrLf
        strBody = strBody & "[livraison_city]Chasné sur illet[/livraison_city]" & vbCrLf
        strBody = strBody & "[lignes]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_zzzz[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_3[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[/lignes]" & vbCrLf
        strBody = strBody & "[/cmdprestashop]" & vbCrLf
        strBody = strBody & "[/xml]" & vbCrLf


        ExportMail.SendMail(Param.SMTP_HOST, Param.SMTP_PORT, Param.SMTP_SSL, Param.SMTP_USER, Param.SMTP_PWD, Param.IMAP_USER, "Test Commande", strBody, "", True)

    End Sub


    Private Sub cbTestFTPEDI_Click(sender As Object, e As EventArgs) Handles cbTestFTPEDI.Click
        TestFTPEDI()
    End Sub

    Private Sub TestFTPEDI()
        Dim oftp As clsFTPVinicom
        oftp = New clsFTPVinicom(Me.tbFTPEDISRV.Text, Me.tbFTPEDIUser.Text, Me.tbFTPEDIPwd.Text, Me.tbFTPEDIRep.Text)

        If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
            My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory("./TESTFTP")

        System.IO.File.WriteAllText("./TESTFTP/testFTPEDI.txt", "test")

        DisplayStatus("")
        'Envoi du fichier par FTP (Pas utile dans note cas)
        DisplayStatus("Envoi du fichier par FTP ")
        If oftp.uploadFromDir("./TESTFTP") Then
            DisplayStatus("Envoi du fichier OK")
            'Suppression et recréation du répertoire de test
            If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
                My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory("./TESTFTP")

            DisplayStatus("Reception du fichier par FTP ")
            If (oftp.downloadDirToDir("./TESTFTP", False)) Then
                If My.Computer.FileSystem.FileExists("./TESTFTP/" & "TestFTPEDI.txt") Then
                    DisplayStatus("Réception du fichier OK")
                    MsgBox("Test OK")
                Else
                    DisplayError("TESTFTP", "Le Fichier ./TESTFTP/" & "TestFTPEDI.txt" & " n'existe pas")
                End If
            Else
                DisplayError("TESTFTP", "Erreur en récupération de fichier")
            End If
        Else
            MsgBox("Erreur en Envoi de fichier")
        End If


    End Sub

    Private Sub tbWEBEDI_SMTPFROM_TextChanged(sender As Object, e As EventArgs) Handles tbWEBEDI_SMTPFROM.TextChanged

    End Sub


    Private Sub btnTestFTPvnd_Click(sender As Object, e As EventArgs) Handles btnTestFTPvnd.Click
        testFTPVND()
    End Sub

    Private Sub testFTPVNC()

        Dim oftp As clsFTPVinicom
        DisplayStatus("")

        setcursorWait()
        oftp = New clsFTPVinicom(Me.tbFTPVNCHost.Text, Me.tbFTPVNCUser.Text, Me.tbFTPVNCPassword.Text, Me.tbFTPVNCRemoteDir.Text)

        If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
            My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory("./TESTFTP")

        Dim nFile As Integer
        Dim objSCMD As SousCommande
        Dim strSCMD_CSV As String
        Dim strPDFFileName As String
        nFile = FreeFile()

        FileOpen(nFile, "./TESTFTP/test.csv", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
        objSCMD = SousCommande.createandload(Persist.GetSCMDMinID())
        DisplayStatus("Chargement de " & objSCMD.code)
        objSCMD.load()
        objSCMD.loadcolLignes()
        DisplayStatus("Chargement de " & objSCMD.code & " CSV")
        strSCMD_CSV = objSCMD.toCSV()
        Print(nFile, strSCMD_CSV)
        FileClose(nFile)
        DisplayStatus("Chargement de " & objSCMD.code & " PDF")
        strPDFFileName = "./TESTFTP/" & objSCMD.code & ".PDF"
        objSCMD.genererPDF(PATHTOREPORTS, strPDFFileName)

        'Créatino du fichier toVinicom.csv
        FileOpen(nFile, "./toVinicom.csv", OpenMode.Output, OpenAccess.Write)
        strSCMD_CSV = objSCMD.FTO_toCSVFromInternet
        Print(nFile, strSCMD_CSV)
        FileClose(nFile)

        'Envoi du fichier par FTP
        DisplayStatus("Envoi du fichier par FTP ")

        If oftp.uploadFromDir("./TESTFTP") Then
            DisplayStatus("Envoi du fichier OK")

            'Envoi du fichier tovinicom.csv
            oftp.remoteDir = Me.tbFTPVNCRemoteDir2.Text
            oftp.uploadFile("./toVinicom.csv")
            System.IO.File.Delete("./toVinicom.csv")

            'Suppression et recréation du répertoire de test
            If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
                My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory("./TESTFTP")



            oftp = New clsFTPVinicom(Me.tbFTPVNCHost.Text, Me.tbFTPVNCUser.Text, Me.tbFTPVNCPassword.Text, Me.tbFTPVNCRemoteDir2.Text)


            DisplayStatus("Reception du fichier par FTP ")
            If (oftp.downloadToDir("./TESTFTP")) Then
                If My.Computer.FileSystem.FileExists("./TESTFTP/toVinicom.csv") Then
                    DisplayStatus("Réception du fichier OK")
                Else
                    DisplayError("TESTFTP", "Le Fichier ./TESTFTP/toVinicom.csv n'existe pas")
                End If
            Else
                DisplayError("TESTFTP", "Erreur en récupération de fichier")
            End If
        Else
            MsgBox("Erreur en Envoi de fichier")
        End If

        restoreCursor()
    End Sub
    Private Sub testFTPVND()

        Dim oftp As clsFTPVinicom
        DisplayStatus("")

        setcursorWait()
        oftp = New clsFTPVinicom(Me.tbftpvnd_host.Text, Me.tbftpvnd_User.Text, Me.tbftpvnd_password.Text)

        If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
            My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory("./TESTFTP")

        Dim nFile As Integer
        Dim objSCMD As SousCommande
        Dim strSCMD_CSV As String
        Dim strPDFFileName As String
        nFile = FreeFile()
        FileOpen(nFile, "./TESTFTP/test.csv", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
        objSCMD = SousCommande.createandload(Persist.GetSCMDMinID())
        DisplayStatus("Chargement de " & objSCMD.code)
        objSCMD.load()
        objSCMD.loadcolLignes()
        DisplayStatus("Chargement de " & objSCMD.code & " CSV")
        strSCMD_CSV = objSCMD.toCSV()
        Print(nFile, strSCMD_CSV)
        FileClose(nFile)
        DisplayStatus("Chargement de " & objSCMD.code & " PDF")
        strPDFFileName = "./TESTFTP/" & objSCMD.code & ".PDF"
        objSCMD.genererPDF(PATHTOREPORTS, strPDFFileName)

        'Envoi du fichier par FTP
        DisplayStatus("Envoi du fichier par FTP ")
        If oftp.uploadFromDir("./TESTFTP") Then
            DisplayStatus("Envoi du fichier OK")

            'Suppression et recréation du répertoire de test
            If My.Computer.FileSystem.DirectoryExists("./TESTFTP") Then
                My.Computer.FileSystem.DeleteDirectory("./TESTFTP", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory("./TESTFTP")
            strPDFFileName = objSCMD.code & ".PDF"



            DisplayStatus("Reception du fichier par FTP ")
            If (oftp.downloadToDir("./TESTFTP", strPDFFileName)) Then
                If My.Computer.FileSystem.FileExists("./TESTFTP/" & strPDFFileName) Then
                    DisplayStatus("Réception du fichier OK")
                    MsgBox("Test OK")
                Else
                    DisplayError("TESTFTP", "Le Fichier ./TESTFTP/" & strPDFFileName & " n'existe pas")
                    MsgBox("Test NOK")
                End If
            Else
                DisplayError("TESTFTP", "Erreur en récupération de fichier")
                MsgBox("Test NOK")
            End If
        Else
            MsgBox("Erreur en Envoi de fichier")
        End If

        restoreCursor()
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub btnTestFTPvnc_Click_1(sender As Object, e As EventArgs) Handles btnTestFTPvnc.Click
        testFTPVNC()
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub
End Class