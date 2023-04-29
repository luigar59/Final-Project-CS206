<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDev
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
        Me.NameLBL = New System.Windows.Forms.Label()
        Me.ContInfoLBL = New System.Windows.Forms.Label()
        Me.ContInfo2LBL = New System.Windows.Forms.Label()
        Me.PfpPICBX = New System.Windows.Forms.PictureBox()
        Me.LogoPICBX = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PfpPICBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPICBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLBL
        '
        Me.NameLBL.AutoSize = True
        Me.NameLBL.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.NameLBL.Location = New System.Drawing.Point(12, 19)
        Me.NameLBL.Name = "NameLBL"
        Me.NameLBL.Size = New System.Drawing.Size(148, 21)
        Me.NameLBL.TabIndex = 0
        Me.NameLBL.Text = "Delrick Rancharan"
        '
        'ContInfoLBL
        '
        Me.ContInfoLBL.AutoSize = True
        Me.ContInfoLBL.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContInfoLBL.Location = New System.Drawing.Point(12, 159)
        Me.ContInfoLBL.Name = "ContInfoLBL"
        Me.ContInfoLBL.Size = New System.Drawing.Size(120, 20)
        Me.ContInfoLBL.TabIndex = 1
        Me.ContInfoLBL.Text = "Contact me on:"
        '
        'ContInfo2LBL
        '
        Me.ContInfo2LBL.AutoSize = True
        Me.ContInfo2LBL.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContInfo2LBL.Location = New System.Drawing.Point(76, 179)
        Me.ContInfo2LBL.Name = "ContInfo2LBL"
        Me.ContInfo2LBL.Size = New System.Drawing.Size(231, 80)
        Me.ContInfo2LBL.TabIndex = 2
        Me.ContInfo2LBL.Text = "Facebook: Delrick Rancharan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instagram: @delrick_rancharan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Twitter: Del_Ran_022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: delran01@cjc.edu.bz"
        '
        'PfpPICBX
        '
        Me.PfpPICBX.BackgroundImage = Global.Register.My.Resources.Resources.PFP
        Me.PfpPICBX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PfpPICBX.Location = New System.Drawing.Point(193, 44)
        Me.PfpPICBX.Name = "PfpPICBX"
        Me.PfpPICBX.Size = New System.Drawing.Size(114, 101)
        Me.PfpPICBX.TabIndex = 7
        Me.PfpPICBX.TabStop = False
        '
        'LogoPICBX
        '
        Me.LogoPICBX.BackgroundImage = Global.Register.My.Resources.Resources.Untitled
        Me.LogoPICBX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPICBX.Location = New System.Drawing.Point(313, 44)
        Me.LogoPICBX.Name = "LogoPICBX"
        Me.LogoPICBX.Size = New System.Drawing.Size(129, 101)
        Me.LogoPICBX.TabIndex = 6
        Me.LogoPICBX.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Register.My.Resources.Resources.BackBackButton
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(330, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AboutDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 271)
        Me.Controls.Add(Me.PfpPICBX)
        Me.Controls.Add(Me.LogoPICBX)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ContInfo2LBL)
        Me.Controls.Add(Me.ContInfoLBL)
        Me.Controls.Add(Me.NameLBL)
        Me.Name = "AboutDev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Developer"
        CType(Me.PfpPICBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPICBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLBL As Label
    Friend WithEvents ContInfoLBL As Label
    Friend WithEvents ContInfo2LBL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LogoPICBX As PictureBox
    Friend WithEvents PfpPICBX As PictureBox
End Class
