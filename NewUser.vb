Public Class NewUser
    Private Sub UserTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User)

    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.User.UserTable)

    End Sub

    Private Sub FirstBTN_Click(sender As Object, e As EventArgs) Handles FirstBTN.Click
        Me.UserTableBindingSource.MoveFirst()
    End Sub

    Private Sub PreviousBTN_Click(sender As Object, e As EventArgs) Handles PreviousBTN.Click
        Me.UserTableBindingSource.MovePrevious()
    End Sub

    Private Sub NextBTN_Click(sender As Object, e As EventArgs) Handles NextBTN.Click
        Me.UserTableBindingSource.MoveNext()
    End Sub

    Private Sub LastBTN_Click(sender As Object, e As EventArgs) Handles LastBTN.Click
        Me.UserTableBindingSource.MoveLast()
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        Try
            Me.UserTableBindingSource.AddNew()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        Try
            Me.UserTableBindingSource.RemoveCurrent()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        Me.Validate()
        Me.UserTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User)
    End Sub

    Private Sub fnameSEARCHBAR_TextChanged(sender As Object, e As EventArgs) Handles fnameSEARCHBAR.TextChanged
        Me.UserTableBindingSource.Filter = "Name LIKE '" & fnameSEARCHBAR.Text & "%'"
    End Sub

    Private Sub BackToRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToRegisterToolStripMenuItem.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class