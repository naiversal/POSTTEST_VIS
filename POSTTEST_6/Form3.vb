Imports System.IO

Public Class Form3

#Region "Form Events & Initializations"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPelanggan()
        TampilPaket()
        TampilReservasi()
        TampilPembayaran()
        LoadComboBoxes()
        LoadComboBoxReservasi()
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LoadComboBoxes()
        Dim dtPelanggan As DataTable = DataModule.GetAllPelanggan()
        cbPelanggan.DataSource = dtPelanggan
        cbPelanggan.DisplayMember = "namaLengkap"
        cbPelanggan.ValueMember = "kodePelanggan"
        cbPelanggan.SelectedIndex = -1

        Dim dtPaket As DataTable = DataModule.GetAllPaket()
        cbPaket.DataSource = dtPaket
        cbPaket.DisplayMember = "namaPaket"
        cbPaket.ValueMember = "kodePaket"
        cbPaket.SelectedIndex = -1
    End Sub

    Private Sub LoadComboBoxReservasi()
        Dim dtReservasi As DataTable = DataModule.GetAllReservasi()
        cbKodeReservasi.DataSource = dtReservasi
        cbKodeReservasi.DisplayMember = "kodeReservasi"
        cbKodeReservasi.ValueMember = "kodeReservasi"
        cbKodeReservasi.SelectedIndex = -1

        cbMetodeBayar.Items.Clear()
        cbMetodeBayar.SelectedIndex = -1

        cbStatusBayar.Items.Clear()
        cbStatusBayar.SelectedIndex = -1
    End Sub
#End Region

#Region "Kelola Data Pelanggan"
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
            LoadComboBoxes()
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

#Region "Kelola Data Paket"
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
            picPaket.Tag = OpenFileDialog1.FileName
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

#Region "Kelola Data Reservasi"
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
            LoadComboBoxReservasi()
        End If
    End Sub

    Private Sub btnUbah3_Click(sender As Object, e As EventArgs) Handles btnUbah3.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataReservasi(ErrorProvider1, txtKodeReservasi, cbPelanggan, cbPaket, txtJam) Then Exit Sub

        If DataModule.UbahReservasi(txtKodeReservasi.Text.Trim(), cbPelanggan.SelectedValue.ToString(), cbPaket.SelectedValue.ToString(), dtpTanggal.Value, txtJam.Text.Trim()) Then
            MessageBox.Show("Data reservasi diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilReservasi()
            KosongReservasi()
            LoadComboBoxReservasi()
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
                LoadComboBoxReservasi()
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
            sb.AppendLine("                STUDIO KINYIS-KINYIS                ")
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

#Region "Kelola Data Pembayaran"
    Private Sub TampilPembayaran()
        dgvPembayaran.DataSource = DataModule.GetAllPembayaran()
    End Sub

    Private Sub KosongPembayaran()
        txtKodePembayaran.Clear()
        cbKodeReservasi.SelectedIndex = -1
        dtpTanggalBayar.Value = DateTime.Now
        cbMetodeBayar.SelectedIndex = -1
        txtJumlahBayar.Clear()
        cbStatusBayar.SelectedIndex = -1
        txtKodePembayaran.Focus()
        ErrorProvider1.Clear()
    End Sub

    Private Sub cbKodeReservasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeReservasi.SelectedIndexChanged
        If cbKodeReservasi.SelectedIndex >= 0 AndAlso cbKodeReservasi.SelectedValue IsNot Nothing Then
            Dim kodeRes As String = cbKodeReservasi.SelectedValue.ToString()
            Dim harga As Integer = DataModule.GetHargaDariReservasi(kodeRes)
            If harga > 0 Then
                txtJumlahBayar.Text = harga.ToString()
            End If
        End If
    End Sub

    Private Sub txtJumlahBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBayar.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub btnTambah4_Click(sender As Object, e As EventArgs) Handles btnTambah4.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPembayaran(ErrorProvider1, txtKodePembayaran,
                                                       cbKodeReservasi, cbMetodeBayar,
                                                       txtJumlahBayar, cbStatusBayar) Then Exit Sub

        If DataModule.KodePembayaranSudahAda(txtKodePembayaran.Text.Trim()) Then
            MessageBox.Show("Kode Pembayaran sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataModule.SimpanPembayaran(
            txtKodePembayaran.Text.Trim(),
            cbKodeReservasi.SelectedValue.ToString(),
            dtpTanggalBayar.Value,
            cbMetodeBayar.Text,
            CInt(txtJumlahBayar.Text.Trim()),
            cbStatusBayar.Text) Then

            MessageBox.Show("Pembayaran berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPembayaran()
            KosongPembayaran()
        End If
    End Sub

    Private Sub btnUbah4_Click(sender As Object, e As EventArgs) Handles btnUbah4.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPembayaran(ErrorProvider1, txtKodePembayaran,
                                                       cbKodeReservasi, cbMetodeBayar,
                                                       txtJumlahBayar, cbStatusBayar) Then Exit Sub

        If DataModule.UbahPembayaran(
            txtKodePembayaran.Text.Trim(),
            cbKodeReservasi.SelectedValue.ToString(),
            dtpTanggalBayar.Value,
            cbMetodeBayar.Text,
            CInt(txtJumlahBayar.Text.Trim()),
            cbStatusBayar.Text) Then

            MessageBox.Show("Data pembayaran berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilPembayaran()
            KosongPembayaran()
        Else
            MessageBox.Show("Data tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus4_Click(sender As Object, e As EventArgs) Handles btnHapus4.Click
        If txtKodePembayaran.Text.Trim() = "" Then
            MessageBox.Show("Pilih pembayaran yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Hapus data pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModule.HapusPembayaran(txtKodePembayaran.Text.Trim()) Then
                MessageBox.Show("Pembayaran berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembayaran()
                KosongPembayaran()
            End If
        End If
    End Sub

    Private Sub btnReset4_Click(sender As Object, e As EventArgs) Handles btnReset4.Click
        KosongPembayaran()
    End Sub

    Private Sub dgvPembayaran_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembayaran.CellClick
        If e.RowIndex >= 0 Then
            txtKodePembayaran.Text = dgvPembayaran.Rows(e.RowIndex).Cells("kodePembayaran").Value.ToString()
            cbKodeReservasi.Text = dgvPembayaran.Rows(e.RowIndex).Cells("kodeReservasi").Value.ToString()
            dtpTanggalBayar.Value = Convert.ToDateTime(dgvPembayaran.Rows(e.RowIndex).Cells("tanggalBayar").Value)
            cbMetodeBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells("metodeBayar").Value.ToString()
            txtJumlahBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells("jumlahBayar").Value.ToString()
            cbStatusBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells("status").Value.ToString()
        End If
    End Sub

    Private Sub txtCariPembayaran_TextChanged(sender As Object, e As EventArgs) Handles txtCariPembayaran.TextChanged
        If txtCariPembayaran.Text.Trim() = "" Or txtCariPembayaran.Text = "Cari Pembayaran..." Then
            TampilPembayaran()
        Else
            dgvPembayaran.DataSource = DataModule.SearchPembayaran(txtCariPembayaran.Text.Trim())
        End If
    End Sub

    Private Sub btnCetakBayar_Click(sender As Object, e As EventArgs) Handles btnCetakBayar.Click
        If txtKodePembayaran.Text.Trim() = "" Then
            MessageBox.Show("Pilih data pembayaran yang ingin dicetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SaveFileDialog1.Filter = "Text File|*.txt"
        SaveFileDialog1.Title = "Cetak Bukti Pembayaran"
        SaveFileDialog1.FileName = "Struk_Bayar_" & txtKodePembayaran.Text.Trim()

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim jumlah As Integer = CInt(txtJumlahBayar.Text.Trim())
            Dim formatJumlah As String = "Rp " & jumlah.ToString("N0")

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("===================================================")
            sb.AppendLine("                STUDIO KINYIS-KINYIS                ")
            sb.AppendLine("               BUKTI PEMBAYARAN RESMI               ")
            sb.AppendLine("===================================================")
            sb.AppendLine("Kode Pembayaran : " & txtKodePembayaran.Text)
            sb.AppendLine("Kode Reservasi  : " & cbKodeReservasi.Text)
            sb.AppendLine("---------------------------------------------------")

            Dim pelanggan As String = ""
            Dim paket As String = ""
            For Each row As DataGridViewRow In dgvPembayaran.Rows
                If row.Cells("kodePembayaran").Value IsNot Nothing AndAlso
                   row.Cells("kodePembayaran").Value.ToString() = txtKodePembayaran.Text.Trim() Then
                    pelanggan = row.Cells("Pelanggan").Value.ToString()
                    paket = row.Cells("Paket").Value.ToString()
                    Exit For
                End If
            Next

            sb.AppendLine("Pelanggan       : " & pelanggan)
            sb.AppendLine("Paket Foto      : " & paket)
            sb.AppendLine("---------------------------------------------------")
            sb.AppendLine("DETAIL PEMBAYARAN")
            sb.AppendLine("Tanggal Bayar   : " & dtpTanggalBayar.Value.ToString("dd-MM-yyyy"))
            sb.AppendLine("Metode Bayar    : " & cbMetodeBayar.Text)
            sb.AppendLine("Jumlah Bayar    : " & formatJumlah)
            sb.AppendLine("Status          : " & cbStatusBayar.Text)
            sb.AppendLine("===================================================")
            sb.AppendLine("     Terima kasih telah melakukan pembayaran!      ")
            sb.AppendLine("===================================================")

            IO.File.WriteAllText(SaveFileDialog1.FileName, sb.ToString())
            MessageBox.Show("Struk pembayaran berhasil dicetak!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

End Class