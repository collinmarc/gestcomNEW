Option Explicit On 
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Imports System.IO
Imports System.Linq

Public Class frmExportColisage
    Inherits FrmVinicom


#Region " Code généré par le Concepteur Windows Form "
    Private m_ListFRN As List(Of Fournisseur)
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
    Friend WithEvents tbCodeFourn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbExporter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents m_pgBar As ProgressBar
    Friend WithEvents ckFTP As CheckBox
    Friend WithEvents lblProgress As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents WebBrowser1 As WebBrowser

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbCodeFourn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbExporter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtPeriode = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.m_pgBar = New System.Windows.Forms.ProgressBar()
        Me.ckFTP = New System.Windows.Forms.CheckBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'tbCodeFourn
        '
        Me.tbCodeFourn.Location = New System.Drawing.Point(123, 16)
        Me.tbCodeFourn.Name = "tbCodeFourn"
        Me.tbCodeFourn.Size = New System.Drawing.Size(72, 20)
        Me.tbCodeFourn.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Code fournisseur :"
        '
        'cbExporter
        '
        Me.cbExporter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbExporter.Location = New System.Drawing.Point(824, 12)
        Me.cbExporter.Name = "cbExporter"
        Me.cbExporter.Size = New System.Drawing.Size(120, 23)
        Me.cbExporter.TabIndex = 2
        Me.cbExporter.Text = "Exporter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Période :"
        '
        'dtPeriode
        '
        Me.dtPeriode.CustomFormat = "MMMM yyyy"
        Me.dtPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPeriode.Location = New System.Drawing.Point(284, 15)
        Me.dtPeriode.Name = "dtPeriode"
        Me.dtPeriode.Size = New System.Drawing.Size(120, 20)
        Me.dtPeriode.TabIndex = 1
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'm_pgBar
        '
        Me.m_pgBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_pgBar.Location = New System.Drawing.Point(13, 65)
        Me.m_pgBar.Name = "m_pgBar"
        Me.m_pgBar.Size = New System.Drawing.Size(933, 23)
        Me.m_pgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.m_pgBar.TabIndex = 11
        '
        'ckFTP
        '
        Me.ckFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckFTP.AutoSize = True
        Me.ckFTP.Checked = True
        Me.ckFTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckFTP.Location = New System.Drawing.Point(698, 16)
        Me.ckFTP.Name = "ckFTP"
        Me.ckFTP.Size = New System.Drawing.Size(109, 17)
        Me.ckFTP.TabIndex = 12
        Me.ckFTP.Text = "Transfert par FTP"
        Me.ckFTP.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(418, 95)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(42, 13)
        Me.lblProgress.TabIndex = 13
        Me.lblProgress.Text = "0 / 100"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_annuler
        '
        Me.btn_annuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_annuler.Location = New System.Drawing.Point(836, 107)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(110, 23)
        Me.btn_annuler.TabIndex = 14
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(20, 136)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(924, 517)
        Me.WebBrowser1.TabIndex = 15
        '
        'frmExportColisage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(988, 686)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.ckFTP)
        Me.Controls.Add(Me.m_pgBar)
        Me.Controls.Add(Me.dtPeriode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCodeFourn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbExporter)
        Me.Name = "frmExportColisage"
        Me.Text = "Exportation des factures et récapitulatif colisage vers l'espace fournisseur VINI" &
    "COM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim m_strFolder As String
    Dim m_strFileCSV As String

    Private Sub frmMouvementArticle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnableControls(True)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub cbExporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbExporter.Click
        setcursorWait()
        ExporterColisage()
        restoreCursor()
    End Sub

    Private Sub ExporterColisage()
        'On Prend les fournisseurs indiqué comme Espace fournisseur
        m_ListFRN = Fournisseur.getListe().Where(Function(o) o.EspFrn).ToList()
        '        m_ListFRN = Fournisseur.getListe(tbCodeFourn.Text)

        m_pgBar.Maximum = m_ListFRN.Count() + 1
        m_pgBar.Minimum = 0
        m_pgBar.Value = 0

        m_strFolder = My.Settings.Tmp & "/ExportColisage" & DateTime.Now.ToString("yyyyMMdd")
        If Not System.IO.Directory.Exists(m_strFolder) Then
            System.IO.Directory.CreateDirectory(m_strFolder)
        End If
        If Directory.EnumerateFiles(m_strFolder).Count > 0 Then
            If MsgBox("Votre répertoire " & m_strFolder & " n'est pas vide, souhaitez-vous supprimer les fichiers existants avant l'export ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each strFile As String In Directory.EnumerateFiles(m_strFolder)
                    File.Delete(strFile)
                Next
            End If
        End If

        m_strFileCSV = m_strFolder & "/col" & dtPeriode.Value.Year & dtPeriode.Value.Month & dtPeriode.Value.Day & ".csv"



        BackgroundWorker1.RunWorkerAsync()
        cbExporter.Enabled = False
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim n As Integer = 0
            For Each oFrn As Fournisseur In m_ListFRN
                If BackgroundWorker1.CancellationPending Then
                    e.Cancel = True
                    Exit For
                End If
                Dim ddeb As DateTime, dFin As DateTime
                ddeb = New Date(dtPeriode.Value.Year, dtPeriode.Value.Month, 1)
                dFin = ddeb.AddMonths(1).AddDays(-1)
                Dim olst As List(Of FactColisageJ) = FactColisageJ.getListe(ddeb, dFin, oFrn.code)
                For Each oFact As FactColisageJ In olst
                    Dim strFilename As String
                    strFilename = "FCOL-" & oFrn.code & "-" & dtPeriode.Value.Year & dtPeriode.Value.Month & dtPeriode.Value.Day & ".pdf"
                    If oFact.genererPDFFacture(PATHTOREPORTS, m_strFolder & "/" & strFilename) Then
                        Dim strLine As String
                        strLine = strFilename & ";" & oFrn.code & ";" & dtPeriode.Value.ToString("yyyyMMdd") & vbCrLf
                        File.AppendAllText(m_strFileCSV, strLine)
                    End If
                    strFilename = "RCAP-" & oFrn.code & "-" & dtPeriode.Value.Year & dtPeriode.Value.Month & dtPeriode.Value.Day & ".pdf"
                    If oFact.genererPDFRecap(PATHTOREPORTS, m_strFolder & "/" & strFilename) Then
                        Dim strLine As String
                        strLine = strFilename & ";" & oFrn.code & ";" & dtPeriode.Value.ToString("yyyyMMdd") & vbCrLf
                        File.AppendAllText(m_strFileCSV, strLine)
                    End If

                Next

                BackgroundWorker1.ReportProgress((n / m_ListFRN.Count()) * 100)
                n = n + 1
            Next
            If ckFTP.Checked And Not e.Cancel Then
                Dim oftp As clsFTPVinicom
                oftp = New clsFTPVinicom(Param.getConstante("CST_FTPVNC_HOST"), Param.getConstante("CST_FTPVNC_USER"), Param.getConstante("CST_FTPVNC_PASSWORD"))
                oftp.uploadFromDir(m_strFolder)
                BackgroundWorker1.ReportProgress(100)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            m_pgBar.Value = m_pgBar.Value + 1
            lblProgress.Text = m_pgBar.Value & "/" & m_pgBar.Maximum
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        WebBrowser1.Navigate(New Uri(Param.getConstante("CST_FTPVNC_URL")))
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Cursor = Cursors.Default
        MsgBox("export terminé")
        cbExporter.Enabled = True

    End Sub
End Class
