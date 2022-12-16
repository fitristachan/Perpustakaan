<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halaman_Daftar
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
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnDaftar
        '
        Me.BtnDaftar.Location = New System.Drawing.Point(274, 157)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(75, 23)
        Me.BtnDaftar.TabIndex = 11
        Me.BtnDaftar.Text = "Daftar"
        Me.BtnDaftar.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(174, 107)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(175, 20)
        Me.TxtPassword.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(174, 54)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(175, 20)
        Me.TxtUsername.TabIndex = 12
        '
        'Halaman_Daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 232)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Halaman_Daftar"
        Me.Text = "Halaman_Daftar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDaftar As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsername As TextBox
End Class
