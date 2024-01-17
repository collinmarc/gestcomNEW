Option Explicit On 
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Public Class frmStatCAClientProducteur
    Inherits frmStatistiques

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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDateDeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtDateFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCodeFournisseur As System.Windows.Forms.TextBox
    Friend WithEvents cbAfficher As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxOrigine As System.Windows.Forms.ComboBox
    'Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbRechercherClient As Button
    Friend WithEvents dbRechercherFournisseur As Button
    Friend WithEvents tbCodeclient As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        'Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDateDeb = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtDateFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCodeclient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCodeFournisseur = New System.Windows.Forms.TextBox()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxOrigine = New System.Windows.Forms.ComboBox()
        Me.cbRechercherClient = New System.Windows.Forms.Button()
        Me.dbRechercherFournisseur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(13, 77)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(927, 557)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date de debut :"
        '
        'dtDateDeb
        '
        Me.dtDateDeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateDeb.Location = New System.Drawing.Point(99, 9)
        Me.dtDateDeb.Name = "dtDateDeb"
        Me.dtDateDeb.Size = New System.Drawing.Size(96, 20)
        Me.dtDateDeb.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date de fin : "
        '
        'dtDateFin
        '
        Me.dtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateFin.Location = New System.Drawing.Point(286, 9)
        Me.dtDateFin.Name = "dtDateFin"
        Me.dtDateFin.Size = New System.Drawing.Size(90, 20)
        Me.dtDateFin.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Code client :"
        '
        'tbCodeclient
        '
        Me.tbCodeclient.Location = New System.Drawing.Point(468, 9)
        Me.tbCodeclient.Name = "tbCodeclient"
        Me.tbCodeclient.Size = New System.Drawing.Size(90, 20)
        Me.tbCodeclient.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Code fournisseur :"
        '
        'tbCodeFournisseur
        '
        Me.tbCodeFournisseur.Location = New System.Drawing.Point(468, 38)
        Me.tbCodeFournisseur.Name = "tbCodeFournisseur"
        Me.tbCodeFournisseur.Size = New System.Drawing.Size(90, 20)
        Me.tbCodeFournisseur.TabIndex = 8
        '
        'cbAfficher
        '
        Me.cbAfficher.Location = New System.Drawing.Point(833, 8)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.Size = New System.Drawing.Size(107, 23)
        Me.cbAfficher.TabIndex = 9
        Me.cbAfficher.Text = "Afficher"
        Me.cbAfficher.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Origine :"
        '
        'cbxOrigine
        '
        Me.cbxOrigine.FormattingEnabled = True
        Me.cbxOrigine.Items.AddRange(New Object() {"VINICOM", "HOBIVIN"})
        Me.cbxOrigine.Location = New System.Drawing.Point(99, 35)
        Me.cbxOrigine.Name = "cbxOrigine"
        Me.cbxOrigine.Size = New System.Drawing.Size(96, 21)
        Me.cbxOrigine.TabIndex = 11
        Me.cbxOrigine.Text = "VINICOM"
        '
        'cbRechercherClient
        '
        Me.cbRechercherClient.Location = New System.Drawing.Point(564, 7)
        Me.cbRechercherClient.Name = "cbRechercherClient"
        Me.cbRechercherClient.Size = New System.Drawing.Size(104, 24)
        Me.cbRechercherClient.TabIndex = 12
        Me.cbRechercherClient.Text = "Rechercher"
        '
        'dbRechercherFournisseur
        '
        Me.dbRechercherFournisseur.Location = New System.Drawing.Point(564, 37)
        Me.dbRechercherFournisseur.Name = "dbRechercherFournisseur"
        Me.dbRechercherFournisseur.Size = New System.Drawing.Size(104, 24)
        Me.dbRechercherFournisseur.TabIndex = 13
        Me.dbRechercherFournisseur.Text = "Rechercher"
        '
        'frmStatCAClientProducteur
        '
        Me.ClientSize = New System.Drawing.Size(952, 646)
        Me.Controls.Add(Me.dbRechercherFournisseur)
        Me.Controls.Add(Me.cbRechercherClient)
        Me.Controls.Add(Me.cbxOrigine)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbAfficher)
        Me.Controls.Add(Me.tbCodeFournisseur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCodeclient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtDateFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtDateDeb)
        Me.Name = "frmStatCAClientProducteur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficher.Click
        Dim objReport As ReportDocument
        Dim strCodeClient As String
        Dim strCodeFourn As String
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.GroupTree

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crStatCAClientProducteur.rpt")
        objReport.SetParameterValue("ddeb", Me.dtDateDeb.Value.ToShortDateString())
        objReport.SetParameterValue("dfin", Me.dtDateFin.Value.ToShortDateString())
        strCodeClient = tbCodeclient.Text
        strCodeClient = strCodeClient.Replace("%", "*")
        If String.IsNullOrEmpty(strCodeClient) Then
            strCodeClient = "*"
        End If
        objReport.SetParameterValue("codeClient", strCodeClient)

        strCodeFourn = tbCodeFournisseur.Text
        strCodeFourn = strCodeFourn.Replace("%", "*")
        If String.IsNullOrEmpty(strCodeFourn) Then
            strCodeFourn = "*"
        End If
        objReport.SetParameterValue("codeFourn", strCodeFourn)
        objReport.SetParameterValue("Origine", Trim(cbxOrigine.Text))

        Persist.setReportConnection(objReport)
        CrystalReportViewer1.ReportSource = objReport


    End Sub

    Protected Overrides Sub setToolbarButtons()
        m_ToolBarNewEnabled = False
        m_ToolBarLoadEnabled = False
        m_ToolBarSaveEnabled = False
        m_ToolBarDelEnabled = False
        m_ToolBarRefreshEnabled = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmBilanClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtDateDeb.Value = CDate("01/01/" & Year(DateTime.Now))
    End Sub

    Private Sub cbRechercherClient_Click(sender As Object, e As EventArgs) Handles cbRechercherClient.Click
        rechercheClient()
    End Sub
    Private Sub rechercheClient()
        Dim objTiers As Tiers

        objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.CLIENT, tbCodeclient)

        If Not objTiers Is Nothing Then
            tbCodeclient.Text = objTiers.code
        End If
    End Sub 'rechercheClient
    Private Sub rechercheFournisseur()
        Dim objTiers As Tiers

        objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.FOURNISSEUR, tbCodeFournisseur)

        If Not objTiers Is Nothing Then
            tbCodeFournisseur.Text = objTiers.code
        End If
    End Sub 'rechercheFournisseur

    Private Sub dbRechercherFournisseur_Click(sender As Object, e As EventArgs) Handles dbRechercherFournisseur.Click
        rechercheFournisseur()
    End Sub
End Class
