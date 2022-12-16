<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Koleksi
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
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapusKoleksi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Anda ingin menghapus koleksi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKoleksi.ForeColor = System.Drawing.Color.Black
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(101, 98)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(150, 25)
        Me.LblNamaKoleksi.TabIndex = 1
        Me.LblNamaKoleksi.Text = "nama koleksi"
        '
        'BtnHapusKoleksi
        '
        Me.BtnHapusKoleksi.BackColor = System.Drawing.Color.Brown
        Me.BtnHapusKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHapusKoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusKoleksi.ForeColor = System.Drawing.Color.White
        Me.BtnHapusKoleksi.Location = New System.Drawing.Point(137, 161)
        Me.BtnHapusKoleksi.Name = "BtnHapusKoleksi"
        Me.BtnHapusKoleksi.Size = New System.Drawing.Size(80, 36)
        Me.BtnHapusKoleksi.TabIndex = 2
        Me.BtnHapusKoleksi.Text = "Hapus"
        Me.BtnHapusKoleksi.UseVisualStyleBackColor = False
        '
        'Hapus_Koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 253)
        Me.Controls.Add(Me.BtnHapusKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Koleksi"
        Me.Text = "Hapus Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents BtnHapusKoleksi As Button
End Class
