<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSaisieCommandeClient
    Inherits frmSaisieCommande

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCtrlStock = New System.Windows.Forms.Button()
        Me.tpClient.SuspendLayout()
        Me.tpLignes.SuspendLayout()
        Me.tpCommentaires.SuspendLayout()
        Me.SSTabCommandeClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAjouterLigne
        '
        '
        'tpLignes
        '
        Me.tpLignes.Controls.Add(Me.btnCtrlStock)
        Me.tpLignes.Controls.SetChildIndex(Me.cbAjouterLigne, 0)
        Me.tpLignes.Controls.SetChildIndex(Me.tbTotalHT, 0)
        Me.tpLignes.Controls.SetChildIndex(Me.cbModifierLigne, 0)
        Me.tpLignes.Controls.SetChildIndex(Me.cbSupprimerLigne, 0)
        Me.tpLignes.Controls.SetChildIndex(Me.tbTotalTTC, 0)
        Me.tpLignes.Controls.SetChildIndex(Me.btnCtrlStock, 0)
        '
        'tbTotalTTC
        '
        Me.tbTotalTTC.Location = New System.Drawing.Point(1079, 474)
        '
        'btnCtrlStock
        '
        Me.btnCtrlStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCtrlStock.Location = New System.Drawing.Point(632, 524)
        Me.btnCtrlStock.Name = "btnCtrlStock"
        Me.btnCtrlStock.Size = New System.Drawing.Size(105, 23)
        Me.btnCtrlStock.TabIndex = 70
        Me.btnCtrlStock.Text = "Contrôle du stock"
        Me.btnCtrlStock.UseVisualStyleBackColor = True
        '
        'frmSaisieCommandeClient
        '
        Me.ClientSize = New System.Drawing.Size(1016, 659)
        Me.Name = "frmSaisieCommandeClient"
        Me.Text = "frmSaisieCommandeClient"
        Me.tpClient.ResumeLayout(False)
        Me.tpClient.PerformLayout()
        Me.tpLignes.ResumeLayout(False)
        Me.tpLignes.PerformLayout()
        Me.tpCommentaires.ResumeLayout(False)
        Me.SSTabCommandeClient.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
