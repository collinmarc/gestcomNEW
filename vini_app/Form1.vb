Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Début")
        Dim oReport As ReportDocument
        MsgBox("Déclaré")
        oReport = New ReportDocument()
        MsgBox("Créé")
        oReport.Load("./cr/CrystalReport2.rpt")
        MsgBox("Chargé")
        CrystalReportViewer2.ReportSource = oReport
        MsgBox("Affiché")
        Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions
        Try
            If Not oReport Is Nothing Then
                oReport.ExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                oReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                diskOpts.DiskFileName = "./test.pdf"
                oReport.ExportOptions.DestinationOptions = diskOpts
                oReport.Export()
                MsgBox("exporté")
                oReport.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class