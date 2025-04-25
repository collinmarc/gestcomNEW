Imports vini_DB
Public Class frmImportTarif
    Inherits FrmVinicom
    Implements IObservateur

    Friend WithEvents Label1 As Label
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnParcourir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents m_OpenFileDialog As OpenFileDialog
    Friend WithEvents nupNumColCode As NumericUpDown
    Friend WithEvents nupNumColTarifA As NumericUpDown
    Private m_bLoad As Boolean = True
    Friend WithEvents lblMsg As Label
    Friend WithEvents nupNumColTarifB As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nupNumColTarifC120b As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nupNumColTarifC60b As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nupNumColTarifC36b As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nupNumColTarifE As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents nupNumColTarifD As NumericUpDown
    Friend WithEvents Label10 As Label
    Private m_oImportTarif As ImportTarifGESTCOM

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.nupNumColCode = New System.Windows.Forms.NumericUpDown()
        Me.nupNumColTarifA = New System.Windows.Forms.NumericUpDown()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.nupNumColTarifB = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nupNumColTarifC120b = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nupNumColTarifC60b = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nupNumColTarifC36b = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nupNumColTarifE = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nupNumColTarifD = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.nupNumColCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifC120b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifC60b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifC36b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNumColTarifD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImporter
        '
        Me.btnImporter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImporter.Location = New System.Drawing.Point(15, 301)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(848, 24)
        Me.btnImporter.TabIndex = 4
        Me.btnImporter.Text = "Importer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 345)
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
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Fichier de tarif (.csv) :"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(126, 11)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(626, 20)
        Me.tbFilePath.TabIndex = 134
        '
        'btnParcourir
        '
        Me.btnParcourir.Location = New System.Drawing.Point(781, 8)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(75, 23)
        Me.btnParcourir.TabIndex = 135
        Me.btnParcourir.Text = "Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Num�ro de la colonne contenant le code (>=1)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Num�ro de la colonne contenant le tarif A (0=Pas d'import) :"
        '
        'm_OpenFileDialog
        '
        Me.m_OpenFileDialog.DefaultExt = "*.csv"
        Me.m_OpenFileDialog.FileName = "*.csv"
        Me.m_OpenFileDialog.Title = "Recherche de fichier Tarif"
        '
        'nupNumColCode
        '
        Me.nupNumColCode.Location = New System.Drawing.Point(323, 82)
        Me.nupNumColCode.Name = "nupNumColCode"
        Me.nupNumColCode.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColCode.TabIndex = 140
        Me.nupNumColCode.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupNumColTarifA
        '
        Me.nupNumColTarifA.Location = New System.Drawing.Point(323, 112)
        Me.nupNumColTarifA.Name = "nupNumColTarifA"
        Me.nupNumColTarifA.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifA.TabIndex = 141
        Me.nupNumColTarifA.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(408, 371)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(39, 13)
        Me.lblMsg.TabIndex = 144
        Me.lblMsg.Text = "Label5"
        '
        'nupNumColTarifB
        '
        Me.nupNumColTarifB.Location = New System.Drawing.Point(323, 138)
        Me.nupNumColTarifB.Name = "nupNumColTarifB"
        Me.nupNumColTarifB.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifB.TabIndex = 146
        Me.nupNumColTarifB.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Num�ro de la colonne contenant le tarif B (0=Pas d'import) :"
        '
        'nupNumColTarifC120b
        '
        Me.nupNumColTarifC120b.Location = New System.Drawing.Point(323, 164)
        Me.nupNumColTarifC120b.Name = "nupNumColTarifC120b"
        Me.nupNumColTarifC120b.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifC120b.TabIndex = 148
        Me.nupNumColTarifC120b.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 13)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Num�ro de la colonne contenant le tarif C120b (0=Pas d'import) :"
        '
        'nupNumColTarifC60b
        '
        Me.nupNumColTarifC60b.Location = New System.Drawing.Point(323, 190)
        Me.nupNumColTarifC60b.Name = "nupNumColTarifC60b"
        Me.nupNumColTarifC60b.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifC60b.TabIndex = 150
        Me.nupNumColTarifC60b.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Num�ro de la colonne contenant le tarif C60b (0=Pas d'import) :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(12, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 13)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Le fichier doit avoir �t� enregistr� au format CSV avec s�parateur ;"
        '
        'nupNumColTarifC36b
        '
        Me.nupNumColTarifC36b.Location = New System.Drawing.Point(323, 221)
        Me.nupNumColTarifC36b.Name = "nupNumColTarifC36b"
        Me.nupNumColTarifC36b.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifC36b.TabIndex = 153
        Me.nupNumColTarifC36b.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 13)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Num�ro de la colonne contenant le tarif C36b (0=Pas d'import) :"
        '
        'nupNumColTarifE
        '
        Me.nupNumColTarifE.Location = New System.Drawing.Point(323, 275)
        Me.nupNumColTarifE.Name = "nupNumColTarifE"
        Me.nupNumColTarifE.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifE.TabIndex = 155
        Me.nupNumColTarifE.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(287, 13)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Num�ro de la colonne contenant le tarif E (0=Pas d'import) :"
        '
        'nupNumColTarifD
        '
        Me.nupNumColTarifD.Location = New System.Drawing.Point(322, 249)
        Me.nupNumColTarifD.Name = "nupNumColTarifD"
        Me.nupNumColTarifD.Size = New System.Drawing.Size(40, 20)
        Me.nupNumColTarifD.TabIndex = 157
        Me.nupNumColTarifD.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(288, 13)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Num�ro de la colonne contenant le tarif D (0=Pas d'import) :"
        '
        'frmImportTarif
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(868, 470)
        Me.Controls.Add(Me.nupNumColTarifD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.nupNumColTarifE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nupNumColTarifC36b)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nupNumColTarifC60b)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nupNumColTarifC120b)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nupNumColTarifB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.nupNumColTarifA)
        Me.Controls.Add(Me.nupNumColCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImporter)
        Me.Name = "frmImportTarif"
        Me.Text = "Import des tarifs � partir du referentiel EXCEL"
        CType(Me.nupNumColCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifC120b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifC60b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifC36b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNumColTarifD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "M�thodes Vinicom"
    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = False
        m_ToolBarLoadEnabled = False
        m_ToolBarDelEnabled = False
        m_ToolBarRefreshEnabled = False
        m_ToolBarSaveEnabled = False
    End Sub

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled)
        nupNumColCode.Enabled = True
        nupNumColTarifA.Enabled = True
        btnParcourir.Enabled = True
        btnImporter.Enabled = True

    End Sub


#End Region

#Region "Methodes priv�es"
    Private Sub initFenetre()

        EnableControls(True)



    End Sub




#Region "Export"
#Region "Methodes backGoundWorker"
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        importer()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            ProgressBar1.Value = ProgressBar1.Value + 1
            lblMsg.Text = m_oImportTarif.message
        Catch ex As Exception

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
        'Dans cette fen�tre seul le bouton G�nerer d�clenche L'evenement Updated
        'AddHandler cbAppliquer.Click, AddressOf ControlUpdated
        'AddHandler cbGenerer.Click, AddressOf ControlUpdated
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = ProgressBar1.Maximum
        MsgBox("Import Termin�")
        restoreCursor()
    End Sub

    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        If m_OpenFileDialog.ShowDialog() Then
            tbFilePath.Text = m_OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
        If MsgBox("Cet import va mettre � jour les Tarif A, B, C120b, c60b, c36b, E    des produits, �tes-vous s�r ?", vbYesNo) = DialogResult.Yes Then
            m_oImportTarif = New ImportTarifGESTCOM(pFileName:=tbFilePath.Text, pNumColCode:=nupNumColCode.Value, pNumColTarifA:=nupNumColTarifA.Value, pNumColTarifB:=nupNumColTarifB.Value, pNumColTarifC120b:=nupNumColTarifC120b.Value, pNumColTarifC60b:=nupNumColTarifC60b.Value, pNumColTarifC36b:=nupNumColTarifC36b.Value, pNumColTarifD:=nupNumColTarifD.Value, pNumColTarifE:=nupNumColTarifE.Value)
            m_oImportTarif.AjouteObservateur(Me)
            Me.ProgressBar1.Minimum = 0
            Me.ProgressBar1.Maximum = m_oImportTarif.getNbreLignes()
            Me.ProgressBar1.Value = Me.ProgressBar1.Minimum

            setcursorWait()
            BackgroundWorker1.RunWorkerAsync()
            restoreCursor()

        End If
    End Sub

    Private Sub importer()
        m_oImportTarif.ImportTarif()
    End Sub
End Class
