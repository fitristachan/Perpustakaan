Public Class Hapus_Koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaKoleksi = Perpustakaan.ListBoxKoleksiBuku.SelectedItem
    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        'Perpustakaan.ListBoxKoleksiBuku.Items.Remove(Perpustakaan.ListBoxKoleksiBuku.SelectedItem)
        Perpustakaan.fungsiperpus.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub

    Private Sub Hapus_Koleksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblNamaKoleksi = Perpustakaan.ListBoxKoleksiBuku.SelectedItem
    End Sub
End Class