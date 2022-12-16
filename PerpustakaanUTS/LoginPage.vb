Public Class LoginPage
    Public Shared fungsiusers As ClassUsers
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fungsiusers = New ClassUsers()
    End Sub
    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text.ToString
        Dim plainPassword As String = TxtPassword.Text.ToString

        'For Each rowUser In fungsiusers.getUserAuth()
        '    rowUser(00)
        'Next

        Dim AuthStatus As Boolean = fungsiusers.CheckAuth(plainUsername, plainPassword)
        If AuthStatus Then
            Perpustakaan.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim regis = New RegisterForm()
        regis.Show()
    End Sub
End Class