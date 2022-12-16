<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Koleksi
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbtnInggris = New System.Windows.Forms.RadioButton()
        Me.RbtnIndonesia = New System.Windows.Forms.RadioButton()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtTahun = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PictureBoxBuku = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(7, 89)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(7, 66)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(7, 43)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(7, 20)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(52, 17)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSains)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 516)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 113)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'RbtnInggris
        '
        Me.RbtnInggris.AutoSize = True
        Me.RbtnInggris.Location = New System.Drawing.Point(7, 44)
        Me.RbtnInggris.Name = "RbtnInggris"
        Me.RbtnInggris.Size = New System.Drawing.Size(95, 17)
        Me.RbtnInggris.TabIndex = 1
        Me.RbtnInggris.TabStop = True
        Me.RbtnInggris.Text = "Bahasa Inggris"
        Me.RbtnInggris.UseVisualStyleBackColor = True
        '
        'RbtnIndonesia
        '
        Me.RbtnIndonesia.AutoSize = True
        Me.RbtnIndonesia.Location = New System.Drawing.Point(7, 20)
        Me.RbtnIndonesia.Name = "RbtnIndonesia"
        Me.RbtnIndonesia.Size = New System.Drawing.Size(110, 17)
        Me.RbtnIndonesia.TabIndex = 0
        Me.RbtnIndonesia.TabStop = True
        Me.RbtnIndonesia.Text = "Bahasa Indonesia"
        Me.RbtnIndonesia.UseVisualStyleBackColor = True
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(382, 101)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(416, 21)
        Me.ComboBoxJenisKoleksi.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtnInggris)
        Me.GroupBox1.Controls.Add(Me.RbtnIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(382, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 73)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'DateTimePickerTanggalMasuk
        '
        Me.DateTimePickerTanggalMasuk.Location = New System.Drawing.Point(382, 343)
        Me.DateTimePickerTanggalMasuk.Name = "DateTimePickerTanggalMasuk"
        Me.DateTimePickerTanggalMasuk.Size = New System.Drawing.Size(416, 20)
        Me.DateTimePickerTanggalMasuk.TabIndex = 45
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(382, 134)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(416, 89)
        Me.RichTextBoxDeskripsi.TabIndex = 44
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(382, 377)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(416, 20)
        Me.TxtStok.TabIndex = 43
        '
        'TxtTahun
        '
        Me.TxtTahun.Location = New System.Drawing.Point(382, 272)
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Size = New System.Drawing.Size(416, 20)
        Me.TxtTahun.TabIndex = 42
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(382, 307)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(416, 20)
        Me.TxtLokasiRak.TabIndex = 41
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(382, 240)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(416, 20)
        Me.TxtPenerbit.TabIndex = 40
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(382, 68)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(416, 20)
        Me.TxtNama.TabIndex = 39
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.BackColor = System.Drawing.Color.Green
        Me.BtnTambahKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambahKoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahKoleksi.ForeColor = System.Drawing.Color.White
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(668, 647)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(130, 28)
        Me.BtnTambahKoleksi.TabIndex = 38
        Me.BtnTambahKoleksi.Text = "Update Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(60, 256)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(127, 23)
        Me.BtnTambahGambar.TabIndex = 37
        Me.BtnTambahGambar.Text = "Update Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxBuku
        '
        Me.PictureBoxBuku.Location = New System.Drawing.Point(60, 71)
        Me.PictureBoxBuku.Name = "PictureBoxBuku"
        Me.PictureBoxBuku.Size = New System.Drawing.Size(127, 169)
        Me.PictureBoxBuku.TabIndex = 36
        Me.PictureBoxBuku.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Penerbit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Jenis Koleksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Tanggal Masuk Koleksi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Bahasa"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 521)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Kategori"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Jumlah Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Lokasi Rak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tahun Terbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Update Koleksi Buku"
        '
        'Update_Koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 703)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePickerTanggalMasuk)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtTahun)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxBuku)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Update_Koleksi"
        Me.Text = "Update_Koleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbtnInggris As RadioButton
    Friend WithEvents RbtnIndonesia As RadioButton
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePickerTanggalMasuk As DateTimePicker
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtTahun As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PictureBoxBuku As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
