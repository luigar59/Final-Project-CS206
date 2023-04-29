Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'THE CODE UNDER THIS ALLOWS YOU TO LOG INTO THE REGISTER USING THE DATABASE

Public Class Login
    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mcufa\Desktop\RegisterSchool\Register.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from UserTable where Username='" + UsernameTB.Text + "' and Password='" + PasswordTB.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("login succesful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegisterForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("login Failed, check username or password.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'THIS IS A MESSAGE BOX ASKING IF YOU WISH TO CLOSE THE APPLICATION
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Dim result As DialogResult = MessageBox.Show("Close Applicatoin?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        Else

        End If
    End Sub
End Class