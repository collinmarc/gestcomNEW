Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Public Class frmListeCommandesTrp
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
    Friend WithEvents cbAfficher As System.Windows.Forms.Button
    Friend WithEvents dtdeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbcodeClient As System.Windows.Forms.TextBox
    Friend WithEvents ckCdeFacturee As System.Windows.Forms.CheckBox
    Friend WithEvents cbRechercher As Button
    Friend WithEvents ckbTransport As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        'Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtdeb = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbcodeClient = New System.Windows.Forms.TextBox()
        Me.ckCdeFacturee = New System.Windows.Forms.CheckBox()
        Me.ckbTransport = New System.Windows.Forms.CheckBox()
        Me.cbRechercher = New System.Windows.Forms.Button()
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date de début"
        '
        'dtdeb
        '
        Me.dtdeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdeb.Location = New System.Drawing.Point(95, 7)
        Me.dtdeb.Name = "dtdeb"
        Me.dtdeb.Size = New System.Drawing.Size(99, 20)
        Me.dtdeb.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(230, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date de fin"
        '
        'dtFin
        '
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(311, 8)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(104, 20)
        Me.dtFin.TabIndex = 1
        '
        'cbAfficher
        '
        Me.cbAfficher.Location = New System.Drawing.Point(872, 8)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.Size = New System.Drawing.Size(120, 23)
        Me.cbAfficher.TabIndex = 5
        Me.cbAfficher.Text = "Afficher"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(432, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code client"
        '
        'tbcodeClient
        '
        Me.tbcodeClient.Location = New System.Drawing.Point(528, 8)
        Me.tbcodeClient.Name = "tbcodeClient"
        Me.tbcodeClient.Size = New System.Drawing.Size(72, 20)
        Me.tbcodeClient.TabIndex = 2
        '
        'ckCdeFacturee
        '
        Me.ckCdeFacturee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckCdeFacturee.Location = New System.Drawing.Point(722, 9)
        Me.ckCdeFacturee.Name = "ckCdeFacturee"
        Me.ckCdeFacturee.Size = New System.Drawing.Size(144, 16)
        Me.ckCdeFacturee.TabIndex = 3
        Me.ckCdeFacturee.Text = "Commandes facturées"
        '
        'ckbTransport
        '
        Me.ckbTransport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbTransport.Location = New System.Drawing.Point(722, 25)
        Me.ckbTransport.Name = "ckbTransport"
        Me.ckbTransport.Size = New System.Drawing.Size(144, 24)
        Me.ckbTransport.TabIndex = 4
        Me.ckbTransport.Text = "Avec/sans transport"
        '
        'cbRechercher
        '
        Me.cbRechercher.Location = New System.Drawing.Point(606, 6)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(75, 23)
        Me.cbRechercher.TabIndex = 7
        Me.cbRechercher.Text = "Rechercher"
        Me.cbRechercher.UseVisualStyleBackColor = True
        '
        'frmListeCommandesTrp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 678)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.ckbTransport)
        Me.Controls.Add(Me.ckCdeFacturee)
        Me.Controls.Add(Me.tbcodeClient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAfficher)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtdeb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListeCommandesTrp"
        Me.Text = "Liste des commandes avec transport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Overrides Function getResume() As String
        Return "Liste des commandes avec transport"
    End Function

    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficher.Click
        Dim str As String

        Dim objReport As ReportDocument

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crListeCommandeTRP.rpt")


        objReport.SetParameterValue("ddeb", Me.dtdeb.Value.ToShortDateString())

        objReport.SetParameterValue("dfin", Me.dtFin.Value.ToShortDateString())

        str = tbcodeClient.Text
        str = Replace(str, "%", "*")
        objReport.SetParameterValue("codeclient", Trim(str))

        objReport.SetParameterValue("bfacture", Me.ckCdeFacturee.Checked)

        objReport.SetParameterValue("bTRP", Me.ckbTransport.Checked)

        Persist.setReportConnection(objReport)
        CrystalReportViewer1.ReportSource = objReport
    End Sub

    Private Sub cbRechercher_Click(sender As Object, e As EventArgs) Handles cbRechercher.Click
        rechercheClient()
    End Sub
    Private Sub rechercheClient()
        Dim objTiers As Tiers

        objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.CLIENT, tbcodeClient)

        If Not objTiers Is Nothing Then
            tbcodeClient.Text = objTiers.code
        End If
    End Sub 'rechercheClient
End Class
