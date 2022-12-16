Public Class Login
    Public Shared fungsiuser As ClassUsers
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fungsiuser = New ClassUsers()
    End Sub
    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text
        Dim AuthStatus As Boolean = fungsiuser.CheckAuth(plainUsername, plainPassword)
        If AuthStatus Then
            Perpustakaan.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub
End Class