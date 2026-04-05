Imports System.IO

Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbNo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Function CekInputValid() As Boolean
        Dim isValid As Boolean = True
        v.Clear()

        If txtNama.Text.Trim() = "" Then v.SetError(txtNama, "Inputan tidak boleh kosong") : isValid = False
        If txtId.Text.Trim() = "" Then v.SetError(txtId, "Inputan tidak boleh kosong") : isValid = False
        If cbDivisi.SelectedIndex = -1 Then v.SetError(cbDivisi, "Inputan tidak boleh kosong") : isValid = False
        If Not (rbLaki.Checked Or rbPerempuan.Checked) Then v.SetError(gbJK, "Inputan tidak boleh kosong") : isValid = False

        If Not mtbNo.MaskCompleted Then v.SetError(mtbNo, "Inputan tidak boleh kosong") : isValid = False
        If txtEmail.Text.Trim() = "" Then v.SetError(txtEmail, "Inputan tidak boleh kosong") : isValid = False
        If txtAlamat.Text.Trim() = "" Then v.SetError(txtAlamat, "Inputan tidak boleh kosong") : isValid = False

        If Not (rbKetua.Checked Or rbWakil.Checked Or rbSekre.Checked Or rbBendahara.Checked Or rbAnggota.Checked) Then
            v.SetError(gbPeran, "Inputan tidak boleh kosong") : isValid = False
        End If

        Dim adaHobi As Boolean = cbSeni.Checked Or cbOlahraga.Checked Or cbMusik.Checked Or cbGaming.Checked Or cbMenari.Checked Or cbDesain.Checked Or cbFotografi.Checked Or cbProgramming.Checked
        If Not adaHobi Then v.SetError(gbHobi, "Inputan tidak boleh kosong") : isValid = False

        Return isValid
    End Function

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        tbProfil.SelectedTab = tbKontak
    End Sub

    Private Sub btnLanjut2_Click(sender As Object, e As EventArgs) Handles btnLanjut2.Click
        tbProfil.SelectedTab = tpProfil
    End Sub

    Private Sub btnSebelum_Click(sender As Object, e As EventArgs) Handles btnSebelum.Click
        tbProfil.SelectedTab = tbData
    End Sub

    Private Sub btnSebelum2_Click(sender As Object, e As EventArgs) Handles btnSebelum2.Click
        tbProfil.SelectedTab = tbKontak
    End Sub

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        tbProfil.SelectedTab = tbData
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using fs As New IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    picProfil.Image = Image.FromStream(fs)
                End Using

                picProfil.SizeMode = PictureBoxSizeMode.Zoom

            Catch ex As Exception
                MessageBox.Show("Gagal membuka gambar. File mungkin rusak atau tidak valid.")
            End Try
        End If
    End Sub

    Private Sub TampilkanKartu()
        If Not CekInputValid() Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim peranDipilih As String = ""
        If rbKetua.Checked Then peranDipilih = rbKetua.Text
        If rbWakil.Checked Then peranDipilih = rbWakil.Text
        If rbSekre.Checked Then peranDipilih = rbSekre.Text
        If rbBendahara.Checked Then peranDipilih = rbBendahara.Text
        If rbAnggota.Checked Then peranDipilih = rbAnggota.Text

        Dim listHobi As New List(Of String)
        If cbProgramming.Checked Then listHobi.Add(cbProgramming.Text)
        If cbFotografi.Checked Then listHobi.Add(cbFotografi.Text)
        If cbDesain.Checked Then listHobi.Add(cbDesain.Text)
        If cbMenari.Checked Then listHobi.Add(cbMenari.Text)
        If cbGaming.Checked Then listHobi.Add(cbGaming.Text)
        If cbMusik.Checked Then listHobi.Add(cbMusik.Text)
        If cbOlahraga.Checked Then listHobi.Add(cbOlahraga.Text)
        If cbSeni.Checked Then listHobi.Add(cbSeni.Text)

        Dim hobiString As String = String.Join(", ", listHobi)
        Dim tgl As String = dtpTL.Value.ToString("dd MMM yyyy")

        Dim frmKartu As New Kartu(txtNama.Text, txtId.Text, peranDipilih, mtbNo.Text, txtEmail.Text, hobiString, tgl, txtAlamat.Text, picProfil.Image)
        frmKartu.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        TampilkanKartu()
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        TampilkanKartu()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        If Not CekInputValid() Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        SaveFileDialog1.Title = "Simpan Data Member"
        SaveFileDialog1.FileName = "Member_" & txtNama.Text

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isiData As String = "Nama=" & txtNama.Text & vbCrLf &
                                    "ID=" & txtId.Text & vbCrLf &
                                    "Divisi=" & cbDivisi.Text & vbCrLf &
                                    "NoTelp=" & mtbNo.Text & vbCrLf &
                                    "Email=" & txtEmail.Text
            File.WriteAllText(SaveFileDialog1.FileName, isiData)
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka Data Member"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim barisFile() As String = File.ReadAllLines(OpenFileDialog1.FileName)
            For Each baris As String In barisFile
                If baris.StartsWith("Nama=") Then txtNama.Text = baris.Substring(5)
                If baris.StartsWith("ID=") Then txtId.Text = baris.Substring(3)
                If baris.StartsWith("Divisi=") Then cbDivisi.Text = baris.Substring(7)
                If baris.StartsWith("NoTelp=") Then mtbNo.Text = baris.Substring(7)
                If baris.StartsWith("Email=") Then txtEmail.Text = baris.Substring(6)
            Next
            MessageBox.Show("Data berhasil dimuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KosongkanData()
        txtNama.Clear()
        txtId.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()
        mtbNo.Clear()
        cbDivisi.SelectedIndex = -1
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        rbKetua.Checked = False
        rbWakil.Checked = False
        rbSekre.Checked = False
        rbBendahara.Checked = False
        rbAnggota.Checked = False
        cbProgramming.Checked = False
        cbFotografi.Checked = False
        cbDesain.Checked = False
        cbMenari.Checked = False
        cbGaming.Checked = False
        cbMusik.Checked = False
        cbOlahraga.Checked = False
        cbSeni.Checked = False
        picProfil.Image = Nothing
        v.Clear()
        tbProfil.SelectedTab = tbData
        txtNama.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        KosongkanData()
    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click
        KosongkanData()
    End Sub

    Private Sub btnReset3_Click(sender As Object, e As EventArgs) Handles btnReset3.Click
        KosongkanData()
    End Sub

End Class