Imports System.Security.Cryptography.X509Certificates

Public Class Tambah_Koleksi
    'Public Shared foto_buku
    Dim isiJenisKoleksi As New List(Of String) From {"Action", "Fantasy", "History", "Teenlit", "Romance", "Light Novel", "Historical Fiction"}
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ComboBoxJenisKoleksi.DataSource = isiJenisKoleksi
        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTanggalMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasuk.CustomFormat = "yyyy/MM/dd"
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

    Private Sub TxtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahun.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Tulis tahun dalam format angka (contoh: 2022)")
        End If
    End Sub

    Private Sub TxtNama_Leave(sender As Object, e As EventArgs) Handles TxtNama.Leave
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Mohon masukkan judul buku terlebih dahulu")
        End If
    End Sub

    Public Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
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

    Private Sub DateTimePickerTanggalMasuk_Click(sender As Object, e As EventArgs) Handles DateTimePickerTanggalMasuk.Click
        MessageBox.Show(DateTimePickerTanggalMasuk.Value.ToShortDateString)
        MessageBox.Show(DateTimePickerTanggalMasuk.Value.ToString("dd/MM/yyyy"))
    End Sub
End Class