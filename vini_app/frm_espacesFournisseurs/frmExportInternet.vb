Imports vini_DB
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class frmExportInternet
    Inherits FrmVinicom
    Protected m_colCommandes As List(Of SousCommande)

#Region " Code g�n�r� par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()
        ckFTP.Enabled = True

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
    Friend WithEvents dtdateFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtDatedeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents cbAfficher As System.Windows.Forms.Button
    Friend WithEvents cbExporter As System.Windows.Forms.Button
    Friend WithEvents ckPDFs As System.Windows.Forms.CheckBox
    Friend WithEvents ckFTP As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCodeFournisseur As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dgvSCmd As System.Windows.Forms.DataGridView
    Friend WithEvents m_bsrcSCMD As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsrcStatus As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNbScmd As System.Windows.Forms.TextBox
    Friend WithEvents StatusDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusMessageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbNbreTheorique As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FournisseurCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiersRS As DataGridViewTextBoxColumn
    Friend WithEvents totalHT As DataGridViewTextBoxColumn
    Friend WithEvents dateCommande As DataGridViewTextBoxColumn
    Friend WithEvents lnkFTP As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbRechercher As Button
    Friend WithEvents dgvStatus As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtdateFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtDatedeb = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.cbExporter = New System.Windows.Forms.Button()
        Me.ckPDFs = New System.Windows.Forms.CheckBox()
        Me.ckFTP = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCodeFournisseur = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dgvSCmd = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FournisseurCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiersRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCommande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcSCMD = New System.Windows.Forms.BindingSource(Me.components)
        Me.m_bsrcStatus = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvStatus = New System.Windows.Forms.DataGridView()
        Me.StatusDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNbScmd = New System.Windows.Forms.TextBox()
        Me.tbNbreTheorique = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnkFTP = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cbRechercher = New System.Windows.Forms.Button()
        CType(Me.dgvSCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcSCMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtdateFin
        '
        Me.dtdateFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdateFin.Location = New System.Drawing.Point(232, 32)
        Me.dtdateFin.Name = "dtdateFin"
        Me.dtdateFin.Size = New System.Drawing.Size(88, 20)
        Me.dtdateFin.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 16)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "date de fin"
        '
        'dtDatedeb
        '
        Me.dtDatedeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDatedeb.Location = New System.Drawing.Point(232, 8)
        Me.dtDatedeb.Name = "dtDatedeb"
        Me.dtDatedeb.Size = New System.Drawing.Size(88, 20)
        Me.dtDatedeb.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "date de d�but "
        '
        'cbAfficher
        '
        Me.cbAfficher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAfficher.BackColor = System.Drawing.SystemColors.Control
        Me.cbAfficher.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbAfficher.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbAfficher.Location = New System.Drawing.Point(8, 96)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbAfficher.Size = New System.Drawing.Size(352, 23)
        Me.cbAfficher.TabIndex = 3
        Me.cbAfficher.Text = "A&fficher"
        Me.cbAfficher.UseVisualStyleBackColor = False
        '
        'cbExporter
        '
        Me.cbExporter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbExporter.Location = New System.Drawing.Point(366, 249)
        Me.cbExporter.Name = "cbExporter"
        Me.cbExporter.Size = New System.Drawing.Size(64, 24)
        Me.cbExporter.TabIndex = 4
        Me.cbExporter.Text = "Exporter"
        '
        'ckPDFs
        '
        Me.ckPDFs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckPDFs.Checked = True
        Me.ckPDFs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPDFs.Location = New System.Drawing.Point(352, 8)
        Me.ckPDFs.Name = "ckPDFs"
        Me.ckPDFs.Size = New System.Drawing.Size(144, 24)
        Me.ckPDFs.TabIndex = 127
        Me.ckPDFs.Text = "Exportation des PDFs"
        '
        'ckFTP
        '
        Me.ckFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckFTP.AutoSize = True
        Me.ckFTP.Checked = True
        Me.ckFTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckFTP.Location = New System.Drawing.Point(638, 7)
        Me.ckFTP.Name = "ckFTP"
        Me.ckFTP.Size = New System.Drawing.Size(213, 17)
        Me.ckFTP.TabIndex = 128
        Me.ckFTP.Text = "Transmission au site internet fournisseur"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Code Fournisseur"
        '
        'tbCodeFournisseur
        '
        Me.tbCodeFournisseur.Location = New System.Drawing.Point(232, 64)
        Me.tbCodeFournisseur.Name = "tbCodeFournisseur"
        Me.tbCodeFournisseur.Size = New System.Drawing.Size(88, 20)
        Me.tbCodeFournisseur.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(438, 96)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(413, 23)
        Me.ProgressBar1.TabIndex = 132
        '
        'dgvSCmd
        '
        Me.dgvSCmd.AllowUserToAddRows = False
        Me.dgvSCmd.AllowUserToDeleteRows = False
        Me.dgvSCmd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSCmd.AutoGenerateColumns = False
        Me.dgvSCmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSCmd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.FournisseurCodeDataGridViewTextBoxColumn, Me.TiersRS, Me.totalHT, Me.dateCommande})
        Me.dgvSCmd.DataSource = Me.m_bsrcSCMD
        Me.dgvSCmd.Location = New System.Drawing.Point(8, 125)
        Me.dgvSCmd.Name = "dgvSCmd"
        Me.dgvSCmd.ReadOnly = True
        Me.dgvSCmd.Size = New System.Drawing.Size(352, 290)
        Me.dgvSCmd.TabIndex = 133
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FournisseurCodeDataGridViewTextBoxColumn
        '
        Me.FournisseurCodeDataGridViewTextBoxColumn.DataPropertyName = "FournisseurCode"
        Me.FournisseurCodeDataGridViewTextBoxColumn.HeaderText = "Producteur"
        Me.FournisseurCodeDataGridViewTextBoxColumn.Name = "FournisseurCodeDataGridViewTextBoxColumn"
        Me.FournisseurCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TiersRS
        '
        Me.TiersRS.DataPropertyName = "ClientRS"
        Me.TiersRS.HeaderText = "Client"
        Me.TiersRS.Name = "TiersRS"
        Me.TiersRS.ReadOnly = True
        '
        'totalHT
        '
        Me.totalHT.DataPropertyName = "totalHT"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.totalHT.DefaultCellStyle = DataGridViewCellStyle1
        Me.totalHT.HeaderText = "totalHT"
        Me.totalHT.Name = "totalHT"
        Me.totalHT.ReadOnly = True
        '
        'dateCommande
        '
        Me.dateCommande.DataPropertyName = "dateCommande"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dateCommande.DefaultCellStyle = DataGridViewCellStyle2
        Me.dateCommande.HeaderText = "dateCommande"
        Me.dateCommande.Name = "dateCommande"
        Me.dateCommande.ReadOnly = True
        '
        'm_bsrcSCMD
        '
        Me.m_bsrcSCMD.DataSource = GetType(vini_DB.SousCommande)
        '
        'm_bsrcStatus
        '
        Me.m_bsrcStatus.DataSource = GetType(vini_DB.clsExportstatus)
        '
        'dgvStatus
        '
        Me.dgvStatus.AllowUserToAddRows = False
        Me.dgvStatus.AllowUserToDeleteRows = False
        Me.dgvStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStatus.AutoGenerateColumns = False
        Me.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusDateDataGridViewTextBoxColumn, Me.StatusMessageDataGridViewTextBoxColumn})
        Me.dgvStatus.DataSource = Me.m_bsrcStatus
        Me.dgvStatus.Location = New System.Drawing.Point(438, 126)
        Me.dgvStatus.Name = "dgvStatus"
        Me.dgvStatus.ReadOnly = True
        Me.dgvStatus.Size = New System.Drawing.Size(413, 290)
        Me.dgvStatus.TabIndex = 134
        '
        'StatusDateDataGridViewTextBoxColumn
        '
        Me.StatusDateDataGridViewTextBoxColumn.DataPropertyName = "statusDate"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.StatusDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.StatusDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.StatusDateDataGridViewTextBoxColumn.Name = "StatusDateDataGridViewTextBoxColumn"
        Me.StatusDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDateDataGridViewTextBoxColumn.Width = 55
        '
        'StatusMessageDataGridViewTextBoxColumn
        '
        Me.StatusMessageDataGridViewTextBoxColumn.DataPropertyName = "statusMessage"
        Me.StatusMessageDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.StatusMessageDataGridViewTextBoxColumn.Name = "StatusMessageDataGridViewTextBoxColumn"
        Me.StatusMessageDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusMessageDataGridViewTextBoxColumn.Width = 75
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Nbre lu"
        '
        'tbNbScmd
        '
        Me.tbNbScmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNbScmd.Enabled = False
        Me.tbNbScmd.Location = New System.Drawing.Point(366, 203)
        Me.tbNbScmd.Name = "tbNbScmd"
        Me.tbNbScmd.Size = New System.Drawing.Size(64, 20)
        Me.tbNbScmd.TabIndex = 136
        '
        'tbNbreTheorique
        '
        Me.tbNbreTheorique.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNbreTheorique.Enabled = False
        Me.tbNbreTheorique.Location = New System.Drawing.Point(370, 157)
        Me.tbNbreTheorique.Name = "tbNbreTheorique"
        Me.tbNbreTheorique.Size = New System.Drawing.Size(60, 20)
        Me.tbNbreTheorique.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Th�orique"
        '
        'lnkFTP
        '
        Me.lnkFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkFTP.Location = New System.Drawing.Point(638, 27)
        Me.lnkFTP.Name = "lnkFTP"
        Me.lnkFTP.Size = New System.Drawing.Size(213, 25)
        Me.lnkFTP.TabIndex = 139
        Me.lnkFTP.TabStop = True
        Me.lnkFTP.Text = "LinkLabel1"
        Me.lnkFTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'cbRechercher
        '
        Me.cbRechercher.Location = New System.Drawing.Point(327, 64)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(75, 23)
        Me.cbRechercher.TabIndex = 140
        Me.cbRechercher.Text = "Rechercher"
        Me.cbRechercher.UseVisualStyleBackColor = True
        '
        'frmExportInternet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(863, 428)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.lnkFTP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNbreTheorique)
        Me.Controls.Add(Me.tbNbScmd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvStatus)
        Me.Controls.Add(Me.dgvSCmd)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbCodeFournisseur)
        Me.Controls.Add(Me.ckFTP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckPDFs)
        Me.Controls.Add(Me.cbExporter)
        Me.Controls.Add(Me.dtdateFin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtDatedeb)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbAfficher)
        Me.Name = "frmExportInternet"
        Me.Text = "Exportation  des bons � facturer vers Internet"
        CType(Me.dgvSCmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcSCMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
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
        dtDatedeb.Enabled = True
        dtdateFin.Enabled = True
        cbAfficher.Enabled = True
        tbCodeFournisseur.Enabled = True
        dgvStatus.Enabled = True

    End Sub


#End Region

#Region "Methodes priv�es"
    Private Sub initFenetre()
        dtDatedeb.Value = Now()
        dtdateFin.Value = Now()
        m_colCommandes = New List(Of SousCommande)
        ckPDFs.Enabled = True
        ckPDFs.Checked = True
        cbExporter.Enabled = False
        lnkFTP.Text = Trim(Param.getConstante("CST_FTPVNC_HOST"))
        lnkFTP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ckFTP.Enabled = True
    End Sub

    Private Sub afficheListeScmd()

        setcursorWait()
        debAffiche()

        m_bsrcSCMD.Clear()

        For Each objSCMD As SousCommande In m_colCommandes
            m_bsrcSCMD.Add(objSCMD)
        Next
        Dim objcommand As System.Data.OleDb.OleDbCommand
        objcommand = New OleDb.OleDbCommand
        objcommand.Connection = Persist.dbConnection.Connection
        objcommand.CommandText = "SELECT     COUNT(SOUSCOMMANDE.SCMD_ID) AS NBRE FROM SOUSCOMMANDE INNER JOIN FOURNISSEUR ON SOUSCOMMANDE.SCMD_FRN_ID = FOURNISSEUR.FRN_ID" &
                                 " WHERE     SOUSCOMMANDE.SCMD_ETAT = 10 AND  FOURNISSEUR.FRN_BEXP_INTERNET = 1 " &
                                 " AND SOUSCOMMANDE.SCMD_DATE >= ? AND " &
                                " SOUSCOMMANDE.SCMD_DATE <= ?"
        If Not String.IsNullOrEmpty(tbCodeFournisseur.Text) Then
            objcommand.CommandText = objcommand.CommandText &
                                     " AND FOURNISSEUR.FRN_CODE LIKE '" & tbCodeFournisseur.Text & "'"
        End If
        '        objcommand.Connection.Open()
        objcommand.Parameters.AddWithValue("?", dtDatedeb.Value)
        objcommand.Parameters.AddWithValue("?", dtdateFin.Value)
        tbNbreTheorique.Text = objcommand.ExecuteScalar().ToString()
        'objcommand.Connection.Close()


        tbNbScmd.Text = m_bsrcSCMD.Count


        finAffiche()
        restoreCursor()

    End Sub 'AfficheListeFactTRP

    Private Function setListeScmd() As Boolean
        Dim ddeb As Date
        Dim dfin As Date
        Dim strCodeFourn As String
        Dim col As List(Of SousCommande)
        Dim bReturn As Boolean
        debAffiche()
        setcursorWait()
        Try

            ddeb = dtDatedeb.Value.ToShortDateString
            dfin = dtdateFin.Value.ToShortDateString
            strCodeFourn = tbCodeFournisseur.Text
            col = SousCommande.getListeAExporterInternet(vncOrigineCmd.vncVinicom, ddeb, dfin, strCodeFourn)
            'Ajout des SousCommande Hobivin ayant des Fournisseurs vinicom
            col.AddRange(SousCommande.getListeAExporterInternet(vncOrigineCmd.vncHOBIVIN, ddeb, dfin, strCodeFourn))
            'Recup�ration de la liste des sous commande non Export�es
            If col Is Nothing Then
                bReturn = False
            Else
                m_colCommandes = col
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




    Private Function sauvegarder() As Boolean
        Dim objSCMD As SousCommande
        Dim bReturn As Boolean

        bReturn = False
        For Each objSCMD In m_colCommandes
            bReturn = bReturn And objSCMD.save()
            Debug.Assert(bReturn, SousCommande.getErreur())
        Next

        Return bReturn
    End Function 'sauvegarderFactures

    Private Function exporter() As Boolean

        Dim objSCMD As SousCommande
        Dim bExportOK As Boolean = True
        Dim bReturn As Boolean
        Dim strFile As String
        Dim strSCMD_CSV As String
        Dim nFile As Integer
        Dim strPDFFileName As String
        Dim strFolder As String
        Dim oFTPvinicom As clsFTPVinicom
        Dim nSousCommandesPreparees As Integer
        Dim nSousCommandesExportees As Integer
        Dim strStatus As String

        '        Dim odlgInternet As dlgInternet
        'Suppression - creation du r�pertoire temporaire
        Try
            bReturn = False
            nSousCommandesPreparees = 0
            '            strFolder = IMPORT_DIRECTORY & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second
            strFolder = My.Settings.Tmp & "/Exportinternet" & DateTime.Now.ToString("yyyyMMdd")
            If My.Computer.FileSystem.DirectoryExists(strFolder) Then
                My.Computer.FileSystem.DeleteDirectory(strFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CreateDirectory(strFolder)

            strFile = strFolder & "/" & "fromVinicom" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".csv"


            'G�n�ration des fichiers dans le r�pertoire temporaire
            nFile = FreeFile()
            FileOpen(nFile, strFile, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
            'G�n�ration de l'entete
            Print(nFile, SousCommande.EnteteCSV)
            'Parcours des Sous-commandes
            Dim nCmd As Integer = 0
            For Each objSCMD In m_colCommandes
                strStatus = ""
                Log("Chargement de " & objSCMD.code)
                objSCMD.load()
                objSCMD.loadcolLignes()
                If objSCMD.colLignes.Count > 0 Then
                    strSCMD_CSV = objSCMD.toCSV_espfrnVNC()
                    strStatus = strStatus + " CSV OK"
                    Print(nFile, strSCMD_CSV)
                    If ckPDFs.Checked Then
                        strPDFFileName = strFolder & "/" & objSCMD.code & ".PDF"
                        If Not objSCMD.genererPDF(PATHTOREPORTS, strPDFFileName) Then
                            DisplayStatus("Chargement de " & objSCMD.code & " PDF ERREUR" & objSCMD.getErreur())
                        End If

                    End If
                    nSousCommandesPreparees = nSousCommandesPreparees + 1
                    objSCMD.releasecolLignes()

                    'changement d'�tat de la sous Commandes
                    objSCMD.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDExportInternet)
                    objSCMD.bExportInternet = True
                    Log(strStatus)
                Else
                    DisplayStatus("Pas de ligne dans la sous-commande " + objSCMD.code)
                End If
                BackgroundWorker1.ReportProgress(nCmd)
                nCmd = nCmd + 1

            Next
            FileClose(nFile)
            bReturn = True
            DisplayStatus("Nombre de commandes pr�par�es : " & nSousCommandesPreparees)
            If ckFTP.Checked Then
                DisplayStatus("Transferts des fichiers vers " + Param.getConstante("CST_FTPVNC_HOST"))
                'Exporter les fichiers g�n�r�s
                oFTPvinicom = New clsFTPVinicom(Param.getConstante("CST_FTPVNC_HOST"),
                                                Param.getConstante("CST_FTPVNC_USER"),
                                                Param.getConstante("CST_FTPVNC_PASSWORD"),
                                                Param.getConstante("CST_FTPVNC_REMOTEDIR")
                                                )
                'If oFTPvinicom.connect() Then
                '                If True Then
                '               If (Not oFTPvinicom.IsLockFrom()) Then
                nSousCommandesExportees = oFTPvinicom.uploadFromDir(strFolder)
                If Not String.IsNullOrEmpty(oFTPvinicom.ErrorDescription) Then
                    DisplayStatus(oFTPvinicom.ErrorDescription())
                Else
                    DisplayStatus("Fin de transfert des fichiers ")
                    DisplayStatus("Nombre de fichiers export�s : " & (nSousCommandesExportees - 1) & "+1")
                    bReturn = True
                End If

                'Globals.WaitnSeconds(10)
                System.Threading.Thread.Sleep(10 * 1000)

                'oFTPvinicom.disconnect()
            End If
            If bReturn Then
                DisplayStatus("Validation des sous commandes (changement d'�tat)")
                For Each objSCMD In m_colCommandes
                    objSCMD.save()
                Next
                DisplayStatus("Validation termin�e")
            End If

            cbExporter.Enabled = False

        Catch ex As Exception
            MsgBox("Erreur" + ex.Message)

        End Try

    End Function 'exporter

    Private Sub ActiverImportBAF()
        Dim odlg As New dlgWebBrowser(False)
        Dim uri_integ As Uri = New Uri(Param.getConstante("CST_FTPVNC_URL"))
        odlg.WebBrowser1.Navigate(uri_integ)
        odlg.ShowDialog()
    End Sub
    Private Shadows Sub DisplayStatus(ByVal strMessage As String)

        Dim oStatus As clsExportstatus
        oStatus = New clsExportstatus()
        oStatus.statusDate = Now()
        oStatus.statusMessage = strMessage
        BackgroundWorker1.ReportProgress(0, oStatus)
        Log(strMessage)
    End Sub
    Private Sub Log(ByVal strMessage As String)
        Trace.WriteLine(Now() + " " + strMessage)
    End Sub
#End Region
#Region "Gestion des Evenements"
    Private Sub frmGestionSCMD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub

    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficher.Click
        If setListeScmd() Then
            afficheListeScmd()
        End If
        If (m_colCommandes.Count > 0) Then
            dgvSCmd.Enabled = True
            cbExporter.Enabled = True
        End If

    End Sub





#End Region

    Protected Overrides Sub AddHandlerValidated(ByVal ocol As System.Windows.Forms.Control.ControlCollection)
        'Dans cette fen�tre seul le bouton G�nerer d�clenche L'evenement Updated
        'AddHandler cbAppliquer.Click, AddressOf ControlUpdated
        'AddHandler cbGenerer.Click, AddressOf ControlUpdated
    End Sub

    Private Sub cbExporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbExporter.Click
        ProgressBar1.Maximum = m_colCommandes.Count
        ProgressBar1.Value = 0
        m_bsrcStatus.Clear()
        Me.Cursor = Cursors.WaitCursor
        cbExporter.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call exporter()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.ProgressPercentage = 0 Then
            Dim oStatus As clsExportstatus
            oStatus = e.UserState
            m_bsrcStatus.Add(oStatus)
        Else
            ProgressBar1.Increment(1)
        End If
        '        dgvStatus.Refresh()
        '       If dgvStatus.Rows.Count > dgvStatus.DisplayedRowCount(True) Then
        '      dgvStatus.FirstDisplayedScrollingRowIndex = dgvStatus.Rows.Count - dgvStatus.DisplayedRowCount(True) + 1
        '     End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ActiverImportBAF()
        Me.Cursor = Cursors.Default
        cbExporter.Enabled = True
        m_bsrcSCMD.Clear()
        m_colCommandes.Clear()
    End Sub

    Private Sub cbRechercher_Click(sender As Object, e As EventArgs) Handles cbRechercher.Click
        rechercheFournisseur()
    End Sub
    Private Sub rechercheFournisseur()
        Dim objTiers As Tiers

        objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.FOURNISSEUR, tbCodeFournisseur)

        If Not objTiers Is Nothing Then
            tbCodeFournisseur.Text = objTiers.code
        End If
    End Sub 'rechercheClient

End Class
