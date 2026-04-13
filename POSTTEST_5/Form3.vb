Imports System.IO

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPelanggan()
        TampilPaket()
        TampilReservasi()
        LoadComboBoxes()
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LoadComboBoxes()
        ' Load ComboBox Pelanggan
        Dim dtPelanggan As DataTable = DataModule.GetAllPelanggan()
        cbPelanggan.DataSource = dtPelanggan
        cbPelanggan.DisplayMember = "namaLengkap"
        cbPelanggan.ValueMember = "kodePelanggan"
        cbPelanggan.SelectedIndex = -1

        ' Load ComboBox Paket
        Dim dtPaket As DataTable = DataModule.GetAllPaket()
        cbPaket.DataSource = dtPaket
        cbPaket.DisplayMember = "namaPaket"
        cbPaket.ValueMember = "kodePaket"
        cbPaket.SelectedIndex = -1
    End Sub

#Region "TAB 1: PELANGGAN"
    Private Sub TampilPelanggan()
        dgvPelanggan.DataSource = DataModule.GetAllPelanggan()
    End Sub

    Private Sub KosongPelanggan()
        txtKodePelanggan.Clear()
        txtNama.Clear()
        mtbNoHp.Clear()
        txtEmail.Clear()
        txtKodePelanggan.Focus()
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnTambah1_Click(sender As Object, e As EventArgs) Handles btnTambah1.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelanggan(ErrorProvider1, txtKodePelanggan, txtNama, mtbNoHp, txtEmail) Then Exit Sub

        If DataModule.KodePelangganSudahAda(txtKodePelanggan.Text.Trim()) Then
            MessageBox.Show("Kode Pelanggan sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataModule.SimpanPelanggan(txtKodePelanggan.Text.Trim(), txtNama.Text.Trim(), mtbNoHp.Text, txtEmail.Text.Trim()) Then
            MessageBox.Show("Pelanggan berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPelanggan()
            KosongPelanggan()
            LoadComboBoxes() ' Refresh combobox di Tab Reservasi
        End If
    End Sub

    Private Sub btnUbah1_Click(sender As Object, e As EventArgs) Handles btnUbah1.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelanggan(ErrorProvider1, txtKodePelanggan, txtNama, mtbNoHp, txtEmail) Then Exit Sub

        If DataModule.UbahPelanggan(txtKodePelanggan.Text.Trim(), txtNama.Text.Trim(), mtbNoHp.Text, txtEmail.Text.Trim()) Then
            MessageBox.Show("Data pelanggan diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPelanggan()
            KosongPelanggan()
            LoadComboBoxes()
        End If
    End Sub

    Private Sub btnHapus1_Click(sender As Object, e As EventArgs) Handles btnHapus1.Click
        If txtKodePelanggan.Text.Trim() = "" Then
            MessageBox.Show("Pilih pelanggan yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Hapus data pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModule.HapusPelanggan(txtKodePelanggan.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPelanggan()
                KosongPelanggan()
                LoadComboBoxes()
            End If
        End If
    End Sub

    Private Sub btnReset1_Click(sender As Object, e As EventArgs) Handles btnReset1.Click
        KosongPelanggan()
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex >= 0 Then
            txtKodePelanggan.Text = dgvPelanggan.Rows(e.RowIndex).Cells("kodePelanggan").Value.ToString()
            txtNama.Text = dgvPelanggan.Rows(e.RowIndex).Cells("namaLengkap").Value.ToString()
            mtbNoHp.Text = dgvPelanggan.Rows(e.RowIndex).Cells("noHp").Value.ToString()
            txtEmail.Text = dgvPelanggan.Rows(e.RowIndex).Cells("email").Value.ToString()
        End If
    End Sub

    Private Sub txtCariPelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtCariPelanggan.TextChanged
        If txtCariPelanggan.Text.Trim() = "" Or txtCariPelanggan.Text = "Cari Pelanggan..." Then
            TampilPelanggan()
        Else
            dgvPelanggan.DataSource = DataModule.SearchPelanggan(txtCariPelanggan.Text.Trim())
        End If
    End Sub
#End Region

#Region "TAB 2: PAKET FOTO"
    Private Sub TampilPaket()
        dgvPaket.DataSource = DataModule.GetAllPaket()
    End Sub

    Private Sub KosongPaket()
        txtKodePaket.Clear()
        txtPaket.Clear()
        txtDurasi.Clear()
        txtHarga.Clear()
        picPaket.Image = Nothing
        picPaket.Tag = ""
        txtKodePaket.Focus()
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtDurasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDurasi.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Gambar Paket"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picPaket.Image = Image.FromFile(OpenFileDialog1.FileName)
            picPaket.SizeMode = PictureBoxSizeMode.StretchImage
            picPaket.Tag = OpenFileDialog1.FileName ' Simpan path file sementara di properties Tag
        End If
    End Sub

    Private Sub btnTambah2_Click(sender As Object, e As EventArgs) Handles btnTambah2.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPaket(ErrorProvider1, txtKodePaket, txtPaket, txtDurasi, txtHarga) Then Exit Sub

        If DataModule.KodePaketSudahAda(txtKodePaket.Text.Trim()) Then
            MessageBox.Show("Kode Paket sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fotoPath As String = If(picPaket.Tag IsNot Nothing, picPaket.Tag.ToString(), "")

        If DataModule.SimpanPaket(txtKodePaket.Text.Trim(), txtPaket.Text.Trim(), CInt(txtDurasi.Text), CInt(txtHarga.Text), fotoPath) Then
            MessageBox.Show("Paket foto berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPaket()
            KosongPaket()
            LoadComboBoxes()
        End If
    End Sub

    Private Sub btnUbah2_Click(sender As Object, e As EventArgs) Handles btnUbah2.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPaket(ErrorProvider1, txtKodePaket, txtPaket, txtDurasi, txtHarga) Then Exit Sub

        Dim fotoPath As String = If(picPaket.Tag IsNot Nothing, picPaket.Tag.ToString(), "")

        If DataModule.UbahPaket(txtKodePaket.Text.Trim(), txtPaket.Text.Trim(), CInt(txtDurasi.Text), CInt(txtHarga.Text), fotoPath) Then
            MessageBox.Show("Data paket diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPaket()
            KosongPaket()
            LoadComboBoxes()
        End If
    End Sub

    Private Sub btnHapus2_Click(sender As Object, e As EventArgs) Handles btnHapus2.Click
        If txtKodePaket.Text.Trim() = "" Then
            MessageBox.Show("Pilih paket yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Hapus data paket ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModule.HapusPaket(txtKodePaket.Text.Trim()) Then
                MessageBox.Show("Paket berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPaket()
                KosongPaket()
                LoadComboBoxes()
            End If
        End If
    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click
        KosongPaket()
    End Sub

    Private Sub dgvPaket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaket.CellClick
        If e.RowIndex >= 0 Then
            txtKodePaket.Text = dgvPaket.Rows(e.RowIndex).Cells("kodePaket").Value.ToString()
            txtPaket.Text = dgvPaket.Rows(e.RowIndex).Cells("namaPaket").Value.ToString()
            txtDurasi.Text = dgvPaket.Rows(e.RowIndex).Cells("durasi").Value.ToString()
            txtHarga.Text = dgvPaket.Rows(e.RowIndex).Cells("harga").Value.ToString()

            Dim imgPath As String = dgvPaket.Rows(e.RowIndex).Cells("foto").Value.ToString()
            If File.Exists(imgPath) Then
                picPaket.Image = Image.FromFile(imgPath)
                picPaket.SizeMode = PictureBoxSizeMode.StretchImage
                picPaket.Tag = imgPath
            Else
                picPaket.Image = Nothing
                picPaket.Tag = ""
            End If
        End If
    End Sub

    Private Sub txtCariPaket_TextChanged(sender As Object, e As EventArgs) Handles txtCariPaket.TextChanged
        If txtCariPaket.Text.Trim() = "" Or txtCariPaket.Text = "Cari Paket..." Then
            TampilPaket()
        Else
            dgvPaket.DataSource = DataModule.SearchPaket(txtCariPaket.Text.Trim())
        End If
    End Sub
#End Region

#Region "TAB 3: RESERVASI"
    Private Sub TampilReservasi()
        dgvReservasi.DataSource = DataModule.GetAllReservasi()
    End Sub

    Private Sub KosongReservasi()
        txtKodeReservasi.Clear()
        cbPelanggan.SelectedIndex = -1
        cbPaket.SelectedIndex = -1
        dtpTanggal.Value = DateTime.Now
        txtJam.Clear()
        txtKodeReservasi.Focus()
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnTambah3_Click(sender As Object, e As EventArgs) Handles btnTambah3.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataReservasi(ErrorProvider1, txtKodeReservasi, cbPelanggan, cbPaket, txtJam) Then Exit Sub

        If DataModule.KodeReservasiSudahAda(txtKodeReservasi.Text.Trim()) Then
            MessageBox.Show("Kode Reservasi sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataModule.SimpanReservasi(txtKodeReservasi.Text.Trim(), cbPelanggan.SelectedValue.ToString(), cbPaket.SelectedValue.ToString(), dtpTanggal.Value, txtJam.Text.Trim()) Then
            MessageBox.Show("Reservasi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilReservasi()
            KosongReservasi()
        End If
    End Sub

    Private Sub btnUbah3_Click(sender As Object, e As EventArgs) Handles btnUbah3.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataReservasi(ErrorProvider1, txtKodeReservasi, cbPelanggan, cbPaket, txtJam) Then Exit Sub

        If DataModule.UbahReservasi(txtKodeReservasi.Text.Trim(), cbPelanggan.SelectedValue.ToString(), cbPaket.SelectedValue.ToString(), dtpTanggal.Value, txtJam.Text.Trim()) Then
            MessageBox.Show("Data reservasi diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilReservasi()
            KosongReservasi()
        End If
    End Sub

    Private Sub btnHapus3_Click(sender As Object, e As EventArgs) Handles btnHapus3.Click
        If txtKodeReservasi.Text.Trim() = "" Then
            MessageBox.Show("Pilih reservasi yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Hapus data reservasi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModule.HapusReservasi(txtKodeReservasi.Text.Trim()) Then
                MessageBox.Show("Reservasi berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilReservasi()
                KosongReservasi()
            End If
        End If
    End Sub

    Private Sub btnReset3_Click(sender As Object, e As EventArgs) Handles btnReset3.Click
        KosongReservasi()
    End Sub

    Private Sub dgvReservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservasi.CellClick
        If e.RowIndex >= 0 Then
            txtKodeReservasi.Text = dgvReservasi.Rows(e.RowIndex).Cells("kodeReservasi").Value.ToString()
            cbPelanggan.Text = dgvReservasi.Rows(e.RowIndex).Cells("Pelanggan").Value.ToString()
            cbPaket.Text = dgvReservasi.Rows(e.RowIndex).Cells("Paket").Value.ToString()
            dtpTanggal.Value = Convert.ToDateTime(dgvReservasi.Rows(e.RowIndex).Cells("tanggal").Value)
            txtJam.Text = dgvReservasi.Rows(e.RowIndex).Cells("jam").Value.ToString()
        End If
    End Sub

    Private Sub txtCariReservasi_TextChanged(sender As Object, e As EventArgs) Handles txtCariReservasi.TextChanged
        If txtCariReservasi.Text.Trim() = "" Or txtCariReservasi.Text = "Cari Reservasi..." Then
            TampilReservasi()
        Else
            dgvReservasi.DataSource = DataModule.SearchReservasi(txtCariReservasi.Text.Trim())
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtKodeReservasi.Text.Trim() = "" Then
            MessageBox.Show("Pilih data reservasi yang ingin dicetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim kodePaket As String = cbPaket.SelectedValue.ToString()
        Dim harga As Integer = DataModule.GetHargaPaket(kodePaket)
        Dim formatHarga As String = "Rp " & harga.ToString("N0")

        SaveFileDialog1.Filter = "Text File|*.txt"
        SaveFileDialog1.Title = "Cetak Bukti Reservasi"
        SaveFileDialog1.FileName = "Struk_Reservasi_" & txtKodeReservasi.Text.Trim()

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("===================================================")
            sb.AppendLine("               STUDIO KINYIS-KINYIS                ")
            sb.AppendLine("===================================================")
            sb.AppendLine("Kode Reservasi : " & txtKodeReservasi.Text)
            sb.AppendLine("---------------------------------------------------")
            sb.AppendLine("DETAIL PELANGGAN")
            sb.AppendLine("Nama Pelanggan : " & cbPelanggan.Text)
            sb.AppendLine("---------------------------------------------------")
            sb.AppendLine("DETAIL RESERVASI")
            sb.AppendLine("Paket Foto     : " & cbPaket.Text)
            sb.AppendLine("Jadwal Tanggal : " & dtpTanggal.Value.ToString("dd-MM-yyyy"))
            sb.AppendLine("Jadwal Jam     : " & txtJam.Text & " WITA")
            sb.AppendLine("TOTAL HARGA    : " & formatHarga)
            sb.AppendLine("===================================================")
            sb.AppendLine("        Terima kasih atas reservasi Anda!          ")
            sb.AppendLine("    Harap datang 15 menit sebelum jadwal foto.     ")
            sb.AppendLine("===================================================")

            IO.File.WriteAllText(SaveFileDialog1.FileName, sb.ToString())
            MessageBox.Show("Struk reservasi berhasil dicetak!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region


End Class