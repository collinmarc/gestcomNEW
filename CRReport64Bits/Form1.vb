Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Début")
        Dim oReport As ReportDocument
        MsgBox("Déclaré")
        oReport = New ReportDocument()
        MsgBox("Créé")
        oReport.Load("./CrystalReport1.rpt")
        MsgBox("Chargé")
        CrystalReportViewer1.ReportSource = oReport
        MsgBox("Affiché")
    End Sub
End Class
