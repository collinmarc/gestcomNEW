Option Strict Off
Imports vini_DB
Public Class frmGeneFactColisage2
    Inherits FrmDonBase
    Protected m_colMouvementsStock As Collection
    Private Const COL_STKDATE As Integer = 0
    Private Const COL_STKQTE As Integer = 1
    Private Const COL_STKLIBELLE As Integer = 2
    Private Const COL_STKINDEX As Integer = 3
    Friend WithEvents m_bsrcMvtStock As System.Windows.Forms.BindingSource
    Friend WithEvents cbxDossier As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRepStockage As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpFact As GroupBox
    Friend WithEvents tbMontantHT As TextBox
    Friend WithEvents tbMontantTTC As TextBox
    Friend WithEvents dtDateFactCourante As DateTimePicker
    Friend WithEvents tbPeriodeFactCourante As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents liTiers As LinkLabel
    Friend WithEvents liFacture As LinkLabel
    Friend WithEvents btnEspFrn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents m_bsrcFactColisage As BindingSource
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FournisseurRSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FournisseurCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalHTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalTTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCodeFournisseur As TextBox
    Private Const COL_NBRECOL As Integer = 4

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
    Friend WithEvents dtDatedeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnGenerer As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDateFacture As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxDossier = New System.Windows.Forms.ComboBox()
        Me.m_bsrcMvtStock = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtDateFacture = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.dtDatedeb = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRepStockage = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.grpFact = New System.Windows.Forms.GroupBox()
        Me.tbMontantHT = New System.Windows.Forms.TextBox()
        Me.tbMontantTTC = New System.Windows.Forms.TextBox()
        Me.dtDateFactCourante = New System.Windows.Forms.DateTimePicker()
        Me.tbPeriodeFactCourante = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.liTiers = New System.Windows.Forms.LinkLabel()
        Me.liFacture = New System.Windows.Forms.LinkLabel()
        Me.btnEspFrn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FournisseurRSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FournisseurCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcFactColisage = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCodeFournisseur = New System.Windows.Forms.TextBox()
        CType(Me.m_bsrcMvtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFact.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcFactColisage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Dossier : "
        '
        'cbxDossier
        '
        Me.cbxDossier.FormattingEnabled = True
        Me.cbxDossier.Location = New System.Drawing.Point(232, 3)
        Me.cbxDossier.Name = "cbxDossier"
        Me.cbxDossier.Size = New System.Drawing.Size(127, 21)
        Me.cbxDossier.TabIndex = 125
        '
        'm_bsrcMvtStock
        '
        Me.m_bsrcMvtStock.DataSource = GetType(vini_DB.mvtStock)
        '
        'dtDateFacture
        '
        Me.dtDateFacture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateFacture.Location = New System.Drawing.Point(521, 30)
        Me.dtDateFacture.Name = "dtDateFacture"
        Me.dtDateFacture.Size = New System.Drawing.Size(104, 20)
        Me.dtDateFacture.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(417, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Date de facture :"
        '
        'btnGenerer
        '
        Me.btnGenerer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerer.Location = New System.Drawing.Point(15, 80)
        Me.btnGenerer.Name = "btnGenerer"
        Me.btnGenerer.Size = New System.Drawing.Size(920, 24)
        Me.btnGenerer.TabIndex = 8
        Me.btnGenerer.Text = "Générer"
        '
        'dtDatedeb
        '
        Me.dtDatedeb.CustomFormat = "MMMM yyyy"
        Me.dtDatedeb.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDatedeb.Location = New System.Drawing.Point(232, 30)
        Me.dtDatedeb.Name = "dtDatedeb"
        Me.dtDatedeb.Size = New System.Drawing.Size(127, 20)
        Me.dtDatedeb.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(12, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Mois de facturation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Répertoire de stockage des factures :"
        '
        'tbRepStockage
        '
        Me.tbRepStockage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRepStockage.Location = New System.Drawing.Point(232, 56)
        Me.tbRepStockage.Name = "tbRepStockage"
        Me.tbRepStockage.Size = New System.Drawing.Size(611, 20)
        Me.tbRepStockage.TabIndex = 128
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(849, 53)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 129
        Me.btnBrowse.Text = "Parcourir"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'grpFact
        '
        Me.grpFact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFact.Controls.Add(Me.tbMontantHT)
        Me.grpFact.Controls.Add(Me.tbMontantTTC)
        Me.grpFact.Controls.Add(Me.dtDateFactCourante)
        Me.grpFact.Controls.Add(Me.tbPeriodeFactCourante)
        Me.grpFact.Controls.Add(Me.Label10)
        Me.grpFact.Controls.Add(Me.Label7)
        Me.grpFact.Controls.Add(Me.Label3)
        Me.grpFact.Controls.Add(Me.Label2)
        Me.grpFact.Controls.Add(Me.liTiers)
        Me.grpFact.Controls.Add(Me.liFacture)
        Me.grpFact.Location = New System.Drawing.Point(658, 111)
        Me.grpFact.Name = "grpFact"
        Me.grpFact.Size = New System.Drawing.Size(282, 199)
        Me.grpFact.TabIndex = 133
        Me.grpFact.TabStop = False
        '
        'tbMontantHT
        '
        Me.tbMontantHT.Location = New System.Drawing.Point(112, 150)
        Me.tbMontantHT.Name = "tbMontantHT"
        Me.tbMontantHT.Size = New System.Drawing.Size(144, 20)
        Me.tbMontantHT.TabIndex = 143
        '
        'tbMontantTTC
        '
        Me.tbMontantTTC.Location = New System.Drawing.Point(112, 124)
        Me.tbMontantTTC.Name = "tbMontantTTC"
        Me.tbMontantTTC.Size = New System.Drawing.Size(144, 20)
        Me.tbMontantTTC.TabIndex = 142
        '
        'dtDateFactCourante
        '
        Me.dtDateFactCourante.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateFactCourante.Location = New System.Drawing.Point(112, 72)
        Me.dtDateFactCourante.Name = "dtDateFactCourante"
        Me.dtDateFactCourante.Size = New System.Drawing.Size(96, 20)
        Me.dtDateFactCourante.TabIndex = 2
        '
        'tbPeriodeFactCourante
        '
        Me.tbPeriodeFactCourante.Location = New System.Drawing.Point(112, 98)
        Me.tbPeriodeFactCourante.Name = "tbPeriodeFactCourante"
        Me.tbPeriodeFactCourante.Size = New System.Drawing.Size(144, 20)
        Me.tbPeriodeFactCourante.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Periode"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "DateFacture"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Montant TTC"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Montant HT"
        '
        'liTiers
        '
        Me.liTiers.Location = New System.Drawing.Point(8, 48)
        Me.liTiers.Name = "liTiers"
        Me.liTiers.Size = New System.Drawing.Size(268, 16)
        Me.liTiers.TabIndex = 1
        Me.liTiers.TabStop = True
        Me.liTiers.Text = "RS Tiers"
        '
        'liFacture
        '
        Me.liFacture.Location = New System.Drawing.Point(8, 24)
        Me.liFacture.Name = "liFacture"
        Me.liFacture.Size = New System.Drawing.Size(256, 24)
        Me.liFacture.TabIndex = 0
        Me.liFacture.TabStop = True
        Me.liFacture.Text = "Reference Facture"
        '
        'btnEspFrn
        '
        Me.btnEspFrn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEspFrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspFrn.Image = Global.vini_app.My.Resources.Resources.Cloud_Mail
        Me.btnEspFrn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEspFrn.Location = New System.Drawing.Point(666, 489)
        Me.btnEspFrn.Name = "btnEspFrn"
        Me.btnEspFrn.Size = New System.Drawing.Size(274, 117)
        Me.btnEspFrn.TabIndex = 135
        Me.btnEspFrn.Text = "Export vers l'espace fournisseur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "et Mail"
        Me.btnEspFrn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEspFrn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.PeriodeDataGridViewTextBoxColumn, Me.FournisseurRSDataGridViewTextBoxColumn, Me.FournisseurCodeDataGridViewTextBoxColumn, Me.TotalHTDataGridViewTextBoxColumn, Me.TotalTTCDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.m_bsrcFactColisage
        Me.DataGridView1.Location = New System.Drawing.Point(15, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(628, 495)
        Me.DataGridView1.TabIndex = 136
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'PeriodeDataGridViewTextBoxColumn
        '
        Me.PeriodeDataGridViewTextBoxColumn.DataPropertyName = "periode"
        Me.PeriodeDataGridViewTextBoxColumn.HeaderText = "periode"
        Me.PeriodeDataGridViewTextBoxColumn.Name = "PeriodeDataGridViewTextBoxColumn"
        '
        'FournisseurRSDataGridViewTextBoxColumn
        '
        Me.FournisseurRSDataGridViewTextBoxColumn.DataPropertyName = "FournisseurRS"
        Me.FournisseurRSDataGridViewTextBoxColumn.HeaderText = "FournisseurRS"
        Me.FournisseurRSDataGridViewTextBoxColumn.Name = "FournisseurRSDataGridViewTextBoxColumn"
        Me.FournisseurRSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FournisseurCodeDataGridViewTextBoxColumn
        '
        Me.FournisseurCodeDataGridViewTextBoxColumn.DataPropertyName = "FournisseurCode"
        Me.FournisseurCodeDataGridViewTextBoxColumn.HeaderText = "FournisseurCode"
        Me.FournisseurCodeDataGridViewTextBoxColumn.Name = "FournisseurCodeDataGridViewTextBoxColumn"
        Me.FournisseurCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalHTDataGridViewTextBoxColumn
        '
        Me.TotalHTDataGridViewTextBoxColumn.DataPropertyName = "totalHT"
        Me.TotalHTDataGridViewTextBoxColumn.HeaderText = "totalHT"
        Me.TotalHTDataGridViewTextBoxColumn.Name = "TotalHTDataGridViewTextBoxColumn"
        '
        'TotalTTCDataGridViewTextBoxColumn
        '
        Me.TotalTTCDataGridViewTextBoxColumn.DataPropertyName = "totalTTC"
        Me.TotalTTCDataGridViewTextBoxColumn.HeaderText = "totalTTC"
        Me.TotalTTCDataGridViewTextBoxColumn.Name = "TotalTTCDataGridViewTextBoxColumn"
        '
        'm_bsrcFactColisage
        '
        Me.m_bsrcFactColisage.DataSource = GetType(vini_DB.FactColisageJ)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Code Fournisseur :"
        '
        'tbCodeFournisseur
        '
        Me.tbCodeFournisseur.Location = New System.Drawing.Point(521, 4)
        Me.tbCodeFournisseur.Name = "tbCodeFournisseur"
        Me.tbCodeFournisseur.Size = New System.Drawing.Size(100, 20)
        Me.tbCodeFournisseur.TabIndex = 138
        '
        'frmGeneFactColisage2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(997, 630)
        Me.Controls.Add(Me.tbCodeFournisseur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEspFrn)
        Me.Controls.Add(Me.grpFact)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbRepStockage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxDossier)
        Me.Controls.Add(Me.dtDateFacture)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGenerer)
        Me.Controls.Add(Me.dtDatedeb)
        Me.Controls.Add(Me.Label14)
        Me.Name = "frmGeneFactColisage2"
        Me.Text = "Génération de factures de colisage"
        CType(Me.m_bsrcMvtStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFact.ResumeLayout(False)
        Me.grpFact.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcFactColisage, System.ComponentModel.ISupportInitialize).EndInit()
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
        m_ToolBarSaveEnabled = True
    End Sub

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled)
        cbxDossier.Enabled = True
        dtDatedeb.Enabled = True
        dtDateFacture.Enabled = True

    End Sub

    Protected Shadows Function getElementCourant() As FactColisageJ
        Return CType(m_ElementCourant, FactColisageJ)
    End Function

    Protected Overrides Function frmSave() As Boolean
        If MyBase.frmSave() Then
            afficheFactureCourante()
        End If
    End Function


#End Region

#Region "Methodes privées"
    Private Sub initFenetre()
        'Initialisation de la COMBO Dossier
        cbxDossier.Items.Clear()
        cbxDossier.Items.Add(Dossier.VINICOM)
        cbxDossier.Items.Add(Dossier.HOBIVIN)
        cbxDossier.Text = Dossier.VINICOM

        'Date de Début = 01 du mois Courant
        dtDatedeb.Value = "01/" & Now.Month() & "/" & Now.Year

        dtDateFacture.Value = Now()
        m_colMouvementsStock = New Collection

        Me.tbRepStockage.Enabled = True
        btnBrowse.Enabled = True
        btnGenerer.Enabled = True
        grpFact.Enabled = False
        btnEspFrn.Enabled = True
    End Sub
    Private Sub afficheListeMvtStock()

        setcursorWait()
        debAffiche()
        m_bsrcMvtStock.Clear()

        Debug.Assert(Not m_colMouvementsStock Is Nothing)
        Dim objMvt As mvtStock
        Dim nRow As Integer


        nRow = 0
        For Each objMvt In m_colMouvementsStock
            m_bsrcMvtStock.Add(objMvt)
        Next objMvt

        btnGenerer.Enabled = True

        finAffiche()
        restoreCursor()

    End Sub 'AfficheListeMvtStock

    ''' <summary>
    ''' Créé la liste des mouvements de stocks en fonction des paramètres
    ''' </summary>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Private Function setListeMouvementsStock() As Boolean
        Dim ddeb As Date
        Dim dfin As Date
        Dim codeFournisseur As String
        Dim strDossier As String
        Dim col As Collection
        Dim bReturn As Boolean
        Dim oFRN As Fournisseur
        'If tbCodeFournisseur.Text = "" And cbxDossier.Text = Dossier.VINICOM Then
        '    MsgBox("Saisie d'un code fournisseur Obligatoire pour le dossier VINICOM")
        '    Return False
        'End If

        'codeFournisseur = tbCodeFournisseur.Text
        strDossier = cbxDossier.Text

        debAffiche()
        setcursorWait()
        Try

            ddeb = CDate("01/" & dtDatedeb.Value.Month & "/" & dtDatedeb.Value.Year)
            dfin = ddeb.AddMonths(1).AddDays(-1)
            col = Nothing
            If strDossier = Dossier.VINICOM Then
                oFRN = Fournisseur.createandload(codeFournisseur)
                If Not oFRN Is Nothing Then
                    'Recupération de la liste des Mouvements de stocks
                    '                    col = mvtStock.getListe2(ddeb, dfin, oFRN, vncEtatMVTSTK.vncMVTSTK_nFact, strDossier)
                    'A Discuter avec Mme Mathurin
                    col = mvtStock.getListe2(ddeb, dfin, oFRN, vncEtatMVTSTK.vncMVTSTK_nFact)
                End If
            End If
            If strDossier = Dossier.HOBIVIN Then
                'Recupération de la liste des Mouvements de stocks
                col = mvtStock.getListeDossierNonFacture(strDossier, ddeb, dfin)
            End If
            If col Is Nothing Then
                bReturn = False
            Else
                'On ne prend sur les Mouvements des produits en stock
                m_colMouvementsStock = col
                bReturn = True
            End If
        Catch ex As Exception
            bReturn = False
            Debug.Assert(bReturn, ex.ToString)
        End Try
        finAffiche()
        restoreCursor()
        Return bReturn
    End Function
    ''' <summary>
    ''' Generatin d'une facture de colisage avec les paramètres
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub genererFactures()
        Dim colFact As New Collection
        Dim oFRN As Fournisseur = Nothing
        Dim oFact As FactColisageJ
        If cbxDossier.Text = Dossier.VINICOM Then
            '            oFRN = Fournisseur.createandload(tbCodeFournisseur.Text)
        End If
        If cbxDossier.Text = Dossier.HOBIVIN Then
            oFRN = Fournisseur.getIntermediairePourUnDossier(Dossier.HOBIVIN)
        End If



        If (Not oFRN Is Nothing) Then
            setcursorWait()
            oFact = FactColisageJ.GenereFacture(dtDatedeb.Value, oFRN, cbxDossier.Text)
            If Not oFact Is Nothing Then
                oFact.dateFacture = dtDateFacture.Value.ToShortDateString()
                setElementCourant2(oFact)
            End If
            restoreCursor()
        End If

    End Sub 'genererFactures

    Private Function appliqueModifications() As Boolean
        Dim bReturn As Boolean
        majElement()
        bReturn = setElementCourant2(Nothing)
        Return bReturn
    End Function
    Public Overrides Function majElement() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing, "Pas de Facture courante")
        Return True
    End Function 'majElement


    Private Function afficheFactureCourante() As Boolean
        Debug.Assert(Not getElementCourant() Is Nothing, "La Facture courante doit être renseignée")

        'Affichage de la Facture
        debAffiche()

        finAffiche()
        Return True

    End Function 'AfficheFactureCourante

    Private Function elementCourantSansModif() As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = True
            If Not getElementCourant() Is Nothing Then
            End If
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function
    Private Sub rechercheClient()
        'Dim objTiers As Tiers

        'objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.FOURNISSEUR, tbCodeFournisseur)

        'If Not objTiers Is Nothing Then
        '    tbCodeFournisseur.Text = objTiers.code
        'End If
    End Sub 'rechercheClient

#End Region
#Region "Gestion des Evenements"
    Private Sub frmGestionSCMD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub

    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If setListeMouvementsStock() Then
            'm_SCMDcourante = Nothing
            afficheListeMvtStock()
        End If
        'dgvMvtStock.Enabled = True

    End Sub





#End Region

    Protected Overrides Sub AddHandlerValidated(ByVal ocol As System.Windows.Forms.Control.ControlCollection)
        'Dans cette fenêtre seul le bouton Génerer déclenche L'evenement Updated
        'AddHandler cbAppliquer.Click, AddressOf ControlUpdated
        'AddHandler cbGenerer.Click, AddressOf ControlUpdated
    End Sub

    'Private Sub cbSelectionnerTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelectionnerTout.Click
    '    Call selectionnerTout()
    'End Sub

    Private Sub cbGenerer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerer.Click
        Call sauvegardeElementCourant()
        Call genererFactures()
        Call afficheFactureCourante()
        If Not getElementCourant() Is Nothing Then
            btnGenerer.Enabled = False
            setfrmUpdated()
        End If
    End Sub





    Private Sub cbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSave()
    End Sub

    'Private Sub cbxDossier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDossier.SelectedIndexChanged
    '    If cbxDossier.Text = Dossier.VINICOM Then
    '        lblFournisseur.Visible = True
    '        tbCodeFournisseur.Visible = True
    '        cbRecherche.Visible = True

    '    End If
    '    If cbxDossier.Text = Dossier.HOBIVIN Then
    '        lblFournisseur.Visible = False
    '        tbCodeFournisseur.Visible = False
    '        cbRecherche.Visible = False

    '    End If
    'End Sub

    Private Sub liTiers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub liFactTRP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class
