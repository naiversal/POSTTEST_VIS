Public Class Kartu

    Public Sub New(nama As String, id As String, peran As String, noHp As String, email As String, hobi As String, tglLahir As String, alamat As String, foto As Image)
        InitializeComponent()

        lblNama.Text = nama
        lblId.Text = id
        lblPeran.Text = peran
        lblNo.Text = noHp
        lblEmail.Text = email
        lblHobi.Text = hobi
        lblTL.Text = tglLahir
        lblAlamat.Text = alamat

        If foto IsNot Nothing Then
            PictureBox1.Image = foto
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

End Class