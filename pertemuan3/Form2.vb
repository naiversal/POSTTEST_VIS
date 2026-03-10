Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.Nama
		lblNim.Text = DataModule.Nim
		lblTLahir.Text = DataModule.Tglahir
		lblJK.Text = DataModule.JK
		lblHobi.Text = DataModule.Hobi
		PictureBox1.Image = Image.FromFile(DataModule.Foto)
	End Sub
End Class