Imports vini_DB
Public Class frmGestParamConditionnement
    Private m_DeletedRows As Collection

    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        DataGridView1.Enabled = True
    End Sub
    Private Sub frmEditTransporteur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objParam As Param

        DataGridView1.DataSource = Nothing
        For Each objParam In Param.colConditionnement
            m_bsrcParam.Add(objParam)
        Next
        DataGridView1.DataSource = m_bsrcParam
    End Sub

    Private Sub cbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCancel.Click
        Me.Close()
    End Sub

    Protected Overrides Function frmSave() As Boolean
        Dim objParam As Param

        'Sauvegarde des lignes "supprim�es"
        For Each objParam In m_DeletedRows
            objParam.Save()
        Next
        'Sauvegarde des autres lignes 
        For Each objParam In m_bsrcParam
            objParam.Save()
        Next
        Param.LoadcolParams()

    End Function
    Private Sub cbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOK.Click
        frmSave()

        Me.Close()
    End Sub

    Private Sub m_bsrcParamModeReglement_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles m_bsrcParam.AddingNew
        Try
            e.NewObject = New Param("D")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim objParam As Param
        objParam = m_bsrcParam.Current
        If Not objParam Is Nothing Then
            objParam.bDeleted = True
            m_DeletedRows.Add(objParam)
        End If

    End Sub

    Public Sub New()

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent().
        m_DeletedRows = New Collection()

    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        setfrmUpdated()
    End Sub
End Class
