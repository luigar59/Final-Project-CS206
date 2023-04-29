<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim IsAdminLabel As System.Windows.Forms.Label
        Me.User = New Register.User()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableTableAdapter = New Register.UserTableAdapters.UserTableTableAdapter()
        Me.TableAdapterManager = New Register.UserTableAdapters.TableAdapterManager()
        Me.UserTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.IsAdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.CounterLBL = New System.Windows.Forms.Label()
        Me.LastBTN = New System.Windows.Forms.Button()
        Me.NextBTN = New System.Windows.Forms.Button()
        Me.PreviousBTN = New System.Windows.Forms.Button()
        Me.FirstBTN = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.SearchLBL = New System.Windows.Forms.Label()
        Me.fnameSEARCHBAR = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserTitleLabel = New System.Windows.Forms.Label()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        IsAdminLabel = New System.Windows.Forms.Label()
        CType(Me.User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User
        '
        Me.User.DataSetName = "User"
        Me.User.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "UserTable"
        Me.UserTableBindingSource.DataSource = Me.User
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Register.UserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableTableAdapter = Me.UserTableTableAdapter
        '
        'UserTableDataGridView
        '
        Me.UserTableDataGridView.AutoGenerateColumns = False
        Me.UserTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.UserTableDataGridView.DataSource = Me.UserTableBindingSource
        Me.UserTableDataGridView.Location = New System.Drawing.Point(12, 221)
        Me.UserTableDataGridView.Name = "UserTableDataGridView"
        Me.UserTableDataGridView.Size = New System.Drawing.Size(639, 220)
        Me.UserTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsAdmin"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsAdmin"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(7, 76)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(71, 73)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(7, 102)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(71, 99)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SurnameTextBox.TabIndex = 7
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(199, 76)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 8
        UsernameLabel.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(263, 73)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UsernameTextBox.TabIndex = 9
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(199, 105)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(263, 102)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PasswordTextBox.TabIndex = 11
        '
        'IsAdminLabel
        '
        IsAdminLabel.AutoSize = True
        IsAdminLabel.Location = New System.Drawing.Point(390, 78)
        IsAdminLabel.Name = "IsAdminLabel"
        IsAdminLabel.Size = New System.Drawing.Size(50, 13)
        IsAdminLabel.TabIndex = 12
        IsAdminLabel.Text = "Is Admin:"
        '
        'IsAdminCheckBox
        '
        Me.IsAdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserTableBindingSource, "IsAdmin", True))
        Me.IsAdminCheckBox.Location = New System.Drawing.Point(454, 73)
        Me.IsAdminCheckBox.Name = "IsAdminCheckBox"
        Me.IsAdminCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsAdminCheckBox.TabIndex = 13
        Me.IsAdminCheckBox.Text = "Yes/no"
        Me.IsAdminCheckBox.UseVisualStyleBackColor = True
        '
        'CounterLBL
        '
        Me.CounterLBL.AutoSize = True
        Me.CounterLBL.BackColor = System.Drawing.Color.White
        Me.CounterLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CounterLBL.Location = New System.Drawing.Point(162, 146)
        Me.CounterLBL.Name = "CounterLBL"
        Me.CounterLBL.Size = New System.Drawing.Size(71, 25)
        Me.CounterLBL.TabIndex = 39
        Me.CounterLBL.Text = "Label1"
        '
        'LastBTN
        '
        Me.LastBTN.BackgroundImage = Global.Register.My.Resources.Resources.FinalItem
        Me.LastBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LastBTN.Location = New System.Drawing.Point(312, 131)
        Me.LastBTN.Name = "LastBTN"
        Me.LastBTN.Size = New System.Drawing.Size(70, 60)
        Me.LastBTN.TabIndex = 38
        Me.LastBTN.UseVisualStyleBackColor = True
        '
        'NextBTN
        '
        Me.NextBTN.BackgroundImage = Global.Register.My.Resources.Resources.NextItem
        Me.NextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextBTN.Location = New System.Drawing.Point(236, 131)
        Me.NextBTN.Name = "NextBTN"
        Me.NextBTN.Size = New System.Drawing.Size(70, 60)
        Me.NextBTN.TabIndex = 37
        Me.NextBTN.UseVisualStyleBackColor = True
        '
        'PreviousBTN
        '
        Me.PreviousBTN.BackgroundImage = Global.Register.My.Resources.Resources.LastItem
        Me.PreviousBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousBTN.Location = New System.Drawing.Point(86, 131)
        Me.PreviousBTN.Name = "PreviousBTN"
        Me.PreviousBTN.Size = New System.Drawing.Size(70, 60)
        Me.PreviousBTN.TabIndex = 36
        Me.PreviousBTN.UseVisualStyleBackColor = True
        '
        'FirstBTN
        '
        Me.FirstBTN.BackgroundImage = Global.Register.My.Resources.Resources.FirstItem
        Me.FirstBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FirstBTN.Location = New System.Drawing.Point(10, 131)
        Me.FirstBTN.Name = "FirstBTN"
        Me.FirstBTN.Size = New System.Drawing.Size(70, 60)
        Me.FirstBTN.TabIndex = 35
        Me.FirstBTN.UseVisualStyleBackColor = True
        '
        'AddBTN
        '
        Me.AddBTN.BackgroundImage = Global.Register.My.Resources.Resources.AddItem
        Me.AddBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddBTN.Location = New System.Drawing.Point(444, 131)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(70, 60)
        Me.AddBTN.TabIndex = 34
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackgroundImage = Global.Register.My.Resources.Resources.DeleteItem
        Me.DeleteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBTN.Location = New System.Drawing.Point(532, 131)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(70, 60)
        Me.DeleteBTN.TabIndex = 33
        Me.DeleteBTN.UseVisualStyleBackColor = True
        '
        'SaveBTN
        '
        Me.SaveBTN.BackgroundImage = Global.Register.My.Resources.Resources.SaveItem
        Me.SaveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBTN.Location = New System.Drawing.Point(622, 131)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(70, 60)
        Me.SaveBTN.TabIndex = 32
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'SearchLBL
        '
        Me.SearchLBL.AutoSize = True
        Me.SearchLBL.BackColor = System.Drawing.Color.White
        Me.SearchLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchLBL.Location = New System.Drawing.Point(15, 197)
        Me.SearchLBL.Name = "SearchLBL"
        Me.SearchLBL.Size = New System.Drawing.Size(160, 17)
        Me.SearchLBL.TabIndex = 41
        Me.SearchLBL.Text = "Search by First Name:   "
        '
        'fnameSEARCHBAR
        '
        Me.fnameSEARCHBAR.Location = New System.Drawing.Point(181, 196)
        Me.fnameSEARCHBAR.MaxLength = 25
        Me.fnameSEARCHBAR.Name = "fnameSEARCHBAR"
        Me.fnameSEARCHBAR.Size = New System.Drawing.Size(100, 20)
        Me.fnameSEARCHBAR.TabIndex = 40
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(703, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "NewUserMenuStrip"
        '
        'FormsToolStripMenuItem
        '
        Me.FormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToRegisterToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        Me.FormsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FormsToolStripMenuItem.Text = "Navigation"
        '
        'BackToRegisterToolStripMenuItem
        '
        Me.BackToRegisterToolStripMenuItem.Name = "BackToRegisterToolStripMenuItem"
        Me.BackToRegisterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BackToRegisterToolStripMenuItem.Text = "Back To Register"
        '
        'UserTitleLabel
        '
        Me.UserTitleLabel.AutoSize = True
        Me.UserTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserTitleLabel.Font = New System.Drawing.Font("Palatino Linotype", 25.0!, System.Drawing.FontStyle.Bold)
        Me.UserTitleLabel.Location = New System.Drawing.Point(2, 24)
        Me.UserTitleLabel.Name = "UserTitleLabel"
        Me.UserTitleLabel.Size = New System.Drawing.Size(563, 46)
        Me.UserTitleLabel.TabIndex = 43
        Me.UserTitleLabel.Text = "Add  a new user to this application"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 453)
        Me.Controls.Add(Me.UserTitleLabel)
        Me.Controls.Add(Me.SearchLBL)
        Me.Controls.Add(Me.fnameSEARCHBAR)
        Me.Controls.Add(Me.CounterLBL)
        Me.Controls.Add(Me.LastBTN)
        Me.Controls.Add(Me.NextBTN)
        Me.Controls.Add(Me.PreviousBTN)
        Me.Controls.Add(Me.FirstBTN)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.DeleteBTN)
        Me.Controls.Add(Me.SaveBTN)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(IsAdminLabel)
        Me.Controls.Add(Me.IsAdminCheckBox)
        Me.Controls.Add(Me.UserTableDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        CType(Me.User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents User As User
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As UserTableAdapters.UserTableTableAdapter
    Friend WithEvents TableAdapterManager As UserTableAdapters.TableAdapterManager
    Friend WithEvents UserTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents IsAdminCheckBox As CheckBox
    Friend WithEvents CounterLBL As Label
    Friend WithEvents LastBTN As Button
    Friend WithEvents NextBTN As Button
    Friend WithEvents PreviousBTN As Button
    Friend WithEvents FirstBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents SaveBTN As Button
    Friend WithEvents SearchLBL As Label
    Friend WithEvents fnameSEARCHBAR As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserTitleLabel As Label
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
End Class
