Imports vini_DB
Public Class frmImportInfosTransport

    Inherits FrmVinicom
    Implements IObservateur

    Friend WithEvents Label1 As Label
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnParcourir As Button
    Friend WithEvents m_OpenFileDialog As OpenFileDialog
    Private m_bLoad As Boolean = True
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbQuitter As Button
    Private m_oImportTarif As ImportTarifGESTCOM

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
    Friend WithEvents btnImporter As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusMessageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnImporter = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.m_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImporter
        '
        Me.btnImporter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImporter.Location = New System.Drawing.Point(8, 70)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(848, 24)
        Me.btnImporter.TabIndex = 4
        Me.btnImporter.Text = "Importer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 109)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(848, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 132
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Fichier de contenant les informations (.csv) :"
        '
        'tbFilePath
        '
        Me.tbFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFilePath.Location = New System.Drawing.Point(228, 11)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(524, 20)
        Me.tbFilePath.TabIndex = 134
        '
        'btnParcourir
        '
        Me.btnParcourir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnParcourir.Location = New System.Drawing.Point(781, 8)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(75, 23)
        Me.btnParcourir.TabIndex = 135
        Me.btnParcourir.Text = "Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'm_OpenFileDialog
        '
        Me.m_OpenFileDialog.DefaultExt = "*.csv"
        Me.m_OpenFileDialog.FileName = "*.csv"
        Me.m_OpenFileDialog.Title = "Recherche de fichier Tarif"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(8, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(392, 13)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Le fichier doit avoir été enregistré au format CSV avec séparateur : point-virgul" &
    "e (;)"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 206)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(848, 121)
        Me.ListBox1.TabIndex = 152
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Liste des annomalies d'import"
        '
        'cbQuitter
        '
        Me.cbQuitter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbQuitter.Location = New System.Drawing.Point(781, 334)
        Me.cbQuitter.Name = "cbQuitter"
        Me.cbQuitter.Size = New System.Drawing.Size(75, 23)
        Me.cbQuitter.TabIndex = 155
        Me.cbQuitter.Text = "Quitter"
        Me.cbQuitter.UseVisualStyleBackColor = True
        '
        'frmImportInfosTransport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(868, 371)
        Me.Controls.Add(Me.cbQuitter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImporter)
        Me.Name = "frmImportInfosTransport"
        Me.Text = "Import des informations de transport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Méthodes Vinicom"
    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = False
        m_ToolBarLoadEnabled = False
        m_ToolBarDelEnabled = False
        m_ToolBarRefreshEnabled = False
        m_ToolBarSaveEnabled = False
    End Sub

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled)
        btnParcourir.Enabled = True
        btnImporter.Enabled = True

    End Sub


#End Region

#Region "Methodes privées"
    Private Sub initFenetre()

        EnableControls(True)



    End Sub




#Region "Export"
#Region "Methodes backGoundWorker"
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        importer(Me.tbFilePath.Text)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            ProgressBar1.Value = e.ProgressPercentage
            If e.UserState.ToString().StartsWith("ERR") Then
                ListBox1.Items.Add(e.UserState.ToString())
            End If
        Catch ex As Exception
            ListBox1.Items.Add(ex.Message)
        End Try
    End Sub
#End Region


    ''' <summary>
    ''' Actualisation du travail
    ''' </summary>
    ''' <param name="pObj"></param>
    ''' <remarks></remarks>
    Public Sub Actualiser(pObj As Observable) Implements IObservateur.Actualiser
        BackgroundWorker1.ReportProgress(1)
    End Sub

#End Region


    Private Sub Log(ByVal strMessage As String)
        Trace.WriteLine(Now() + " " + strMessage)
    End Sub
#End Region
#Region "Gestion des Evenements"
    Private Sub frmGestionSCMD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
        m_bLoad = False '' fin du load
    End Sub


#End Region

    Protected Overrides Sub AddHandlerValidated(ByVal ocol As System.Windows.Forms.Control.ControlCollection)
        'Dans cette fenêtre seul le bouton Génerer déclenche L'evenement Updated
        'AddHandler cbAppliquer.Click, AddressOf ControlUpdated
        'AddHandler cbGenerer.Click, AddressOf ControlUpdated
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = ProgressBar1.Maximum
        MsgBox("Import Terminé")
        restoreCursor()
        cbQuitter.Enabled = True
    End Sub

    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        If m_OpenFileDialog.ShowDialog() Then
            tbFilePath.Text = m_OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
        If MsgBox("Cet import va mettre à jour les informations de transport dans les commandes et les bon d'appro, êtes-vous sûr ?", vbYesNo) = DialogResult.Yes Then
            Me.ProgressBar1.Minimum = 0
            Me.ProgressBar1.Maximum = 100
            Me.ProgressBar1.Value = Me.ProgressBar1.Minimum
            ListBox1.Items.Clear()
            cbQuitter.Enabled = False
            setcursorWait()
            BackgroundWorker1.RunWorkerAsync()
            restoreCursor()

        End If
    End Sub

    Private Sub importer(pCSVFile As String)
        Try

            Dim nMax As Integer = 0
            Dim nIndex As Integer = 0
            '            If IO.File.Exists(pCSVFile) Then
            Dim lst As List(Of InfosTransportCSV)
            lst = InfosTransportCSV.Read(pCSVFile)
            nMax = lst.Count
            nIndex = 0
            For Each oInfos As InfosTransportCSV In lst
                nIndex = nIndex + 1
                Dim oCmd As Commande
                Select Case oInfos.typeCMD_BA
                    Case "CMD"
                        Dim oCol As Collection = CommandeClient.getListe(oInfos.RefCMD_BA, "", vncEtatCommande.vncRien, "")
                        If oCol.Count > 0 Then
                            oCmd = oCol(1)

                            Persist.executeSQLNonQuery("UPDATE COMMANDE SET CMD_LETTREVOITURE = '" & oInfos.LettreVoiture & "' , CMD_COUT_TRANSPORT = " & oInfos.coutstr & ", CMD_REFFACT_TRP = '" & oInfos.RefFactTrp & "'  WHERE CMD_ID = " & oCmd.id & "")
                            BackgroundWorker1.ReportProgress(nIndex / nMax * 100, "CMD" & oCmd.id)
                        Else
                            BackgroundWorker1.ReportProgress(nIndex / nMax * 100, "ERR : Commande introuvable" & "[" & nIndex & "] (" & oInfos.RefCMD_BA & ")")
                        End If
                    Case "BA"
                        Dim oCol As Collection = BonAppro.getListe(oInfos.RefCMD_BA)
                        If oCol.Count > 0 Then
                            oCmd = oCol(1)
                            Persist.executeSQLNonQuery("UPDATE BONAPPRO SET CMD_LETTREVOITURE = '" & oInfos.LettreVoiture & "' , CMD_COUT_TRANSPORT = " & oInfos.coutstr & ", CMD_REFFACT_TRP = '" & oInfos.RefFactTrp & "'  WHERE CMD_ID = " & oCmd.id & "")
                            BackgroundWorker1.ReportProgress(nIndex / nMax * 100, "BA" & oCmd.id)
                        Else
                            BackgroundWorker1.ReportProgress(nIndex / nMax * 100, "ERR : BA introuvable" & "[" & nIndex & "] (" & oInfos.RefCMD_BA & ")")
                        End If
                    Case Else
                        BackgroundWorker1.ReportProgress(nIndex / nMax * 100, "ERR : Type inconnu (" & oInfos.typeCMD_BA & ")")
                End Select
            Next
            ' End If
        Catch ex As Exception
            BackgroundWorker1.ReportProgress(100, "ERR : " & ex.Message)
        End Try
    End Sub

    Private Sub cbQuitter_Click(sender As Object, e As EventArgs) Handles cbQuitter.Click
        Me.Close()
    End Sub
End Class
