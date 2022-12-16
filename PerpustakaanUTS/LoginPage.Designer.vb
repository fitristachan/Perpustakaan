<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(182, 38)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(175, 20)
        Me.TxtUsername.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(282, 139)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(182, 91)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(175, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'BtnDaftar
        '
        Me.BtnDaftar.Location = New System.Drawing.Point(182, 139)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(75, 23)
        Me.BtnDaftar.TabIndex = 5
        Me.BtnDaftar.Text = "Daftar"
        Me.BtnDaftar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 191)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnDaftar As Button
End Class
