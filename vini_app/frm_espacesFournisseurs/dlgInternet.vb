Public Class dlgInternet

    Private Sub dlgInternet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser4.Navigate(vini_DB.Param.getConstante("CST_FTPVNC_URL"))
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class