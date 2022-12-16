Imports System.Text
Imports System.Windows.Forms.PropertyGridInternal
Imports MySql.Data.MySqlClient

Public Class FungsiPerpustakaan
    Private NamaKoleksi As String
    Private JenisKoleksi As String
    Private Deskripsi As String
    Private Penerbit As String
    Private TahunTerbit As String
    Private LokasiRak As String
    Private TanggalMasukKoleksi As String
    Private JumlahStok As Integer
    Private Bahasa As String
    Private Kategori As New List(Of String)
    Private listKoleksi As New List(Of String)
    Private dirGambarBuku As String
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Property GSNamaKoleksi() As String
        Get
            Return NamaKoleksi
        End Get
        Set(value As String)
            NamaKoleksi = value
        End Set
    End Property

    Public Property GSJenisKoleksi As String
        Get
            Return JenisKoleksi
        End Get
        Set(value As String)
            JenisKoleksi = value
        End Set
    End Property

    Public Property GSDeskripsi As String
        Get
            Return Deskripsi
        End Get
        Set(value As String)
            Deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit As String
        Get
            Return Penerbit
        End Get
        Set(value As String)
            Penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit As Integer
        Get
            Return TahunTerbit
        End Get
        Set(value As Integer)
            TahunTerbit = value
        End Set
    End Property

    Public Property GSLokasiRak As String
        Get
            Return LokasiRak
        End Get
        Set(value As String)
            LokasiRak = value
        End Set
    End Property

    Public Property GSTanggalMasukKoleksi As String
        Get
            Return TanggalMasukKoleksi
        End Get
        Set(value As String)
            TanggalMasukKoleksi = value
        End Set
    End Property

    Public Property GSJumlahStok As Integer
        Get
            Return JumlahStok
        End Get
        Set(value As Integer)
            JumlahStok = value
        End Set
    End Property

    Public Property GSBahasa As String
        Get
            Return Bahasa
        End Get
        Set(value As String)
            Bahasa = value
        End Set
    End Property

    'Public Property GSKategori As List(Of String)
    'Get
    'Return Kategori
    'End Get
    'Set(value As List(Of String))
    '       Kategori = value
    'End Set
    'End Property
    Public Function AddKategori(value As String)
        Kategori.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return Kategori
        End Get
    End Property

    Public Function resetKategori()
        Kategori.Clear()
    End Function

    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
        Return ""
    End Function
    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
        Return ""
    End Function
    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property

    Public Property dirGambarBukuProperty As String
        Get
            Return dirGambarBuku
        End Get
        Set(value As String)
            dirGambarBuku = value
        End Set
    End Property

    'Public Function AddKoleksiDataTable(dir_gambar As String,
    '                                   nama_koleksi As String,
    '                                  jenis_koleksi As String,
    '                                 deskripsi_koleksi As String,
    '                                penerbit_koleksi As String,
    '                               tahun_terbit As String,
    '                             lokasi_rak As String,
    '                              tanggal_masuk As String,
    '                            stock_koleksi As Integer,
    '                           bahasa_koleksi As String,
    '                          kategori_koleksi As String)
    'koleksiDataTable.Add({dir_gambar,
    '                     nama_koleksi,
    '                    jenis_koleksi,
    '                   deskripsi_koleksi,
    '                  penerbit_koleksi,
    '                 tahun_terbit,
    '                lokasi_rak,
    '               tanggal_masuk,
    '              stock_koleksi,
    '             bahasa_koleksi,
    '            kategori_koleksi})
    'End Function

    'Public Function RemoveKoleksiDataTable(index As Integer)
    '   koleksiDataTable.RemoveAt(index)
    'End Function

    'Public ReadOnly Property getKoleksiDataTable() As ArrayList
    'Get
    'Return koleksiDataTable
    'End Get
    'End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" _
            + username + ";" + "password=" + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  dir_gambar as 'Gambar Buku',
                                  nama_koleksi as 'Nama Koleksi',
                                  jenis_koleksi As 'Jenis Koleksi',
                                  deskripsi as 'Deskripsi',
                                  penerbit As 'Penerbit',
                                  tahun_terbit AS 'Tahun Terbit',
                                  lokasi AS 'Lokasi Rak',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori AS 'Kategori'
                                  FROM koleksi"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                    nama_koleksi As String,
                                    jenis_koleksi As String,
                                    deskripsi_koleksi As String,
                                    penerbit_koleksi As String,
                                    tahun_terbit As String,
                                    lokasi_rak As String,
                                    tanggal_masuk As Date,
                                    stock_koleksi As Integer,
                                    bahasa_koleksi As String,
                                    kategori_koleksi As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" _
            + username + ";" + "password=" + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi (nama_koleksi, dir_gambar, deskipsi, penerbit,
                        jenis_koleksi, tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori) VALUE ('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi_koleksi & "', '" _
                        & penerbit_koleksi & "', '" _
                        & jenis_koleksi & "', '" _
                        & tahun_terbit & "', '" _
                        & lokasi_rak & "', '" _
                        & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                        & stock_koleksi & "', '" _
                        & bahasa_koleksi & "', '" _
                        & kategori_koleksi & "', '"

            MessageBox.Show(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" _
        + username + ";" + "password=" + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn

        sqlCommand.CommandText = "SELECT id_koleksi,
                                  dir_gambar,
                                  nama_koleksi,
                                  jenis_koleksi,
                                  deskripsi,
                                  penerbit,
                                  tahun_terbit,
                                  lokasi,
                                  tanggal_masuk_koleksi,
                                  stock,
                                  bahasa,
                                  kategori
                                  FROM koleksi
                                  WHERE id_koleksi='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiDatabase(ID As Integer,
                                             dir_gambar As String,
                                nama_koleksi As String,
                                jenis_koleksi As String,
                                deskripsi_koleksi As String,
                                penerbit_koleksi As String,
                                tahun_terbit As String,
                                lokasi_rak As String,
                                tanggal_masuk As Date,
                                stock_koleksi As Integer,
                                bahasa_koleksi As String,
                                kategori_koleksi As String)

        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" _
            + username + ";" + "password=" + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " &
                        "nama_koleksi='" & nama_koleksi & "', '" &
                        "dir_gambar='" & dir_gambar & "', " &
                        "deskipsi='" & deskripsi_koleksi & "', '" &
                        "penerbit='" & penerbit_koleksi & "', '" &
                        "jenis_koleksi='" & jenis_koleksi & "', '" &
                        "tahun_terbit='" & tahun_terbit & "', '" &
                        "lokasi='" & lokasi_rak & "', '" &
                        "tanggal_masuk_koleksi='" & tanggal_masuk & "', '" &
                        "stock='" & stock_koleksi & "', '" &
                        "bahasa'" & bahasa_koleksi & "', '" &
                        "kategori'" & kategori_koleksi & "', '" &
                        "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" _
            + username + ";" + "password=" + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                        "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
