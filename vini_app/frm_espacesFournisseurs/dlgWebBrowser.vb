Imports System.Windows.Forms

Public Class dlgWebBrowser
    Private m_bFermetureAuto As Boolean
    Public Property FermetureAuto() As Boolean
        Get
            Return m_bFermetureAuto
        End Get
        Set(ByVal value As Boolean)
            m_bFermetureAuto = value
        End Set
    End Property
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        FermetureAuto = False
    End Sub
    Public Sub New(pFermetureAuto As Boolean)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        FermetureAuto = pFermetureAuto
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If FermetureAuto Then
            Me.WebBrowser1.Show()
            Threading.Thread.Sleep(10 * 1000)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class
