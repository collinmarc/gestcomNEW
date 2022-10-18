<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportcommandeClientWoo
    Inherits vini_app.FrmVinicom

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRepLocal = New System.Windows.Forms.TextBox()
        Me.tbRepDistant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbFTPPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFTPUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFTPHostName = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateImportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomFichierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCdeWooCommerceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecmdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PImportDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CmdCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.m_bsrcImport = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtDateDeb = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtDateFin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckTous = New System.Windows.Forms.CheckBox()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.btnPurger = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.btnImport)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbRepLocal)
        Me.GroupBox1.Controls.Add(Me.tbRepDistant)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbFTPPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbFTPUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbFTPHostName)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 153)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(573, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 94)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(734, 23)
        Me.ProgressBar1.TabIndex = 24
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(654, 124)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Répertoire local :"
        '
        'tbRepLocal
        '
        Me.tbRepLocal.Location = New System.Drawing.Point(347, 42)
        Me.tbRepLocal.Name = "tbRepLocal"
        Me.tbRepLocal.Size = New System.Drawing.Size(219, 20)
        Me.tbRepLocal.TabIndex = 8
        Me.tbRepLocal.Text = Global.vini_app.My.MySettings.Default.wooFTPRepLocal
        '
        'tbRepDistant
        '
        Me.tbRepDistant.Location = New System.Drawing.Point(347, 16)
        Me.tbRepDistant.Name = "tbRepDistant"
        Me.tbRepDistant.Size = New System.Drawing.Size(219, 20)
        Me.tbRepDistant.TabIndex = 7
        Me.tbRepDistant.Text = Global.vini_app.My.MySettings.Default.wooFTPRepDistant
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Répertoire distant :"
        '
        'tbFTPPassword
        '
        Me.tbFTPPassword.Location = New System.Drawing.Point(85, 68)
        Me.tbFTPPassword.Name = "tbFTPPassword"
        Me.tbFTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbFTPPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbFTPPassword.TabIndex = 5
        Me.tbFTPPassword.Text = Global.vini_app.My.MySettings.Default.wooFTPPwd
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FTP Password :"
        '
        'tbFTPUser
        '
        Me.tbFTPUser.Location = New System.Drawing.Point(85, 42)
        Me.tbFTPUser.Name = "tbFTPUser"
        Me.tbFTPUser.Size = New System.Drawing.Size(152, 20)
        Me.tbFTPUser.TabIndex = 3
        Me.tbFTPUser.Text = Global.vini_app.My.MySettings.Default.wooFTPUser
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FTP User :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FTP Serveur :"
        '
        'tbFTPHostName
        '
        Me.tbFTPHostName.Location = New System.Drawing.Point(85, 16)
        Me.tbFTPHostName.Name = "tbFTPHostName"
        Me.tbFTPHostName.Size = New System.Drawing.Size(152, 20)
        Me.tbFTPHostName.TabIndex = 0
        Me.tbFTPHostName.Text = Global.vini_app.My.MySettings.Default.wooFTPHost
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateImportDataGridViewTextBoxColumn, Me.NomFichierDataGridViewTextBoxColumn, Me.NumCdeWooCommerceDataGridViewTextBoxColumn, Me.DatecmdDataGridViewTextBoxColumn, Me.PImportDataGridViewCheckBoxColumn, Me.CmdCodeDataGridViewTextBoxColumn, Me.MotifDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.m_bsrcLog
        Me.DataGridView1.Location = New System.Drawing.Point(11, 190)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(735, 302)
        Me.DataGridView1.TabIndex = 25
        '
        'DateImportDataGridViewTextBoxColumn
        '
        Me.DateImportDataGridViewTextBoxColumn.DataPropertyName = "DateImport"
        Me.DateImportDataGridViewTextBoxColumn.HeaderText = "DateImport"
        Me.DateImportDataGridViewTextBoxColumn.Name = "DateImportDataGridViewTextBoxColumn"
        '
        'NomFichierDataGridViewTextBoxColumn
        '
        Me.NomFichierDataGridViewTextBoxColumn.DataPropertyName = "NomFichier"
        Me.NomFichierDataGridViewTextBoxColumn.HeaderText = "NomFichier"
        Me.NomFichierDataGridViewTextBoxColumn.Name = "NomFichierDataGridViewTextBoxColumn"
        '
        'NumCdeWooCommerceDataGridViewTextBoxColumn
        '
        Me.NumCdeWooCommerceDataGridViewTextBoxColumn.DataPropertyName = "NumCdeWooCommerce"
        Me.NumCdeWooCommerceDataGridViewTextBoxColumn.HeaderText = "NumCdeWooCommerce"
        Me.NumCdeWooCommerceDataGridViewTextBoxColumn.Name = "NumCdeWooCommerceDataGridViewTextBoxColumn"
        '
        'DatecmdDataGridViewTextBoxColumn
        '
        Me.DatecmdDataGridViewTextBoxColumn.DataPropertyName = "Datecmd"
        Me.DatecmdDataGridViewTextBoxColumn.HeaderText = "Datecmd"
        Me.DatecmdDataGridViewTextBoxColumn.Name = "DatecmdDataGridViewTextBoxColumn"
        '
        'PImportDataGridViewCheckBoxColumn
        '
        Me.PImportDataGridViewCheckBoxColumn.DataPropertyName = "PImport"
        Me.PImportDataGridViewCheckBoxColumn.HeaderText = "PImport"
        Me.PImportDataGridViewCheckBoxColumn.Name = "PImportDataGridViewCheckBoxColumn"
        '
        'CmdCodeDataGridViewTextBoxColumn
        '
        Me.CmdCodeDataGridViewTextBoxColumn.DataPropertyName = "CmdCode"
        Me.CmdCodeDataGridViewTextBoxColumn.HeaderText = "CmdCode"
        Me.CmdCodeDataGridViewTextBoxColumn.Name = "CmdCodeDataGridViewTextBoxColumn"
        '
        'MotifDataGridViewTextBoxColumn
        '
        Me.MotifDataGridViewTextBoxColumn.DataPropertyName = "Motif"
        Me.MotifDataGridViewTextBoxColumn.HeaderText = "Motif"
        Me.MotifDataGridViewTextBoxColumn.Name = "MotifDataGridViewTextBoxColumn"
        '
        'm_bsrcLog
        '
        Me.m_bsrcLog.AllowNew = False
        Me.m_bsrcLog.DataSource = GetType(vini_DB.ItemLogImportWoo)
        Me.m_bsrcLog.Sort = "dateImport DESC"
        '
        'dtDateDeb
        '
        Me.dtDateDeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateDeb.Location = New System.Drawing.Point(96, 161)
        Me.dtDateDeb.Name = "dtDateDeb"
        Me.dtDateDeb.Size = New System.Drawing.Size(100, 20)
        Me.dtDateDeb.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Date de début"
        '
        'dtDateFin
        '
        Me.dtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateFin.Location = New System.Drawing.Point(267, 161)
        Me.dtDateFin.Name = "dtDateFin"
        Me.dtDateFin.Size = New System.Drawing.Size(100, 20)
        Me.dtDateFin.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Date de fin"
        '
        'ckTous
        '
        Me.ckTous.AutoSize = True
        Me.ckTous.Location = New System.Drawing.Point(382, 164)
        Me.ckTous.Name = "ckTous"
        Me.ckTous.Size = New System.Drawing.Size(50, 17)
        Me.ckTous.TabIndex = 30
        Me.ckTous.Text = "Tous"
        Me.ckTous.UseVisualStyleBackColor = True
        '
        'btnAfficher
        '
        Me.btnAfficher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAfficher.Location = New System.Drawing.Point(665, 161)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(75, 23)
        Me.btnAfficher.TabIndex = 31
        Me.btnAfficher.Text = "Afficher"
        Me.btnAfficher.UseVisualStyleBackColor = True
        '
        'btnPurger
        '
        Me.btnPurger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPurger.Location = New System.Drawing.Point(584, 160)
        Me.btnPurger.Name = "btnPurger"
        Me.btnPurger.Size = New System.Drawing.Size(75, 23)
        Me.btnPurger.TabIndex = 32
        Me.btnPurger.Text = "Purger"
        Me.btnPurger.UseVisualStyleBackColor = True
        '
        'frmImportcommandeClientWoo
        '
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.btnPurger)
        Me.Controls.Add(Me.btnAfficher)
        Me.Controls.Add(Me.ckTous)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtDateFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtDateDeb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmImportcommandeClientWoo"
        Me.Text = "Import des commandes clients créées le site internet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbRepLocal As TextBox
    Friend WithEvents tbRepDistant As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbFTPPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFTPUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFTPHostName As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents m_bsrcLog As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomFichierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumCdeWooCommerceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecmdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PImportDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CmdCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents m_bsrcImport As BindingSource
    Friend WithEvents dtDateDeb As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtDateFin As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ckTous As CheckBox
    Friend WithEvents btnAfficher As Button
    Friend WithEvents btnPurger As Button
End Class
