Public Class Perpustakaan
    Public Shared fungsiperpus As FungsiPerpustakaan
    Public selectedTableKoleksi As Integer
    Public selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fungsiperpus = New FungsiPerpustakaan()
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Public Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        If ListBoxKoleksiBuku.Items.Count = 0 Then
            MessageBox.Show("Mohon tambah koleksi buku terlebih dahulu")
        End If

        'f ListBoxKoleksiBuku.Items.Count > 0 & ListBoxKoleksiBuku.SelectedItem = Null Then
        ' MessageBox.Show("Mohon klik koleksi buku yang ingin dihapus")
        ' End If

        '       If ListBoxKoleksiBuku.Items.Count > 0 & ListBoxKoleksiBuku.SelectedItem = Not Null Then
        '      Dim hapus_koleksi = New Hapus_Koleksi()
        '  Hapus_Koleksi.Show()
        ' End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = fungsiperpus.GetDataKoleksiDatabase()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim tambah_koleksi = New Tambah_Koleksi()
        tambah_koleksi.Show()
    End Sub

    'Public Sub UpdateDataTableArrayList()
    '    DataGridKoleksi.Rows.Clear()
    '    For Each rowKoleksi In fungsiperpus.GetDataKoleksiByIDDatabase()
    '        Dim dataTable As String() = {rowKoleksi(1),
    '                                     rowKoleksi(2),
    '                                     rowKoleksi(3),
    '                                     rowKoleksi(4),
    '                                     rowKoleksi(5),
    '                                     rowKoleksi(6),
    '                                     rowKoleksi(7),
    '                                     rowKoleksi(8),
    '                                     rowKoleksi(9)}
    '        DataGridKoleksi.Rows.Add(dataTable)
    '    Next
    'End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ListBoxKoleksiBuku.Items.Clear()
        ReloadDataTableDatabase()
        For Each kol In fungsiperpus.getKoleksiItem
            ListBoxKoleksiBuku.Items.Add(kol)
        Next

        'UpdateDataTableArrayList()

    End Sub



    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnShowDataGrid_Click(sender As Object, e As EventArgs) Handles BtnShowDataGrid.Click
        Dim dataselected As List(Of String) = fungsiperpus.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        fungsiperpus.dirGambarBukuProperty = dataselected(1)
        fungsiperpus.GSNamaKoleksi = dataselected(2)
        fungsiperpus.GSJenisKoleksi = dataselected(3)
        fungsiperpus.GSDeskripsi = dataselected(4)
        fungsiperpus.GSPenerbit = dataselected(5)
        fungsiperpus.GSTahunTerbit = dataselected(6)
        fungsiperpus.GSLokasiRak = dataselected(7)
        fungsiperpus.GSTanggalMasukKoleksi = dataselected(8)
        fungsiperpus.GSJumlahStok = dataselected(9)
        fungsiperpus.GSBahasa = dataselected(10)

        Dim data_koleksi As List(Of String) = fungsiperpus.ConvertStringToKoleksi(dataselected(11))

        For Each info_tambah In data_koleksi
            fungsiperpus.AddKategori(info_tambah)
        Next

        Dim infoTambah = New Info_Tambah_Koleksi()
        infoTambah.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim dataselected = fungsiperpus.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        fungsiperpus.dirGambarBukuProperty = dataselected(1)
        fungsiperpus.GSNamaKoleksi = dataselected(2)
        fungsiperpus.GSJenisKoleksi = dataselected(3)
        fungsiperpus.GSDeskripsi = dataselected(4)
        fungsiperpus.GSPenerbit = dataselected(5)
        fungsiperpus.GSTahunTerbit = dataselected(6)
        fungsiperpus.GSLokasiRak = dataselected(7)
        fungsiperpus.GSTanggalMasukKoleksi = dataselected(8)
        fungsiperpus.GSJumlahStok = dataselected(9)
        fungsiperpus.GSBahasa = dataselected(10)

        Dim data_koleksi As List(Of String) = fungsiperpus.ConvertStringToKoleksi(dataselected(11))

        For Each info_tambah In data_koleksi
            fungsiperpus.AddKategori(info_tambah)
        Next

        Dim formUpdate = New Update_Koleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim formHapus = New Hapus_Koleksi()
        formHapus.Show()
    End Sub
End Class
