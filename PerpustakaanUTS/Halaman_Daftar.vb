Public Class Halaman_Daftar
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Perpustakaan.fungsiuser.GSUsername = TxtUsername.Text.ToString()
        Perpustakaan.fungsiuser.GSPassword = TxtPassword.Text.ToString()
        Perpustakaan.fungsiuser.AddUser(Perpustakaan.fungsiuser.GSUsername,
                                        Perpustakaan.fungsiuser.GSPassword)
        Dim login = New Login()
        login.Show()
    End Sub
End Class