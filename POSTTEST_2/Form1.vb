Public Class Form1
    Public judul As String
    Public genre As String
    Public indexBuku As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtTambahJudul.Text
        genre = txtTambahGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            MessageBox.Show("Buku '" & judul & "' berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTambahJudul.Clear()
            txtTambahGenre.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulCari As String = txtHapusJudul.Text

        indexBuku = cariBuku(judulCari)

        If indexBuku <> -1 Then
            hapusBuku(indexBuku)
            tampilkanData()
            txtHapusJudul.Clear()
            MessageBox.Show("Buku berhasil dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Buku tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub tampilkanData()
        lstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

End Class