Public Class RegisterForm
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        LoginPage.fungsiusers.GSUsername = TxtUsername.Text.ToString()
        LoginPage.fungsiusers.GSPassword = TxtPassword.Text.ToString()

        LoginPage.fungsiusers.AddUserAuth(LoginPage.fungsiusers.GSUsername,
                                          LoginPage.fungsiusers.GSPassword)

        Me.Close()
    End Sub
End Class