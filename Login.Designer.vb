<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameLBL = New System.Windows.Forms.Label()
        Me.PasswordLBL = New System.Windows.Forms.Label()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLBL
        '
        Me.UsernameLBL.AutoSize = True
        Me.UsernameLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.UsernameLBL.Location = New System.Drawing.Point(26, 50)
        Me.UsernameLBL.Name = "UsernameLBL"
        Me.UsernameLBL.Size = New System.Drawing.Size(166, 36)
        Me.UsernameLBL.TabIndex = 0
        Me.UsernameLBL.Text = "Username: "
        '
        'PasswordLBL
        '
        Me.PasswordLBL.AutoSize = True
        Me.PasswordLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.PasswordLBL.Location = New System.Drawing.Point(26, 112)
        Me.PasswordLBL.Name = "PasswordLBL"
        Me.PasswordLBL.Size = New System.Drawing.Size(163, 36)
        Me.PasswordLBL.TabIndex = 1
        Me.PasswordLBL.Text = "Password: "
        '
        'UsernameTB
        '
        Me.UsernameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.UsernameTB.Location = New System.Drawing.Point(225, 47)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(202, 41)
        Me.UsernameTB.TabIndex = 2
        '
        'PasswordTB
        '
        Me.PasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.PasswordTB.Location = New System.Drawing.Point(225, 109)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTB.Size = New System.Drawing.Size(202, 41)
        Me.PasswordTB.TabIndex = 3
        '
        'LoginBTN
        '
        Me.LoginBTN.BackgroundImage = Global.Register.My.Resources.Resources.LoginButton
        Me.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginBTN.Location = New System.Drawing.Point(332, 189)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(140, 60)
        Me.LoginBTN.TabIndex = 5
        Me.LoginBTN.UseVisualStyleBackColor = True
        '
        'CloseBTN
        '
        Me.CloseBTN.BackgroundImage = Global.Register.My.Resources.Resources.CloseButton
        Me.CloseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBTN.Location = New System.Drawing.Point(32, 189)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(140, 60)
        Me.CloseBTN.TabIndex = 4
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AcceptButton = Me.LoginBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.CancelButton = Me.CloseBTN
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.UsernameTB)
        Me.Controls.Add(Me.PasswordLBL)
        Me.Controls.Add(Me.UsernameLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameLBL As Label
    Friend WithEvents PasswordLBL As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents CloseBTN As Button
    Friend WithEvents LoginBTN As Button
End Class
