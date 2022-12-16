Imports System.Security.Cryptography
Imports System.Text

Public Class ClassUsers
    Private username
    Private password
    Private UserAuth As New ArrayList()
    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Sub New()
        UserAuth.Add({"gita", "gita123"})
        UserAuth.Add({"archie", "archie123"})
    End Sub

    Public Property GSUsername() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Function AddUserAuth(username As String,
                            password As String)

        UserAuth.Add({username,
                      password})
    End Function


    Public ReadOnly Property getUserAuth() As ArrayList
        Get
            Return UserAuth
        End Get
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String
        'convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'create the stream
        Dim ms As New System.IO.MemoryStream

        'create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function


    Public Function CheckAuth(plainUsername As String, ByVal plainPassword As String) As String
        For Each rowUser In getUserAuth()
            If plainUsername = rowUser(0) And EncryptData(plainPassword) = EncryptData(rowUser(1)) Then

                Return True
            End If
        Next
        Return False
    End Function

End Class
