<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutPro))
        Me.NameLBL = New System.Windows.Forms.Label()
        Me.DescLBL = New System.Windows.Forms.Label()
        Me.VerLBL = New System.Windows.Forms.Label()
        Me.RelDateLBL = New System.Windows.Forms.Label()
        Me.LogoPICBX = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LogoPICBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLBL
        '
        Me.NameLBL.AutoSize = True
        Me.NameLBL.Location = New System.Drawing.Point(12, 9)
        Me.NameLBL.Name = "NameLBL"
        Me.NameLBL.Size = New System.Drawing.Size(82, 13)
        Me.NameLBL.TabIndex = 0
        Me.NameLBL.Text = "School Register"
        '
        'DescLBL
        '
        Me.DescLBL.AutoSize = True
        Me.DescLBL.Location = New System.Drawing.Point(12, 40)
        Me.DescLBL.Name = "DescLBL"
        Me.DescLBL.Size = New System.Drawing.Size(267, 104)
        Me.DescLBL.TabIndex = 1
        Me.DescLBL.Text = resources.GetString("DescLBL.Text")
        '
        'VerLBL
        '
        Me.VerLBL.AutoSize = True
        Me.VerLBL.Location = New System.Drawing.Point(12, 154)
        Me.VerLBL.Name = "VerLBL"
        Me.VerLBL.Size = New System.Drawing.Size(69, 13)
        Me.VerLBL.TabIndex = 2
        Me.VerLBL.Text = "Version 1.1.0"
        '
        'RelDateLBL
        '
        Me.RelDateLBL.AutoSize = True
        Me.RelDateLBL.Location = New System.Drawing.Point(12, 192)
        Me.RelDateLBL.Name = "RelDateLBL"
        Me.RelDateLBL.Size = New System.Drawing.Size(140, 13)
        Me.RelDateLBL.TabIndex = 3
        Me.RelDateLBL.Text = "Released on the 30/3/2023"
        '
        'LogoPICBX
        '
        Me.LogoPICBX.BackgroundImage = Global.Register.My.Resources.Resources.Untitled
        Me.LogoPICBX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPICBX.Location = New System.Drawing.Point(299, 37)
        Me.LogoPICBX.Name = "LogoPICBX"
        Me.LogoPICBX.Size = New System.Drawing.Size(142, 117)
        Me.LogoPICBX.TabIndex = 5
        Me.LogoPICBX.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button1.BackgroundImage = Global.Register.My.Resources.Resources.BackBackButton
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(330, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AboutPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 271)
        Me.Controls.Add(Me.LogoPICBX)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RelDateLBL)
        Me.Controls.Add(Me.VerLBL)
        Me.Controls.Add(Me.DescLBL)
        Me.Controls.Add(Me.NameLBL)
        Me.Name = "AboutPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Program"
        CType(Me.LogoPICBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLBL As Label
    Friend WithEvents DescLBL As Label
    Friend WithEvents VerLBL As Label
    Friend WithEvents RelDateLBL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LogoPICBX As PictureBox
End Class
