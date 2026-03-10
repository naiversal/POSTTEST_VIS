Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Private Function CekData() As Boolean
        grupHobi = {cbGame, cbBaca, cbMancing}
        grupJK = {rbCowo, rbCewe}
        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtNim, "NIM Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(picProfil, "Gambar Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {cbGame, cbBaca, cbMancing}
            grupJK = {rbCowo, rbCewe}
            Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(grupJK)
            DataModule.Nama = txtNama.Text
            DataModule.Nim = txtNim.Text
            DataModule.Hobi = Hobi_Selected
            DataModule.JK = jk_Selected
            DataModule.Tglahir = dtpLahir.Value.ToShortDateString()
            Form2.Show()
        End If
    End Sub

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
        If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                picProfil.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub
    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

End Class