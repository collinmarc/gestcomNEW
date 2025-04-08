Imports vini_DB
Public Class frmGestionMillesime
    Inherits FrmDonBase
    Private Const COL_STKDATE As Integer = 0
    Private Const COL_STKQTE As Integer = 1
    Private Const COL_STKLIBELLE As Integer = 2
    Private Const COL_STKINDEX As Integer = 3
    Private Const COL_NBRECOL As Integer = 4

    Private m_objProduitCourant As Produit
    Private m_objmvtCourant As mvtStock
    Friend WithEvents m_bsrcProduitRacine As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcRegion As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcCouleur As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcContenant As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcConditionnement As System.Windows.Forms.BindingSource
    Friend WithEvents Label24 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents m_bsrcDossier As BindingSource
    Friend WithEvents LogoList As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvPrdMillesime As DataGridView
    Friend WithEvents MillesimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbQuitter As Button
    Friend WithEvents cbValider As Button
    Friend WithEvents m_bsrcProduitMillesime As BindingSource
    Friend WithEvents cbAjouter As Button
    Friend WithEvents TarifCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents millesime As DataGridViewTextBoxColumn
    Friend WithEvents MillesimeCode As DataGridViewTextBoxColumn
    Friend WithEvents codeStat As DataGridViewTextBoxColumn
    Friend WithEvents BDisponibleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents bStock As DataGridViewCheckBoxColumn
    Friend WithEvents bFactureColisage As DataGridViewCheckBoxColumn
    Friend WithEvents BArchiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TarifADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifC120b As DataGridViewTextBoxColumn
    Friend WithEvents TarifC60b As DataGridViewTextBoxColumn
    Friend WithEvents TarifC36b As DataGridViewTextBoxColumn
    Friend WithEvents TarifE As DataGridViewTextBoxColumn
    Private m_bAjoutmvt As Boolean

#Region "Code généré par le Concepteur Windows Form "
    Public Sub New()
        MyBase.New()
        m_TypeDonnees = vncEnums.vncTypeDonnee.PRODUIT
        InitializeComponent()
        m_ToolBarSaveEnabled = True
        'Cette feneêtre ne bloque pas l'elément courant
        m_BloquageElementCourant = False
    End Sub
    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer
    Public WithEvents tbDesignation As System.Windows.Forms.TextBox
    Public WithEvents tbCode As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboConditionnement As System.Windows.Forms.ComboBox
    Friend WithEvents liNomFournisseur As System.Windows.Forms.LinkLabel
    Public WithEvents cboCouleur As System.Windows.Forms.ComboBox
    Public WithEvents cboRegion As System.Windows.Forms.ComboBox
    Public WithEvents cboContenant As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionMillesime))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbDesignation = New System.Windows.Forms.TextBox()
        Me.m_bsrcProduitRacine = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCouleur = New System.Windows.Forms.ComboBox()
        Me.m_bsrcCouleur = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.m_bsrcRegion = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboContenant = New System.Windows.Forms.ComboBox()
        Me.m_bsrcContenant = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.liNomFournisseur = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboConditionnement = New System.Windows.Forms.ComboBox()
        Me.m_bsrcConditionnement = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.m_bsrcDossier = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogoList = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvPrdMillesime = New System.Windows.Forms.DataGridView()
        Me.m_bsrcProduitMillesime = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbQuitter = New System.Windows.Forms.Button()
        Me.cbValider = New System.Windows.Forms.Button()
        Me.cbAjouter = New System.Windows.Forms.Button()
        Me.millesime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MillesimeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDisponibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bStock = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bFactureColisage = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BArchiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TarifADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifC120b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifC60b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifC36b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.m_bsrcProduitRacine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcCouleur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcContenant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcConditionnement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcDossier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrdMillesime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcProduitMillesime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbDesignation
        '
        Me.tbDesignation.AcceptsReturn = True
        resources.ApplyResources(Me.tbDesignation, "tbDesignation")
        Me.tbDesignation.BackColor = System.Drawing.SystemColors.Window
        Me.tbDesignation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDesignation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduitRacine, "nom", True))
        Me.tbDesignation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDesignation.Name = "tbDesignation"
        '
        'm_bsrcProduitRacine
        '
        Me.m_bsrcProduitRacine.DataSource = GetType(vini_DB.Produit)
        '
        'tbCode
        '
        Me.tbCode.AcceptsReturn = True
        Me.tbCode.BackColor = System.Drawing.SystemColors.Window
        Me.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduitRacine, "RacineCode", True))
        Me.tbCode.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.tbCode, "tbCode")
        Me.tbCode.Name = "tbCode"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cboCouleur
        '
        Me.cboCouleur.BackColor = System.Drawing.SystemColors.Window
        Me.cboCouleur.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCouleur.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduitRacine, "idCouleur", True))
        Me.cboCouleur.DataSource = Me.m_bsrcCouleur
        Me.cboCouleur.DisplayMember = "valeur"
        Me.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCouleur.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.cboCouleur, "cboCouleur")
        Me.cboCouleur.Name = "cboCouleur"
        Me.cboCouleur.ValueMember = "id"
        '
        'm_bsrcCouleur
        '
        Me.m_bsrcCouleur.DataSource = GetType(vini_DB.Param)
        '
        'cboRegion
        '
        Me.cboRegion.BackColor = System.Drawing.SystemColors.Window
        Me.cboRegion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboRegion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduitRacine, "idRegion", True))
        Me.cboRegion.DataSource = Me.m_bsrcRegion
        Me.cboRegion.DisplayMember = "valeur"
        Me.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegion.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.cboRegion, "cboRegion")
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.ValueMember = "id"
        '
        'm_bsrcRegion
        '
        Me.m_bsrcRegion.DataSource = GetType(vini_DB.Param)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'cboContenant
        '
        Me.cboContenant.BackColor = System.Drawing.SystemColors.Window
        Me.cboContenant.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboContenant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduitRacine, "idContenant", True))
        Me.cboContenant.DataSource = Me.m_bsrcContenant
        Me.cboContenant.DisplayMember = "libelle"
        Me.cboContenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContenant.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.cboContenant, "cboContenant")
        Me.cboContenant.Name = "cboContenant"
        Me.cboContenant.ValueMember = "id"
        '
        'm_bsrcContenant
        '
        Me.m_bsrcContenant.DataSource = GetType(vini_DB.contenant)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'liNomFournisseur
        '
        resources.ApplyResources(Me.liNomFournisseur, "liNomFournisseur")
        Me.liNomFournisseur.Name = "liNomFournisseur"
        Me.liNomFournisseur.TabStop = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'cboConditionnement
        '
        resources.ApplyResources(Me.cboConditionnement, "cboConditionnement")
        Me.cboConditionnement.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduitRacine, "idConditionnement", True))
        Me.cboConditionnement.DataSource = Me.m_bsrcConditionnement
        Me.cboConditionnement.DisplayMember = "valeur"
        Me.cboConditionnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConditionnement.Name = "cboConditionnement"
        Me.cboConditionnement.ValueMember = "id"
        '
        'm_bsrcConditionnement
        '
        Me.m_bsrcConditionnement.DataSource = GetType(vini_DB.Param)
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'ComboBox1
        '
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduitRacine, "DossierProduit", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduitRacine, "DossierProduit", True))
        Me.ComboBox1.DataSource = Me.m_bsrcDossier
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        '
        'm_bsrcDossier
        '
        Me.m_bsrcDossier.DataMember = "String"
        '
        'LogoList
        '
        Me.LogoList.ImageStream = CType(resources.GetObject("LogoList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LogoList.TransparentColor = System.Drawing.Color.Transparent
        Me.LogoList.Images.SetKeyName(0, "LogoVinicom.jpg")
        Me.LogoList.Images.SetKeyName(1, "LogoHobivin.jpg")
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'dgvPrdMillesime
        '
        resources.ApplyResources(Me.dgvPrdMillesime, "dgvPrdMillesime")
        Me.dgvPrdMillesime.AutoGenerateColumns = False
        Me.dgvPrdMillesime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrdMillesime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrdMillesime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.millesime, Me.MillesimeCode, Me.codeStat, Me.BDisponibleDataGridViewCheckBoxColumn, Me.bStock, Me.bFactureColisage, Me.BArchiveDataGridViewCheckBoxColumn, Me.TarifADataGridViewTextBoxColumn, Me.TarifBDataGridViewTextBoxColumn, Me.TarifC120b, Me.TarifC60b, Me.TarifC36b, Me.TarifE})
        Me.dgvPrdMillesime.DataSource = Me.m_bsrcProduitMillesime
        Me.dgvPrdMillesime.Name = "dgvPrdMillesime"
        '
        'm_bsrcProduitMillesime
        '
        Me.m_bsrcProduitMillesime.DataSource = GetType(vini_DB.Produit)
        '
        'cbQuitter
        '
        resources.ApplyResources(Me.cbQuitter, "cbQuitter")
        Me.cbQuitter.Name = "cbQuitter"
        Me.cbQuitter.UseVisualStyleBackColor = True
        '
        'cbValider
        '
        resources.ApplyResources(Me.cbValider, "cbValider")
        Me.cbValider.Name = "cbValider"
        Me.cbValider.UseVisualStyleBackColor = True
        '
        'cbAjouter
        '
        resources.ApplyResources(Me.cbAjouter, "cbAjouter")
        Me.cbAjouter.Name = "cbAjouter"
        Me.cbAjouter.UseVisualStyleBackColor = True
        '
        'millesime
        '
        Me.millesime.DataPropertyName = "millesime"
        resources.ApplyResources(Me.millesime, "millesime")
        Me.millesime.Name = "millesime"
        '
        'MillesimeCode
        '
        Me.MillesimeCode.DataPropertyName = "MillesimeCode"
        resources.ApplyResources(Me.MillesimeCode, "MillesimeCode")
        Me.MillesimeCode.Name = "MillesimeCode"
        '
        'codeStat
        '
        Me.codeStat.DataPropertyName = "codeStat"
        resources.ApplyResources(Me.codeStat, "codeStat")
        Me.codeStat.Name = "codeStat"
        '
        'BDisponibleDataGridViewCheckBoxColumn
        '
        Me.BDisponibleDataGridViewCheckBoxColumn.DataPropertyName = "bDisponible"
        resources.ApplyResources(Me.BDisponibleDataGridViewCheckBoxColumn, "BDisponibleDataGridViewCheckBoxColumn")
        Me.BDisponibleDataGridViewCheckBoxColumn.Name = "BDisponibleDataGridViewCheckBoxColumn"
        '
        'bStock
        '
        Me.bStock.DataPropertyName = "bStock"
        resources.ApplyResources(Me.bStock, "bStock")
        Me.bStock.Name = "bStock"
        '
        'bFactureColisage
        '
        Me.bFactureColisage.DataPropertyName = "bFactureColisage"
        resources.ApplyResources(Me.bFactureColisage, "bFactureColisage")
        Me.bFactureColisage.Name = "bFactureColisage"
        '
        'BArchiveDataGridViewCheckBoxColumn
        '
        Me.BArchiveDataGridViewCheckBoxColumn.DataPropertyName = "bArchive"
        resources.ApplyResources(Me.BArchiveDataGridViewCheckBoxColumn, "BArchiveDataGridViewCheckBoxColumn")
        Me.BArchiveDataGridViewCheckBoxColumn.Name = "BArchiveDataGridViewCheckBoxColumn"
        '
        'TarifADataGridViewTextBoxColumn
        '
        Me.TarifADataGridViewTextBoxColumn.DataPropertyName = "TarifA"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.TarifADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.TarifADataGridViewTextBoxColumn, "TarifADataGridViewTextBoxColumn")
        Me.TarifADataGridViewTextBoxColumn.Name = "TarifADataGridViewTextBoxColumn"
        '
        'TarifBDataGridViewTextBoxColumn
        '
        Me.TarifBDataGridViewTextBoxColumn.DataPropertyName = "TarifB"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.TarifBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.TarifBDataGridViewTextBoxColumn, "TarifBDataGridViewTextBoxColumn")
        Me.TarifBDataGridViewTextBoxColumn.Name = "TarifBDataGridViewTextBoxColumn"
        '
        'TarifC120b
        '
        Me.TarifC120b.DataPropertyName = "TarifC120b"
        DataGridViewCellStyle3.Format = "C2"
        Me.TarifC120b.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.TarifC120b, "TarifC120b")
        Me.TarifC120b.Name = "TarifC120b"
        '
        'TarifC60b
        '
        Me.TarifC60b.DataPropertyName = "TarifC60b"
        DataGridViewCellStyle4.Format = "C2"
        Me.TarifC60b.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.TarifC60b, "TarifC60b")
        Me.TarifC60b.Name = "TarifC60b"
        '
        'TarifC36b
        '
        Me.TarifC36b.DataPropertyName = "TarifC36b"
        DataGridViewCellStyle5.Format = "C2"
        Me.TarifC36b.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.TarifC36b, "TarifC36b")
        Me.TarifC36b.Name = "TarifC36b"
        '
        'TarifE
        '
        Me.TarifE.DataPropertyName = "TarifE"
        DataGridViewCellStyle6.Format = "C2"
        Me.TarifE.DefaultCellStyle = DataGridViewCellStyle6
        resources.ApplyResources(Me.TarifE, "TarifE")
        Me.TarifE.Name = "TarifE"
        '
        'frmGestionMillesime
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.cbAjouter)
        Me.Controls.Add(Me.cbValider)
        Me.Controls.Add(Me.cbQuitter)
        Me.Controls.Add(Me.dgvPrdMillesime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbDesignation)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.cboConditionnement)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboContenant)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCouleur)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.liNomFournisseur)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmGestionMillesime"
        CType(Me.m_bsrcProduitRacine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcCouleur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcContenant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcConditionnement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcDossier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrdMillesime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcProduitMillesime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Méthodes Privées"
    Private Function initFenetre() As Boolean
        Dim bReturn As Boolean
        Dim objParam As Param
        Dim objContenant As contenant
        debAffiche()
        Try

            For Each objParam In Param.colRegion
                m_bsrcRegion.Add(objParam)
            Next
            For Each objParam In Param.colCouleur
                m_bsrcCouleur.Add(objParam)
            Next
            For Each objParam In Param.colConditionnement
                m_bsrcConditionnement.Add(objParam)
            Next
            For Each objContenant In contenant.colContenant
                m_bsrcContenant.Add(objContenant)
            Next
            m_bsrcDossier.Clear()
            m_bsrcDossier.Add(Dossier.VINICOM)
            m_bsrcDossier.Add(Dossier.HOBIVIN)

            bReturn = True
        Catch ex As Exception
            bReturn = False
            Debug.Assert(bReturn, "initFenetre" & ex.ToString)
            Throw ex
        End Try
        finAffiche()
        Return bReturn
    End Function 'initFenetre
    Private Sub afficheFournisseur(ByVal objFournisseur As Fournisseur)
        liNomFournisseur.Text = objFournisseur.nom
        liNomFournisseur.Tag = objFournisseur.id
    End Sub
#End Region
#Region "Méthodes Redefines"
    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = False
        'm_ToolBarLoadEnabled = False
        '        m_ToolBarSaveEnabled = False
        m_ToolBarDelEnabled = False
        m_ToolBarRefreshEnabled = False

    End Sub
    Protected Overrides Function creerElement() As Boolean

        Return False
    End Function

    Public Overrides Function setElementCourant2(ByVal pElement As Persist) As Boolean
        Dim bReturn As Boolean
        m_objProduitCourant = CType(pElement, Produit)
        bReturn = MyBase.setElementCourant2(pElement)
        'Ajout du produit Racine
        If bReturn Then
            m_bsrcProduitRacine.Clear()
            m_bsrcProduitRacine.Add(m_objProduitCourant)
        End If
        'Chargement des Produits millésimé
        m_objProduitCourant.LoadMillesime()
        m_bsrcProduitMillesime.Clear()
        For Each oPrdMillesime As Produit In m_objProduitCourant.lstProduitMillesime
            m_bsrcProduitMillesime.Add(oPrdMillesime)
        Next
        setfrmNotUpdated()
        Return bReturn
    End Function
    Public Overrides Function getResume() As String 'Rend le caption de la fenêtre
        Return "Gestion des Millésimes"
    End Function 'getResume

    Public Overrides Function AfficheElement() As Boolean
        Dim objFournisseur As Fournisseur



        'Chargement du fournisseur
        objFournisseur = New Fournisseur
        If m_objProduitCourant.idFournisseur <> 0 Then
            objFournisseur.load(m_objProduitCourant.idFournisseur)
        End If

        afficheFournisseur(objFournisseur)

        EnableControls(True)
        setfrmNotUpdated()
    End Function 'AfficheElementCourant

    Public Overrides Function ControleAvantSauvegarde() As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = True
            If getElementCourant().bNew = True Then
                'controle de l'unicité du code
                If Produit.getListe(vncEnums.vncTypeProduit.vncTous, tbCode.Text).Count > 0 Then
                    DisplayError("Controleavantsauvegarde", "Le code produit doit être unique")
                    bReturn = False
                End If
            End If
            If Not (liNomFournisseur.Tag <> 0 And IsNumeric(liNomFournisseur.Tag)) Then
                bReturn = False
                DisplayError("Controleavantsauvegarde", "Le Fournisseur n'est pas renseigné")
            End If
        Catch ex As Exception
            bReturn = False
            Throw ex
        End Try
        Return bReturn
    End Function
    Public Overrides Function SauveElement() As Boolean
        Dim bReturn As Boolean
        debAffiche()
        For Each oProduit As Produit In m_bsrcProduitMillesime
            'oProduit.millesime = oProduit.MillesimeCode.Replace("M", "")
            oProduit.save()
        Next
        finAffiche()
        setfrmNotUpdated()
        Return bReturn
    End Function
    Protected Overrides Function frmNew() As Boolean
        MyBase.frmNew()
        tbCode.Focus()
    End Function
#End Region


    Private Sub liNomFournisseur_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles liNomFournisseur.LinkClicked
        afficheFenetreFournisseur(liNomFournisseur.Tag)
    End Sub

    Private Sub frmProduit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()

    End Sub

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled) ' Activation de tous les contrôles de la fenêtre
        If m_action = vncEnums.vncfrmAction.FRMLOAD Then
            'Modifiation d'un Element
            Me.tbCode.Enabled = currentuser.aLeDroitdeModifierleFourniseurProduit()
        End If
    End Sub

    Private Sub cbAjouter_Click(sender As Object, e As EventArgs) Handles cbAjouter.Click
        AjouterMillesime()
    End Sub
    Private Sub AjouterMillesime()
        Dim oProduit As New Produit
        For n As Integer = 0 To 99
            Dim str As String
            str = n.ToString("00")
            If m_objProduitCourant.MillesimeCode <> "" Then
                oProduit.code = m_objProduitCourant.code.Replace(m_objProduitCourant.MillesimeCode, "M" & str)
                oProduit.millesime = 2000 + n
            Else
                oProduit.code = m_objProduitCourant.code & "M00"
                oProduit.millesime = 2000
            End If
            'Les produit existe-t-il en base  ou dans la liste ?
            If Not oProduit.isCodeExistant() Then
                Dim bPrdOK As Boolean = True
                For Each oPrd As Produit In m_bsrcProduitMillesime.List
                    If oPrd.code = oProduit.code Then
                        bPrdOK = False
                    End If
                Next
                If bPrdOK Then
                    Exit For
                End If
            End If
            oProduit.code = ""
            oProduit.millesime = 0
        Next
        If oProduit.code = "" Then
            MsgBox("Il n'y a plus de codes produits disponibles pour cette racine" & m_objProduitCourant.RacineCode)
        End If
        oProduit.codeStat = oProduit.RacineCode
        oProduit.nom = m_objProduitCourant.nom
        oProduit.DossierProduit = m_objProduitCourant.DossierProduit
        oProduit.idFournisseur = m_objProduitCourant.idFournisseur
        oProduit.idRegion = m_objProduitCourant.idRegion
        oProduit.idCouleur = m_objProduitCourant.idCouleur
        oProduit.idContenant = m_objProduitCourant.idContenant
        oProduit.idConditionnement = m_objProduitCourant.idConditionnement
        oProduit.TarifA = m_objProduitCourant.TarifA
        oProduit.TarifB = m_objProduitCourant.TarifB
        oProduit.TarifC120b = m_objProduitCourant.TarifC120b
        oProduit.TarifC60b = m_objProduitCourant.TarifC60b
        oProduit.TarifC36b = m_objProduitCourant.TarifC36b
        oProduit.TarifE = m_objProduitCourant.TarifE
        oProduit.bStock = m_objProduitCourant.bStock
        oProduit.bFactureColisage = m_objProduitCourant.bFactureColisage

        m_bsrcProduitMillesime.Add(oProduit)
        m_bsrcProduitMillesime.MoveLast()
        dgvPrdMillesime.CurrentCell = dgvPrdMillesime.CurrentRow.Cells(0)
        dgvPrdMillesime.BeginEdit(True)
        setfrmUpdated()

    End Sub

    Private Sub cbValider_Click(sender As Object, e As EventArgs) Handles cbValider.Click
        'Vérification de l'unicité des codes
        Dim oProduit As Produit
        Dim nPosition As Integer = 0
        Dim bOK As Boolean = True
        For Each oProduit In m_bsrcProduitMillesime
            If oProduit.bNew Then
                If oProduit.isCodeExistant() Then
                    MsgBox("Le code produit: [" & oProduit.code & "] existe déjà en base")
                    m_bsrcProduitMillesime.Position = nPosition
                    bOK = False
                    Exit For
                End If
            End If
            nPosition = nPosition + 1
        Next
        If bOK Then
            setfrmUpdated()
            Me.Close()
        End If
    End Sub

    Private Sub cbQuitter_Click(sender As Object, e As EventArgs) Handles cbQuitter.Click
        setfrmNotUpdated()
        Me.Close()
    End Sub

    Private Sub dgvPrdMillesime_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrdMillesime.CellEnter
        setfrmUpdated()
    End Sub

    Private Sub dgvPrdMillesime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrdMillesime.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim oPrdMil As Produit
            oPrdMil = m_bsrcProduitMillesime.Current
            If oPrdMil.millesime = 0 Then
                oPrdMil.millesime = CInt("20" & dgvPrdMillesime.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.replace("M", ""))
            End If
        End If
    End Sub

    Private Sub dgvPrdMillesime_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrdMillesime.CellValidated
        If e.ColumnIndex = 0 Then
            Dim oPrdMil As Produit
            oPrdMil = m_bsrcProduitMillesime.Current
            If oPrdMil.millesime > 1000 And oPrdMil.millesime < 10000 Then
                oPrdMil.MillesimeCode = "M" & CStr(oPrdMil.millesime).Substring(2, 2)
            End If
        End If

    End Sub

    Private Sub dgvPrdMillesime_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrdMillesime.CellDoubleClick
        Dim oPrd As Produit
        oPrd = m_bsrcProduitMillesime.Current
        If oPrd.id <> 0 Then

            afficheFenetreProduit(oPrd.id)
        End If
    End Sub
End Class