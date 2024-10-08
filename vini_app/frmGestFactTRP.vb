Imports vini_DB
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
'Imports FAXCOMLib
Imports System.Windows.Forms.Cursors

Public Class frmGestFactTRP
    Inherits frmDonBase
    Private Enum vncColLigneCommande
        COL_NUM = 0
        COL_DATELIV = 1
        COL_REFLIV = 2
        COL_TRPEUR = 3
        COL_DATE_CMD = 4
        COL_CODE_CMD = 5
        COL_MONTANTHT = 6
        COL_NBRECOL = 7
    End Enum
    'Private getElementCourant() As FactTRP

#Region " Code g�n�r� par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()
        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()


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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cbSupprimerLigne As System.Windows.Forms.Button
    Public WithEvents cbAjouterLigne As System.Windows.Forms.Button
    Public WithEvents tbTotalHT As textBoxCurrency
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents tpLignes As System.Windows.Forms.TabPage
    Public WithEvents tpCommentaires As System.Windows.Forms.TabPage
    Friend WithEvents tpValidCmd As System.Windows.Forms.TabPage
    Friend WithEvents laEtatCommande As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbCode As System.Windows.Forms.TextBox
    Public WithEvents SSTabCommandeClient As System.Windows.Forms.TabControl
    Friend WithEvents tbCommentaireFacturation As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents tbTotalTTC As textBoxCurrency
    Friend WithEvents grpEntete As System.Windows.Forms.GroupBox
    Friend WithEvents dtDateFact As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbPeriode As System.Windows.Forms.TextBox
    Friend WithEvents cbBrowse As System.Windows.Forms.Button
    Friend WithEvents tbDossierStockage As System.Windows.Forms.TextBox
    Friend WithEvents cbStocker As System.Windows.Forms.Button
    Friend WithEvents cbAfficherEtat As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbRecalcTotaux As System.Windows.Forms.Button
    Friend WithEvents ckEntete As System.Windows.Forms.CheckBox
    Friend WithEvents liTiers As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbMontantTaxes As textBoxCurrency
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbAnnExport As System.Windows.Forms.Button
    Friend WithEvents cbReglement As System.Windows.Forms.Button
    Friend WithEvents m_bsrcFacture As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents m_bsrcModeReglement As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcLgFact As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateLivraisonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceLivraisonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTransporteurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCommandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefCommandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixHTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboModeReglement As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpEntete = New System.Windows.Forms.GroupBox()
        Me.tbPeriode = New System.Windows.Forms.TextBox()
        Me.m_bsrcFacture = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtDateFact = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.liTiers = New System.Windows.Forms.LinkLabel()
        Me.laEtatCommande = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAnnExport = New System.Windows.Forms.Button()
        Me.SSTabCommandeClient = New System.Windows.Forms.TabControl()
        Me.tpLignes = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateLivraisonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenceLivraisonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTransporteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCommandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefCommandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcLgFact = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboModeReglement = New System.Windows.Forms.ComboBox()
        Me.m_bsrcModeReglement = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMontantTaxes = New vini_app.textBoxCurrency()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbRecalcTotaux = New System.Windows.Forms.Button()
        Me.tbTotalTTC = New vini_app.textBoxCurrency()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cbSupprimerLigne = New System.Windows.Forms.Button()
        Me.cbAjouterLigne = New System.Windows.Forms.Button()
        Me.tbTotalHT = New vini_app.textBoxCurrency()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tpCommentaires = New System.Windows.Forms.TabPage()
        Me.tbCommentaireFacturation = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tpValidCmd = New System.Windows.Forms.TabPage()
        Me.ckEntete = New System.Windows.Forms.CheckBox()
        Me.cbAfficherEtat = New System.Windows.Forms.Button()
        Me.cbBrowse = New System.Windows.Forms.Button()
        Me.tbDossierStockage = New System.Windows.Forms.TextBox()
        Me.cbStocker = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbReglement = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grpEntete.SuspendLayout()
        CType(Me.m_bsrcFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSTabCommandeClient.SuspendLayout()
        Me.tpLignes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcLgFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcModeReglement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCommentaires.SuspendLayout()
        Me.tpValidCmd.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEntete
        '
        Me.grpEntete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntete.Controls.Add(Me.tbPeriode)
        Me.grpEntete.Controls.Add(Me.Label3)
        Me.grpEntete.Controls.Add(Me.dtDateFact)
        Me.grpEntete.Controls.Add(Me.Label29)
        Me.grpEntete.Controls.Add(Me.liTiers)
        Me.grpEntete.Controls.Add(Me.laEtatCommande)
        Me.grpEntete.Controls.Add(Me.tbCode)
        Me.grpEntete.Controls.Add(Me.Label1)
        Me.grpEntete.Location = New System.Drawing.Point(8, 0)
        Me.grpEntete.Name = "grpEntete"
        Me.grpEntete.Size = New System.Drawing.Size(992, 64)
        Me.grpEntete.TabIndex = 0
        Me.grpEntete.TabStop = False
        Me.grpEntete.Text = "Facture"
        '
        'tbPeriode
        '
        Me.tbPeriode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "periode", True))
        Me.tbPeriode.Location = New System.Drawing.Point(656, 16)
        Me.tbPeriode.Name = "tbPeriode"
        Me.tbPeriode.Size = New System.Drawing.Size(152, 20)
        Me.tbPeriode.TabIndex = 2
        '
        'm_bsrcFacture
        '
        Me.m_bsrcFacture.DataSource = GetType(vini_DB.FactTRP)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(586, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "P�riode"
        '
        'dtDateFact
        '
        Me.dtDateFact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "dateFacture", True))
        Me.dtDateFact.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateFact.Location = New System.Drawing.Point(280, 16)
        Me.dtDateFact.Name = "dtDateFact"
        Me.dtDateFact.Size = New System.Drawing.Size(104, 20)
        Me.dtDateFact.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(166, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 16)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Date de facture"
        '
        'liTiers
        '
        Me.liTiers.Location = New System.Drawing.Point(8, 40)
        Me.liTiers.Name = "liTiers"
        Me.liTiers.Size = New System.Drawing.Size(712, 16)
        Me.liTiers.TabIndex = 8
        '
        'laEtatCommande
        '
        Me.laEtatCommande.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.laEtatCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laEtatCommande.ForeColor = System.Drawing.Color.Red
        Me.laEtatCommande.Location = New System.Drawing.Point(856, 16)
        Me.laEtatCommande.Name = "laEtatCommande"
        Me.laEtatCommande.Size = New System.Drawing.Size(128, 20)
        Me.laEtatCommande.TabIndex = 7
        '
        'tbCode
        '
        Me.tbCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "code", True))
        Me.tbCode.Location = New System.Drawing.Point(48, 16)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(112, 20)
        Me.tbCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N�"
        '
        'cbAnnExport
        '
        Me.cbAnnExport.Location = New System.Drawing.Point(868, 70)
        Me.cbAnnExport.Name = "cbAnnExport"
        Me.cbAnnExport.Size = New System.Drawing.Size(132, 23)
        Me.cbAnnExport.TabIndex = 18
        Me.cbAnnExport.Text = "Annulation Export"
        Me.cbAnnExport.UseVisualStyleBackColor = True
        '
        'SSTabCommandeClient
        '
        Me.SSTabCommandeClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SSTabCommandeClient.Controls.Add(Me.tpLignes)
        Me.SSTabCommandeClient.Controls.Add(Me.tpCommentaires)
        Me.SSTabCommandeClient.Controls.Add(Me.tpValidCmd)
        Me.SSTabCommandeClient.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTabCommandeClient.Location = New System.Drawing.Point(0, 95)
        Me.SSTabCommandeClient.Name = "SSTabCommandeClient"
        Me.SSTabCommandeClient.SelectedIndex = 0
        Me.SSTabCommandeClient.Size = New System.Drawing.Size(1000, 579)
        Me.SSTabCommandeClient.TabIndex = 0
        '
        'tpLignes
        '
        Me.tpLignes.Controls.Add(Me.DataGridView1)
        Me.tpLignes.Controls.Add(Me.DateTimePicker1)
        Me.tpLignes.Controls.Add(Me.Label5)
        Me.tpLignes.Controls.Add(Me.cboModeReglement)
        Me.tpLignes.Controls.Add(Me.Label4)
        Me.tpLignes.Controls.Add(Me.tbMontantTaxes)
        Me.tpLignes.Controls.Add(Me.Label2)
        Me.tpLignes.Controls.Add(Me.cbRecalcTotaux)
        Me.tpLignes.Controls.Add(Me.tbTotalTTC)
        Me.tpLignes.Controls.Add(Me.Label51)
        Me.tpLignes.Controls.Add(Me.cbSupprimerLigne)
        Me.tpLignes.Controls.Add(Me.cbAjouterLigne)
        Me.tpLignes.Controls.Add(Me.tbTotalHT)
        Me.tpLignes.Controls.Add(Me.Label10)
        Me.tpLignes.Location = New System.Drawing.Point(4, 22)
        Me.tpLignes.Name = "tpLignes"
        Me.tpLignes.Size = New System.Drawing.Size(992, 553)
        Me.tpLignes.TabIndex = 1
        Me.tpLignes.Text = "Lignes"
        Me.tpLignes.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateLivraisonDataGridViewTextBoxColumn, Me.ReferenceLivraisonDataGridViewTextBoxColumn, Me.NomTransporteurDataGridViewTextBoxColumn, Me.DateCommandeDataGridViewTextBoxColumn, Me.RefCommandeDataGridViewTextBoxColumn, Me.PrixHTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.m_bsrcLgFact
        Me.DataGridView1.Location = New System.Drawing.Point(9, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(967, 430)
        Me.DataGridView1.TabIndex = 1
        '
        'DateLivraisonDataGridViewTextBoxColumn
        '
        Me.DateLivraisonDataGridViewTextBoxColumn.DataPropertyName = "dateLivraison"
        Me.DateLivraisonDataGridViewTextBoxColumn.HeaderText = "Date liv."
        Me.DateLivraisonDataGridViewTextBoxColumn.Name = "DateLivraisonDataGridViewTextBoxColumn"
        Me.DateLivraisonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenceLivraisonDataGridViewTextBoxColumn
        '
        Me.ReferenceLivraisonDataGridViewTextBoxColumn.DataPropertyName = "referenceLivraison"
        Me.ReferenceLivraisonDataGridViewTextBoxColumn.HeaderText = "R�cepiss�"
        Me.ReferenceLivraisonDataGridViewTextBoxColumn.Name = "ReferenceLivraisonDataGridViewTextBoxColumn"
        Me.ReferenceLivraisonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomTransporteurDataGridViewTextBoxColumn
        '
        Me.NomTransporteurDataGridViewTextBoxColumn.DataPropertyName = "nomTransporteur"
        Me.NomTransporteurDataGridViewTextBoxColumn.FillWeight = 300.0!
        Me.NomTransporteurDataGridViewTextBoxColumn.HeaderText = "Transporteur"
        Me.NomTransporteurDataGridViewTextBoxColumn.Name = "NomTransporteurDataGridViewTextBoxColumn"
        Me.NomTransporteurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCommandeDataGridViewTextBoxColumn
        '
        Me.DateCommandeDataGridViewTextBoxColumn.DataPropertyName = "dateCommande"
        Me.DateCommandeDataGridViewTextBoxColumn.HeaderText = "Date commande"
        Me.DateCommandeDataGridViewTextBoxColumn.Name = "DateCommandeDataGridViewTextBoxColumn"
        Me.DateCommandeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RefCommandeDataGridViewTextBoxColumn
        '
        Me.RefCommandeDataGridViewTextBoxColumn.DataPropertyName = "refCommande"
        Me.RefCommandeDataGridViewTextBoxColumn.HeaderText = "N� Cde"
        Me.RefCommandeDataGridViewTextBoxColumn.Name = "RefCommandeDataGridViewTextBoxColumn"
        Me.RefCommandeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrixHTDataGridViewTextBoxColumn
        '
        Me.PrixHTDataGridViewTextBoxColumn.DataPropertyName = "prixHT"
        DataGridViewCellStyle1.Format = "C2"
        Me.PrixHTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrixHTDataGridViewTextBoxColumn.HeaderText = "Montant HT"
        Me.PrixHTDataGridViewTextBoxColumn.Name = "PrixHTDataGridViewTextBoxColumn"
        Me.PrixHTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'm_bsrcLgFact
        '
        Me.m_bsrcLgFact.DataSource = GetType(vini_DB.LgFactTRP)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "dEcheance", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(113, 519)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(89, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Date d'�ch�ance :"
        '
        'cboModeReglement
        '
        Me.cboModeReglement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboModeReglement.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.m_bsrcFacture, "idModeReglement", True))
        Me.cboModeReglement.DataSource = Me.m_bsrcModeReglement
        Me.cboModeReglement.DisplayMember = "valeur"
        Me.cboModeReglement.Location = New System.Drawing.Point(113, 497)
        Me.cboModeReglement.Name = "cboModeReglement"
        Me.cboModeReglement.Size = New System.Drawing.Size(224, 21)
        Me.cboModeReglement.TabIndex = 4
        Me.cboModeReglement.ValueMember = "id"
        '
        'm_bsrcModeReglement
        '
        Me.m_bsrcModeReglement.DataSource = GetType(vini_DB.Param)
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(1, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Mode r�glement :"
        '
        'tbMontantTaxes
        '
        Me.tbMontantTaxes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMontantTaxes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "montantTaxes", True))
        Me.tbMontantTaxes.Location = New System.Drawing.Point(864, 471)
        Me.tbMontantTaxes.Name = "tbMontantTaxes"
        Me.tbMontantTaxes.Size = New System.Drawing.Size(113, 20)
        Me.tbMontantTaxes.TabIndex = 7
        Me.tbMontantTaxes.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(719, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Frais d'enregistrement :"
        '
        'cbRecalcTotaux
        '
        Me.cbRecalcTotaux.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRecalcTotaux.Location = New System.Drawing.Point(638, 493)
        Me.cbRecalcTotaux.Name = "cbRecalcTotaux"
        Me.cbRecalcTotaux.Size = New System.Drawing.Size(75, 23)
        Me.cbRecalcTotaux.TabIndex = 6
        Me.cbRecalcTotaux.Text = "Re&Calcul"
        '
        'tbTotalTTC
        '
        Me.tbTotalTTC.AcceptsReturn = True
        Me.tbTotalTTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotalTTC.BackColor = System.Drawing.SystemColors.Window
        Me.tbTotalTTC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTotalTTC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "totalTTC", True))
        Me.tbTotalTTC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTotalTTC.Location = New System.Drawing.Point(864, 520)
        Me.tbTotalTTC.MaxLength = 0
        Me.tbTotalTTC.Name = "tbTotalTTC"
        Me.tbTotalTTC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotalTTC.Size = New System.Drawing.Size(113, 20)
        Me.tbTotalTTC.TabIndex = 9
        Me.tbTotalTTC.Text = "0"
        '
        'Label51
        '
        Me.Label51.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label51.Location = New System.Drawing.Point(719, 523)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(128, 16)
        Me.Label51.TabIndex = 62
        Me.Label51.Text = "Total TTC"
        '
        'cbSupprimerLigne
        '
        Me.cbSupprimerLigne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSupprimerLigne.BackColor = System.Drawing.SystemColors.Control
        Me.cbSupprimerLigne.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbSupprimerLigne.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbSupprimerLigne.Location = New System.Drawing.Point(903, 440)
        Me.cbSupprimerLigne.Name = "cbSupprimerLigne"
        Me.cbSupprimerLigne.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbSupprimerLigne.Size = New System.Drawing.Size(73, 25)
        Me.cbSupprimerLigne.TabIndex = 3
        Me.cbSupprimerLigne.Text = "&Supprimer"
        Me.cbSupprimerLigne.UseVisualStyleBackColor = False
        '
        'cbAjouterLigne
        '
        Me.cbAjouterLigne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAjouterLigne.BackColor = System.Drawing.SystemColors.Control
        Me.cbAjouterLigne.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbAjouterLigne.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAjouterLigne.Location = New System.Drawing.Point(743, 440)
        Me.cbAjouterLigne.Name = "cbAjouterLigne"
        Me.cbAjouterLigne.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbAjouterLigne.Size = New System.Drawing.Size(73, 25)
        Me.cbAjouterLigne.TabIndex = 2
        Me.cbAjouterLigne.Text = "A&jouter"
        Me.cbAjouterLigne.UseVisualStyleBackColor = False
        '
        'tbTotalHT
        '
        Me.tbTotalHT.AcceptsReturn = True
        Me.tbTotalHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotalHT.BackColor = System.Drawing.SystemColors.Window
        Me.tbTotalHT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTotalHT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "totalHT", True))
        Me.tbTotalHT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTotalHT.Location = New System.Drawing.Point(864, 495)
        Me.tbTotalHT.MaxLength = 0
        Me.tbTotalHT.Name = "tbTotalHT"
        Me.tbTotalHT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotalHT.Size = New System.Drawing.Size(113, 20)
        Me.tbTotalHT.TabIndex = 8
        Me.tbTotalHT.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(719, 498)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(136, 17)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Total H.T. :"
        '
        'tpCommentaires
        '
        Me.tpCommentaires.Controls.Add(Me.tbCommentaireFacturation)
        Me.tpCommentaires.Controls.Add(Me.Label26)
        Me.tpCommentaires.Location = New System.Drawing.Point(4, 22)
        Me.tpCommentaires.Name = "tpCommentaires"
        Me.tpCommentaires.Size = New System.Drawing.Size(992, 553)
        Me.tpCommentaires.TabIndex = 3
        Me.tpCommentaires.Text = "Commentaires"
        Me.tpCommentaires.Visible = False
        '
        'tbCommentaireFacturation
        '
        Me.tbCommentaireFacturation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCommentaireFacturation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsrcFacture, "CommentaireFacturationText", True))
        Me.tbCommentaireFacturation.Location = New System.Drawing.Point(96, 8)
        Me.tbCommentaireFacturation.Multiline = True
        Me.tbCommentaireFacturation.Name = "tbCommentaireFacturation"
        Me.tbCommentaireFacturation.Size = New System.Drawing.Size(882, 120)
        Me.tbCommentaireFacturation.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(64, 25)
        Me.Label26.TabIndex = 74
        Me.Label26.Text = "Facturation"
        '
        'tpValidCmd
        '
        Me.tpValidCmd.Controls.Add(Me.CrystalReportViewer1)
        Me.tpValidCmd.Controls.Add(Me.ckEntete)
        Me.tpValidCmd.Controls.Add(Me.cbAfficherEtat)
        Me.tpValidCmd.Controls.Add(Me.cbBrowse)
        Me.tpValidCmd.Controls.Add(Me.tbDossierStockage)
        Me.tpValidCmd.Controls.Add(Me.cbStocker)
        Me.tpValidCmd.Location = New System.Drawing.Point(4, 22)
        Me.tpValidCmd.Name = "tpValidCmd"
        Me.tpValidCmd.Size = New System.Drawing.Size(992, 553)
        Me.tpValidCmd.TabIndex = 4
        Me.tpValidCmd.Text = "Editions"
        '
        'ckEntete
        '
        Me.ckEntete.Location = New System.Drawing.Point(8, 6)
        Me.ckEntete.Name = "ckEntete"
        Me.ckEntete.Size = New System.Drawing.Size(59, 24)
        Me.ckEntete.TabIndex = 128
        Me.ckEntete.Text = "Entete"
        Me.ckEntete.Checked = True
        '
        'cbAfficherEtat
        '
        Me.cbAfficherEtat.Location = New System.Drawing.Point(73, 4)
        Me.cbAfficherEtat.Name = "cbAfficherEtat"
        Me.cbAfficherEtat.Size = New System.Drawing.Size(80, 24)
        Me.cbAfficherEtat.TabIndex = 127
        Me.cbAfficherEtat.Text = "Afficher"
        '
        'cbBrowse
        '
        Me.cbBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBrowse.Location = New System.Drawing.Point(874, 4)
        Me.cbBrowse.Name = "cbBrowse"
        Me.cbBrowse.Size = New System.Drawing.Size(40, 24)
        Me.cbBrowse.TabIndex = 126
        Me.cbBrowse.Text = "..."
        '
        'tbDossierStockage
        '
        Me.tbDossierStockage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDossierStockage.Location = New System.Drawing.Point(159, 8)
        Me.tbDossierStockage.Name = "tbDossierStockage"
        Me.tbDossierStockage.Size = New System.Drawing.Size(709, 20)
        Me.tbDossierStockage.TabIndex = 125
        '
        'cbStocker
        '
        Me.cbStocker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbStocker.Location = New System.Drawing.Point(920, 3)
        Me.cbStocker.Name = "cbStocker"
        Me.cbStocker.Size = New System.Drawing.Size(56, 24)
        Me.cbStocker.TabIndex = 124
        Me.cbStocker.Text = "Stocker"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(104, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 16)
        Me.Label34.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(496, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Editer BaF"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Valider BaF"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(8, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 16)
        Me.Label33.TabIndex = 9
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(80, 48)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(488, 176)
        Me.RichTextBox2.TabIndex = 8
        Me.RichTextBox2.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 24)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Appliquer"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 16)
        Me.Label35.TabIndex = 0
        '
        'cbReglement
        '
        Me.cbReglement.Location = New System.Drawing.Point(787, 70)
        Me.cbReglement.Name = "cbReglement"
        Me.cbReglement.Size = New System.Drawing.Size(75, 23)
        Me.cbReglement.TabIndex = 19
        Me.cbReglement.Text = "R�glements"
        Me.cbReglement.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 37)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(980, 513)
        Me.CrystalReportViewer1.TabIndex = 129
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmGestFactTRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1016, 686)
        Me.Controls.Add(Me.cbReglement)
        Me.Controls.Add(Me.cbAnnExport)
        Me.Controls.Add(Me.SSTabCommandeClient)
        Me.Controls.Add(Me.grpEntete)
        Me.Name = "frmGestFactTRP"
        Me.ShowInTaskbar = False
        Me.Text = "Facture de transport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpEntete.ResumeLayout(False)
        Me.grpEntete.PerformLayout()
        CType(Me.m_bsrcFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSTabCommandeClient.ResumeLayout(False)
        Me.tpLignes.ResumeLayout(False)
        Me.tpLignes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcLgFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcModeReglement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCommentaires.ResumeLayout(False)
        Me.tpCommentaires.PerformLayout()
        Me.tpValidCmd.ResumeLayout(False)
        Me.tpValidCmd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "M�thodes Vinicom"

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled)
        Me.tbCode.Enabled = False
        Me.DataGridView1.Enabled = True
    End Sub
    Protected Overrides Function creerElement() As Boolean
        Debug.Assert(Not isfrmUpdated(), "La fenetre n'est pas libre")
        Dim bReturn As Boolean

        bReturn = setElementCourant2(New FactTRP(New Client("", "")))

        Return bReturn
    End Function
    Protected Shadows Function getElementCourant() As FactTRP
        Return CType(m_ElementCourant, FactTRP)
    End Function
    Public Overrides Function setElementCourant2(ByVal pElement As Persist) As Boolean
        Dim bReturn As Boolean
        If Not pElement Is Nothing Then
            pElement.load()
            bReturn = MyBase.setElementCourant2(pElement)
            If (bReturn) Then
                getElementCourant().loadcolLignes()
            End If
        Else
            bReturn = MyBase.setElementCourant2(pElement)
        End If
        m_bsrcFacture.Clear()
        m_bsrcFacture.Add(pElement)
        m_bsrcFacture.ResetCurrentItem()

        'Activation/Desactivation des boutons de MAJ
        If Not getElementCourant() Is Nothing And bReturn Then
            cbAjouterLigne.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            cbSupprimerLigne.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            dtDateFact.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            tbPeriode.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            tbTotalHT.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            tbTotalTTC.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
            cbRecalcTotaux.Enabled = getElementCourant().etat.codeEtat <> vncEtatCommande.vncFactTRPExportee
        End If
        setToolbarButtons()
        Return bReturn
    End Function 'SetElement_Specifique
    'Interface ElementCourant -> Ecran
    Public Overrides Function AfficheElement() As Boolean


        Debug.Assert(Not getElementCourant() Is Nothing)

        'Affichage des caract�ristiques de la commande


        'Etat de la commande
        AfficheEtat()

        'Fournisseur
        liTiers.Text = getElementCourant().oTiers.shortResume
        liTiers.Tag = getElementCourant().oTiers.id


        'Commentaires

        'Lignes de Commandes
        affichecolLignes()
        afficheTotaux()

        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Refresh()


        Return True
    End Function 'AfficheElement
    Public Overrides Function ControleAvantSauvegarde() As Boolean
        Dim bReturn As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing, "Element Courant Requis")

        Try
            bReturn = True
        Catch ex As Exception
            bReturn = False
            DisplayError("ControleAvantSauvegarde", ex.ToString)
        End Try
        Return bReturn
    End Function
    Public Overrides Function getResume() As String 'Rend le caption de la fen�tre
        Dim str As String
        str = "FCTTRP"
        If Not getElementCourant() Is Nothing Then
            str = str & getElementCourant().shortResume()
        End If
        Return str
    End Function 'getResume
    Protected Overrides Function frmNew() As Boolean
        Dim breturn As Boolean
        breturn = False
        Return breturn
    End Function
    Protected Overrides Function frmDel() As Boolean
        Dim bReturn As Boolean
        bReturn = False
        MyBase.frmDel()
        If getElementCourant() Is Nothing Then
            bReturn = setElementCourant2(Nothing)
        End If
        Return bReturn
    End Function ' frmDel

    Protected Overrides Sub setfrmUpdated()
        If Not getElementCourant() Is Nothing Then
            MAJElementCourant()
            MyBase.setfrmUpdated()
        End If
    End Sub
    Public Overrides Function SauveElement() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing)
        Dim bReturn As Boolean
        bReturn = getElementCourant().Save
        If bReturn Then
            tbCode.Text = getElementCourant().code
            MyBase.getResume()
        End If
        Debug.Assert(bReturn, "Erreur en sauvegarde")
        Return bReturn
    End Function
    Protected Overrides Sub AddHandlerValidated(ByVal ocol As System.Windows.Forms.Control.ControlCollection)
        MyBase.AddHandlerValidated(ocol)
        RemoveHandler tbDossierStockage.Validated, AddressOf ControlUpdated
        RemoveHandler cbStocker.Click, AddressOf ControlUpdated
        RemoveHandler cbAfficherEtat.Click, AddressOf ControlUpdated
    End Sub


    '==============================================================================================
    '==============================================================================================
    '==============================================================================================
#End Region
#Region "Methodes Priv�es"
    Protected Sub initFenetre()
        debAffiche()
        m_TypeDonnees = vncEnums.vncTypeDonnee.FACTTRP
        tbDossierStockage.Text = Param.getConstante("CST_PATH_FACTTRP")
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        CrystalReportViewer1.DisplayToolbar = True
        Dim objModeReglement As Param
        m_bsrcModeReglement.Clear()
        For Each objModeReglement In Param.colModeReglement
            m_bsrcModeReglement.Add(objModeReglement)
        Next

        finAffiche()
    End Sub 'initFenetre


    'Affiche la boite de dialogue d'ajout de ligne
    Protected Function ajouteruneLigne() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing)
        Debug.Assert(Not getElementCourant().oTiers Is Nothing)
        Dim bReturn As Boolean
        Dim odlg As dlgLgFactTRP
        Dim objLg As LgFactTRP


        objLg = New LgFactTRP
        objLg.num = getElementCourant().getNextNumLg()
        odlg = New dlgLgFactTRP
        odlg.setElementCourant(objLg)
        odlg.setTiersCourant(getElementCourant().oTiers)
        If odlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            objLg = getElementCourant().AjouteLigneFactTRP(objLg, True)
            m_bsrcLgFact.Add(objLg)
            afficheTotaux()
        End If
        bReturn = True

        Return bReturn

    End Function 'Ajouteruneligne
    'Affiche la boite de dialogue de modification de ligne
    Protected Function supprimeruneLigne() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing)
        Dim objLg As LgFactTRP
        Dim bReturn As Boolean
        Dim objCMD As CommandeClient

        Try
            objLg = m_bsrcLgFact.Current
            If MsgBox("Etes-vous sur de vouloir supprimer la ligne " & objLg.num, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                getElementCourant().supprimeLigne(objLg.num)
                If objLg.idCmdCLT <> 0 Then
                    objCMD = CommandeClient.createandload(objLg.idCmdCLT)
                    objCMD.idFactTransport = 0
                    objCMD.save()
                End If
                setfrmUpdated()
                bReturn = True
            End If
        Catch ex As Exception
            bReturn = False
            DisplayError("frmGestFactCom.SupprimerUneLigne", "Impossible de charger la ligne")
        End Try
        getElementCourant().calculPrixTotal()
        debAffiche()
        affichecolLignes()
        afficheTotaux()
        finAffiche()


        bReturn = True

        Return bReturn
    End Function 'Ajouteruneligne

    Protected Sub afficheTotaux()
        debAffiche()
        m_bsrcFacture.ResetCurrentItem()
        finAffiche()
    End Sub 'Affiche des totaux HT et TTC
    Protected Function affichecolLignes() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing)
        Debug.Assert(Not getElementCourant().colLignes Is Nothing)

        Dim objLg As LgFactTRP
        debAffiche()
        m_bsrcLgFact.Clear()
        For Each objLg In getElementCourant().colLignes
            m_bsrcLgFact.Add(objLg)
        Next objLg
        m_bsrcLgFact.ResetBindings(False)
        finAffiche()
    End Function ' Affichage de des lignes de commandes

    Private Sub afficherRapport()
        Dim strReport As String
        Dim objReport As ReportDocument
        Dim tabIds As ArrayList

        sauvegardeElementCourant()
        'Choix de l'�tat
        strReport = PATHTOREPORTS & "crFactureTRP.rpt"

        If strReport = "" Then
            Exit Sub
        End If
        setcursorWait()
        objReport = New ReportDocument
        objReport.Load(strReport)
        tabIds = New ArrayList()
        tabIds.Add(getElementCourant().id)

        objReport.SetParameterValue("IdFactures", tabIds.ToArray())

        objReport.SetParameterValue("bEntete", ckEntete.Checked)

        objReport.SetParameterValue("LGNUMGAZOLE", Param.LGNUM_GAZOLE)

        Persist.setReportConnection(objReport)
        CrystalReportViewer1.ReportSource = objReport
        restoreCursor()

    End Sub
    Private Sub StockerFactTrp()
        '==================================================================================================
        'Function : exporterFacttrp
        'Description : exporte l'�tat dans le r�pertoire sp�cifi�
        '===================================================================================================
        Dim objReport As ReportDocument
        Dim diskOpts As DiskFileDestinationOptions
        Try
            setcursorWait()
            DisplayStatus("Stokage de la facture")
            objReport = New ReportDocument
            diskOpts = New DiskFileDestinationOptions
            objReport.Load(PATHTOREPORTS & "crFactureTRP.rpt")
            objReport.SetParameterValue("idFactures", getElementCourant().id)
            objReport.SetParameterValue("BENTETE", True)
            objReport.SetParameterValue("LGNUMGAZOLE", Param.LGNUM_GAZOLE)
            objReport.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
            objReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            diskOpts.DiskFileName = tbDossierStockage.Text & "\F" & Format(CInt(getElementCourant().code), "000000") & "_" & getElementCourant().oTiers.rs & "_" & getElementCourant().periode & ".pdf"
            objReport.ExportOptions.DestinationOptions = diskOpts
            Persist.setReportConnection(objReport)
            objReport.Export()
            objReport.Close()

            DisplayStatus("")

            setfrmUpdated()

            restoreCursor()
        Catch ex As Exception
            MsgBox("erreur en Stockage de Facture de Transport, essayer en manuel" & ex.ToString)
        End Try
    End Sub
    Private Sub AfficheEtat()
        debAffiche()
        Me.laEtatCommande.Text = getElementCourant().etat.libelle
        laEtatCommande.Tag = getElementCourant().etat.codeEtat
        cbAnnExport.Visible = (getElementCourant().etat.codeEtat = vncEtatCommande.vncFactTRPExportee)
        finAffiche()
    End Sub 'AfficheEtat

    '***********************************************************************************************************************************************************************
#End Region 'M�thodes Priv�es
#Region "Gestion Evenements"
    'Affichage de l'entete de la liste des lignes
    Private Sub cbAjouterLigne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAjouterLigne.Click
        If ajouteruneLigne() Then
            recalcul()
            setfrmUpdated()
        End If
    End Sub

    Private Sub liTiers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles liTiers.LinkClicked
        afficheFenetreClient(liTiers.Tag)
    End Sub 'liNomClient_LinkClicked
    Private Sub cbSupprimerLigne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSupprimerLigne.Click
        If Not m_bsrcLgFact.Current Is Nothing Then
            If supprimeruneLigne() Then
                recalcul()
                setfrmUpdated()
            End If
        End If
    End Sub




    Private Sub cbRecalcTotaux_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRecalcTotaux.Click
        recalcul()
    End Sub

    Private Sub recalcul()
        Debug.Assert(Not getElementCourant() Is Nothing, "Facture courante non renseign�e")
        getElementCourant().calculPrixTotal()
        affichecolLignes()
        afficheTotaux()
        setfrmUpdated()

    End Sub
    Private Sub frmGestFactTRP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub
    Private Sub dbAfficherEtat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficherEtat.Click
        afficherRapport()
    End Sub

    Private Sub cbBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBrowse.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.tbDossierStockage.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub cbStocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStocker.Click
        StockerFactTrp()
        AfficheEtat()
    End Sub


#End Region



    Private Sub frmGestFactTRP_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If isfrmUpdated() Then
            If getElementCourant().bcolLignesUpated Then
                getElementCourant().Save()
            End If
        End If
    End Sub



    Private Sub bAnnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnnExport.Click
        getElementCourant().changeEtat(vncActionEtatCommande.vncActionFactTRPAnnExporter)
        setfrmUpdated()
        AfficheEtat()
    End Sub

    Private Sub cbReglement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbReglement.Click
        Dim odlg As dlgReglements
        odlg = New dlgReglements
        odlg.setFact(Me.getElementCourant())
        odlg.ShowDialog(Me)

    End Sub
    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = True
        m_ToolBarLoadEnabled = True
        If isfrmUpdated() Then
            m_ToolBarSaveEnabled = True
        Else
            m_ToolBarSaveEnabled = False
        End If
        m_ToolBarDelEnabled = True
        m_ToolBarRefreshEnabled = True

    End Sub
    Protected Overrides Function isfrmUpdated() As Boolean
        If getElementCourant() Is Nothing Then
            Return False
        End If
        If getElementCourant().etat.codeEtat = vncEtatCommande.vncFactComExportee Then
            Return False
        Else
            Return MyBase.isfrmUpdated()
        End If

    End Function

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Trace.WriteLine("Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick")
    End Sub
End Class
