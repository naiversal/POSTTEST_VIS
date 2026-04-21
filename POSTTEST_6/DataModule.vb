Imports MySqlConnector

Module DataModule

    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpelanggan ORDER BY kodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPelanggan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpelanggan WHERE kodePelanggan LIKE @keyword OR namaLengkap LIKE @keyword ORDER BY kodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pelanggan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePelangganSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpelanggan WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanPelanggan(kode As String, nama As String, nohp As String, email As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbpelanggan (kodePelanggan, namaLengkap, noHp, email) VALUES (@kode, @nama, @nohp, @email)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@nohp", nohp)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPelanggan(kode As String, nama As String, nohp As String, email As String) As Boolean
        Try
            Dim query As String = "UPDATE tbpelanggan SET namaLengkap = @nama, noHp = @nohp, email = @email WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@nohp", nohp)
                    cmd.Parameters.AddWithValue("@email", email)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPelanggan(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpelanggan WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllPaket() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpaket ORDER BY kodePaket ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data paket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPaket(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpaket WHERE kodePaket LIKE @keyword OR namaPaket LIKE @keyword ORDER BY kodePaket ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data paket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePaketSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpaket WHERE kodePaket = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function GetHargaPaket(kode As String) As Integer
        Dim harga As Integer = 0
        Try
            Dim query As String = "SELECT harga FROM tbpaket WHERE kodePaket = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    harga = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return harga
    End Function

    Public Function SimpanPaket(kode As String, nama As String, durasi As Integer, harga As Integer, pathFoto As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbpaket (kodePaket, namaPaket, durasi, harga, foto) VALUES (@kode, @nama, @durasi, @harga, @foto)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@foto", pathFoto)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan paket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPaket(kode As String, nama As String, durasi As Integer, harga As Integer, pathFoto As String) As Boolean
        Try
            Dim query As String = "UPDATE tbpaket SET namaPaket = @nama, durasi = @durasi, harga = @harga, foto = @foto WHERE kodePaket = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@foto", pathFoto)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah paket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPaket(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpaket WHERE kodePaket = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus paket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllReservasi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT r.kodeReservasi, p.namaLengkap AS 'Pelanggan', pkt.namaPaket AS 'Paket', " &
                                  "r.tanggal, r.jam " &
                                  "FROM tbreservasi r " &
                                  "INNER JOIN tbpelanggan p ON r.kodePelanggan = p.kodePelanggan " &
                                  "INNER JOIN tbpaket pkt ON r.kodePaket = pkt.kodePaket " &
                                  "ORDER BY r.kodeReservasi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchReservasi(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT r.kodeReservasi, p.namaLengkap AS 'Pelanggan', pkt.namaPaket AS 'Paket', r.tanggal, r.jam " &
                                  "FROM tbreservasi r " &
                                  "INNER JOIN tbpelanggan p ON r.kodePelanggan = p.kodePelanggan " &
                                  "INNER JOIN tbpaket pkt ON r.kodePaket = pkt.kodePaket " &
                                  "WHERE r.kodeReservasi LIKE @keyword OR p.namaLengkap LIKE @keyword " &
                                  "ORDER BY r.kodeReservasi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeReservasiSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbreservasi WHERE kodeReservasi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanReservasi(kode As String, kodePelanggan As String, kodePaket As String, tanggal As Date, jam As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbreservasi (kodeReservasi, kodePelanggan, kodePaket, tanggal, jam) VALUES (@kode, @pelanggan, @paket, @tanggal, @jam)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@pelanggan", kodePelanggan)
                    cmd.Parameters.AddWithValue("@paket", kodePaket)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jam", jam)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahReservasi(kode As String, kodePelanggan As String, kodePaket As String, tanggal As Date, jam As String) As Boolean
        Try
            Dim query As String = "UPDATE tbreservasi SET kodePelanggan = @pelanggan, kodePaket = @paket, tanggal = @tanggal, jam = @jam WHERE kodeReservasi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@pelanggan", kodePelanggan)
                    cmd.Parameters.AddWithValue("@paket", kodePaket)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jam", jam)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusReservasi(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbreservasi WHERE kodeReservasi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllPembayaran() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT b.kodePembayaran, b.kodeReservasi, " &
                "p.namaLengkap AS 'Pelanggan', pkt.namaPaket AS 'Paket', " &
                "b.tanggalBayar, b.metodeBayar, b.jumlahBayar, b.status " &
                "FROM tbpembayaran b " &
                "INNER JOIN tbreservasi r ON b.kodeReservasi = r.kodeReservasi " &
                "INNER JOIN tbpelanggan p ON r.kodePelanggan = p.kodePelanggan " &
                "INNER JOIN tbpaket pkt ON r.kodePaket = pkt.kodePaket " &
                "ORDER BY b.kodePembayaran ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPembayaran(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT b.kodePembayaran, b.kodeReservasi, " &
                "p.namaLengkap AS 'Pelanggan', pkt.namaPaket AS 'Paket', " &
                "b.tanggalBayar, b.metodeBayar, b.jumlahBayar, b.status " &
                "FROM tbpembayaran b " &
                "INNER JOIN tbreservasi r ON b.kodeReservasi = r.kodeReservasi " &
                "INNER JOIN tbpelanggan p ON r.kodePelanggan = p.kodePelanggan " &
                "INNER JOIN tbpaket pkt ON r.kodePaket = pkt.kodePaket " &
                "WHERE b.kodePembayaran LIKE @keyword " &
                "OR b.kodeReservasi LIKE @keyword " &
                "OR p.namaLengkap LIKE @keyword " &
                "OR b.status LIKE @keyword " &
                "ORDER BY b.kodePembayaran ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePembayaranSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpembayaran WHERE kodePembayaran = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function GetHargaDariReservasi(kodeReservasi As String) As Integer
        Dim harga As Integer = 0
        Try
            Dim query As String =
                "SELECT pkt.harga FROM tbreservasi r " &
                "INNER JOIN tbpaket pkt ON r.kodePaket = pkt.kodePaket " &
                "WHERE r.kodeReservasi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kodeReservasi)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        harga = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return harga
    End Function

    Public Function SimpanPembayaran(kode As String, kodeReservasi As String,
                                     tanggalBayar As Date, metodeBayar As String,
                                     jumlahBayar As Integer, status As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpembayaran " &
                "(kodePembayaran, kodeReservasi, tanggalBayar, metodeBayar, jumlahBayar, status) " &
                "VALUES (@kode, @reservasi, @tanggal, @metode, @jumlah, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@reservasi", kodeReservasi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggalBayar.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@metode", metodeBayar)
                    cmd.Parameters.AddWithValue("@jumlah", jumlahBayar)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPembayaran(kode As String, kodeReservasi As String,
                                   tanggalBayar As Date, metodeBayar As String,
                                   jumlahBayar As Integer, status As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpembayaran SET " &
                "kodeReservasi = @reservasi, tanggalBayar = @tanggal, " &
                "metodeBayar = @metode, jumlahBayar = @jumlah, " &
                "status = @status " &
                "WHERE kodePembayaran = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@reservasi", kodeReservasi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggalBayar.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@metode", metodeBayar)
                    cmd.Parameters.AddWithValue("@jumlah", jumlahBayar)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPembayaran(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpembayaran WHERE kodePembayaran = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module