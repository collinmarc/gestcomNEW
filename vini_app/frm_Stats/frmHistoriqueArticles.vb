Option Explicit On 
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Public Class frmHistoriqueArticles
    Inherits frmStatistiques

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

    'REMARQUE�: la proc�dure suivante est requise par le Concepteur Windows Form
    'Elle peut �tre modifi�e en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'�diteur de code.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbAfficher As System.Windows.Forms.Button
    Friend WithEvents dtdeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbRechercher As Button
    Friend WithEvents tbCodeArticle As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        ' Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtdeb = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCodeArticle = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date de D�but"
        '
        'dtdeb
        '
        Me.dtdeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdeb.Location = New System.Drawing.Point(128, 8)
        Me.dtdeb.Name = "dtdeb"
        Me.dtdeb.Size = New System.Drawing.Size(136, 20)
        Me.dtdeb.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(270, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date de Fin"
        '
        'dtFin
        '
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(360, 8)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(104, 20)
        Me.dtFin.TabIndex = 1
        '
        'cbAfficher
        '
        Me.cbAfficher.Location = New System.Drawing.Point(820, 12)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.Size = New System.Drawing.Size(120, 23)
        Me.cbAfficher.TabIndex = 3
        Me.cbAfficher.Text = "Afficher"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(470, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code Article"
        '
        'tbCodeArticle
        '
        Me.tbCodeArticle.Location = New System.Drawing.Point(560, 8)
        Me.tbCodeArticle.Name = "tbCodeArticle"
        Me.tbCodeArticle.Size = New System.Drawing.Size(72, 20)
        Me.tbCodeArticle.TabIndex = 2
        '
        'cbRechercher
        '
        Me.cbRechercher.Location = New System.Drawing.Point(638, 8)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(104, 24)
        Me.cbRechercher.TabIndex = 10
        Me.cbRechercher.Text = "Rechercher"
        '
        'frmHistoriqueArticles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 694)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.tbCodeArticle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAfficher)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtdeb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHistoriqueArticles"
        Me.Text = "Historique Articles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub initFenetre()
        dtdeb.Value = DateAdd(DateInterval.Year, -1, Now())
    End Sub
    Private Sub afficheEtat()
        Dim str As String
        Dim objReport As ReportDocument

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crStatHistoriqueArticles.rpt")


        objReport.SetParameterValue("ddeb", Me.dtdeb.Value.ToShortDateString())
        objReport.SetParameterValue("dfin", Me.dtFin.Value.ToShortDateString())
        str = tbCodeArticle.Text
        str = Replace(str, "%", "*")
        objReport.SetParameterValue("CodeArticle", Trim(str))

        Persist.setReportConnection(objReport)
        CrystalReportViewer1.ReportSource = objReport

    End Sub

    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficher.Click
        afficheEtat()
    End Sub


    Private Sub frmHistoriqueArticles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub

    Private Sub cbRechercher_Click(sender As Object, e As EventArgs) Handles cbRechercher.Click
        rechercherProduit()
    End Sub
    Private Sub rechercherProduit()
        Dim obj As Produit

        obj = rechercheDonnee(vncEnums.vncTypeDonnee.PRODUIT, tbCodeArticle)

        If Not obj Is Nothing Then
            tbCodeArticle.Text = obj.code
        End If
    End Sub 'rechercheClient

End Class
