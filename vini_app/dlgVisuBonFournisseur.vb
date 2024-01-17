Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB

Public Class dlgVisuBonFournisseur
    Inherits System.Windows.Forms.Form
    Private m_objSCMD As SousCommande


#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        ' crwPrecommande.Dispose()

        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer
    Friend WithEvents crwPrecommande As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crwPrecommande = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crwPrecommande
        '
        Me.crwPrecommande.ActiveViewIndex = -1
        Me.crwPrecommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crwPrecommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.crwPrecommande.DisplayStatusBar = False
        Me.crwPrecommande.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crwPrecommande.Location = New System.Drawing.Point(0, 0)
        Me.crwPrecommande.Name = "crwPrecommande"
        Me.crwPrecommande.Size = New System.Drawing.Size(688, 536)
        Me.crwPrecommande.TabIndex = 83
        Me.crwPrecommande.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'dlgVisuBonFournisseur
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 536)
        Me.Controls.Add(Me.crwPrecommande)
        Me.Name = "dlgVisuBonFournisseur"
        Me.Text = "dlgVisuPrecommande"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub setElement(ByVal obj As SousCommande)
        Debug.Assert(Not obj Is Nothing)
        m_objSCMD = obj
        m_objSCMD.oFournisseur.load()
        Text = "[SCMD]" & m_objSCMD.shortResume
        Visu()
    End Sub

    Private Sub Visu()
        Dim objReport As ReportDocument

        objReport = m_objSCMD.genererReport(PATHTOREPORTS)
        If Not objReport Is Nothing Then
            crwPrecommande.ReportSource = objReport
        End If

    End Sub



    '    Private Sub crwPrecommande_ReportRefresh(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles crwPrecommande.ReportRefresh
    '        Dim objReport As ReportDocument
    '        m_objSCMD.genererReport()
    '        objReport = m_objSCMD.report
    '        crwPrecommande.ReportSource = objReport
    '   End Sub


    Private Sub dlgVisuBonFournisseur_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.crwPrecommande.ShowPageNavigateButtons = True
    End Sub
End Class
