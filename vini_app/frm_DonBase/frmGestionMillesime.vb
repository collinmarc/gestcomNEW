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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbTarifA As vini_app.textBoxCurrency
    Friend WithEvents tbTarifB As vini_app.textBoxCurrency
    Friend WithEvents tbTarifC As vini_app.textBoxCurrency
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents m_bsrcProduit As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcRegion As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcCouleur As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcContenant As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcConditionnement As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcMvtStock As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcTypeMvt As System.Windows.Forms.BindingSource
    Friend WithEvents Label24 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents m_bsrcDossier As BindingSource
    Friend WithEvents LogoList As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tbDepot As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbTarifD As textBoxCurrency
    Public WithEvents tbMillesime As textBoxNumeric
    Public WithEvents Label7 As Label
    Friend WithEvents ckkPrdArchive As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents m_bsrcMillesime As BindingSource
    Friend WithEvents MillesimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BDisponibleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BArchiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TarifADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbQuitter As Button
    Friend WithEvents cbValider As Button
    Private m_bAjoutmvt As Boolean

#Region "Code généré par le Concepteur Windows Form "
    Public Sub New()
        MyBase.New()
        m_TypeDonnees = vncEnums.vncTypeDonnee.PRODUIT
        InitializeComponent()
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
    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Il peut être modifié à l'aide du Concepteur Windows Form.
    'Ne pas le modifier à l'aide de l'éditeur de code.
    Public WithEvents tbMotDirecteur As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbCodeStat As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboConditionnement As System.Windows.Forms.ComboBox
    Friend WithEvents liNomFournisseur As System.Windows.Forms.LinkLabel
    Public WithEvents cboCouleur As System.Windows.Forms.ComboBox
    Public WithEvents cboRegion As System.Windows.Forms.ComboBox
    Public WithEvents cboContenant As System.Windows.Forms.ComboBox
    Friend WithEvents ckStock As System.Windows.Forms.CheckBox
    Friend WithEvents ckDispo As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionMillesime))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbDesignation = New System.Windows.Forms.TextBox()
        Me.m_bsrcProduit = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMotDirecteur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.ckStock = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbCodeStat = New System.Windows.Forms.TextBox()
        Me.m_bsrcMvtStock = New System.Windows.Forms.BindingSource(Me.components)
        Me.m_bsrcTypeMvt = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboConditionnement = New System.Windows.Forms.ComboBox()
        Me.m_bsrcConditionnement = New System.Windows.Forms.BindingSource(Me.components)
        Me.ckDispo = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbTarifA = New vini_app.textBoxCurrency()
        Me.tbTarifB = New vini_app.textBoxCurrency()
        Me.tbTarifC = New vini_app.textBoxCurrency()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.m_bsrcDossier = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogoList = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbDepot = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbTarifD = New vini_app.textBoxCurrency()
        Me.tbMillesime = New vini_app.textBoxNumeric()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckkPrdArchive = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MillesimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDisponibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BArchiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TarifADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcMillesime = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbQuitter = New System.Windows.Forms.Button()
        Me.cbValider = New System.Windows.Forms.Button()
        CType(Me.m_bsrcProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcCouleur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcContenant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcMvtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcTypeMvt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcConditionnement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcDossier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcMillesime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbDesignation
        '
        Me.tbDesignation.AcceptsReturn = True
        resources.ApplyResources(Me.tbDesignation, "tbDesignation")
        Me.tbDesignation.BackColor = System.Drawing.SystemColors.Window
        Me.tbDesignation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDesignation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "nom", True))
        Me.tbDesignation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDesignation.Name = "tbDesignation"
        '
        'm_bsrcProduit
        '
        Me.m_bsrcProduit.DataSource = GetType(vini_DB.Produit)
        '
        'tbCode
        '
        Me.tbCode.AcceptsReturn = True
        Me.tbCode.BackColor = System.Drawing.SystemColors.Window
        Me.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "code", True))
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
        'tbMotDirecteur
        '
        Me.tbMotDirecteur.AcceptsReturn = True
        Me.tbMotDirecteur.BackColor = System.Drawing.SystemColors.Window
        Me.tbMotDirecteur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMotDirecteur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "motcle", True))
        Me.tbMotDirecteur.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.tbMotDirecteur, "tbMotDirecteur")
        Me.tbMotDirecteur.Name = "tbMotDirecteur"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'cboCouleur
        '
        Me.cboCouleur.BackColor = System.Drawing.SystemColors.Window
        Me.cboCouleur.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCouleur.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduit, "idCouleur", True))
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
        Me.cboRegion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduit, "idRegion", True))
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
        Me.cboContenant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduit, "idContenant", True))
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
        'ckStock
        '
        resources.ApplyResources(Me.ckStock, "ckStock")
        Me.ckStock.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsrcProduit, "bStock", True))
        Me.ckStock.Name = "ckStock"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'tbCodeStat
        '
        Me.tbCodeStat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "codeStat", True))
        resources.ApplyResources(Me.tbCodeStat, "tbCodeStat")
        Me.tbCodeStat.Name = "tbCodeStat"
        '
        'm_bsrcMvtStock
        '
        Me.m_bsrcMvtStock.DataSource = GetType(vini_DB.mvtStock)
        '
        'm_bsrcTypeMvt
        '
        Me.m_bsrcTypeMvt.DataSource = GetType(vini_DB.Param)
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'cboConditionnement
        '
        resources.ApplyResources(Me.cboConditionnement, "cboConditionnement")
        Me.cboConditionnement.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduit, "idConditionnement", True))
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
        'ckDispo
        '
        resources.ApplyResources(Me.ckDispo, "ckDispo")
        Me.ckDispo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsrcProduit, "bDisponible", True))
        Me.ckDispo.Name = "ckDispo"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'tbTarifA
        '
        resources.ApplyResources(Me.tbTarifA, "tbTarifA")
        Me.tbTarifA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "TarifA", True))
        Me.tbTarifA.Name = "tbTarifA"
        '
        'tbTarifB
        '
        resources.ApplyResources(Me.tbTarifB, "tbTarifB")
        Me.tbTarifB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "TarifB", True))
        Me.tbTarifB.Name = "tbTarifB"
        '
        'tbTarifC
        '
        resources.ApplyResources(Me.tbTarifC, "tbTarifC")
        Me.tbTarifC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "TarifC", True))
        Me.tbTarifC.Name = "tbTarifC"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'ComboBox1
        '
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "DossierProduit", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcProduit, "DossierProduit", True))
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
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'tbDepot
        '
        Me.tbDepot.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "Depot", True))
        resources.ApplyResources(Me.tbDepot, "tbDepot")
        Me.tbDepot.Name = "tbDepot"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'tbTarifD
        '
        resources.ApplyResources(Me.tbTarifD, "tbTarifD")
        Me.tbTarifD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "TarifD", True))
        Me.tbTarifD.Name = "tbTarifD"
        '
        'tbMillesime
        '
        Me.tbMillesime.AcceptsReturn = True
        resources.ApplyResources(Me.tbMillesime, "tbMillesime")
        Me.tbMillesime.BackColor = System.Drawing.SystemColors.Window
        Me.tbMillesime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMillesime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcProduit, "millesime", True))
        Me.tbMillesime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbMillesime.Name = "tbMillesime"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Name = "Label7"
        '
        'ckkPrdArchive
        '
        resources.ApplyResources(Me.ckkPrdArchive, "ckkPrdArchive")
        Me.ckkPrdArchive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsrcProduit, "bDisponible", True))
        Me.ckkPrdArchive.Name = "ckkPrdArchive"
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MillesimeDataGridViewTextBoxColumn, Me.BDisponibleDataGridViewCheckBoxColumn, Me.BArchiveDataGridViewCheckBoxColumn, Me.TarifADataGridViewTextBoxColumn, Me.TarifBDataGridViewTextBoxColumn, Me.TarifCDataGridViewTextBoxColumn, Me.TarifDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.m_bsrcMillesime
        Me.DataGridView1.Name = "DataGridView1"
        '
        'MillesimeDataGridViewTextBoxColumn
        '
        Me.MillesimeDataGridViewTextBoxColumn.DataPropertyName = "Millesime"
        resources.ApplyResources(Me.MillesimeDataGridViewTextBoxColumn, "MillesimeDataGridViewTextBoxColumn")
        Me.MillesimeDataGridViewTextBoxColumn.Name = "MillesimeDataGridViewTextBoxColumn"
        '
        'BDisponibleDataGridViewCheckBoxColumn
        '
        Me.BDisponibleDataGridViewCheckBoxColumn.DataPropertyName = "bDisponible"
        resources.ApplyResources(Me.BDisponibleDataGridViewCheckBoxColumn, "BDisponibleDataGridViewCheckBoxColumn")
        Me.BDisponibleDataGridViewCheckBoxColumn.Name = "BDisponibleDataGridViewCheckBoxColumn"
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
        'TarifCDataGridViewTextBoxColumn
        '
        Me.TarifCDataGridViewTextBoxColumn.DataPropertyName = "TarifC"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.TarifCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.TarifCDataGridViewTextBoxColumn, "TarifCDataGridViewTextBoxColumn")
        Me.TarifCDataGridViewTextBoxColumn.Name = "TarifCDataGridViewTextBoxColumn"
        '
        'TarifDDataGridViewTextBoxColumn
        '
        Me.TarifDDataGridViewTextBoxColumn.DataPropertyName = "TarifD"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.TarifDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.TarifDDataGridViewTextBoxColumn, "TarifDDataGridViewTextBoxColumn")
        Me.TarifDDataGridViewTextBoxColumn.Name = "TarifDDataGridViewTextBoxColumn"
        '
        'm_bsrcMillesime
        '
        Me.m_bsrcMillesime.DataSource = GetType(vini_DB.MillesimeProduit)
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
        'frmGestionMillesime
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.cbValider)
        Me.Controls.Add(Me.cbQuitter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ckkPrdArchive)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.tbTarifD)
        Me.Controls.Add(Me.tbDepot)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbTarifC)
        Me.Controls.Add(Me.tbTarifB)
        Me.Controls.Add(Me.tbTarifA)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbCodeStat)
        Me.Controls.Add(Me.tbMillesime)
        Me.Controls.Add(Me.tbMotDirecteur)
        Me.Controls.Add(Me.tbDesignation)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.cboConditionnement)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ckDispo)
        Me.Controls.Add(Me.ckStock)
        Me.Controls.Add(Me.cboContenant)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCouleur)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.liNomFournisseur)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmGestionMillesime"
        CType(Me.m_bsrcProduit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcCouleur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcContenant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcMvtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcTypeMvt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcConditionnement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcDossier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcMillesime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Méthodes Privées"
    Private Function initFenetre() As Boolean
        Dim bReturn As Boolean
        debAffiche()
        Try
            Dim obj As Produit

            obj = Produit.createandloadbyKey("0000001M18")
            m_bsrcProduit.Add(obj)
            setElementCourant2(obj)
            AfficheElementCourant()
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
        m_ToolBarSaveEnabled = False
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
        If bReturn Then
            m_bsrcProduit.Clear()
            m_bsrcProduit.Add(m_objProduitCourant)
        End If
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
    End Function 'AfficheElementCourant

    Public Overrides Function MAJElement() As Boolean
        Dim bReturn As Boolean
        Dim objProduit As Produit


        objProduit = CType(getElementCourant(), Produit)
        Return bReturn
    End Function 'MAJElementCourant
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
        Debug.Assert(Not m_objProduitCourant Is Nothing)
        Dim bReturn As Boolean
        bReturn = m_objProduitCourant.save
        Debug.Assert(bReturn, "Erreur en sauvegarde")
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

End Class