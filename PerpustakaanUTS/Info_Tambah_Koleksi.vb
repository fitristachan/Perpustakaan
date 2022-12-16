Public Class Info_Tambah_Koleksi
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'ListBoxKategori.Items.Clear()
        lblnama.Text = Perpustakaan.fungsiperpus.GSNamaKoleksi
        lbjeniskoleksi.Text = Perpustakaan.fungsiperpus.GSJenisKoleksi
        RichTextBoxDeskripsi.Text = Perpustakaan.fungsiperpus.GSDeskripsi
        lblpenerbit.Text = Perpustakaan.fungsiperpus.GSPenerbit
        lblthnterbit.Text = Perpustakaan.fungsiperpus.GSTahunTerbit
        lbllokasirak.Text = Perpustakaan.fungsiperpus.GSLokasiRak
        lbltanggalmasukkoleksi.Text = Perpustakaan.fungsiperpus.GSTanggalMasukKoleksi
        lblstok.Text = Perpustakaan.fungsiperpus.GSJumlahStok
        lblbahasa.Text = Perpustakaan.fungsiperpus.GSBahasa

        If Not String.IsNullOrEmpty(Perpustakaan.fungsiperpus.dirGambarBukuProperty) Then
            PictureBoxBuku.Load(Perpustakaan.fungsiperpus.dirGambarBukuProperty)
            PictureBoxBuku.SizeMode = PictureBoxSizeMode.StretchImage
        End If


        For Each kat In Perpustakaan.fungsiperpus.getKategoriItem
            ListBoxKategori.Items.Add(kat)
        Next

        'Perpustakaan.fungsiperpus.GSKategori.Clear()
    End Sub
End Class