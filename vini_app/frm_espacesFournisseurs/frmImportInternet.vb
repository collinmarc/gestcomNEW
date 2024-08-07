Imports vini_DB
Public Class frmImportInternet
    Inherits FrmVinicom

    Private m_FileName As String
    Private m_Repertoire As String
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRechercher As Button
    Friend WithEvents lblNomFichier As Label
    Friend WithEvents grpFTP As GroupBox
    Friend WithEvents grpFichier As GroupBox
    Friend WithEvents m_ofd As OpenFileDialog
    Private m_oFTP As clsFTPVinicom = Nothing

#Region " Code g�n�r� par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()
    End Sub

    'La m�thode substitu�e Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE�: la proc�dure suivante est requise par le Concepteur Windows Form
    'Elle peut �tre modifi�e en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'�diteur de code.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents laTraitement As System.Windows.Forms.Label
    Friend WithEvents cbImport As System.Windows.Forms.Button
    Friend WithEvents ckFTP As System.Windows.Forms.CheckBox
    Friend WithEvents tbNbreLignesTraitees As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNbLignesATraiter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lnkHostName As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbErreurs As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbImport = New System.Windows.Forms.Button()
        Me.pbProgressBar = New System.Windows.Forms.ProgressBar()
        Me.laTraitement = New System.Windows.Forms.Label()
        Me.ckFTP = New System.Windows.Forms.CheckBox()
        Me.lbErreurs = New System.Windows.Forms.ListBox()
        Me.tbNbreLignesTraitees = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNbLignesATraiter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkHostName = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbRechercher = New System.Windows.Forms.Button()
        Me.lblNomFichier = New System.Windows.Forms.Label()
        Me.grpFTP = New System.Windows.Forms.GroupBox()
        Me.grpFichier = New System.Windows.Forms.GroupBox()
        Me.m_ofd = New System.Windows.Forms.OpenFileDialog()
        Me.grpFTP.SuspendLayout()
        Me.grpFichier.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cette fen�tre permet de r�cup�rer les rapprochements de factures des fournisseurs" &
    " �tablis par le site internet"
        '
        'cbImport
        '
        Me.cbImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbImport.Location = New System.Drawing.Point(5, 106)
        Me.cbImport.Name = "cbImport"
        Me.cbImport.Size = New System.Drawing.Size(579, 32)
        Me.cbImport.TabIndex = 2
        Me.cbImport.Text = "&Importer"
        '
        'pbProgressBar
        '
        Me.pbProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgressBar.Location = New System.Drawing.Point(8, 193)
        Me.pbProgressBar.Name = "pbProgressBar"
        Me.pbProgressBar.Size = New System.Drawing.Size(579, 24)
        Me.pbProgressBar.TabIndex = 2
        '
        'laTraitement
        '
        Me.laTraitement.Location = New System.Drawing.Point(8, 142)
        Me.laTraitement.Name = "laTraitement"
        Me.laTraitement.Size = New System.Drawing.Size(576, 10)
        Me.laTraitement.TabIndex = 3
        '
        'ckFTP
        '
        Me.ckFTP.Checked = True
        Me.ckFTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckFTP.Location = New System.Drawing.Point(11, 36)
        Me.ckFTP.Name = "ckFTP"
        Me.ckFTP.Size = New System.Drawing.Size(54, 24)
        Me.ckFTP.TabIndex = 4
        Me.ckFTP.Text = "FTP"
        '
        'lbErreurs
        '
        Me.lbErreurs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbErreurs.Location = New System.Drawing.Point(8, 223)
        Me.lbErreurs.Name = "lbErreurs"
        Me.lbErreurs.Size = New System.Drawing.Size(579, 251)
        Me.lbErreurs.TabIndex = 8
        '
        'tbNbreLignesTraitees
        '
        Me.tbNbreLignesTraitees.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNbreLignesTraitees.Enabled = False
        Me.tbNbreLignesTraitees.Location = New System.Drawing.Point(529, 167)
        Me.tbNbreLignesTraitees.Name = "tbNbreLignesTraitees"
        Me.tbNbreLignesTraitees.Size = New System.Drawing.Size(58, 20)
        Me.tbNbreLignesTraitees.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nbre de lignes trait�es :"
        '
        'tbNbLignesATraiter
        '
        Me.tbNbLignesATraiter.Enabled = False
        Me.tbNbLignesATraiter.Location = New System.Drawing.Point(131, 167)
        Me.tbNbLignesATraiter.Name = "tbNbLignesATraiter"
        Me.tbNbLignesATraiter.Size = New System.Drawing.Size(65, 20)
        Me.tbNbLignesATraiter.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nbre de lignes � traiter :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "site distant :"
        '
        'lnkHostName
        '
        Me.lnkHostName.AutoSize = True
        Me.lnkHostName.Location = New System.Drawing.Point(75, 16)
        Me.lnkHostName.Name = "lnkHostName"
        Me.lnkHostName.Size = New System.Drawing.Size(59, 13)
        Me.lnkHostName.TabIndex = 20
        Me.lnkHostName.TabStop = True
        Me.lnkHostName.Text = "LinkLabel1"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "fichier � importer :"
        '
        'cbRechercher
        '
        Me.cbRechercher.Location = New System.Drawing.Point(99, 12)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(75, 23)
        Me.cbRechercher.TabIndex = 22
        Me.cbRechercher.Text = "Rechercher"
        Me.cbRechercher.UseVisualStyleBackColor = True
        '
        'lblNomFichier
        '
        Me.lblNomFichier.AutoSize = True
        Me.lblNomFichier.Location = New System.Drawing.Point(180, 17)
        Me.lblNomFichier.Name = "lblNomFichier"
        Me.lblNomFichier.Size = New System.Drawing.Size(58, 13)
        Me.lblNomFichier.TabIndex = 23
        Me.lblNomFichier.Text = "nomFichier"
        '
        'grpFTP
        '
        Me.grpFTP.Controls.Add(Me.lnkHostName)
        Me.grpFTP.Controls.Add(Me.Label2)
        Me.grpFTP.Location = New System.Drawing.Point(131, 26)
        Me.grpFTP.Name = "grpFTP"
        Me.grpFTP.Size = New System.Drawing.Size(452, 34)
        Me.grpFTP.TabIndex = 24
        Me.grpFTP.TabStop = False
        '
        'grpFichier
        '
        Me.grpFichier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFichier.Controls.Add(Me.lblNomFichier)
        Me.grpFichier.Controls.Add(Me.Label5)
        Me.grpFichier.Controls.Add(Me.cbRechercher)
        Me.grpFichier.Location = New System.Drawing.Point(131, 58)
        Me.grpFichier.Name = "grpFichier"
        Me.grpFichier.Size = New System.Drawing.Size(453, 42)
        Me.grpFichier.TabIndex = 25
        Me.grpFichier.TabStop = False
        '
        'm_ofd
        '
        Me.m_ofd.AddExtension = False
        Me.m_ofd.DefaultExt = "csv"
        Me.m_ofd.FileName = "toVinicom.csv"
        Me.m_ofd.Filter = "Fichier CSV|*.csv"
        Me.m_ofd.InitialDirectory = "E:\Gestcom_Temp"
        Me.m_ofd.Multiselect = True
        Me.m_ofd.Title = "S�lection du fichier � importer"
        '
        'frmImportInternet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(595, 486)
        Me.Controls.Add(Me.grpFichier)
        Me.Controls.Add(Me.grpFTP)
        Me.Controls.Add(Me.tbNbreLignesTraitees)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbNbLignesATraiter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbErreurs)
        Me.Controls.Add(Me.ckFTP)
        Me.Controls.Add(Me.laTraitement)
        Me.Controls.Add(Me.pbProgressBar)
        Me.Controls.Add(Me.cbImport)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmImportInternet"
        Me.Text = "Import Internet"
        Me.grpFTP.ResumeLayout(False)
        Me.grpFTP.PerformLayout()
        Me.grpFichier.ResumeLayout(False)
        Me.grpFichier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = False
        m_ToolBarLoadEnabled = False
        m_ToolBarSaveEnabled = False
        m_ToolBarDelEnabled = False
        m_ToolBarRefreshEnabled = False

    End Sub


    Private Sub initFenetre()
        Me.Text = "Import des sous commandes depuis le site internet"
        lnkHostName.Text = Param.getConstante("CST_FTPVNC_HOST")
    End Sub
    Private Function import() As Boolean
        Dim bReturn As Boolean
        Dim nFile As Integer
        Dim strResult As String = ""
        Dim tabFiles As String()
        Dim nNbreLignes As Integer = 0

        Dim strFolder As String
        setcursorWait()
        Try
            lbErreurs.Items.Clear()
            'Creation du r�pertoire temporaire
            strFolder = My.Settings.Tmp & "/Importinternet" & DateTime.Now.ToString("yyyyMMdd")

            If My.Computer.FileSystem.DirectoryExists(strFolder) Then
                My.Computer.FileSystem.DeleteDirectory(strFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory(strFolder)
            ''Suppression du fichier toVinicom.csv
            'If My.Computer.FileSystem.FileExists("./toVinicom.csv") Then
            '    My.Computer.FileSystem.DeleteFile("./tovinicom.csv")
            'End If


            ' Ce champsest invisible et est lu dans le fichier appConfig
            If ckFTP.Checked Then
                'Activation de l'URL D'extraction
                ActiverExportBAF()
                m_oFTP = New clsFTPVinicom(Param.getConstante("CST_FTPVNC_HOST"),
                                                Param.getConstante("CST_FTPVNC_USER"),
                                                Param.getConstante("CST_FTPVNC_PASSWORD"),
                                                Param.getConstante("CST_FTPVNC_REMOTEDIR2")
                                                )
                'Suppresssion des fichiers apr�s t�l�chargement
                m_oFTP.downloadDirToDir(strFolder, True)
                '                m_oFTP.downloadToDir(strFolder)
            Else
                'Tableau des noms de fichiers avec le path
                tabFiles = m_ofd.FileNames()
                'Tableau des noms de fichiers
                Dim tabFileNames() As String = m_ofd.SafeFileNames()
                For i As Integer = 0 To tabFiles.Length - 1
                    System.IO.File.Copy(tabFiles(i), strFolder & "/" & tabFileNames(i))
                Next
            End If
            m_Repertoire = strFolder

            tabFiles = System.IO.Directory.GetFiles(m_Repertoire, "*.csv")
            nNbreLignes = 0
            For Each m_FileName As String In tabFiles
                nFile = FreeFile()
                FileOpen(nFile, m_FileName, OpenMode.Input, OpenAccess.Read)
                'Calcul du nombre de lignes � traiter pour initaliser la ProgressBar
                '-------------------------------------------------------------------
                strResult = LineInput(nFile)
                While Not EOF(nFile)
                    strResult = LineInput(nFile)
                    If Not String.IsNullOrEmpty(strResult) Then
                        nNbreLignes = nNbreLignes + 1
                    End If
                End While
                FileClose(nFile)
            Next
            pbProgressBar.Minimum = 0
            pbProgressBar.Maximum = nNbreLignes
            tbNbLignesATraiter.Text = nNbreLignes

            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            DisplayStatus("ERREUR :" & ex.ToString())
            bReturn = False
            FileClose(nFile)
        End Try
        restoreCursor()
        Return bReturn
    End Function
    Private Sub cdimport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbImport.Click
        import()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmImportInternet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
        ckFTP.Enabled = True
        ckFTP.Checked = True
#If DEBUG Then
        ckFTP.Checked = False
#End If
        cbRechercher.Enabled = True
        cbImport.Enabled = True
        lbErreurs.Enabled = True
        tbNbLignesATraiter.Enabled = True
        tbNbreLignesTraitees.Enabled = True

    End Sub
    Private Shadows Sub DisplayStatus(ByVal strMessage As String)

        lbErreurs.Items.Add(Now().ToShortTimeString() + " " + strMessage)
        Log(strMessage)
    End Sub
    Private Sub Log(ByVal strMessage As String)
        Trace.WriteLine(Now() + " " + strMessage)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim nFile As Integer
        Dim strResult As String
        Dim nSousCommandeTraitees As Integer
        Dim oScmd As SousCommande
        Dim tabfiles As String()
        Dim nLineNumber As Integer = 0

        nSousCommandeTraitees = 0
        tabfiles = System.IO.Directory.GetFiles(m_Repertoire, "*.csv")
        For Each NomFichier As String In tabfiles
            'on Traite chaque fichier 1 par 1
            nFile = FreeFile()
            FileOpen(nFile, NomFichier, OpenMode.Input, OpenAccess.Read)
            'Lecture de la ligne d'entete
            strResult = LineInput(nFile)
            While Not EOF(nFile)
                Try
                    strResult = LineInput(nFile)
                    If Not String.IsNullOrEmpty(strResult) Then
                        oScmd = SousCommande.ImportCSV_espfrnVNC(strResult)
                        nSousCommandeTraitees = nSousCommandeTraitees + 1
                        BackgroundWorker1.ReportProgress(nSousCommandeTraitees)
                        If oScmd IsNot Nothing Then
                            BackgroundWorker1.ReportProgress(0, oScmd.code & " TotalHT=" & oScmd.totalHTFacture.ToString("c") & " ,refFact=" & oScmd.refFactFournisseur)
                        Else
                            BackgroundWorker1.ReportProgress(0, "Sous commande inconnue : " & strResult)

                        End If

                    End If
                Catch Ex As Exception
                    BackgroundWorker1.ReportProgress(0, Ex.Message)
                End Try
            End While

            FileClose(nFile)
        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.ProgressPercentage > 0 Then
            pbProgressBar.Value = e.ProgressPercentage
            tbNbreLignesTraitees.Text = e.ProgressPercentage
        Else
            DisplayStatus(e.UserState)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If ckFTP.Checked Then
            If MsgBox("Import termin�, Suppression du fichier d'import", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                m_oFTP.deleteRemotefile(IMPORTFTP_FILENAME)
            End If
        End If
    End Sub
    Private Sub ActiverExportBAF()
        Dim odlg As New dlgWebBrowser()
        Dim uri_integ As Uri = New Uri(Param.getConstante("CST_FTPVNC_URL2"))
        odlg.WebBrowser1.Navigate(uri_integ)
        odlg.ShowDialog()
    End Sub

    Private Sub ckFTP_CheckedChanged(sender As Object, e As EventArgs) Handles ckFTP.CheckedChanged
        grpFTP.Visible = ckFTP.Checked
        grpFichier.Enabled = Not ckFTP.Checked
        grpFichier.Visible = Not ckFTP.Checked
        cbRechercher.Enabled = grpFichier.Visible
    End Sub

    Private Sub cbRechercher_Click(sender As Object, e As EventArgs) Handles cbRechercher.Click
        If m_ofd.ShowDialog() = DialogResult.OK Then
            lblNomFichier.Text = m_ofd.FileName
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles m_ofd.FileOk

    End Sub
End Class
