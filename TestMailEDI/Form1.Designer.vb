<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckSSL = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host :"
        '
        'tbHost
        '
        Me.tbHost.Location = New System.Drawing.Point(55, 5)
        Me.tbHost.Name = "tbHost"
        Me.tbHost.Size = New System.Drawing.Size(404, 20)
        Me.tbHost.TabIndex = 1
        Me.tbHost.Text = "mail.vinicom.fr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port : "
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(55, 42)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(404, 20)
        Me.tbPort.TabIndex = 3
        Me.tbPort.Text = "465"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SSL"
        '
        'ckSSL
        '
        Me.ckSSL.AutoSize = True
        Me.ckSSL.Checked = True
        Me.ckSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckSSL.Location = New System.Drawing.Point(55, 78)
        Me.ckSSL.Name = "ckSSL"
        Me.ckSSL.Size = New System.Drawing.Size(15, 14)
        Me.ckSSL.TabIndex = 5
        Me.ckSSL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "user"
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(55, 101)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(404, 20)
        Me.tbUser.TabIndex = 7
        Me.tbUser.Text = "gestcom@vinicom.fr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pwd"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(55, 143)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(404, 20)
        Me.tbPassword.TabIndex = 9
        Me.tbPassword.Text = "AqwZsx11!WxcQsd"
        '
        'btnMail
        '
        Me.btnMail.Location = New System.Drawing.Point(586, 230)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(75, 23)
        Me.btnMail.TabIndex = 10
        Me.btnMail.Text = "Test"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 269)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ckSSL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbHost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbHost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ckSSL As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnMail As Button
End Class
