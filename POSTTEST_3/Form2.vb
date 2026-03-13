Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblLahir.Text = DataModule.Tglahir.ToShortDateString()
        lblJK.Text = DataModule.JK
        lblTelpon.Text = DataModule.Telpon
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.Alamat
        PictureBox2.Image = Image.FromFile(DataModule.Foto)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class