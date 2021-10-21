<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConstantes
    Inherits vini_app.FrmVinicom

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CST_SOC_NOMSOCLabel = New System.Windows.Forms.Label()
        Me.CST_SOC_ADRESSE_RUE1Label = New System.Windows.Forms.Label()
        Me.CST_SOC_TELLabel = New System.Windows.Forms.Label()
        Me.CST_SOC_FAXLabel = New System.Windows.Forms.Label()
        Me.CST_SOC_PORTLabel = New System.Windows.Forms.Label()
        Me.CST_SOC_EMAILLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_NOMSOCLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_ADRESSE_RUE1Label = New System.Windows.Forms.Label()
        Me.CST_SOC2_TELLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_FAXLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_PORTLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_EMAILLabel = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_NOMLabel = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_RUE1Label = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_TELLabel = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_FAXLabel = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_PORTLabel = New System.Windows.Forms.Label()
        Me.CST_PLTFRM_EMAILLabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_CMD_CLTLabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_SCMDLabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_BALabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_FACTCOMLabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_FACT_TRPLabel = New System.Windows.Forms.Label()
        Me.CST_DERN_NUM_FACT_COLISAGELabel = New System.Windows.Forms.Label()
        Me.CST_SOC_TVAINTRALabel = New System.Windows.Forms.Label()
        Me.CST_SOC_RCSLabel = New System.Windows.Forms.Label()
        Me.CST_SOC_LICENCELabel = New System.Windows.Forms.Label()
        Me.CST_SOC1_CMPT_TVALabel = New System.Windows.Forms.Label()
        Me.CST_SOC1_CMPT_PRODLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_TVAINTRALabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_RCSLabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_LICENCELabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_CMPT_TVALabel = New System.Windows.Forms.Label()
        Me.CST_SOC2_CMPT_PRODLabel = New System.Windows.Forms.Label()
        Me.CST_VERSION_BDLabel = New System.Windows.Forms.Label()
        Me.CST_TX_COMMISSIONLabel = New System.Windows.Forms.Label()
        Me.CST_TAXES_TRPLabel = New System.Windows.Forms.Label()
        Me.CST_TRP_IDMODEREGLEMENTLabel = New System.Windows.Forms.Label()
        Me.CST_TRP_TXGAZOLELabel = New System.Windows.Forms.Label()
        Me.CST_PU_PALL_PREPLabel = New System.Windows.Forms.Label()
        Me.CST_PU_PALL_NONPREPLabel = New System.Windows.Forms.Label()
        Me.CST_COL_IDMODEREGLEMENTLabel = New System.Windows.Forms.Label()
        Me.CST_FACT_COL_TAXESLabel = New System.Windows.Forms.Label()
        Me.CST_FACT_COL_PU_COLISLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabVinicom = New System.Windows.Forms.TabPage()
        Me.tbCompteBanque = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVinicom1 = New vini_DB.dsVinicom()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CST_SOC1_CMPT_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC1_CMPT_TVATextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_LICENCETextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_RCSTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_TVAINTRATextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_PORTTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_FAXTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_TELTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_ADRESSE_VILLETextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_ADRESSE_CPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_ADRESSE_RUE2TextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_ADRESSE_RUE1TextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC_NOMSOCTextBox = New System.Windows.Forms.TextBox()
        Me.TabVinidis = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbSOC2COMPTPROD2 = New System.Windows.Forms.TextBox()
        Me.tbCodeBanque2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CST_SOC2_CMPT_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_CMPT_TVATextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_LICENCETextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_RCSTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_TVAINTRATextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_PORTTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_FAXTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_TELTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_ADRESSE_VILLETextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_ADRESSE_CPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_ADRESSE_RUE2TextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_ADRESSE_RUE1TextBox = New System.Windows.Forms.TextBox()
        Me.CST_SOC2_NOMSOCTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CST_PLTFRM_EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_PORTTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_FAXTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_TELTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_VILLETextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_CPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_RUE2TextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_RUE1TextBox = New System.Windows.Forms.TextBox()
        Me.CST_PLTFRM_NOMTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CST_PATH_FACTTRPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PATH_FACTCOMTextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_FACT_COLISAGETextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_FACT_TRPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_FACTCOMTextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_BATextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_SCMDTextBox = New System.Windows.Forms.TextBox()
        Me.CST_DERN_NUM_CMD_CLTTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CST_FACT_COL_PU_COLISTextBox = New System.Windows.Forms.TextBox()
        Me.CST_FACT_COL_TAXESTextBox = New System.Windows.Forms.TextBox()
        Me.CST_COL_IDMODEREGLEMENTTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PU_PALL_NONPREPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_PU_PALL_PREPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_TRP_TXGAZOLETextBox = New System.Windows.Forms.TextBox()
        Me.CST_TRP_IDMODEREGLEMENTTextBox = New System.Windows.Forms.TextBox()
        Me.CST_TAXES_TRPTextBox = New System.Windows.Forms.TextBox()
        Me.CST_TX_COMMISSIONTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnTestFTPvnc = New System.Windows.Forms.Button()
        Me.tbFTPVNCUrl2 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tbFTPVNCRemoteDir2 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tbFTPVNCURL = New System.Windows.Forms.TextBox()
        Me.tbFTPVNCRemoteDir = New System.Windows.Forms.TextBox()
        Me.tbFTPVNCPassword = New System.Windows.Forms.TextBox()
        Me.tbFTPVNCUser = New System.Windows.Forms.TextBox()
        Me.tbFTPVNCHost = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbftpVND_URL = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnTestFTPvnd = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbftnvnd_remoteDir = New System.Windows.Forms.TextBox()
        Me.tbftpvnd_password = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbftpvnd_User = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tbftpvnd_host = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbFTPEDIRepLocal = New System.Windows.Forms.TextBox()
        Me.cbTestFTPEDI = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbFTPEDIRep = New System.Windows.Forms.TextBox()
        Me.tbFTPEDIPwd = New System.Windows.Forms.TextBox()
        Me.tbFTPEDIUser = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbFTPEDIPort = New System.Windows.Forms.TextBox()
        Me.tbFTPEDISRV = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbEDI_Destinataire = New System.Windows.Forms.TabPage()
        Me.ckWEBEDI_SSL = New System.Windows.Forms.CheckBox()
        Me.tbWEBEDI_Destinataire = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbWEBEDI_SMTPPWD = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbWEBEDI_SMTPuser = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbWEBEDI_TEMP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbTestWebEdi = New System.Windows.Forms.Button()
        Me.tbWEBEDI_SMTPFROM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbWEBEDI_SMTPPORT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWEBEDI_SMTPHOST = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ckCheck = New System.Windows.Forms.CheckBox()
        Me.tbImapNSec = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbImapFolder = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbImport = New System.Windows.Forms.Button()
        Me.tbImapPwd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ckImapSSL = New System.Windows.Forms.CheckBox()
        Me.tbImapUser = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbImapPort = New System.Windows.Forms.TextBox()
        Me.tbImapHost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.FTP_LOCKTOFILENAMELabel = New System.Windows.Forms.Label()
        Me.FTP_LOCKTOFILENAMETextBox = New System.Windows.Forms.TextBox()
        Me.FTP_LOCKFROMFILENAMELabel = New System.Windows.Forms.Label()
        Me.FTP_LOCKFROMFILENAMETextBox = New System.Windows.Forms.TextBox()
        Me.FTP_REMOTEDIRLabel = New System.Windows.Forms.Label()
        Me.FTP_REMOTEDIRTextBox = New System.Windows.Forms.TextBox()
        Me.FTP_PASSWORDLabel = New System.Windows.Forms.Label()
        Me.FTP_PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.FTP_USERNAMELabel = New System.Windows.Forms.Label()
        Me.FTP_USERNAMETextBox = New System.Windows.Forms.TextBox()
        Me.FTP_HOSTNAMELabel = New System.Windows.Forms.Label()
        Me.FTP_HOSTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.btnCorpsFactCom = New System.Windows.Forms.Button()
        Me.btnCorpsFactTrp = New System.Windows.Forms.Button()
        Me.btnCorpsFactColisage = New System.Windows.Forms.Button()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.CST_VERSION_BDTextBox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpdateMAj = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.tabVinicom.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVinicom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVinidis.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.tbEDI_Destinataire.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'CST_SOC_NOMSOCLabel
        '
        Me.CST_SOC_NOMSOCLabel.AutoSize = True
        Me.CST_SOC_NOMSOCLabel.Location = New System.Drawing.Point(10, 24)
        Me.CST_SOC_NOMSOCLabel.Name = "CST_SOC_NOMSOCLabel"
        Me.CST_SOC_NOMSOCLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_SOC_NOMSOCLabel.TabIndex = 0
        Me.CST_SOC_NOMSOCLabel.Text = "Nom : "
        '
        'CST_SOC_ADRESSE_RUE1Label
        '
        Me.CST_SOC_ADRESSE_RUE1Label.AutoSize = True
        Me.CST_SOC_ADRESSE_RUE1Label.Location = New System.Drawing.Point(10, 47)
        Me.CST_SOC_ADRESSE_RUE1Label.Name = "CST_SOC_ADRESSE_RUE1Label"
        Me.CST_SOC_ADRESSE_RUE1Label.Size = New System.Drawing.Size(54, 13)
        Me.CST_SOC_ADRESSE_RUE1Label.TabIndex = 2
        Me.CST_SOC_ADRESSE_RUE1Label.Text = "Adresse : "
        '
        'CST_SOC_TELLabel
        '
        Me.CST_SOC_TELLabel.AutoSize = True
        Me.CST_SOC_TELLabel.Location = New System.Drawing.Point(10, 128)
        Me.CST_SOC_TELLabel.Name = "CST_SOC_TELLabel"
        Me.CST_SOC_TELLabel.Size = New System.Drawing.Size(28, 13)
        Me.CST_SOC_TELLabel.TabIndex = 10
        Me.CST_SOC_TELLabel.Text = "Tel :"
        '
        'CST_SOC_FAXLabel
        '
        Me.CST_SOC_FAXLabel.AutoSize = True
        Me.CST_SOC_FAXLabel.Location = New System.Drawing.Point(389, 131)
        Me.CST_SOC_FAXLabel.Name = "CST_SOC_FAXLabel"
        Me.CST_SOC_FAXLabel.Size = New System.Drawing.Size(30, 13)
        Me.CST_SOC_FAXLabel.TabIndex = 12
        Me.CST_SOC_FAXLabel.Text = "Fax :"
        '
        'CST_SOC_PORTLabel
        '
        Me.CST_SOC_PORTLabel.AutoSize = True
        Me.CST_SOC_PORTLabel.Location = New System.Drawing.Point(10, 154)
        Me.CST_SOC_PORTLabel.Name = "CST_SOC_PORTLabel"
        Me.CST_SOC_PORTLabel.Size = New System.Drawing.Size(52, 13)
        Me.CST_SOC_PORTLabel.TabIndex = 14
        Me.CST_SOC_PORTLabel.Text = "Portable :"
        '
        'CST_SOC_EMAILLabel
        '
        Me.CST_SOC_EMAILLabel.AutoSize = True
        Me.CST_SOC_EMAILLabel.Location = New System.Drawing.Point(389, 158)
        Me.CST_SOC_EMAILLabel.Name = "CST_SOC_EMAILLabel"
        Me.CST_SOC_EMAILLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_SOC_EMAILLabel.TabIndex = 16
        Me.CST_SOC_EMAILLabel.Text = "Email :"
        '
        'CST_SOC2_NOMSOCLabel
        '
        Me.CST_SOC2_NOMSOCLabel.AutoSize = True
        Me.CST_SOC2_NOMSOCLabel.Location = New System.Drawing.Point(8, 9)
        Me.CST_SOC2_NOMSOCLabel.Name = "CST_SOC2_NOMSOCLabel"
        Me.CST_SOC2_NOMSOCLabel.Size = New System.Drawing.Size(68, 13)
        Me.CST_SOC2_NOMSOCLabel.TabIndex = 0
        Me.CST_SOC2_NOMSOCLabel.Text = "Nom Société"
        '
        'CST_SOC2_ADRESSE_RUE1Label
        '
        Me.CST_SOC2_ADRESSE_RUE1Label.AutoSize = True
        Me.CST_SOC2_ADRESSE_RUE1Label.Location = New System.Drawing.Point(8, 32)
        Me.CST_SOC2_ADRESSE_RUE1Label.Name = "CST_SOC2_ADRESSE_RUE1Label"
        Me.CST_SOC2_ADRESSE_RUE1Label.Size = New System.Drawing.Size(54, 13)
        Me.CST_SOC2_ADRESSE_RUE1Label.TabIndex = 2
        Me.CST_SOC2_ADRESSE_RUE1Label.Text = "Adresse : "
        '
        'CST_SOC2_TELLabel
        '
        Me.CST_SOC2_TELLabel.AutoSize = True
        Me.CST_SOC2_TELLabel.Location = New System.Drawing.Point(8, 113)
        Me.CST_SOC2_TELLabel.Name = "CST_SOC2_TELLabel"
        Me.CST_SOC2_TELLabel.Size = New System.Drawing.Size(28, 13)
        Me.CST_SOC2_TELLabel.TabIndex = 9
        Me.CST_SOC2_TELLabel.Text = "Tel :"
        '
        'CST_SOC2_FAXLabel
        '
        Me.CST_SOC2_FAXLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_FAXLabel.AutoSize = True
        Me.CST_SOC2_FAXLabel.Location = New System.Drawing.Point(505, 113)
        Me.CST_SOC2_FAXLabel.Name = "CST_SOC2_FAXLabel"
        Me.CST_SOC2_FAXLabel.Size = New System.Drawing.Size(33, 13)
        Me.CST_SOC2_FAXLabel.TabIndex = 10
        Me.CST_SOC2_FAXLabel.Text = "Fax : "
        '
        'CST_SOC2_PORTLabel
        '
        Me.CST_SOC2_PORTLabel.AutoSize = True
        Me.CST_SOC2_PORTLabel.Location = New System.Drawing.Point(8, 139)
        Me.CST_SOC2_PORTLabel.Name = "CST_SOC2_PORTLabel"
        Me.CST_SOC2_PORTLabel.Size = New System.Drawing.Size(52, 13)
        Me.CST_SOC2_PORTLabel.TabIndex = 11
        Me.CST_SOC2_PORTLabel.Text = "Portable :"
        '
        'CST_SOC2_EMAILLabel
        '
        Me.CST_SOC2_EMAILLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_EMAILLabel.AutoSize = True
        Me.CST_SOC2_EMAILLabel.Location = New System.Drawing.Point(505, 139)
        Me.CST_SOC2_EMAILLabel.Name = "CST_SOC2_EMAILLabel"
        Me.CST_SOC2_EMAILLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_SOC2_EMAILLabel.TabIndex = 13
        Me.CST_SOC2_EMAILLabel.Text = "Email :"
        '
        'CST_PLTFRM_NOMLabel
        '
        Me.CST_PLTFRM_NOMLabel.AutoSize = True
        Me.CST_PLTFRM_NOMLabel.Location = New System.Drawing.Point(8, 3)
        Me.CST_PLTFRM_NOMLabel.Name = "CST_PLTFRM_NOMLabel"
        Me.CST_PLTFRM_NOMLabel.Size = New System.Drawing.Size(35, 13)
        Me.CST_PLTFRM_NOMLabel.TabIndex = 0
        Me.CST_PLTFRM_NOMLabel.Text = "Nom :"
        '
        'CST_PLTFRM_RUE1Label
        '
        Me.CST_PLTFRM_RUE1Label.AutoSize = True
        Me.CST_PLTFRM_RUE1Label.Location = New System.Drawing.Point(8, 29)
        Me.CST_PLTFRM_RUE1Label.Name = "CST_PLTFRM_RUE1Label"
        Me.CST_PLTFRM_RUE1Label.Size = New System.Drawing.Size(54, 13)
        Me.CST_PLTFRM_RUE1Label.TabIndex = 2
        Me.CST_PLTFRM_RUE1Label.Text = "Adresse : "
        '
        'CST_PLTFRM_TELLabel
        '
        Me.CST_PLTFRM_TELLabel.AutoSize = True
        Me.CST_PLTFRM_TELLabel.Location = New System.Drawing.Point(8, 124)
        Me.CST_PLTFRM_TELLabel.Name = "CST_PLTFRM_TELLabel"
        Me.CST_PLTFRM_TELLabel.Size = New System.Drawing.Size(31, 13)
        Me.CST_PLTFRM_TELLabel.TabIndex = 10
        Me.CST_PLTFRM_TELLabel.Text = "Tel : "
        '
        'CST_PLTFRM_FAXLabel
        '
        Me.CST_PLTFRM_FAXLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_FAXLabel.AutoSize = True
        Me.CST_PLTFRM_FAXLabel.Location = New System.Drawing.Point(482, 124)
        Me.CST_PLTFRM_FAXLabel.Name = "CST_PLTFRM_FAXLabel"
        Me.CST_PLTFRM_FAXLabel.Size = New System.Drawing.Size(33, 13)
        Me.CST_PLTFRM_FAXLabel.TabIndex = 12
        Me.CST_PLTFRM_FAXLabel.Text = "Fax : "
        '
        'CST_PLTFRM_PORTLabel
        '
        Me.CST_PLTFRM_PORTLabel.AutoSize = True
        Me.CST_PLTFRM_PORTLabel.Location = New System.Drawing.Point(8, 150)
        Me.CST_PLTFRM_PORTLabel.Name = "CST_PLTFRM_PORTLabel"
        Me.CST_PLTFRM_PORTLabel.Size = New System.Drawing.Size(55, 13)
        Me.CST_PLTFRM_PORTLabel.TabIndex = 14
        Me.CST_PLTFRM_PORTLabel.Text = "Portable : "
        '
        'CST_PLTFRM_EMAILLabel
        '
        Me.CST_PLTFRM_EMAILLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_EMAILLabel.AutoSize = True
        Me.CST_PLTFRM_EMAILLabel.Location = New System.Drawing.Point(482, 150)
        Me.CST_PLTFRM_EMAILLabel.Name = "CST_PLTFRM_EMAILLabel"
        Me.CST_PLTFRM_EMAILLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_PLTFRM_EMAILLabel.TabIndex = 16
        Me.CST_PLTFRM_EMAILLabel.Text = "Email :"
        '
        'CST_DERN_NUM_CMD_CLTLabel
        '
        Me.CST_DERN_NUM_CMD_CLTLabel.AutoSize = True
        Me.CST_DERN_NUM_CMD_CLTLabel.Location = New System.Drawing.Point(6, 12)
        Me.CST_DERN_NUM_CMD_CLTLabel.Name = "CST_DERN_NUM_CMD_CLTLabel"
        Me.CST_DERN_NUM_CMD_CLTLabel.Size = New System.Drawing.Size(98, 13)
        Me.CST_DERN_NUM_CMD_CLTLabel.TabIndex = 0
        Me.CST_DERN_NUM_CMD_CLTLabel.Text = "Commande Client : "
        '
        'CST_DERN_NUM_SCMDLabel
        '
        Me.CST_DERN_NUM_SCMDLabel.AutoSize = True
        Me.CST_DERN_NUM_SCMDLabel.Location = New System.Drawing.Point(6, 35)
        Me.CST_DERN_NUM_SCMDLabel.Name = "CST_DERN_NUM_SCMDLabel"
        Me.CST_DERN_NUM_SCMDLabel.Size = New System.Drawing.Size(101, 13)
        Me.CST_DERN_NUM_SCMDLabel.TabIndex = 2
        Me.CST_DERN_NUM_SCMDLabel.Text = "Sous-Commandes : "
        '
        'CST_DERN_NUM_BALabel
        '
        Me.CST_DERN_NUM_BALabel.AutoSize = True
        Me.CST_DERN_NUM_BALabel.Location = New System.Drawing.Point(6, 61)
        Me.CST_DERN_NUM_BALabel.Name = "CST_DERN_NUM_BALabel"
        Me.CST_DERN_NUM_BALabel.Size = New System.Drawing.Size(128, 13)
        Me.CST_DERN_NUM_BALabel.TabIndex = 4
        Me.CST_DERN_NUM_BALabel.Text = "Bon Approvisionnement : "
        '
        'CST_DERN_NUM_FACTCOMLabel
        '
        Me.CST_DERN_NUM_FACTCOMLabel.AutoSize = True
        Me.CST_DERN_NUM_FACTCOMLabel.Location = New System.Drawing.Point(6, 87)
        Me.CST_DERN_NUM_FACTCOMLabel.Name = "CST_DERN_NUM_FACTCOMLabel"
        Me.CST_DERN_NUM_FACTCOMLabel.Size = New System.Drawing.Size(116, 13)
        Me.CST_DERN_NUM_FACTCOMLabel.TabIndex = 6
        Me.CST_DERN_NUM_FACTCOMLabel.Text = "Facture de commision :"
        '
        'CST_DERN_NUM_FACT_TRPLabel
        '
        Me.CST_DERN_NUM_FACT_TRPLabel.AutoSize = True
        Me.CST_DERN_NUM_FACT_TRPLabel.Location = New System.Drawing.Point(6, 113)
        Me.CST_DERN_NUM_FACT_TRPLabel.Name = "CST_DERN_NUM_FACT_TRPLabel"
        Me.CST_DERN_NUM_FACT_TRPLabel.Size = New System.Drawing.Size(111, 13)
        Me.CST_DERN_NUM_FACT_TRPLabel.TabIndex = 8
        Me.CST_DERN_NUM_FACT_TRPLabel.Text = "Facture de transport : "
        '
        'CST_DERN_NUM_FACT_COLISAGELabel
        '
        Me.CST_DERN_NUM_FACT_COLISAGELabel.AutoSize = True
        Me.CST_DERN_NUM_FACT_COLISAGELabel.Location = New System.Drawing.Point(6, 139)
        Me.CST_DERN_NUM_FACT_COLISAGELabel.Name = "CST_DERN_NUM_FACT_COLISAGELabel"
        Me.CST_DERN_NUM_FACT_COLISAGELabel.Size = New System.Drawing.Size(109, 13)
        Me.CST_DERN_NUM_FACT_COLISAGELabel.TabIndex = 10
        Me.CST_DERN_NUM_FACT_COLISAGELabel.Text = "Facture de colisage : "
        '
        'CST_SOC_TVAINTRALabel
        '
        Me.CST_SOC_TVAINTRALabel.AutoSize = True
        Me.CST_SOC_TVAINTRALabel.Location = New System.Drawing.Point(10, 207)
        Me.CST_SOC_TVAINTRALabel.Name = "CST_SOC_TVAINTRALabel"
        Me.CST_SOC_TVAINTRALabel.Size = New System.Drawing.Size(73, 13)
        Me.CST_SOC_TVAINTRALabel.TabIndex = 17
        Me.CST_SOC_TVAINTRALabel.Text = "TVA INTRA : "
        '
        'CST_SOC_RCSLabel
        '
        Me.CST_SOC_RCSLabel.AutoSize = True
        Me.CST_SOC_RCSLabel.Location = New System.Drawing.Point(10, 229)
        Me.CST_SOC_RCSLabel.Name = "CST_SOC_RCSLabel"
        Me.CST_SOC_RCSLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_SOC_RCSLabel.TabIndex = 18
        Me.CST_SOC_RCSLabel.Text = "RCS : "
        '
        'CST_SOC_LICENCELabel
        '
        Me.CST_SOC_LICENCELabel.AutoSize = True
        Me.CST_SOC_LICENCELabel.Location = New System.Drawing.Point(10, 258)
        Me.CST_SOC_LICENCELabel.Name = "CST_SOC_LICENCELabel"
        Me.CST_SOC_LICENCELabel.Size = New System.Drawing.Size(54, 13)
        Me.CST_SOC_LICENCELabel.TabIndex = 19
        Me.CST_SOC_LICENCELabel.Text = "Licence : "
        '
        'CST_SOC1_CMPT_TVALabel
        '
        Me.CST_SOC1_CMPT_TVALabel.AutoSize = True
        Me.CST_SOC1_CMPT_TVALabel.Location = New System.Drawing.Point(10, 305)
        Me.CST_SOC1_CMPT_TVALabel.Name = "CST_SOC1_CMPT_TVALabel"
        Me.CST_SOC1_CMPT_TVALabel.Size = New System.Drawing.Size(128, 13)
        Me.CST_SOC1_CMPT_TVALabel.TabIndex = 21
        Me.CST_SOC1_CMPT_TVALabel.Text = "Compte TVA sur ventes : "
        '
        'CST_SOC1_CMPT_PRODLabel
        '
        Me.CST_SOC1_CMPT_PRODLabel.AutoSize = True
        Me.CST_SOC1_CMPT_PRODLabel.Location = New System.Drawing.Point(10, 331)
        Me.CST_SOC1_CMPT_PRODLabel.Name = "CST_SOC1_CMPT_PRODLabel"
        Me.CST_SOC1_CMPT_PRODLabel.Size = New System.Drawing.Size(88, 13)
        Me.CST_SOC1_CMPT_PRODLabel.TabIndex = 23
        Me.CST_SOC1_CMPT_PRODLabel.Text = "Compte Produit : "
        '
        'CST_SOC2_TVAINTRALabel
        '
        Me.CST_SOC2_TVAINTRALabel.AutoSize = True
        Me.CST_SOC2_TVAINTRALabel.Location = New System.Drawing.Point(6, 210)
        Me.CST_SOC2_TVAINTRALabel.Name = "CST_SOC2_TVAINTRALabel"
        Me.CST_SOC2_TVAINTRALabel.Size = New System.Drawing.Size(73, 13)
        Me.CST_SOC2_TVAINTRALabel.TabIndex = 15
        Me.CST_SOC2_TVAINTRALabel.Text = "TVA INTRA : "
        '
        'CST_SOC2_RCSLabel
        '
        Me.CST_SOC2_RCSLabel.AutoSize = True
        Me.CST_SOC2_RCSLabel.Location = New System.Drawing.Point(8, 238)
        Me.CST_SOC2_RCSLabel.Name = "CST_SOC2_RCSLabel"
        Me.CST_SOC2_RCSLabel.Size = New System.Drawing.Size(38, 13)
        Me.CST_SOC2_RCSLabel.TabIndex = 17
        Me.CST_SOC2_RCSLabel.Text = "RCS : "
        '
        'CST_SOC2_LICENCELabel
        '
        Me.CST_SOC2_LICENCELabel.AutoSize = True
        Me.CST_SOC2_LICENCELabel.Location = New System.Drawing.Point(8, 264)
        Me.CST_SOC2_LICENCELabel.Name = "CST_SOC2_LICENCELabel"
        Me.CST_SOC2_LICENCELabel.Size = New System.Drawing.Size(54, 13)
        Me.CST_SOC2_LICENCELabel.TabIndex = 19
        Me.CST_SOC2_LICENCELabel.Text = "Licence : "
        '
        'CST_SOC2_CMPT_TVALabel
        '
        Me.CST_SOC2_CMPT_TVALabel.AutoSize = True
        Me.CST_SOC2_CMPT_TVALabel.Location = New System.Drawing.Point(6, 290)
        Me.CST_SOC2_CMPT_TVALabel.Name = "CST_SOC2_CMPT_TVALabel"
        Me.CST_SOC2_CMPT_TVALabel.Size = New System.Drawing.Size(129, 13)
        Me.CST_SOC2_CMPT_TVALabel.TabIndex = 21
        Me.CST_SOC2_CMPT_TVALabel.Text = "Compte TVA sur Ventes : "
        '
        'CST_SOC2_CMPT_PRODLabel
        '
        Me.CST_SOC2_CMPT_PRODLabel.AutoSize = True
        Me.CST_SOC2_CMPT_PRODLabel.Location = New System.Drawing.Point(6, 316)
        Me.CST_SOC2_CMPT_PRODLabel.Name = "CST_SOC2_CMPT_PRODLabel"
        Me.CST_SOC2_CMPT_PRODLabel.Size = New System.Drawing.Size(88, 13)
        Me.CST_SOC2_CMPT_PRODLabel.TabIndex = 23
        Me.CST_SOC2_CMPT_PRODLabel.Text = "Compte Produit : "
        '
        'CST_VERSION_BDLabel
        '
        Me.CST_VERSION_BDLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_VERSION_BDLabel.AutoSize = True
        Me.CST_VERSION_BDLabel.Location = New System.Drawing.Point(619, 9)
        Me.CST_VERSION_BDLabel.Name = "CST_VERSION_BDLabel"
        Me.CST_VERSION_BDLabel.Size = New System.Drawing.Size(51, 13)
        Me.CST_VERSION_BDLabel.TabIndex = 1
        Me.CST_VERSION_BDLabel.Text = "Version : "
        '
        'CST_TX_COMMISSIONLabel
        '
        Me.CST_TX_COMMISSIONLabel.AutoSize = True
        Me.CST_TX_COMMISSIONLabel.Location = New System.Drawing.Point(8, 15)
        Me.CST_TX_COMMISSIONLabel.Name = "CST_TX_COMMISSIONLabel"
        Me.CST_TX_COMMISSIONLabel.Size = New System.Drawing.Size(161, 13)
        Me.CST_TX_COMMISSIONLabel.TabIndex = 0
        Me.CST_TX_COMMISSIONLabel.Text = "Taux de Commission par defaut :"
        '
        'CST_TAXES_TRPLabel
        '
        Me.CST_TAXES_TRPLabel.AutoSize = True
        Me.CST_TAXES_TRPLabel.Location = New System.Drawing.Point(8, 47)
        Me.CST_TAXES_TRPLabel.Name = "CST_TAXES_TRPLabel"
        Me.CST_TAXES_TRPLabel.Size = New System.Drawing.Size(136, 13)
        Me.CST_TAXES_TRPLabel.TabIndex = 2
        Me.CST_TAXES_TRPLabel.Text = "Taxe Frais d'enregistrement"
        '
        'CST_TRP_IDMODEREGLEMENTLabel
        '
        Me.CST_TRP_IDMODEREGLEMENTLabel.AutoSize = True
        Me.CST_TRP_IDMODEREGLEMENTLabel.Location = New System.Drawing.Point(344, 44)
        Me.CST_TRP_IDMODEREGLEMENTLabel.Name = "CST_TRP_IDMODEREGLEMENTLabel"
        Me.CST_TRP_IDMODEREGLEMENTLabel.Size = New System.Drawing.Size(151, 13)
        Me.CST_TRP_IDMODEREGLEMENTLabel.TabIndex = 4
        Me.CST_TRP_IDMODEREGLEMENTLabel.Text = "Mode de reglement transport : "
        '
        'CST_TRP_TXGAZOLELabel
        '
        Me.CST_TRP_TXGAZOLELabel.AutoSize = True
        Me.CST_TRP_TXGAZOLELabel.Location = New System.Drawing.Point(8, 96)
        Me.CST_TRP_TXGAZOLELabel.Name = "CST_TRP_TXGAZOLELabel"
        Me.CST_TRP_TXGAZOLELabel.Size = New System.Drawing.Size(67, 13)
        Me.CST_TRP_TXGAZOLELabel.TabIndex = 6
        Me.CST_TRP_TXGAZOLELabel.Text = "Taxe Gazole"
        '
        'CST_PU_PALL_PREPLabel
        '
        Me.CST_PU_PALL_PREPLabel.AutoSize = True
        Me.CST_PU_PALL_PREPLabel.Location = New System.Drawing.Point(8, 125)
        Me.CST_PU_PALL_PREPLabel.Name = "CST_PU_PALL_PREPLabel"
        Me.CST_PU_PALL_PREPLabel.Size = New System.Drawing.Size(150, 13)
        Me.CST_PU_PALL_PREPLabel.TabIndex = 8
        Me.CST_PU_PALL_PREPLabel.Text = "Prix unitaire palette préparée : "
        '
        'CST_PU_PALL_NONPREPLabel
        '
        Me.CST_PU_PALL_NONPREPLabel.AutoSize = True
        Me.CST_PU_PALL_NONPREPLabel.Location = New System.Drawing.Point(8, 151)
        Me.CST_PU_PALL_NONPREPLabel.Name = "CST_PU_PALL_NONPREPLabel"
        Me.CST_PU_PALL_NONPREPLabel.Size = New System.Drawing.Size(171, 13)
        Me.CST_PU_PALL_NONPREPLabel.TabIndex = 10
        Me.CST_PU_PALL_NONPREPLabel.Text = "Prix unitaire palette non préparée : "
        '
        'CST_COL_IDMODEREGLEMENTLabel
        '
        Me.CST_COL_IDMODEREGLEMENTLabel.AutoSize = True
        Me.CST_COL_IDMODEREGLEMENTLabel.Location = New System.Drawing.Point(344, 70)
        Me.CST_COL_IDMODEREGLEMENTLabel.Name = "CST_COL_IDMODEREGLEMENTLabel"
        Me.CST_COL_IDMODEREGLEMENTLabel.Size = New System.Drawing.Size(149, 13)
        Me.CST_COL_IDMODEREGLEMENTLabel.TabIndex = 12
        Me.CST_COL_IDMODEREGLEMENTLabel.Text = "Mode de reglement colisage : "
        '
        'CST_FACT_COL_TAXESLabel
        '
        Me.CST_FACT_COL_TAXESLabel.AutoSize = True
        Me.CST_FACT_COL_TAXESLabel.Location = New System.Drawing.Point(8, 177)
        Me.CST_FACT_COL_TAXESLabel.Name = "CST_FACT_COL_TAXESLabel"
        Me.CST_FACT_COL_TAXESLabel.Size = New System.Drawing.Size(80, 13)
        Me.CST_FACT_COL_TAXESLabel.TabIndex = 14
        Me.CST_FACT_COL_TAXESLabel.Text = "Taxe Colisage :"
        '
        'CST_FACT_COL_PU_COLISLabel
        '
        Me.CST_FACT_COL_PU_COLISLabel.AutoSize = True
        Me.CST_FACT_COL_PU_COLISLabel.Location = New System.Drawing.Point(8, 203)
        Me.CST_FACT_COL_PU_COLISLabel.Name = "CST_FACT_COL_PU_COLISLabel"
        Me.CST_FACT_COL_PU_COLISLabel.Size = New System.Drawing.Size(94, 13)
        Me.CST_FACT_COL_PU_COLISLabel.TabIndex = 16
        Me.CST_FACT_COL_PU_COLISLabel.Text = "Prix unitaire colis : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Compte Produit TRP : "
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabVinicom)
        Me.TabControl1.Controls.Add(Me.TabVinidis)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.tbEDI_Destinataire)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 505)
        Me.TabControl1.TabIndex = 0
        '
        'tabVinicom
        '
        Me.tabVinicom.AutoScroll = True
        Me.tabVinicom.Controls.Add(Me.tbCompteBanque)
        Me.tabVinicom.Controls.Add(Me.Label2)
        Me.tabVinicom.Controls.Add(Me.CST_SOC1_CMPT_PRODLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC1_CMPT_PRODTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC1_CMPT_TVALabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC1_CMPT_TVATextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_LICENCELabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_LICENCETextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_RCSLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_RCSTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_TVAINTRALabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_TVAINTRATextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_EMAILLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_EMAILTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_PORTLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_PORTTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_FAXLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_FAXTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_TELLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_TELTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_ADRESSE_VILLETextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_ADRESSE_CPTextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_ADRESSE_RUE2TextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_ADRESSE_RUE1Label)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_ADRESSE_RUE1TextBox)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_NOMSOCLabel)
        Me.tabVinicom.Controls.Add(Me.CST_SOC_NOMSOCTextBox)
        Me.tabVinicom.Location = New System.Drawing.Point(4, 22)
        Me.tabVinicom.Name = "tabVinicom"
        Me.tabVinicom.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVinicom.Size = New System.Drawing.Size(768, 479)
        Me.tabVinicom.TabIndex = 0
        Me.tabVinicom.Text = "VINICOM"
        Me.tabVinicom.UseVisualStyleBackColor = True
        '
        'tbCompteBanque
        '
        Me.tbCompteBanque.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_COMPTEBANQUE", True))
        Me.tbCompteBanque.Location = New System.Drawing.Point(291, 355)
        Me.tbCompteBanque.Name = "tbCompteBanque"
        Me.tbCompteBanque.Size = New System.Drawing.Size(100, 20)
        Me.tbCompteBanque.TabIndex = 26
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "CONSTANTES"
        Me.BindingSource1.DataSource = Me.DsVinicom1
        '
        'DsVinicom1
        '
        Me.DsVinicom1.DataSetName = "dsVinicom"
        Me.DsVinicom1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Compte Banque :"
        '
        'CST_SOC1_CMPT_PRODTextBox
        '
        Me.CST_SOC1_CMPT_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_COMPTEPRODUIT", True))
        Me.CST_SOC1_CMPT_PRODTextBox.Location = New System.Drawing.Point(291, 328)
        Me.CST_SOC1_CMPT_PRODTextBox.Name = "CST_SOC1_CMPT_PRODTextBox"
        Me.CST_SOC1_CMPT_PRODTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_SOC1_CMPT_PRODTextBox.TabIndex = 24
        '
        'CST_SOC1_CMPT_TVATextBox
        '
        Me.CST_SOC1_CMPT_TVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_COMPTETVA", True))
        Me.CST_SOC1_CMPT_TVATextBox.Location = New System.Drawing.Point(291, 302)
        Me.CST_SOC1_CMPT_TVATextBox.Name = "CST_SOC1_CMPT_TVATextBox"
        Me.CST_SOC1_CMPT_TVATextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_SOC1_CMPT_TVATextBox.TabIndex = 22
        '
        'CST_SOC_LICENCETextBox
        '
        Me.CST_SOC_LICENCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_LICENCE", True))
        Me.CST_SOC_LICENCETextBox.Location = New System.Drawing.Point(89, 252)
        Me.CST_SOC_LICENCETextBox.Name = "CST_SOC_LICENCETextBox"
        Me.CST_SOC_LICENCETextBox.Size = New System.Drawing.Size(302, 20)
        Me.CST_SOC_LICENCETextBox.TabIndex = 20
        '
        'CST_SOC_RCSTextBox
        '
        Me.CST_SOC_RCSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_RCS", True))
        Me.CST_SOC_RCSTextBox.Location = New System.Drawing.Point(89, 226)
        Me.CST_SOC_RCSTextBox.Name = "CST_SOC_RCSTextBox"
        Me.CST_SOC_RCSTextBox.Size = New System.Drawing.Size(302, 20)
        Me.CST_SOC_RCSTextBox.TabIndex = 19
        '
        'CST_SOC_TVAINTRATextBox
        '
        Me.CST_SOC_TVAINTRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_TVAINTRA", True))
        Me.CST_SOC_TVAINTRATextBox.Location = New System.Drawing.Point(89, 200)
        Me.CST_SOC_TVAINTRATextBox.Name = "CST_SOC_TVAINTRATextBox"
        Me.CST_SOC_TVAINTRATextBox.Size = New System.Drawing.Size(302, 20)
        Me.CST_SOC_TVAINTRATextBox.TabIndex = 18
        '
        'CST_SOC_EMAILTextBox
        '
        Me.CST_SOC_EMAILTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_EMAIL", True))
        Me.CST_SOC_EMAILTextBox.Location = New System.Drawing.Point(524, 150)
        Me.CST_SOC_EMAILTextBox.Name = "CST_SOC_EMAILTextBox"
        Me.CST_SOC_EMAILTextBox.Size = New System.Drawing.Size(224, 20)
        Me.CST_SOC_EMAILTextBox.TabIndex = 17
        '
        'CST_SOC_PORTTextBox
        '
        Me.CST_SOC_PORTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_PORT", True))
        Me.CST_SOC_PORTTextBox.Location = New System.Drawing.Point(68, 150)
        Me.CST_SOC_PORTTextBox.Name = "CST_SOC_PORTTextBox"
        Me.CST_SOC_PORTTextBox.Size = New System.Drawing.Size(224, 20)
        Me.CST_SOC_PORTTextBox.TabIndex = 15
        '
        'CST_SOC_FAXTextBox
        '
        Me.CST_SOC_FAXTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_FAX", True))
        Me.CST_SOC_FAXTextBox.Location = New System.Drawing.Point(524, 125)
        Me.CST_SOC_FAXTextBox.Name = "CST_SOC_FAXTextBox"
        Me.CST_SOC_FAXTextBox.Size = New System.Drawing.Size(224, 20)
        Me.CST_SOC_FAXTextBox.TabIndex = 13
        '
        'CST_SOC_TELTextBox
        '
        Me.CST_SOC_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_TEL", True))
        Me.CST_SOC_TELTextBox.Location = New System.Drawing.Point(68, 124)
        Me.CST_SOC_TELTextBox.Name = "CST_SOC_TELTextBox"
        Me.CST_SOC_TELTextBox.Size = New System.Drawing.Size(224, 20)
        Me.CST_SOC_TELTextBox.TabIndex = 11
        '
        'CST_SOC_ADRESSE_VILLETextBox
        '
        Me.CST_SOC_ADRESSE_VILLETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_ADRESSE_VILLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_ADRESSE_VILLE", True))
        Me.CST_SOC_ADRESSE_VILLETextBox.Location = New System.Drawing.Point(152, 99)
        Me.CST_SOC_ADRESSE_VILLETextBox.Name = "CST_SOC_ADRESSE_VILLETextBox"
        Me.CST_SOC_ADRESSE_VILLETextBox.Size = New System.Drawing.Size(596, 20)
        Me.CST_SOC_ADRESSE_VILLETextBox.TabIndex = 9
        '
        'CST_SOC_ADRESSE_CPTextBox
        '
        Me.CST_SOC_ADRESSE_CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_ADRESSE_CP", True))
        Me.CST_SOC_ADRESSE_CPTextBox.Location = New System.Drawing.Point(68, 99)
        Me.CST_SOC_ADRESSE_CPTextBox.Name = "CST_SOC_ADRESSE_CPTextBox"
        Me.CST_SOC_ADRESSE_CPTextBox.Size = New System.Drawing.Size(78, 20)
        Me.CST_SOC_ADRESSE_CPTextBox.TabIndex = 7
        '
        'CST_SOC_ADRESSE_RUE2TextBox
        '
        Me.CST_SOC_ADRESSE_RUE2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_ADRESSE_RUE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_ADRESSE_RUE2", True))
        Me.CST_SOC_ADRESSE_RUE2TextBox.Location = New System.Drawing.Point(68, 73)
        Me.CST_SOC_ADRESSE_RUE2TextBox.Name = "CST_SOC_ADRESSE_RUE2TextBox"
        Me.CST_SOC_ADRESSE_RUE2TextBox.Size = New System.Drawing.Size(682, 20)
        Me.CST_SOC_ADRESSE_RUE2TextBox.TabIndex = 5
        '
        'CST_SOC_ADRESSE_RUE1TextBox
        '
        Me.CST_SOC_ADRESSE_RUE1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_ADRESSE_RUE1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_ADRESSE_RUE1", True))
        Me.CST_SOC_ADRESSE_RUE1TextBox.Location = New System.Drawing.Point(68, 47)
        Me.CST_SOC_ADRESSE_RUE1TextBox.Name = "CST_SOC_ADRESSE_RUE1TextBox"
        Me.CST_SOC_ADRESSE_RUE1TextBox.Size = New System.Drawing.Size(682, 20)
        Me.CST_SOC_ADRESSE_RUE1TextBox.TabIndex = 3
        '
        'CST_SOC_NOMSOCTextBox
        '
        Me.CST_SOC_NOMSOCTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC_NOMSOCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC_NOMSOC", True))
        Me.CST_SOC_NOMSOCTextBox.Location = New System.Drawing.Point(68, 21)
        Me.CST_SOC_NOMSOCTextBox.Name = "CST_SOC_NOMSOCTextBox"
        Me.CST_SOC_NOMSOCTextBox.Size = New System.Drawing.Size(682, 20)
        Me.CST_SOC_NOMSOCTextBox.TabIndex = 1
        '
        'TabVinidis
        '
        Me.TabVinidis.Controls.Add(Me.TextBox4)
        Me.TabVinidis.Controls.Add(Me.Label24)
        Me.TabVinidis.Controls.Add(Me.tbSOC2COMPTPROD2)
        Me.TabVinidis.Controls.Add(Me.Label4)
        Me.TabVinidis.Controls.Add(Me.tbCodeBanque2)
        Me.TabVinidis.Controls.Add(Me.Label3)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_CMPT_PRODLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_CMPT_PRODTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_CMPT_TVALabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_CMPT_TVATextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_LICENCELabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_LICENCETextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_RCSLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_RCSTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_TVAINTRALabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_TVAINTRATextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_EMAILLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_EMAILTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_PORTLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_PORTTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_FAXLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_FAXTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_TELLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_TELTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_ADRESSE_VILLETextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_ADRESSE_CPTextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_ADRESSE_RUE2TextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_ADRESSE_RUE1Label)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_ADRESSE_RUE1TextBox)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_NOMSOCLabel)
        Me.TabVinidis.Controls.Add(Me.CST_SOC2_NOMSOCTextBox)
        Me.TabVinidis.Location = New System.Drawing.Point(4, 22)
        Me.TabVinidis.Name = "TabVinidis"
        Me.TabVinidis.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVinidis.Size = New System.Drawing.Size(768, 479)
        Me.TabVinidis.TabIndex = 1
        Me.TabVinidis.Text = "Vinidis"
        Me.TabVinidis.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_COMPTEPRODUIT_TAXEGO", True))
        Me.TextBox4.Location = New System.Drawing.Point(549, 340)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(383, 343)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(143, 13)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Compte Produit taxe Gasoil : "
        '
        'tbSOC2COMPTPROD2
        '
        Me.tbSOC2COMPTPROD2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_COMPTEPRODUIT_COL", True))
        Me.tbSOC2COMPTPROD2.Location = New System.Drawing.Point(549, 313)
        Me.tbSOC2COMPTPROD2.Name = "tbSOC2COMPTPROD2"
        Me.tbSOC2COMPTPROD2.Size = New System.Drawing.Size(100, 20)
        Me.tbSOC2COMPTPROD2.TabIndex = 28
        '
        'tbCodeBanque2
        '
        Me.tbCodeBanque2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_COMPTEBANQUE", True))
        Me.tbCodeBanque2.Location = New System.Drawing.Point(218, 340)
        Me.tbCodeBanque2.Name = "tbCodeBanque2"
        Me.tbCodeBanque2.Size = New System.Drawing.Size(100, 20)
        Me.tbCodeBanque2.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Compte Banque : "
        '
        'CST_SOC2_CMPT_PRODTextBox
        '
        Me.CST_SOC2_CMPT_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_COMPTEPRODUIT", True))
        Me.CST_SOC2_CMPT_PRODTextBox.Location = New System.Drawing.Point(218, 313)
        Me.CST_SOC2_CMPT_PRODTextBox.Name = "CST_SOC2_CMPT_PRODTextBox"
        Me.CST_SOC2_CMPT_PRODTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_SOC2_CMPT_PRODTextBox.TabIndex = 24
        '
        'CST_SOC2_CMPT_TVATextBox
        '
        Me.CST_SOC2_CMPT_TVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_COMPTETVA", True))
        Me.CST_SOC2_CMPT_TVATextBox.Location = New System.Drawing.Point(218, 287)
        Me.CST_SOC2_CMPT_TVATextBox.Name = "CST_SOC2_CMPT_TVATextBox"
        Me.CST_SOC2_CMPT_TVATextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_SOC2_CMPT_TVATextBox.TabIndex = 22
        '
        'CST_SOC2_LICENCETextBox
        '
        Me.CST_SOC2_LICENCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_LICENCE", True))
        Me.CST_SOC2_LICENCETextBox.Location = New System.Drawing.Point(83, 261)
        Me.CST_SOC2_LICENCETextBox.Name = "CST_SOC2_LICENCETextBox"
        Me.CST_SOC2_LICENCETextBox.Size = New System.Drawing.Size(235, 20)
        Me.CST_SOC2_LICENCETextBox.TabIndex = 20
        '
        'CST_SOC2_RCSTextBox
        '
        Me.CST_SOC2_RCSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_RCS", True))
        Me.CST_SOC2_RCSTextBox.Location = New System.Drawing.Point(83, 235)
        Me.CST_SOC2_RCSTextBox.Name = "CST_SOC2_RCSTextBox"
        Me.CST_SOC2_RCSTextBox.Size = New System.Drawing.Size(235, 20)
        Me.CST_SOC2_RCSTextBox.TabIndex = 18
        '
        'CST_SOC2_TVAINTRATextBox
        '
        Me.CST_SOC2_TVAINTRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_TVAINTRA", True))
        Me.CST_SOC2_TVAINTRATextBox.Location = New System.Drawing.Point(83, 207)
        Me.CST_SOC2_TVAINTRATextBox.Name = "CST_SOC2_TVAINTRATextBox"
        Me.CST_SOC2_TVAINTRATextBox.Size = New System.Drawing.Size(235, 20)
        Me.CST_SOC2_TVAINTRATextBox.TabIndex = 16
        '
        'CST_SOC2_EMAILTextBox
        '
        Me.CST_SOC2_EMAILTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_EMAIL", True))
        Me.CST_SOC2_EMAILTextBox.Location = New System.Drawing.Point(549, 136)
        Me.CST_SOC2_EMAILTextBox.Name = "CST_SOC2_EMAILTextBox"
        Me.CST_SOC2_EMAILTextBox.Size = New System.Drawing.Size(213, 20)
        Me.CST_SOC2_EMAILTextBox.TabIndex = 14
        '
        'CST_SOC2_PORTTextBox
        '
        Me.CST_SOC2_PORTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_PORT", True))
        Me.CST_SOC2_PORTTextBox.Location = New System.Drawing.Point(83, 136)
        Me.CST_SOC2_PORTTextBox.Name = "CST_SOC2_PORTTextBox"
        Me.CST_SOC2_PORTTextBox.Size = New System.Drawing.Size(213, 20)
        Me.CST_SOC2_PORTTextBox.TabIndex = 12
        '
        'CST_SOC2_FAXTextBox
        '
        Me.CST_SOC2_FAXTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_FAX", True))
        Me.CST_SOC2_FAXTextBox.Location = New System.Drawing.Point(549, 110)
        Me.CST_SOC2_FAXTextBox.Name = "CST_SOC2_FAXTextBox"
        Me.CST_SOC2_FAXTextBox.Size = New System.Drawing.Size(213, 20)
        Me.CST_SOC2_FAXTextBox.TabIndex = 11
        '
        'CST_SOC2_TELTextBox
        '
        Me.CST_SOC2_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_TEL", True))
        Me.CST_SOC2_TELTextBox.Location = New System.Drawing.Point(83, 110)
        Me.CST_SOC2_TELTextBox.Name = "CST_SOC2_TELTextBox"
        Me.CST_SOC2_TELTextBox.Size = New System.Drawing.Size(213, 20)
        Me.CST_SOC2_TELTextBox.TabIndex = 10
        '
        'CST_SOC2_ADRESSE_VILLETextBox
        '
        Me.CST_SOC2_ADRESSE_VILLETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_ADRESSE_VILLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_ADRESSE_VILLE", True))
        Me.CST_SOC2_ADRESSE_VILLETextBox.Location = New System.Drawing.Point(162, 84)
        Me.CST_SOC2_ADRESSE_VILLETextBox.Name = "CST_SOC2_ADRESSE_VILLETextBox"
        Me.CST_SOC2_ADRESSE_VILLETextBox.Size = New System.Drawing.Size(600, 20)
        Me.CST_SOC2_ADRESSE_VILLETextBox.TabIndex = 9
        '
        'CST_SOC2_ADRESSE_CPTextBox
        '
        Me.CST_SOC2_ADRESSE_CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_ADRESSE_CP", True))
        Me.CST_SOC2_ADRESSE_CPTextBox.Location = New System.Drawing.Point(83, 84)
        Me.CST_SOC2_ADRESSE_CPTextBox.Name = "CST_SOC2_ADRESSE_CPTextBox"
        Me.CST_SOC2_ADRESSE_CPTextBox.Size = New System.Drawing.Size(73, 20)
        Me.CST_SOC2_ADRESSE_CPTextBox.TabIndex = 7
        '
        'CST_SOC2_ADRESSE_RUE2TextBox
        '
        Me.CST_SOC2_ADRESSE_RUE2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_ADRESSE_RUE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_ADRESSE_RUE2", True))
        Me.CST_SOC2_ADRESSE_RUE2TextBox.Location = New System.Drawing.Point(83, 58)
        Me.CST_SOC2_ADRESSE_RUE2TextBox.Name = "CST_SOC2_ADRESSE_RUE2TextBox"
        Me.CST_SOC2_ADRESSE_RUE2TextBox.Size = New System.Drawing.Size(679, 20)
        Me.CST_SOC2_ADRESSE_RUE2TextBox.TabIndex = 5
        '
        'CST_SOC2_ADRESSE_RUE1TextBox
        '
        Me.CST_SOC2_ADRESSE_RUE1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_ADRESSE_RUE1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_ADRESSE_RUE1", True))
        Me.CST_SOC2_ADRESSE_RUE1TextBox.Location = New System.Drawing.Point(83, 32)
        Me.CST_SOC2_ADRESSE_RUE1TextBox.Name = "CST_SOC2_ADRESSE_RUE1TextBox"
        Me.CST_SOC2_ADRESSE_RUE1TextBox.Size = New System.Drawing.Size(679, 20)
        Me.CST_SOC2_ADRESSE_RUE1TextBox.TabIndex = 3
        '
        'CST_SOC2_NOMSOCTextBox
        '
        Me.CST_SOC2_NOMSOCTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_SOC2_NOMSOCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_SOC2_NOMSOC", True))
        Me.CST_SOC2_NOMSOCTextBox.Location = New System.Drawing.Point(83, 6)
        Me.CST_SOC2_NOMSOCTextBox.Name = "CST_SOC2_NOMSOCTextBox"
        Me.CST_SOC2_NOMSOCTextBox.Size = New System.Drawing.Size(679, 20)
        Me.CST_SOC2_NOMSOCTextBox.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_EMAILLabel)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_EMAILTextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_PORTLabel)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_PORTTextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_FAXLabel)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_FAXTextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_TELLabel)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_TELTextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_VILLETextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_CPTextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_RUE2TextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_RUE1Label)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_RUE1TextBox)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_NOMLabel)
        Me.TabPage1.Controls.Add(Me.CST_PLTFRM_NOMTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 479)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Plateforme"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CST_PLTFRM_EMAILTextBox
        '
        Me.CST_PLTFRM_EMAILTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_EMAIL", True))
        Me.CST_PLTFRM_EMAILTextBox.Location = New System.Drawing.Point(521, 147)
        Me.CST_PLTFRM_EMAILTextBox.Name = "CST_PLTFRM_EMAILTextBox"
        Me.CST_PLTFRM_EMAILTextBox.Size = New System.Drawing.Size(241, 20)
        Me.CST_PLTFRM_EMAILTextBox.TabIndex = 17
        '
        'CST_PLTFRM_PORTTextBox
        '
        Me.CST_PLTFRM_PORTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_PORT", True))
        Me.CST_PLTFRM_PORTTextBox.Location = New System.Drawing.Point(67, 147)
        Me.CST_PLTFRM_PORTTextBox.Name = "CST_PLTFRM_PORTTextBox"
        Me.CST_PLTFRM_PORTTextBox.Size = New System.Drawing.Size(241, 20)
        Me.CST_PLTFRM_PORTTextBox.TabIndex = 15
        '
        'CST_PLTFRM_FAXTextBox
        '
        Me.CST_PLTFRM_FAXTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_FAX", True))
        Me.CST_PLTFRM_FAXTextBox.Location = New System.Drawing.Point(521, 121)
        Me.CST_PLTFRM_FAXTextBox.Name = "CST_PLTFRM_FAXTextBox"
        Me.CST_PLTFRM_FAXTextBox.Size = New System.Drawing.Size(241, 20)
        Me.CST_PLTFRM_FAXTextBox.TabIndex = 13
        '
        'CST_PLTFRM_TELTextBox
        '
        Me.CST_PLTFRM_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_TEL", True))
        Me.CST_PLTFRM_TELTextBox.Location = New System.Drawing.Point(68, 121)
        Me.CST_PLTFRM_TELTextBox.Name = "CST_PLTFRM_TELTextBox"
        Me.CST_PLTFRM_TELTextBox.Size = New System.Drawing.Size(241, 20)
        Me.CST_PLTFRM_TELTextBox.TabIndex = 11
        '
        'CST_PLTFRM_VILLETextBox
        '
        Me.CST_PLTFRM_VILLETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_VILLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_VILLE", True))
        Me.CST_PLTFRM_VILLETextBox.Location = New System.Drawing.Point(174, 84)
        Me.CST_PLTFRM_VILLETextBox.Name = "CST_PLTFRM_VILLETextBox"
        Me.CST_PLTFRM_VILLETextBox.Size = New System.Drawing.Size(586, 20)
        Me.CST_PLTFRM_VILLETextBox.TabIndex = 9
        '
        'CST_PLTFRM_CPTextBox
        '
        Me.CST_PLTFRM_CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_CP", True))
        Me.CST_PLTFRM_CPTextBox.Location = New System.Drawing.Point(68, 84)
        Me.CST_PLTFRM_CPTextBox.Name = "CST_PLTFRM_CPTextBox"
        Me.CST_PLTFRM_CPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_PLTFRM_CPTextBox.TabIndex = 7
        '
        'CST_PLTFRM_RUE2TextBox
        '
        Me.CST_PLTFRM_RUE2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_RUE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_RUE2", True))
        Me.CST_PLTFRM_RUE2TextBox.Location = New System.Drawing.Point(68, 58)
        Me.CST_PLTFRM_RUE2TextBox.Name = "CST_PLTFRM_RUE2TextBox"
        Me.CST_PLTFRM_RUE2TextBox.Size = New System.Drawing.Size(692, 20)
        Me.CST_PLTFRM_RUE2TextBox.TabIndex = 5
        '
        'CST_PLTFRM_RUE1TextBox
        '
        Me.CST_PLTFRM_RUE1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_RUE1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_RUE1", True))
        Me.CST_PLTFRM_RUE1TextBox.Location = New System.Drawing.Point(68, 32)
        Me.CST_PLTFRM_RUE1TextBox.Name = "CST_PLTFRM_RUE1TextBox"
        Me.CST_PLTFRM_RUE1TextBox.Size = New System.Drawing.Size(692, 20)
        Me.CST_PLTFRM_RUE1TextBox.TabIndex = 3
        '
        'CST_PLTFRM_NOMTextBox
        '
        Me.CST_PLTFRM_NOMTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PLTFRM_NOMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PLTFRM_NOM", True))
        Me.CST_PLTFRM_NOMTextBox.Location = New System.Drawing.Point(67, 6)
        Me.CST_PLTFRM_NOMTextBox.Name = "CST_PLTFRM_NOMTextBox"
        Me.CST_PLTFRM_NOMTextBox.Size = New System.Drawing.Size(695, 20)
        Me.CST_PLTFRM_NOMTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.CST_PATH_FACTTRPTextBox)
        Me.TabPage3.Controls.Add(Me.CST_PATH_FACTCOMTextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACT_COLISAGELabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACT_COLISAGETextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACT_TRPLabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACT_TRPTextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACTCOMLabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_FACTCOMTextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_BALabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_BATextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_SCMDLabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_SCMDTextBox)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_CMD_CLTLabel)
        Me.TabPage3.Controls.Add(Me.CST_DERN_NUM_CMD_CLTTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(768, 479)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Numérotation"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Facture HOBIVIN : "
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_FACT_HBV", True))
        Me.TextBox2.Location = New System.Drawing.Point(189, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EXPORT_COMPTA_PATH", True))
        Me.TextBox1.Location = New System.Drawing.Point(295, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(467, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Répertoire d'exportation vers la comptabilité : "
        '
        'CST_PATH_FACTTRPTextBox
        '
        Me.CST_PATH_FACTTRPTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PATH_FACTTRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PATH_FACTTRP", True))
        Me.CST_PATH_FACTTRPTextBox.Location = New System.Drawing.Point(295, 110)
        Me.CST_PATH_FACTTRPTextBox.Name = "CST_PATH_FACTTRPTextBox"
        Me.CST_PATH_FACTTRPTextBox.Size = New System.Drawing.Size(467, 20)
        Me.CST_PATH_FACTTRPTextBox.TabIndex = 14
        '
        'CST_PATH_FACTCOMTextBox
        '
        Me.CST_PATH_FACTCOMTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_PATH_FACTCOMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PATH_FACTCOM", True))
        Me.CST_PATH_FACTCOMTextBox.Location = New System.Drawing.Point(295, 84)
        Me.CST_PATH_FACTCOMTextBox.Name = "CST_PATH_FACTCOMTextBox"
        Me.CST_PATH_FACTCOMTextBox.Size = New System.Drawing.Size(467, 20)
        Me.CST_PATH_FACTCOMTextBox.TabIndex = 13
        '
        'CST_DERN_NUM_FACT_COLISAGETextBox
        '
        Me.CST_DERN_NUM_FACT_COLISAGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_FACT_COLISAGE", True))
        Me.CST_DERN_NUM_FACT_COLISAGETextBox.Location = New System.Drawing.Point(189, 136)
        Me.CST_DERN_NUM_FACT_COLISAGETextBox.Name = "CST_DERN_NUM_FACT_COLISAGETextBox"
        Me.CST_DERN_NUM_FACT_COLISAGETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_FACT_COLISAGETextBox.TabIndex = 11
        '
        'CST_DERN_NUM_FACT_TRPTextBox
        '
        Me.CST_DERN_NUM_FACT_TRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_FACT_TRP", True))
        Me.CST_DERN_NUM_FACT_TRPTextBox.Location = New System.Drawing.Point(189, 110)
        Me.CST_DERN_NUM_FACT_TRPTextBox.Name = "CST_DERN_NUM_FACT_TRPTextBox"
        Me.CST_DERN_NUM_FACT_TRPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_FACT_TRPTextBox.TabIndex = 9
        '
        'CST_DERN_NUM_FACTCOMTextBox
        '
        Me.CST_DERN_NUM_FACTCOMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_FACTCOM", True))
        Me.CST_DERN_NUM_FACTCOMTextBox.Location = New System.Drawing.Point(189, 84)
        Me.CST_DERN_NUM_FACTCOMTextBox.Name = "CST_DERN_NUM_FACTCOMTextBox"
        Me.CST_DERN_NUM_FACTCOMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_FACTCOMTextBox.TabIndex = 7
        '
        'CST_DERN_NUM_BATextBox
        '
        Me.CST_DERN_NUM_BATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_BA", True))
        Me.CST_DERN_NUM_BATextBox.Location = New System.Drawing.Point(189, 58)
        Me.CST_DERN_NUM_BATextBox.Name = "CST_DERN_NUM_BATextBox"
        Me.CST_DERN_NUM_BATextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_BATextBox.TabIndex = 5
        '
        'CST_DERN_NUM_SCMDTextBox
        '
        Me.CST_DERN_NUM_SCMDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_SCMD", True))
        Me.CST_DERN_NUM_SCMDTextBox.Location = New System.Drawing.Point(189, 32)
        Me.CST_DERN_NUM_SCMDTextBox.Name = "CST_DERN_NUM_SCMDTextBox"
        Me.CST_DERN_NUM_SCMDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_SCMDTextBox.TabIndex = 3
        '
        'CST_DERN_NUM_CMD_CLTTextBox
        '
        Me.CST_DERN_NUM_CMD_CLTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_DERN_NUM_CMD_CLT", True))
        Me.CST_DERN_NUM_CMD_CLTTextBox.Location = New System.Drawing.Point(189, 6)
        Me.CST_DERN_NUM_CMD_CLTTextBox.Name = "CST_DERN_NUM_CMD_CLTTextBox"
        Me.CST_DERN_NUM_CMD_CLTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_DERN_NUM_CMD_CLTTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.CST_FACT_COL_PU_COLISLabel)
        Me.TabPage4.Controls.Add(Me.CST_FACT_COL_PU_COLISTextBox)
        Me.TabPage4.Controls.Add(Me.CST_FACT_COL_TAXESLabel)
        Me.TabPage4.Controls.Add(Me.CST_FACT_COL_TAXESTextBox)
        Me.TabPage4.Controls.Add(Me.CST_COL_IDMODEREGLEMENTLabel)
        Me.TabPage4.Controls.Add(Me.CST_COL_IDMODEREGLEMENTTextBox)
        Me.TabPage4.Controls.Add(Me.CST_PU_PALL_NONPREPLabel)
        Me.TabPage4.Controls.Add(Me.CST_PU_PALL_NONPREPTextBox)
        Me.TabPage4.Controls.Add(Me.CST_PU_PALL_PREPLabel)
        Me.TabPage4.Controls.Add(Me.CST_PU_PALL_PREPTextBox)
        Me.TabPage4.Controls.Add(Me.CST_TRP_TXGAZOLELabel)
        Me.TabPage4.Controls.Add(Me.CST_TRP_TXGAZOLETextBox)
        Me.TabPage4.Controls.Add(Me.CST_TRP_IDMODEREGLEMENTLabel)
        Me.TabPage4.Controls.Add(Me.CST_TRP_IDMODEREGLEMENTTextBox)
        Me.TabPage4.Controls.Add(Me.CST_TAXES_TRPLabel)
        Me.TabPage4.Controls.Add(Me.CST_TAXES_TRPTextBox)
        Me.TabPage4.Controls.Add(Me.CST_TX_COMMISSIONLabel)
        Me.TabPage4.Controls.Add(Me.CST_TX_COMMISSIONTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(768, 479)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Taxes et Taux"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Part Gazole Transport"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_TRP_PARTTRP", True))
        Me.TextBox3.Location = New System.Drawing.Point(194, 70)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'CST_FACT_COL_PU_COLISTextBox
        '
        Me.CST_FACT_COL_PU_COLISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FACT_COL_PU_COLIS", True))
        Me.CST_FACT_COL_PU_COLISTextBox.Location = New System.Drawing.Point(194, 200)
        Me.CST_FACT_COL_PU_COLISTextBox.Name = "CST_FACT_COL_PU_COLISTextBox"
        Me.CST_FACT_COL_PU_COLISTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_FACT_COL_PU_COLISTextBox.TabIndex = 17
        '
        'CST_FACT_COL_TAXESTextBox
        '
        Me.CST_FACT_COL_TAXESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FACT_COL_TAXES", True))
        Me.CST_FACT_COL_TAXESTextBox.Location = New System.Drawing.Point(194, 174)
        Me.CST_FACT_COL_TAXESTextBox.Name = "CST_FACT_COL_TAXESTextBox"
        Me.CST_FACT_COL_TAXESTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_FACT_COL_TAXESTextBox.TabIndex = 15
        '
        'CST_COL_IDMODEREGLEMENTTextBox
        '
        Me.CST_COL_IDMODEREGLEMENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_COL_IDMODEREGLEMENT", True))
        Me.CST_COL_IDMODEREGLEMENTTextBox.Location = New System.Drawing.Point(526, 67)
        Me.CST_COL_IDMODEREGLEMENTTextBox.Name = "CST_COL_IDMODEREGLEMENTTextBox"
        Me.CST_COL_IDMODEREGLEMENTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_COL_IDMODEREGLEMENTTextBox.TabIndex = 13
        '
        'CST_PU_PALL_NONPREPTextBox
        '
        Me.CST_PU_PALL_NONPREPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PU_PALL_NONPREP", True))
        Me.CST_PU_PALL_NONPREPTextBox.Location = New System.Drawing.Point(194, 148)
        Me.CST_PU_PALL_NONPREPTextBox.Name = "CST_PU_PALL_NONPREPTextBox"
        Me.CST_PU_PALL_NONPREPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_PU_PALL_NONPREPTextBox.TabIndex = 11
        '
        'CST_PU_PALL_PREPTextBox
        '
        Me.CST_PU_PALL_PREPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_PU_PALL_PREP", True))
        Me.CST_PU_PALL_PREPTextBox.Location = New System.Drawing.Point(194, 122)
        Me.CST_PU_PALL_PREPTextBox.Name = "CST_PU_PALL_PREPTextBox"
        Me.CST_PU_PALL_PREPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_PU_PALL_PREPTextBox.TabIndex = 9
        '
        'CST_TRP_TXGAZOLETextBox
        '
        Me.CST_TRP_TXGAZOLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_TRP_TXGAZOLE", True))
        Me.CST_TRP_TXGAZOLETextBox.Location = New System.Drawing.Point(194, 96)
        Me.CST_TRP_TXGAZOLETextBox.Name = "CST_TRP_TXGAZOLETextBox"
        Me.CST_TRP_TXGAZOLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_TRP_TXGAZOLETextBox.TabIndex = 7
        '
        'CST_TRP_IDMODEREGLEMENTTextBox
        '
        Me.CST_TRP_IDMODEREGLEMENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_TRP_IDMODEREGLEMENT", True))
        Me.CST_TRP_IDMODEREGLEMENTTextBox.Location = New System.Drawing.Point(526, 41)
        Me.CST_TRP_IDMODEREGLEMENTTextBox.Name = "CST_TRP_IDMODEREGLEMENTTextBox"
        Me.CST_TRP_IDMODEREGLEMENTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_TRP_IDMODEREGLEMENTTextBox.TabIndex = 5
        '
        'CST_TAXES_TRPTextBox
        '
        Me.CST_TAXES_TRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_TAXES_TRP", True))
        Me.CST_TAXES_TRPTextBox.Location = New System.Drawing.Point(194, 44)
        Me.CST_TAXES_TRPTextBox.Name = "CST_TAXES_TRPTextBox"
        Me.CST_TAXES_TRPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_TAXES_TRPTextBox.TabIndex = 3
        '
        'CST_TX_COMMISSIONTextBox
        '
        Me.CST_TX_COMMISSIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_TX_COMMISSION", True))
        Me.CST_TX_COMMISSIONTextBox.Location = New System.Drawing.Point(194, 15)
        Me.CST_TX_COMMISSIONTextBox.Name = "CST_TX_COMMISSIONTextBox"
        Me.CST_TX_COMMISSIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_TX_COMMISSIONTextBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnTestFTPvnc)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCUrl2)
        Me.TabPage5.Controls.Add(Me.Label40)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCRemoteDir2)
        Me.TabPage5.Controls.Add(Me.Label39)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCURL)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCRemoteDir)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCPassword)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCUser)
        Me.TabPage5.Controls.Add(Me.tbFTPVNCHost)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Label32)
        Me.TabPage5.Controls.Add(Me.Label37)
        Me.TabPage5.Controls.Add(Me.Label38)
        Me.TabPage5.Controls.Add(Me.Label36)
        Me.TabPage5.Controls.Add(Me.tbftpVND_URL)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.btnTestFTPvnd)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.tbftnvnd_remoteDir)
        Me.TabPage5.Controls.Add(Me.tbftpvnd_password)
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Controls.Add(Me.tbftpvnd_User)
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.tbftpvnd_host)
        Me.TabPage5.Controls.Add(Me.Label35)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.tbFTPEDIRepLocal)
        Me.TabPage5.Controls.Add(Me.cbTestFTPEDI)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.tbFTPEDIRep)
        Me.TabPage5.Controls.Add(Me.tbFTPEDIPwd)
        Me.TabPage5.Controls.Add(Me.tbFTPEDIUser)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.tbFTPEDIPort)
        Me.TabPage5.Controls.Add(Me.tbFTPEDISRV)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(768, 479)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "FTP"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnTestFTPvnc
        '
        Me.btnTestFTPvnc.Location = New System.Drawing.Point(647, 154)
        Me.btnTestFTPvnc.Name = "btnTestFTPvnc"
        Me.btnTestFTPvnc.Size = New System.Drawing.Size(89, 25)
        Me.btnTestFTPvnc.TabIndex = 60
        Me.btnTestFTPvnc.Text = "Test"
        Me.btnTestFTPvnc.UseVisualStyleBackColor = True
        '
        'tbFTPVNCUrl2
        '
        Me.tbFTPVNCUrl2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_URL2", True))
        Me.tbFTPVNCUrl2.Location = New System.Drawing.Point(191, 291)
        Me.tbFTPVNCUrl2.Name = "tbFTPVNCUrl2"
        Me.tbFTPVNCUrl2.Size = New System.Drawing.Size(438, 20)
        Me.tbFTPVNCUrl2.TabIndex = 59
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(13, 294)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(161, 13)
        Me.Label40.TabIndex = 58
        Me.Label40.Text = "URL d'extraction des documents"
        '
        'tbFTPVNCRemoteDir2
        '
        Me.tbFTPVNCRemoteDir2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_REMOTEDIR2", True))
        Me.tbFTPVNCRemoteDir2.Location = New System.Drawing.Point(191, 235)
        Me.tbFTPVNCRemoteDir2.Name = "tbFTPVNCRemoteDir2"
        Me.tbFTPVNCRemoteDir2.Size = New System.Drawing.Size(438, 20)
        Me.tbFTPVNCRemoteDir2.TabIndex = 57
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(14, 242)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(109, 13)
        Me.Label39.TabIndex = 56
        Me.Label39.Text = "Répertoire de lecture:"
        '
        'tbFTPVNCURL
        '
        Me.tbFTPVNCURL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_URL", True))
        Me.tbFTPVNCURL.Location = New System.Drawing.Point(191, 265)
        Me.tbFTPVNCURL.Name = "tbFTPVNCURL"
        Me.tbFTPVNCURL.Size = New System.Drawing.Size(438, 20)
        Me.tbFTPVNCURL.TabIndex = 55
        '
        'tbFTPVNCRemoteDir
        '
        Me.tbFTPVNCRemoteDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_REMOTEDIR", True))
        Me.tbFTPVNCRemoteDir.Location = New System.Drawing.Point(191, 209)
        Me.tbFTPVNCRemoteDir.Name = "tbFTPVNCRemoteDir"
        Me.tbFTPVNCRemoteDir.Size = New System.Drawing.Size(438, 20)
        Me.tbFTPVNCRemoteDir.TabIndex = 54
        '
        'tbFTPVNCPassword
        '
        Me.tbFTPVNCPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_PASSWORD", True))
        Me.tbFTPVNCPassword.Location = New System.Drawing.Point(398, 183)
        Me.tbFTPVNCPassword.Name = "tbFTPVNCPassword"
        Me.tbFTPVNCPassword.Size = New System.Drawing.Size(201, 20)
        Me.tbFTPVNCPassword.TabIndex = 53
        '
        'tbFTPVNCUser
        '
        Me.tbFTPVNCUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_USER", True))
        Me.tbFTPVNCUser.Location = New System.Drawing.Point(191, 183)
        Me.tbFTPVNCUser.Name = "tbFTPVNCUser"
        Me.tbFTPVNCUser.Size = New System.Drawing.Size(201, 20)
        Me.tbFTPVNCUser.TabIndex = 52
        '
        'tbFTPVNCHost
        '
        Me.tbFTPVNCHost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVNC_HOST", True))
        Me.tbFTPVNCHost.Location = New System.Drawing.Point(191, 157)
        Me.tbFTPVNCHost.Name = "tbFTPVNCHost"
        Me.tbFTPVNCHost.Size = New System.Drawing.Size(201, 20)
        Me.tbFTPVNCHost.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 268)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(164, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "URL d'intégration des documents"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(14, 216)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 13)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Répertoire de dépot:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(14, 190)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(122, 13)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Utilisateur/Mot de passe"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(14, 164)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(50, 13)
        Me.Label38.TabIndex = 47
        Me.Label38.Text = "Serveur :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 131)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(300, 13)
        Me.Label36.TabIndex = 46
        Me.Label36.Text = "FTP Espace Fournisseur VINICOM (Bons à facturer)"
        '
        'tbftpVND_URL
        '
        Me.tbftpVND_URL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVND_URL", True))
        Me.tbftpVND_URL.Location = New System.Drawing.Point(191, 95)
        Me.tbftpVND_URL.Name = "tbftpVND_URL"
        Me.tbftpVND_URL.Size = New System.Drawing.Size(438, 20)
        Me.tbftpVND_URL.TabIndex = 45
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(13, 98)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(164, 13)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "URL d'intégration des documents"
        '
        'btnTestFTPvnd
        '
        Me.btnTestFTPvnd.Location = New System.Drawing.Point(647, 105)
        Me.btnTestFTPvnd.Name = "btnTestFTPvnd"
        Me.btnTestFTPvnd.Size = New System.Drawing.Size(89, 25)
        Me.btnTestFTPvnd.TabIndex = 42
        Me.btnTestFTPvnd.Text = "Test"
        Me.btnTestFTPvnd.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(14, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 13)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "FTP REMOTEDIR:"
        '
        'tbftnvnd_remoteDir
        '
        Me.tbftnvnd_remoteDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVND_REMOTEDIR", True))
        Me.tbftnvnd_remoteDir.Location = New System.Drawing.Point(191, 69)
        Me.tbftnvnd_remoteDir.Name = "tbftnvnd_remoteDir"
        Me.tbftnvnd_remoteDir.Size = New System.Drawing.Size(438, 20)
        Me.tbftnvnd_remoteDir.TabIndex = 37
        '
        'tbftpvnd_password
        '
        Me.tbftpvnd_password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVND_PASSWORD", True))
        Me.tbftpvnd_password.Location = New System.Drawing.Point(398, 45)
        Me.tbftpvnd_password.Name = "tbftpvnd_password"
        Me.tbftpvnd_password.Size = New System.Drawing.Size(201, 20)
        Me.tbftpvnd_password.TabIndex = 35
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(14, 48)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 13)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "FTP USERNAME:"
        '
        'tbftpvnd_User
        '
        Me.tbftpvnd_User.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVND_USER", True))
        Me.tbftpvnd_User.Location = New System.Drawing.Point(191, 45)
        Me.tbftpvnd_User.Name = "tbftpvnd_User"
        Me.tbftpvnd_User.Size = New System.Drawing.Size(201, 20)
        Me.tbftpvnd_User.TabIndex = 33
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(14, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "FTP HOSTNAME:"
        '
        'tbftpvnd_host
        '
        Me.tbftpvnd_host.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPVND_HOST", True))
        Me.tbftpvnd_host.Location = New System.Drawing.Point(191, 19)
        Me.tbftpvnd_host.Name = "tbftpvnd_host"
        Me.tbftpvnd_host.Size = New System.Drawing.Size(201, 20)
        Me.tbftpvnd_host.TabIndex = 31
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(12, 3)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(292, 13)
        Me.Label35.TabIndex = 43
        Me.Label35.Text = "FTP Espace Fournisseur VINIDIS (Stock-Colisage)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 450)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Rép Local :"
        '
        'tbFTPEDIRepLocal
        '
        Me.tbFTPEDIRepLocal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_REPLOCAL", True))
        Me.tbFTPEDIRepLocal.Location = New System.Drawing.Point(105, 443)
        Me.tbFTPEDIRepLocal.Name = "tbFTPEDIRepLocal"
        Me.tbFTPEDIRepLocal.Size = New System.Drawing.Size(432, 20)
        Me.tbFTPEDIRepLocal.TabIndex = 28
        '
        'cbTestFTPEDI
        '
        Me.cbTestFTPEDI.Location = New System.Drawing.Point(639, 377)
        Me.cbTestFTPEDI.Name = "cbTestFTPEDI"
        Me.cbTestFTPEDI.Size = New System.Drawing.Size(89, 25)
        Me.cbTestFTPEDI.TabIndex = 27
        Me.cbTestFTPEDI.Text = "Test"
        Me.cbTestFTPEDI.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 424)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Rép distant :"
        '
        'tbFTPEDIRep
        '
        Me.tbFTPEDIRep.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_REP", True))
        Me.tbFTPEDIRep.Location = New System.Drawing.Point(105, 417)
        Me.tbFTPEDIRep.Name = "tbFTPEDIRep"
        Me.tbFTPEDIRep.Size = New System.Drawing.Size(432, 20)
        Me.tbFTPEDIRep.TabIndex = 24
        '
        'tbFTPEDIPwd
        '
        Me.tbFTPEDIPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_PWD", True))
        Me.tbFTPEDIPwd.Location = New System.Drawing.Point(318, 391)
        Me.tbFTPEDIPwd.Name = "tbFTPEDIPwd"
        Me.tbFTPEDIPwd.Size = New System.Drawing.Size(219, 20)
        Me.tbFTPEDIPwd.TabIndex = 23
        '
        'tbFTPEDIUser
        '
        Me.tbFTPEDIUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_USER", True))
        Me.tbFTPEDIUser.Location = New System.Drawing.Point(105, 391)
        Me.tbFTPEDIUser.Name = "tbFTPEDIUser"
        Me.tbFTPEDIUser.Size = New System.Drawing.Size(203, 20)
        Me.tbFTPEDIUser.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 391)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Utilisateur :"
        '
        'tbFTPEDIPort
        '
        Me.tbFTPEDIPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_PORT", True))
        Me.tbFTPEDIPort.Location = New System.Drawing.Point(553, 362)
        Me.tbFTPEDIPort.Name = "tbFTPEDIPort"
        Me.tbFTPEDIPort.Size = New System.Drawing.Size(36, 20)
        Me.tbFTPEDIPort.TabIndex = 20
        '
        'tbFTPEDISRV
        '
        Me.tbFTPEDISRV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_FTPEDI_SRV", True))
        Me.tbFTPEDISRV.Location = New System.Drawing.Point(105, 362)
        Me.tbFTPEDISRV.Name = "tbFTPEDISRV"
        Me.tbFTPEDISRV.Size = New System.Drawing.Size(432, 20)
        Me.tbFTPEDISRV.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Serveur :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 337)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "FTP EDI Retour de livraison"
        '
        'tbEDI_Destinataire
        '
        Me.tbEDI_Destinataire.Controls.Add(Me.ckWEBEDI_SSL)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_Destinataire)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label28)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_SMTPPWD)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label27)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_SMTPuser)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label26)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_TEMP)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label8)
        Me.tbEDI_Destinataire.Controls.Add(Me.cbTestWebEdi)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_SMTPFROM)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label7)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_SMTPPORT)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label6)
        Me.tbEDI_Destinataire.Controls.Add(Me.Label5)
        Me.tbEDI_Destinataire.Controls.Add(Me.tbWEBEDI_SMTPHOST)
        Me.tbEDI_Destinataire.Location = New System.Drawing.Point(4, 22)
        Me.tbEDI_Destinataire.Name = "tbEDI_Destinataire"
        Me.tbEDI_Destinataire.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEDI_Destinataire.Size = New System.Drawing.Size(768, 479)
        Me.tbEDI_Destinataire.TabIndex = 7
        Me.tbEDI_Destinataire.Text = "WEBEDI"
        Me.tbEDI_Destinataire.UseVisualStyleBackColor = True
        '
        'ckWEBEDI_SSL
        '
        Me.ckWEBEDI_SSL.AutoSize = True
        Me.ckWEBEDI_SSL.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "CST_EDI_SSL", True))
        Me.ckWEBEDI_SSL.Location = New System.Drawing.Point(233, 50)
        Me.ckWEBEDI_SSL.Name = "ckWEBEDI_SSL"
        Me.ckWEBEDI_SSL.Size = New System.Drawing.Size(46, 17)
        Me.ckWEBEDI_SSL.TabIndex = 15
        Me.ckWEBEDI_SSL.Text = "SSL"
        Me.ckWEBEDI_SSL.UseVisualStyleBackColor = True
        '
        'tbWEBEDI_Destinataire
        '
        Me.tbWEBEDI_Destinataire.Location = New System.Drawing.Point(120, 231)
        Me.tbWEBEDI_Destinataire.Name = "tbWEBEDI_Destinataire"
        Me.tbWEBEDI_Destinataire.Size = New System.Drawing.Size(415, 20)
        Me.tbWEBEDI_Destinataire.TabIndex = 14
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 234)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 13)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Destinataire de test "
        '
        'tbWEBEDI_SMTPPWD
        '
        Me.tbWEBEDI_SMTPPWD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_PWD", True))
        Me.tbWEBEDI_SMTPPWD.Location = New System.Drawing.Point(105, 101)
        Me.tbWEBEDI_SMTPPWD.Name = "tbWEBEDI_SMTPPWD"
        Me.tbWEBEDI_SMTPPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbWEBEDI_SMTPPWD.Size = New System.Drawing.Size(430, 20)
        Me.tbWEBEDI_SMTPPWD.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 101)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "SMTP pwd :"
        '
        'tbWEBEDI_SMTPuser
        '
        Me.tbWEBEDI_SMTPuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_USER", True))
        Me.tbWEBEDI_SMTPuser.Location = New System.Drawing.Point(105, 73)
        Me.tbWEBEDI_SMTPuser.Name = "tbWEBEDI_SMTPuser"
        Me.tbWEBEDI_SMTPuser.Size = New System.Drawing.Size(430, 20)
        Me.tbWEBEDI_SMTPuser.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "SMTP user :"
        '
        'tbWEBEDI_TEMP
        '
        Me.tbWEBEDI_TEMP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_TEMP", True))
        Me.tbWEBEDI_TEMP.Location = New System.Drawing.Point(105, 166)
        Me.tbWEBEDI_TEMP.Name = "tbWEBEDI_TEMP"
        Me.tbWEBEDI_TEMP.Size = New System.Drawing.Size(432, 20)
        Me.tbWEBEDI_TEMP.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Répertoire Temporaire"
        '
        'cbTestWebEdi
        '
        Me.cbTestWebEdi.Location = New System.Drawing.Point(630, 228)
        Me.cbTestWebEdi.Name = "cbTestWebEdi"
        Me.cbTestWebEdi.Size = New System.Drawing.Size(110, 24)
        Me.cbTestWebEdi.TabIndex = 6
        Me.cbTestWebEdi.Text = "TEST"
        Me.cbTestWebEdi.UseVisualStyleBackColor = True
        '
        'tbWEBEDI_SMTPFROM
        '
        Me.tbWEBEDI_SMTPFROM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_FROM", True))
        Me.tbWEBEDI_SMTPFROM.Location = New System.Drawing.Point(105, 127)
        Me.tbWEBEDI_SMTPFROM.Name = "tbWEBEDI_SMTPFROM"
        Me.tbWEBEDI_SMTPFROM.Size = New System.Drawing.Size(432, 20)
        Me.tbWEBEDI_SMTPFROM.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SMTP From :"
        '
        'tbWEBEDI_SMTPPORT
        '
        Me.tbWEBEDI_SMTPPORT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_PORT", True))
        Me.tbWEBEDI_SMTPPORT.Location = New System.Drawing.Point(105, 46)
        Me.tbWEBEDI_SMTPPORT.Name = "tbWEBEDI_SMTPPORT"
        Me.tbWEBEDI_SMTPPORT.Size = New System.Drawing.Size(87, 20)
        Me.tbWEBEDI_SMTPPORT.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SMTP Port :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SMTP Host :"
        '
        'tbWEBEDI_SMTPHOST
        '
        Me.tbWEBEDI_SMTPHOST.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_EDI_HOST", True))
        Me.tbWEBEDI_SMTPHOST.Location = New System.Drawing.Point(105, 20)
        Me.tbWEBEDI_SMTPHOST.Name = "tbWEBEDI_SMTPHOST"
        Me.tbWEBEDI_SMTPHOST.Size = New System.Drawing.Size(433, 20)
        Me.tbWEBEDI_SMTPHOST.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ckCheck)
        Me.TabPage7.Controls.Add(Me.tbImapNSec)
        Me.TabPage7.Controls.Add(Me.Label13)
        Me.TabPage7.Controls.Add(Me.tbImapFolder)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Controls.Add(Me.tbImport)
        Me.TabPage7.Controls.Add(Me.tbImapPwd)
        Me.TabPage7.Controls.Add(Me.Label12)
        Me.TabPage7.Controls.Add(Me.ckImapSSL)
        Me.TabPage7.Controls.Add(Me.tbImapUser)
        Me.TabPage7.Controls.Add(Me.Label11)
        Me.TabPage7.Controls.Add(Me.Label10)
        Me.TabPage7.Controls.Add(Me.tbImapPort)
        Me.TabPage7.Controls.Add(Me.tbImapHost)
        Me.TabPage7.Controls.Add(Me.Label9)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(768, 479)
        Me.TabPage7.TabIndex = 8
        Me.TabPage7.Text = "PrestaShop"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ckCheck
        '
        Me.ckCheck.AutoSize = True
        Me.ckCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckCheck.Checked = True
        Me.ckCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckCheck.Location = New System.Drawing.Point(186, 158)
        Me.ckCheck.Name = "ckCheck"
        Me.ckCheck.Size = New System.Drawing.Size(118, 17)
        Me.ckCheck.TabIndex = 16
        Me.ckCheck.Text = "Check avant import"
        Me.ckCheck.UseVisualStyleBackColor = True
        '
        'tbImapNSec
        '
        Me.tbImapNSec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_NSEC", True))
        Me.tbImapNSec.Location = New System.Drawing.Point(186, 135)
        Me.tbImapNSec.Name = "tbImapNSec"
        Me.tbImapNSec.Size = New System.Drawing.Size(45, 20)
        Me.tbImapNSec.TabIndex = 15
        Me.tbImapNSec.Text = "30"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Intervalle de traitement (Service) :"
        '
        'tbImapFolder
        '
        Me.tbImapFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_MSGFOLDER", True))
        Me.tbImapFolder.Location = New System.Drawing.Point(169, 102)
        Me.tbImapFolder.Name = "tbImapFolder"
        Me.tbImapFolder.Size = New System.Drawing.Size(243, 20)
        Me.tbImapFolder.TabIndex = 13
        Me.tbImapFolder.Text = "MSGTRAITES"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Dossiers Commandes traitées :"
        '
        'tbImport
        '
        Me.tbImport.Location = New System.Drawing.Point(312, 153)
        Me.tbImport.Name = "tbImport"
        Me.tbImport.Size = New System.Drawing.Size(75, 23)
        Me.tbImport.TabIndex = 9
        Me.tbImport.Text = "TEST"
        Me.tbImport.UseVisualStyleBackColor = True
        '
        'tbImapPwd
        '
        Me.tbImapPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_PWD", True))
        Me.tbImapPwd.Location = New System.Drawing.Point(312, 46)
        Me.tbImapPwd.Name = "tbImapPwd"
        Me.tbImapPwd.Size = New System.Drawing.Size(100, 20)
        Me.tbImapPwd.TabIndex = 8
        Me.tbImapPwd.Text = "vinicom35760"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(247, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Password :"
        '
        'ckImapSSL
        '
        Me.ckImapSSL.AutoSize = True
        Me.ckImapSSL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckImapSSL.Checked = True
        Me.ckImapSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckImapSSL.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "CST_IMAP_SSL", True))
        Me.ckImapSSL.Location = New System.Drawing.Point(322, 18)
        Me.ckImapSSL.Name = "ckImapSSL"
        Me.ckImapSSL.Size = New System.Drawing.Size(46, 17)
        Me.ckImapSSL.TabIndex = 6
        Me.ckImapSSL.Text = "SSL"
        Me.ckImapSSL.UseVisualStyleBackColor = True
        '
        'tbImapUser
        '
        Me.tbImapUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_USER", True))
        Me.tbImapUser.Location = New System.Drawing.Point(131, 46)
        Me.tbImapUser.Name = "tbImapUser"
        Me.tbImapUser.Size = New System.Drawing.Size(100, 20)
        Me.tbImapUser.TabIndex = 5
        Me.tbImapUser.Text = "cmdprestashop@vinicom.fr"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Imap user"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Port :"
        '
        'tbImapPort
        '
        Me.tbImapPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_PORT", True))
        Me.tbImapPort.Location = New System.Drawing.Point(275, 16)
        Me.tbImapPort.Name = "tbImapPort"
        Me.tbImapPort.Size = New System.Drawing.Size(29, 20)
        Me.tbImapPort.TabIndex = 2
        Me.tbImapPort.Text = "143"
        '
        'tbImapHost
        '
        Me.tbImapHost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_IMAP_HOST", True))
        Me.tbImapHost.Location = New System.Drawing.Point(131, 16)
        Me.tbImapHost.Name = "tbImapHost"
        Me.tbImapHost.Size = New System.Drawing.Size(100, 20)
        Me.tbImapHost.TabIndex = 1
        Me.tbImapHost.Text = "192.168.0.240"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nom du serveur IMAP :"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.FTP_LOCKTOFILENAMELabel)
        Me.TabPage6.Controls.Add(Me.FTP_LOCKTOFILENAMETextBox)
        Me.TabPage6.Controls.Add(Me.FTP_LOCKFROMFILENAMELabel)
        Me.TabPage6.Controls.Add(Me.FTP_LOCKFROMFILENAMETextBox)
        Me.TabPage6.Controls.Add(Me.FTP_REMOTEDIRLabel)
        Me.TabPage6.Controls.Add(Me.FTP_REMOTEDIRTextBox)
        Me.TabPage6.Controls.Add(Me.FTP_PASSWORDLabel)
        Me.TabPage6.Controls.Add(Me.FTP_PASSWORDTextBox)
        Me.TabPage6.Controls.Add(Me.FTP_USERNAMELabel)
        Me.TabPage6.Controls.Add(Me.FTP_USERNAMETextBox)
        Me.TabPage6.Controls.Add(Me.FTP_HOSTNAMELabel)
        Me.TabPage6.Controls.Add(Me.FTP_HOSTNAMETextBox)
        Me.TabPage6.Controls.Add(Me.Label19)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(768, 479)
        Me.TabPage6.TabIndex = 9
        Me.TabPage6.Text = "FTP SERES"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(327, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 13)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Site inutilisé "
        '
        'FTP_LOCKTOFILENAMELabel
        '
        Me.FTP_LOCKTOFILENAMELabel.AutoSize = True
        Me.FTP_LOCKTOFILENAMELabel.Location = New System.Drawing.Point(7, 163)
        Me.FTP_LOCKTOFILENAMELabel.Name = "FTP_LOCKTOFILENAMELabel"
        Me.FTP_LOCKTOFILENAMELabel.Size = New System.Drawing.Size(129, 13)
        Me.FTP_LOCKTOFILENAMELabel.TabIndex = 24
        Me.FTP_LOCKTOFILENAMELabel.Text = "FTP LOCKTOFILENAME:"
        '
        'FTP_LOCKTOFILENAMETextBox
        '
        Me.FTP_LOCKTOFILENAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_LOCKTOFILENAME", True))
        Me.FTP_LOCKTOFILENAMETextBox.Location = New System.Drawing.Point(187, 160)
        Me.FTP_LOCKTOFILENAMETextBox.Name = "FTP_LOCKTOFILENAMETextBox"
        Me.FTP_LOCKTOFILENAMETextBox.Size = New System.Drawing.Size(201, 20)
        Me.FTP_LOCKTOFILENAMETextBox.TabIndex = 25
        '
        'FTP_LOCKFROMFILENAMELabel
        '
        Me.FTP_LOCKFROMFILENAMELabel.AutoSize = True
        Me.FTP_LOCKFROMFILENAMELabel.Location = New System.Drawing.Point(7, 137)
        Me.FTP_LOCKFROMFILENAMELabel.Name = "FTP_LOCKFROMFILENAMELabel"
        Me.FTP_LOCKFROMFILENAMELabel.Size = New System.Drawing.Size(145, 13)
        Me.FTP_LOCKFROMFILENAMELabel.TabIndex = 22
        Me.FTP_LOCKFROMFILENAMELabel.Text = "FTP LOCKFROMFILENAME:"
        '
        'FTP_LOCKFROMFILENAMETextBox
        '
        Me.FTP_LOCKFROMFILENAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_LOCKFROMFILENAME", True))
        Me.FTP_LOCKFROMFILENAMETextBox.Location = New System.Drawing.Point(187, 134)
        Me.FTP_LOCKFROMFILENAMETextBox.Name = "FTP_LOCKFROMFILENAMETextBox"
        Me.FTP_LOCKFROMFILENAMETextBox.Size = New System.Drawing.Size(201, 20)
        Me.FTP_LOCKFROMFILENAMETextBox.TabIndex = 23
        '
        'FTP_REMOTEDIRLabel
        '
        Me.FTP_REMOTEDIRLabel.AutoSize = True
        Me.FTP_REMOTEDIRLabel.Location = New System.Drawing.Point(5, 111)
        Me.FTP_REMOTEDIRLabel.Name = "FTP_REMOTEDIRLabel"
        Me.FTP_REMOTEDIRLabel.Size = New System.Drawing.Size(98, 13)
        Me.FTP_REMOTEDIRLabel.TabIndex = 20
        Me.FTP_REMOTEDIRLabel.Text = "FTP REMOTEDIR:"
        '
        'FTP_REMOTEDIRTextBox
        '
        Me.FTP_REMOTEDIRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_REMOTEDIR", True))
        Me.FTP_REMOTEDIRTextBox.Location = New System.Drawing.Point(187, 108)
        Me.FTP_REMOTEDIRTextBox.Name = "FTP_REMOTEDIRTextBox"
        Me.FTP_REMOTEDIRTextBox.Size = New System.Drawing.Size(438, 20)
        Me.FTP_REMOTEDIRTextBox.TabIndex = 21
        '
        'FTP_PASSWORDLabel
        '
        Me.FTP_PASSWORDLabel.AutoSize = True
        Me.FTP_PASSWORDLabel.Location = New System.Drawing.Point(7, 85)
        Me.FTP_PASSWORDLabel.Name = "FTP_PASSWORDLabel"
        Me.FTP_PASSWORDLabel.Size = New System.Drawing.Size(96, 13)
        Me.FTP_PASSWORDLabel.TabIndex = 18
        Me.FTP_PASSWORDLabel.Text = "FTP PASSWORD:"
        '
        'FTP_PASSWORDTextBox
        '
        Me.FTP_PASSWORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_PASSWORD", True))
        Me.FTP_PASSWORDTextBox.Location = New System.Drawing.Point(187, 82)
        Me.FTP_PASSWORDTextBox.Name = "FTP_PASSWORDTextBox"
        Me.FTP_PASSWORDTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FTP_PASSWORDTextBox.TabIndex = 19
        '
        'FTP_USERNAMELabel
        '
        Me.FTP_USERNAMELabel.AutoSize = True
        Me.FTP_USERNAMELabel.Location = New System.Drawing.Point(5, 59)
        Me.FTP_USERNAMELabel.Name = "FTP_USERNAMELabel"
        Me.FTP_USERNAMELabel.Size = New System.Drawing.Size(94, 13)
        Me.FTP_USERNAMELabel.TabIndex = 16
        Me.FTP_USERNAMELabel.Text = "FTP USERNAME:"
        '
        'FTP_USERNAMETextBox
        '
        Me.FTP_USERNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_USERNAME", True))
        Me.FTP_USERNAMETextBox.Location = New System.Drawing.Point(187, 56)
        Me.FTP_USERNAMETextBox.Name = "FTP_USERNAMETextBox"
        Me.FTP_USERNAMETextBox.Size = New System.Drawing.Size(201, 20)
        Me.FTP_USERNAMETextBox.TabIndex = 17
        '
        'FTP_HOSTNAMELabel
        '
        Me.FTP_HOSTNAMELabel.AutoSize = True
        Me.FTP_HOSTNAMELabel.Location = New System.Drawing.Point(5, 37)
        Me.FTP_HOSTNAMELabel.Name = "FTP_HOSTNAMELabel"
        Me.FTP_HOSTNAMELabel.Size = New System.Drawing.Size(94, 13)
        Me.FTP_HOSTNAMELabel.TabIndex = 14
        Me.FTP_HOSTNAMELabel.Text = "FTP HOSTNAME:"
        '
        'FTP_HOSTNAMETextBox
        '
        Me.FTP_HOSTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FTP_HOSTNAME", True))
        Me.FTP_HOSTNAMETextBox.Location = New System.Drawing.Point(187, 30)
        Me.FTP_HOSTNAMETextBox.Name = "FTP_HOSTNAMETextBox"
        Me.FTP_HOSTNAMETextBox.Size = New System.Drawing.Size(201, 20)
        Me.FTP_HOSTNAMETextBox.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(290, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "FTP Espace Fournisseur SERES (Bon à Facturer):"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnCorpsFactCom)
        Me.TabPage8.Controls.Add(Me.btnCorpsFactTrp)
        Me.TabPage8.Controls.Add(Me.btnCorpsFactColisage)
        Me.TabPage8.Controls.Add(Me.Label51)
        Me.TabPage8.Controls.Add(Me.CheckBox3)
        Me.TabPage8.Controls.Add(Me.TextBox17)
        Me.TabPage8.Controls.Add(Me.Label52)
        Me.TabPage8.Controls.Add(Me.TextBox18)
        Me.TabPage8.Controls.Add(Me.TextBox19)
        Me.TabPage8.Controls.Add(Me.Label53)
        Me.TabPage8.Controls.Add(Me.Button3)
        Me.TabPage8.Controls.Add(Me.TextBox20)
        Me.TabPage8.Controls.Add(Me.Label54)
        Me.TabPage8.Controls.Add(Me.TextBox21)
        Me.TabPage8.Controls.Add(Me.Label55)
        Me.TabPage8.Controls.Add(Me.TextBox22)
        Me.TabPage8.Controls.Add(Me.Label42)
        Me.TabPage8.Controls.Add(Me.CheckBox2)
        Me.TabPage8.Controls.Add(Me.TextBox8)
        Me.TabPage8.Controls.Add(Me.Label44)
        Me.TabPage8.Controls.Add(Me.TextBox12)
        Me.TabPage8.Controls.Add(Me.TextBox13)
        Me.TabPage8.Controls.Add(Me.Label46)
        Me.TabPage8.Controls.Add(Me.Button2)
        Me.TabPage8.Controls.Add(Me.TextBox14)
        Me.TabPage8.Controls.Add(Me.Label49)
        Me.TabPage8.Controls.Add(Me.TextBox15)
        Me.TabPage8.Controls.Add(Me.Label50)
        Me.TabPage8.Controls.Add(Me.TextBox16)
        Me.TabPage8.Controls.Add(Me.Label48)
        Me.TabPage8.Controls.Add(Me.CheckBox1)
        Me.TabPage8.Controls.Add(Me.TextBox5)
        Me.TabPage8.Controls.Add(Me.Label41)
        Me.TabPage8.Controls.Add(Me.TextBox6)
        Me.TabPage8.Controls.Add(Me.TextBox7)
        Me.TabPage8.Controls.Add(Me.Label43)
        Me.TabPage8.Controls.Add(Me.Button1)
        Me.TabPage8.Controls.Add(Me.TextBox9)
        Me.TabPage8.Controls.Add(Me.Label45)
        Me.TabPage8.Controls.Add(Me.TextBox10)
        Me.TabPage8.Controls.Add(Me.Label47)
        Me.TabPage8.Controls.Add(Me.TextBox11)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(768, 479)
        Me.TabPage8.TabIndex = 10
        Me.TabPage8.Text = "Messagerie Factures"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnCorpsFactCom
        '
        Me.btnCorpsFactCom.Location = New System.Drawing.Point(649, 342)
        Me.btnCorpsFactCom.Name = "btnCorpsFactCom"
        Me.btnCorpsFactCom.Size = New System.Drawing.Size(75, 40)
        Me.btnCorpsFactCom.TabIndex = 61
        Me.btnCorpsFactCom.Text = "Corps du message"
        Me.btnCorpsFactCom.UseVisualStyleBackColor = True
        '
        'btnCorpsFactTrp
        '
        Me.btnCorpsFactTrp.Location = New System.Drawing.Point(649, 200)
        Me.btnCorpsFactTrp.Name = "btnCorpsFactTrp"
        Me.btnCorpsFactTrp.Size = New System.Drawing.Size(75, 40)
        Me.btnCorpsFactTrp.TabIndex = 60
        Me.btnCorpsFactTrp.Text = "Corps du message"
        Me.btnCorpsFactTrp.UseVisualStyleBackColor = True
        '
        'btnCorpsFactColisage
        '
        Me.btnCorpsFactColisage.Location = New System.Drawing.Point(649, 47)
        Me.btnCorpsFactColisage.Name = "btnCorpsFactColisage"
        Me.btnCorpsFactColisage.Size = New System.Drawing.Size(75, 40)
        Me.btnCorpsFactColisage.TabIndex = 59
        Me.btnCorpsFactColisage.Text = "Corps du message"
        Me.btnCorpsFactColisage.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 291)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(297, 13)
        Me.Label51.TabIndex = 58
        Me.Label51.Text = "Paramétres pour la transmission des factures de commission : "
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(490, 319)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox3.TabIndex = 57
        Me.CheckBox3.Text = "SSL"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(150, 398)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(415, 20)
        Me.TextBox17.TabIndex = 56
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(22, 401)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(101, 13)
        Me.Label52.TabIndex = 55
        Me.Label52.Text = "Destinataire de test "
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(323, 342)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox18.Size = New System.Drawing.Size(242, 20)
        Me.TextBox18.TabIndex = 54
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(135, 342)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(174, 20)
        Me.TextBox19.TabIndex = 53
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(38, 342)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(66, 13)
        Me.Label53.TabIndex = 52
        Me.Label53.Text = "SMTP user :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(630, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 24)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "TEST"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(135, 368)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(432, 20)
        Me.TextBox20.TabIndex = 50
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(35, 371)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(69, 13)
        Me.Label54.TabIndex = 49
        Me.Label54.Text = "SMTP From :"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(397, 316)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(87, 20)
        Me.TextBox21.TabIndex = 48
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(36, 320)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(68, 13)
        Me.Label55.TabIndex = 47
        Me.Label55.Text = "SMTP Host :"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(135, 316)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(259, 20)
        Me.TextBox22.TabIndex = 46
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 149)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(281, 13)
        Me.Label42.TabIndex = 45
        Me.Label42.Text = "Paramétres pour la transmission des factures de transport :"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(490, 177)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 44
        Me.CheckBox2.Text = "SSL"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(150, 256)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(415, 20)
        Me.TextBox8.TabIndex = 43
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(22, 259)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(101, 13)
        Me.Label44.TabIndex = 42
        Me.Label44.Text = "Destinataire de test "
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(323, 200)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox12.Size = New System.Drawing.Size(242, 20)
        Me.TextBox12.TabIndex = 41
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(135, 200)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(174, 20)
        Me.TextBox13.TabIndex = 40
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(38, 200)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(66, 13)
        Me.Label46.TabIndex = 39
        Me.Label46.Text = "SMTP user :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(630, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 24)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "TEST"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(135, 226)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(432, 20)
        Me.TextBox14.TabIndex = 37
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(35, 229)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 13)
        Me.Label49.TabIndex = 36
        Me.Label49.Text = "SMTP From :"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(397, 174)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(87, 20)
        Me.TextBox15.TabIndex = 35
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(36, 178)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(68, 13)
        Me.Label50.TabIndex = 34
        Me.Label50.Text = "SMTP Host :"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(135, 174)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(259, 20)
        Me.TextBox16.TabIndex = 33
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(9, 7)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(279, 13)
        Me.Label48.TabIndex = 32
        Me.Label48.Text = "Paramétres pour la transmission des factures de colisage :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(493, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "SSL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(153, 114)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(415, 20)
        Me.TextBox5.TabIndex = 30
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(25, 117)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(101, 13)
        Me.Label41.TabIndex = 29
        Me.Label41.Text = "Destinataire de test "
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(326, 58)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox6.Size = New System.Drawing.Size(242, 20)
        Me.TextBox6.TabIndex = 28
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(138, 58)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(174, 20)
        Me.TextBox7.TabIndex = 26
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(41, 58)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(66, 13)
        Me.Label43.TabIndex = 25
        Me.Label43.Text = "SMTP user :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(633, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "TEST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(138, 84)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(432, 20)
        Me.TextBox9.TabIndex = 21
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(38, 87)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(69, 13)
        Me.Label45.TabIndex = 20
        Me.Label45.Text = "SMTP From :"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(400, 32)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(87, 20)
        Me.TextBox10.TabIndex = 19
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(39, 36)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(68, 13)
        Me.Label47.TabIndex = 17
        Me.Label47.Text = "SMTP Host :"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(138, 32)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(259, 20)
        Me.TextBox11.TabIndex = 16
        '
        'CST_VERSION_BDTextBox
        '
        Me.CST_VERSION_BDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CST_VERSION_BDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CST_VERSION_BD", True))
        Me.CST_VERSION_BDTextBox.Location = New System.Drawing.Point(676, 6)
        Me.CST_VERSION_BDTextBox.Name = "CST_VERSION_BDTextBox"
        Me.CST_VERSION_BDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CST_VERSION_BDTextBox.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(458, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Date : "
        '
        'dtpdateMAj
        '
        Me.dtpdateMAj.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpdateMAj.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdateMAj.Location = New System.Drawing.Point(518, 6)
        Me.dtpdateMAj.Name = "dtpdateMAj"
        Me.dtpdateMAj.Size = New System.Drawing.Size(152, 20)
        Me.dtpdateMAj.TabIndex = 4
        '
        'frmConstantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(788, 540)
        Me.Controls.Add(Me.dtpdateMAj)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.CST_VERSION_BDLabel)
        Me.Controls.Add(Me.CST_VERSION_BDTextBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmConstantes"
        Me.Text = "Gestion des constantes"
        Me.TabControl1.ResumeLayout(False)
        Me.tabVinicom.ResumeLayout(False)
        Me.tabVinicom.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVinicom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVinidis.ResumeLayout(False)
        Me.TabVinidis.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.tbEDI_Destinataire.ResumeLayout(False)
        Me.tbEDI_Destinataire.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabVinicom As System.Windows.Forms.TabPage
    Friend WithEvents TabVinidis As System.Windows.Forms.TabPage
    Friend WithEvents CST_SOC_EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_PORTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_FAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_ADRESSE_VILLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_ADRESSE_CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_ADRESSE_RUE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_ADRESSE_RUE1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_NOMSOCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_ADRESSE_VILLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_ADRESSE_CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_ADRESSE_RUE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_ADRESSE_RUE1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_NOMSOCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_PORTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_FAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CST_PLTFRM_EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_PORTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_FAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_VILLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_RUE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_RUE1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PLTFRM_NOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_RCSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_TVAINTRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CST_DERN_NUM_FACT_COLISAGETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_DERN_NUM_FACT_TRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_DERN_NUM_FACTCOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_DERN_NUM_BATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_DERN_NUM_SCMDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_DERN_NUM_CMD_CLTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_LICENCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC1_CMPT_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC1_CMPT_TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_CMPT_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_CMPT_TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_LICENCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_RCSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC2_TVAINTRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PATH_FACTCOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CST_VERSION_BDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PATH_FACTTRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_TRP_IDMODEREGLEMENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_TAXES_TRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_TX_COMMISSIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_FACT_COL_TAXESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_COL_IDMODEREGLEMENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PU_PALL_NONPREPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_PU_PALL_PREPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_TRP_TXGAZOLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CST_FACT_COL_PU_COLISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCompteBanque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCodeBanque2 As System.Windows.Forms.TextBox
    Friend WithEvents tbSOC2COMPTPROD2 As System.Windows.Forms.TextBox
    Friend WithEvents CST_SOC_NOMSOCLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_ADRESSE_RUE1Label As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_TELLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_FAXLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_PORTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_EMAILLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_NOMSOCLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_ADRESSE_RUE1Label As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_TELLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_FAXLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_PORTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_EMAILLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_NOMLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_RUE1Label As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_TELLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_FAXLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_PORTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PLTFRM_EMAILLabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_CMD_CLTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_SCMDLabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_BALabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_FACTCOMLabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_FACT_TRPLabel As System.Windows.Forms.Label
    Friend WithEvents CST_DERN_NUM_FACT_COLISAGELabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_TVAINTRALabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_RCSLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC_LICENCELabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC1_CMPT_TVALabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC1_CMPT_PRODLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_TVAINTRALabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_RCSLabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_LICENCELabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_CMPT_TVALabel As System.Windows.Forms.Label
    Friend WithEvents CST_SOC2_CMPT_PRODLabel As System.Windows.Forms.Label
    Friend WithEvents CST_VERSION_BDLabel As System.Windows.Forms.Label
    Friend WithEvents CST_TX_COMMISSIONLabel As System.Windows.Forms.Label
    Friend WithEvents CST_TAXES_TRPLabel As System.Windows.Forms.Label
    Friend WithEvents CST_TRP_IDMODEREGLEMENTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_TRP_TXGAZOLELabel As System.Windows.Forms.Label
    Friend WithEvents CST_PU_PALL_PREPLabel As System.Windows.Forms.Label
    Friend WithEvents CST_PU_PALL_NONPREPLabel As System.Windows.Forms.Label
    Friend WithEvents CST_COL_IDMODEREGLEMENTLabel As System.Windows.Forms.Label
    Friend WithEvents CST_FACT_COL_TAXESLabel As System.Windows.Forms.Label
    Friend WithEvents CST_FACT_COL_PU_COLISLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbEDI_Destinataire As System.Windows.Forms.TabPage
    Friend WithEvents cbTestWebEdi As System.Windows.Forms.Button
    Friend WithEvents tbWEBEDI_SMTPFROM As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbWEBEDI_SMTPPORT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWEBEDI_SMTPHOST As System.Windows.Forms.TextBox
    Friend WithEvents tbWEBEDI_TEMP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents tbImapHost As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbImapPort As System.Windows.Forms.TextBox
    Friend WithEvents ckImapSSL As System.Windows.Forms.CheckBox
    Friend WithEvents tbImapUser As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbImapPwd As System.Windows.Forms.TextBox
    Friend WithEvents tbImapNSec As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbImapFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbImport As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpdateMAj As DateTimePicker
    Friend WithEvents tbWEBEDI_SMTPPWD As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbWEBEDI_SMTPuser As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tbWEBEDI_Destinataire As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents ckWEBEDI_SSL As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label22 As Label
    Friend WithEvents tbFTPEDIRepLocal As TextBox
    Friend WithEvents cbTestFTPEDI As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents tbFTPEDIRep As TextBox
    Friend WithEvents tbFTPEDIPwd As TextBox
    Friend WithEvents tbFTPEDIUser As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbFTPEDIPort As TextBox
    Friend WithEvents tbFTPEDISRV As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents FTP_LOCKTOFILENAMELabel As Label
    Friend WithEvents FTP_LOCKTOFILENAMETextBox As TextBox
    Friend WithEvents FTP_LOCKFROMFILENAMELabel As Label
    Friend WithEvents FTP_LOCKFROMFILENAMETextBox As TextBox
    Friend WithEvents FTP_REMOTEDIRLabel As Label
    Friend WithEvents FTP_REMOTEDIRTextBox As TextBox
    Friend WithEvents FTP_PASSWORDLabel As Label
    Friend WithEvents FTP_PASSWORDTextBox As TextBox
    Friend WithEvents FTP_USERNAMELabel As Label
    Friend WithEvents FTP_USERNAMETextBox As TextBox
    Friend WithEvents FTP_HOSTNAMELabel As Label
    Friend WithEvents FTP_HOSTNAMETextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnTestFTPvnd As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents tbftnvnd_remoteDir As TextBox
    Friend WithEvents tbftpvnd_password As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents tbftpvnd_User As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents tbftpvnd_host As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tbftpVND_URL As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DsVinicom1 As vini_DB.dsVinicom
    Friend WithEvents tbFTPVNCURL As TextBox
    Friend WithEvents tbFTPVNCRemoteDir As TextBox
    Friend WithEvents tbFTPVNCPassword As TextBox
    Friend WithEvents tbFTPVNCUser As TextBox
    Friend WithEvents tbFTPVNCHost As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents tbFTPVNCRemoteDir2 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents tbFTPVNCUrl2 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents btnTestFTPvnc As Button
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label42 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents btnCorpsFactCom As Button
    Friend WithEvents btnCorpsFactTrp As Button
    Friend WithEvents btnCorpsFactColisage As Button
    Friend WithEvents ckCheck As CheckBox
End Class
