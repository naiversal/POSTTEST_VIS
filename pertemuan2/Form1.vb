Public Class Form1
    Public nama As String
    Public nim As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        nama = txtNama.Text
        nim = txtNim.Text
        If nama = "" And nim = "" Then
            MessageBox.Show("Nama dan Nim Harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahMahasiswa(nama, nim)
            tampilkanData()
            txtNama.Clear()
            txtNim.Clear()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvHasil.SelectedRows.Count > 0 Then
            nama = txtNama.Text
            nim = txtNim.Text
            index = dgvHasil.SelectedRows(0).Index

            If nama = "" And nim = "" Then
                MessageBox.Show("Nama dan Nim Harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                editMahasiswa(index, nama, nim)
                tampilkanData()
                txtNama.Clear()
                txtNim.Clear()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvHasil.SelectedRows.Count > 0 Then
            index = dgvHasil.SelectedRows(0).Index
            hapusMahasiswa(index)
            tampilkanData()
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub tampilkanData()
        dgvHasil.Rows.Clear()
        For i As Integer = 0 To jumlahMahasiswa - 1
            dgvHasil.Rows.Add(daftarMahasiswa(i, 0), daftarMahasiswa(i, 1))
        Next
    End Sub
End Class