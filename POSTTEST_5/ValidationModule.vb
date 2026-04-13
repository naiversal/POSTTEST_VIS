Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Or cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    ' --- FUNGSI VALIDASI KHUSUS STUDIO KINYIS-KINYIS ---

    Public Function ValidasiDataPelanggan(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, mtbNoHp As MaskedTextBox, txtEmail As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Pelanggan wajib diisi!")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama wajib diisi!")
        Dim hpValid As Boolean = ValidasiMaskedTextBox(ep, mtbNoHp, "No HP harus lengkap sesuai format!")
        Dim emailValid As Boolean = ValidasiTextBox(ep, txtEmail, "Email wajib diisi!")
        Return kodeValid And namaValid And hpValid And emailValid
    End Function

    Public Function ValidasiDataPaket(ep As ErrorProvider, txtKode As TextBox, txtPaket As TextBox, txtDurasi As TextBox, txtHarga As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Paket wajib diisi!")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtPaket, "Nama Paket wajib diisi!")
        Dim durasiValid As Boolean = ValidasiTextBox(ep, txtDurasi, "Durasi wajib diisi!")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga wajib diisi!")
        Return kodeValid And namaValid And durasiValid And hargaValid
    End Function

    Public Function ValidasiDataReservasi(ep As ErrorProvider, txtKode As TextBox, cbPelanggan As ComboBox, cbPaket As ComboBox, txtJam As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Reservasi wajib diisi!")
        Dim pelangganValid As Boolean = ValidasiComboBox(ep, cbPelanggan, "Silakan pilih pelanggan!")
        Dim paketValid As Boolean = ValidasiComboBox(ep, cbPaket, "Silakan pilih paket foto!")
        Dim jamValid As Boolean = ValidasiTextBox(ep, txtJam, "Jam reservasi wajib diisi!")
        Return kodeValid And pelangganValid And paketValid And jamValid
    End Function

End Module