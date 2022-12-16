Public Class Update_Koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxBuku.Load(Perpustakaan.fungsiperpus.dirGambarBukuProperty)
        PictureBoxBuku.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerTanggalMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        TxtNama.Text = Perpustakaan.fungsiperpus.GSNamaKoleksi
        ComboBoxJenisKoleksi.SelectedItem() = Perpustakaan.fungsiperpus.GSJenisKoleksi
        RichTextBoxDeskripsi.Text = Perpustakaan.fungsiperpus.GSDeskripsi
        TxtPenerbit.Text = Perpustakaan.fungsiperpus.GSPenerbit
        TxtTahun.Text = Perpustakaan.fungsiperpus.GSTahunTerbit
        TxtLokasiRak.Text = Perpustakaan.fungsiperpus.GSLokasiRak
        DateTimePickerTanggalMasuk.Value = Perpustakaan.fungsiperpus.GSTanggalMasukKoleksi
        TxtStok.Text = Perpustakaan.fungsiperpus.GSJumlahStok

        If String.Compare(Perpustakaan.fungsiperpus.GSBahasa, "Indonesia") = 0 Then
            RbtnIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.fungsiperpus.GSBahasa, "Inggris") = 0 Then
            RbtnInggris.Checked = True
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image BMP|*.bmp|Image JPEG|*.jpeg|Image PNG|*.png|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName
        'Perpustakaan.fungsiperpus.GSFoto = OpenFileDialog1.FileName

        PictureBoxBuku.Load(picKoleksiDir)
        PictureBoxBuku.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.fungsiperpus.dirGambarBukuProperty = picKoleksiDir.ToString()
        Perpustakaan.fungsiperpus.dirGambarBukuProperty = Perpustakaan.fungsiperpus.dirGambarBukuProperty.Replace("\", "/")
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Perpustakaan.fungsiperpus.GSNamaKoleksi = TxtNama.Text.ToString()
        Perpustakaan.fungsiperpus.GSDeskripsi = RichTextBoxDeskripsi.Text.ToString()
        Perpustakaan.fungsiperpus.GSPenerbit = TxtPenerbit.Text.ToString()
        Perpustakaan.fungsiperpus.GSTahunTerbit = Integer.Parse(TxtTahun.Text)
        Perpustakaan.fungsiperpus.GSLokasiRak = TxtLokasiRak.Text.ToString()
        Perpustakaan.fungsiperpus.GSTanggalMasukKoleksi = DateTimePickerTanggalMasuk.Value.ToShortDateString()
        Perpustakaan.fungsiperpus.GSJumlahStok = Integer.Parse(TxtStok.Text)
        Perpustakaan.fungsiperpus.GSJenisKoleksi = ComboBoxJenisKoleksi.SelectedItem.ToString()
        'foto_buku = OpenFileDialog1.FileName
        'RBTN
        If RbtnIndonesia.Checked Then
            Perpustakaan.fungsiperpus.GSBahasa = "Indonesia"
        End If

        If RbtnInggris.Checked Then
            Perpustakaan.fungsiperpus.GSBahasa = "Inggris"
        End If

        'CheckBox
        If CheckBoxBudaya.Checked Then
            Perpustakaan.fungsiperpus.AddKategori("Budaya")
        End If
        If CheckBoxSains.Checked Then
            Perpustakaan.fungsiperpus.AddKategori("Sains")
        End If
        If CheckBoxSosial.Checked Then
            Perpustakaan.fungsiperpus.AddKategori("Sosial")
        End If
        If CheckBoxTeknologi.Checked Then
            Perpustakaan.fungsiperpus.AddKategori("Teknologi")
        End If

        Perpustakaan.fungsiperpus.AddKategori(TxtNama.Text.ToString())
        Dim tambahKoleksi = TxtNama.Text
        Perpustakaan.ListBoxKoleksiBuku.Items.Add(tambahKoleksi)
        Dim info_tambah_koleksi = New Info_Tambah_Koleksi()
        info_tambah_koleksi.Show()

        Dim convertedKoleksi = Perpustakaan.fungsiperpus.ConvertKoleksiToString(Perpustakaan.fungsiperpus.getKategoriItem)
        Perpustakaan.fungsiperpus.AddDataKoleksiDatabase(Perpustakaan.fungsiperpus.dirGambarBukuProperty,
                                                      Perpustakaan.fungsiperpus.GSNamaKoleksi,
                                                      Perpustakaan.fungsiperpus.GSJenisKoleksi,
                                                      Perpustakaan.fungsiperpus.GSDeskripsi,
                                                      Perpustakaan.fungsiperpus.GSPenerbit,
                                                      Perpustakaan.fungsiperpus.GSTahunTerbit,
                                                      Perpustakaan.fungsiperpus.GSLokasiRak,
                                                      Perpustakaan.fungsiperpus.GSTanggalMasukKoleksi,
                                                      Perpustakaan.fungsiperpus.GSJumlahStok,
                                                      Perpustakaan.fungsiperpus.GSBahasa,
                                                      convertedKoleksi)
    End Sub
End Class