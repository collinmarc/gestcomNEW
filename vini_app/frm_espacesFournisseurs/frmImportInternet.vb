Imports vini_DB
Public Class frmImportInternet
    Inherits FrmVinicom

    Private m_FileName As String
    Private m_oFTP As clsFTPVinicom = Nothing

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()
    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cette fenêtre permet de récupérer les rapprochements de factures des fournisseurs" &
    " établis par le site internet"
        '
        'cbImport
        '
        Me.cbImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbImport.Location = New System.Drawing.Point(8, 96)
        Me.cbImport.Name = "cbImport"
        Me.cbImport.Size = New System.Drawing.Size(576, 32)
        Me.cbImport.TabIndex = 2
        Me.cbImport.Text = "&Importer"
        '
        'pbProgressBar
        '
        Me.pbProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgressBar.Location = New System.Drawing.Point(8, 193)
        Me.pbProgressBar.Name = "pbProgressBar"
        Me.pbProgressBar.Size = New System.Drawing.Size(576, 24)
        Me.pbProgressBar.TabIndex = 2
        '
        'laTraitement
        '
        Me.laTraitement.Location = New System.Drawing.Point(8, 136)
        Me.laTraitement.Name = "laTraitement"
        Me.laTraitement.Size = New System.Drawing.Size(576, 16)
        Me.laTraitement.TabIndex = 3
        '
        'ckFTP
        '
        Me.ckFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckFTP.Checked = Global.vini_app.My.MySettings.Default.ckFTP_Checked
        Me.ckFTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckFTP.Location = New System.Drawing.Point(530, -3)
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
        Me.lbErreurs.Size = New System.Drawing.Size(576, 251)
        Me.lbErreurs.TabIndex = 8
        '
        'tbNbreLignesTraitees
        '
        Me.tbNbreLignesTraitees.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNbreLignesTraitees.Enabled = False
        Me.tbNbreLignesTraitees.Location = New System.Drawing.Point(526, 167)
        Me.tbNbreLignesTraitees.Name = "tbNbreLignesTraitees"
        Me.tbNbreLignesTraitees.Size = New System.Drawing.Size(58, 20)
        Me.tbNbreLignesTraitees.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nbre de lignes traitées :"
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
        Me.Label3.Text = "Nbre de lignes à traiter :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "site distant :"
        '
        'lnkHostName
        '
        Me.lnkHostName.AutoSize = True
        Me.lnkHostName.Location = New System.Drawing.Point(78, 51)
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
        'frmImportInternet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 486)
        Me.Controls.Add(Me.lnkHostName)
        Me.Controls.Add(Me.Label2)
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
        Dim strImportFileName As String

        Dim strFolder As String
        setcursorWait()
        Try
            lbErreurs.Items.Clear()
            'Creation du répertoire temporaire
            strFolder = My.Settings.Tmp & "/Importinternet" & DateTime.Now.ToString("yyyyMMdd")

            If My.Computer.FileSystem.DirectoryExists(strFolder) Then
                My.Computer.FileSystem.DeleteDirectory(strFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory(strFolder)
            'Suppression du fichier toVinicom.csv
            If My.Computer.FileSystem.FileExists("./toVinicom.csv") Then
                My.Computer.FileSystem.DeleteFile("./tovinicom.csv")
            End If


            ' Ce champsest invisible et est lu dans le fichier appConfig
            If ckFTP.Checked Then
                m_oFTP = New clsFTPVinicom(Param.getConstante("CST_FTPVNC_HOST"),
                                                Param.getConstante("CST_FTPVNC_USER"),
                                                Param.getConstante("CST_FTPVNC_PASSWORD"),
                                                Param.getConstante("CST_FTPVNC_REMOTEDIR")
                                                )

                m_oFTP.downloadToDir(strFolder)
            Else
                lbErreurs.Items.Add("Connexion impossible (" + Param.getConstante("FTP_USERNAME") + " /" + Param.getConstante("FTP_PASSWORD") + ")")
            End If
            If My.Computer.FileSystem.FileExists(strFolder & "/toVinicom.csv") Then
                'Recopie du fichier d'import
                TraitementImportfichier(strFolder & "/toVinicom.csv")
                'Suppression du fichier d'import sur le seveur
            Else
                'pas de fichier à traité
                DisplayStatus("Pas de fichier d'import à traiter")
            End If

        Catch ex As Exception
            DisplayStatus("ERREUR :" & ex.ToString())
            bReturn = False
            FileClose(nFile)
        End Try
        restoreCursor()
        Return bReturn
    End Function
    Private Sub TraitementImportfichier(pstrImportfileName As String)

        Dim bReturn As Boolean
        Dim nFile As Integer
        Dim nLineNumber As Integer
        Dim strResult As String = ""
        Dim tabCSV As String()
        Dim nId As Integer
        Dim oSCMD As SousCommande
        Dim nSousCommandeTraitees As Integer ' Nbre de sousCommandes traitées

        nFile = FreeFile()
        FileOpen(nFile, pstrImportfileName, OpenMode.Input, OpenAccess.Read)
        'Calcul du nombre de lignes à traiter
        nLineNumber = 0
        While Not EOF(nFile)
            nLineNumber = nLineNumber + 1
            LineInput(nFile)
        End While
        FileClose(nFile)
        pbProgressBar.Minimum = 0
        pbProgressBar.Maximum = nLineNumber
        tbNbLignesATraiter.Text = nLineNumber
        nSousCommandeTraitees = 0
        tbNbreLignesTraitees.Text = nSousCommandeTraitees


        m_FileName = pstrImportfileName
        BackgroundWorker1.RunWorkerAsync()

        DisplayStatus("Nbre d'éléments traités :" & nSousCommandeTraitees)
        bReturn = True

    End Sub
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

        nFile = FreeFile()
        FileOpen(nFile, m_FileName, OpenMode.Input, OpenAccess.Read)
        nSousCommandeTraitees = 0
        While Not EOF(nFile)
            Try
                strResult = LineInput(nFile)
                SousCommande.ImportCSV(strResult)
                BackgroundWorker1.ReportProgress(nSousCommandeTraitees)

                nSousCommandeTraitees = nSousCommandeTraitees + 1
            Catch Ex As Exception
                BackgroundWorker1.ReportProgress(0, Ex.Message)
            End Try
        End While

        FileClose(nFile)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.ProgressPercentage > 0 Then
            pbProgressBar.Value = e.ProgressPercentage
        Else
            DisplayStatus(e.UserState)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If ckFTP.Checked Then
            If MsgBox("Import terminé, Suppression du fichier d'import", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                m_oFTP.deleteRemotefile(IMPORTFTP_FILENAME)
            End If
        End If
    End Sub
End Class
