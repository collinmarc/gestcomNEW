Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Public Class frmListeSousCommandes
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
    Friend WithEvents m_bsrcEtat As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxEtat As System.Windows.Forms.ComboBox
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbRechercher As Button
    Friend WithEvents tbCodeFourn As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtdeb = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCodeFourn = New System.Windows.Forms.TextBox()
        Me.m_bsrcEtat = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxEtat = New System.Windows.Forms.ComboBox()
        Me.cbRechercher = New System.Windows.Forms.Button()
        CType(Me.m_bsrcEtat, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date de d�but"
        '
        'dtdeb
        '
        Me.dtdeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdeb.Location = New System.Drawing.Point(128, 8)
        Me.dtdeb.Name = "dtdeb"
        Me.dtdeb.Size = New System.Drawing.Size(136, 20)
        Me.dtdeb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(270, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date de fin"
        '
        'dtFin
        '
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(360, 8)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(104, 20)
        Me.dtFin.TabIndex = 4
        '
        'cbAfficher
        '
        Me.cbAfficher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAfficher.Location = New System.Drawing.Point(872, 12)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.Size = New System.Drawing.Size(120, 23)
        Me.cbAfficher.TabIndex = 5
        Me.cbAfficher.Text = "Afficher"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(472, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code fournisseur"
        '
        'tbCodeFourn
        '
        Me.tbCodeFourn.Location = New System.Drawing.Point(576, 8)
        Me.tbCodeFourn.Name = "tbCodeFourn"
        Me.tbCodeFourn.Size = New System.Drawing.Size(72, 20)
        Me.tbCodeFourn.TabIndex = 7
        '
        'm_bsrcEtat
        '
        Me.m_bsrcEtat.DataSource = GetType(vini_DB.EtatCommande)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Etat"
        '
        'cbxEtat
        '
        Me.cbxEtat.DataSource = Me.m_bsrcEtat
        Me.cbxEtat.DisplayMember = "libelle"
        Me.cbxEtat.FormattingEnabled = True
        Me.cbxEtat.Location = New System.Drawing.Point(576, 34)
        Me.cbxEtat.Name = "cbxEtat"
        Me.cbxEtat.Size = New System.Drawing.Size(121, 21)
        Me.cbxEtat.TabIndex = 12
        Me.cbxEtat.ValueMember = "codeEtat"
        '
        'cbRechercher
        '
        Me.cbRechercher.Location = New System.Drawing.Point(655, 8)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(75, 23)
        Me.cbRechercher.TabIndex = 14
        Me.cbRechercher.Text = "Rechercher"
        Me.cbRechercher.UseVisualStyleBackColor = True
        '
        'frmListeSousCommandes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 678)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxEtat)
        Me.Controls.Add(Me.tbCodeFourn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAfficher)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtdeb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListeSousCommandes"
        Me.Text = "Liste des Sous commandes"
        CType(Me.m_bsrcEtat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Overrides Function getResume() As String
        Return "Liste des Sous Commandes"
    End Function



    Private Sub cbAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAfficher.Click

        Dim objReport As ReportDocument
        Dim str As String

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crListeSousCommande.rpt")


        objReport.SetParameterValue("ddeb", Me.dtdeb.Value.ToShortDateString())
        objReport.SetParameterValue("dfin", Me.dtFin.Value.ToShortDateString())

        str = tbCodeFourn.Text + "%"
        str = Replace(str, "%", "*")
        objReport.SetParameterValue("codeFourn", Trim(str))
        objReport.SetParameterValue("codeEtat", cbxEtat.SelectedValue)

        Persist.setReportConnection(objReport)
        CrystalReportViewer1.ReportSource = objReport
    End Sub

    Private Sub frmListeSousCommandes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_bsrcEtat.Add(New EtatSSCommandeGeneree)
        m_bsrcEtat.Add(New EtatSSCommandeTransmise)
        m_bsrcEtat.Add(New EtatSSCommandeExporteeInt)
        m_bsrcEtat.Add(New EtatSSCommandeRapprochee)
        m_bsrcEtat.Add(New EtatSSCommandeRapprocheeInt)
        m_bsrcEtat.Add(New EtatSSCommandeFacturee)
        m_bsrcEtat.Add(New EtatTous())
        cbxEtat.SelectedIndex = cbxEtat.Items.Count - 1
        tbCodeFourn.Text = "%"

    End Sub

    Private Sub cbRechercher_Click(sender As Object, e As EventArgs) Handles cbRechercher.Click
        rechercheFournisseur()
    End Sub
    Private Sub rechercheFournisseur()
        Dim objTiers As Tiers

        objTiers = rechercheDonnee(vncEnums.vncTypeDonnee.FOURNISSEUR, tbCodeFourn)

        If Not objTiers Is Nothing Then
            tbCodeFourn.Text = objTiers.code
        End If
    End Sub 'rechercheFournisseur

End Class
