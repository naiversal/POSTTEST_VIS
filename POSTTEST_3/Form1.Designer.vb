<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        gbJK = New GroupBox()
        rbCewe = New RadioButton()
        rbCowo = New RadioButton()
        gbHobi = New GroupBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenggambar = New CheckBox()
        cbTraveling = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtpLahir = New DateTimePicker()
        btnGambar = New Button()
        btnCetak = New Button()
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Panel2 = New Panel()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbJK.SuspendLayout()
        gbHobi.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.BackgroundImage = CType(resources.GetObject("picProfil.BackgroundImage"), Image)
        picProfil.BackgroundImageLayout = ImageLayout.Zoom
        picProfil.Location = New Point(38, 93)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(292, 397)
        picProfil.TabIndex = 2
        picProfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Helvetica", 8.999999F)
        Label1.Location = New Point(349, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 3
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Helvetica", 8.999999F)
        Label2.Location = New Point(349, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 21)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Helvetica", 8.999999F)
        Label3.Location = New Point(349, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 21)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Helvetica", 8.999999F)
        Label4.Location = New Point(349, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 6
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Helvetica", 8.999999F)
        Label5.Location = New Point(349, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 21)
        Label5.TabIndex = 7
        Label5.Text = "Alamat"
        ' 
        ' gbJK
        ' 
        gbJK.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        gbJK.Controls.Add(rbCewe)
        gbJK.Controls.Add(rbCowo)
        gbJK.Font = New Font("Helvetica", 8.999999F)
        gbJK.Location = New Point(349, 275)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(224, 215)
        gbJK.TabIndex = 8
        gbJK.TabStop = False
        gbJK.Text = "Jenis Kelamin"
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.Font = New Font("Helvetica", 8.999999F)
        rbCewe.Location = New Point(17, 65)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(128, 25)
        rbCewe.TabIndex = 1
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = True
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.Font = New Font("Helvetica", 8.999999F)
        rbCowo.Location = New Point(17, 30)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(107, 25)
        rbCowo.TabIndex = 0
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-Laki"
        rbCowo.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbMenari)
        gbHobi.Controls.Add(cbMenyanyi)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Controls.Add(cbMembaca)
        gbHobi.Controls.Add(cbMemancing)
        gbHobi.Controls.Add(cbMenulis)
        gbHobi.Controls.Add(cbMenggambar)
        gbHobi.Controls.Add(cbTraveling)
        gbHobi.Controls.Add(cbCoding)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Font = New Font("Helvetica", 8.999999F)
        gbHobi.Location = New Point(579, 275)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(312, 215)
        gbHobi.TabIndex = 9
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Font = New Font("Helvetica", 8.999999F)
        cbMenari.Location = New Point(173, 171)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(91, 25)
        cbMenari.TabIndex = 22
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Font = New Font("Helvetica", 8.999999F)
        cbMenyanyi.Location = New Point(173, 136)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(113, 25)
        cbMenyanyi.TabIndex = 21
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Helvetica", 8.999999F)
        cbOlahraga.Location = New Point(173, 101)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(110, 25)
        cbOlahraga.TabIndex = 20
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Helvetica", 8.999999F)
        cbMembaca.Location = New Point(173, 66)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(115, 25)
        cbMembaca.TabIndex = 19
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Font = New Font("Helvetica", 8.999999F)
        cbMemancing.Location = New Point(173, 31)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(129, 25)
        cbMemancing.TabIndex = 18
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Helvetica", 8.999999F)
        cbMenulis.Location = New Point(16, 171)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(98, 25)
        cbMenulis.TabIndex = 17
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Font = New Font("Helvetica", 8.999999F)
        cbMenggambar.Location = New Point(16, 136)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(142, 25)
        cbMenggambar.TabIndex = 16
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Font = New Font("Helvetica", 8.999999F)
        cbTraveling.Location = New Point(16, 101)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(110, 25)
        cbTraveling.TabIndex = 15
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Helvetica", 8.999999F)
        cbCoding.Location = New Point(16, 66)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(93, 25)
        cbCoding.TabIndex = 14
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Helvetica", 8.999999F)
        cbGaming.Location = New Point(16, 30)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(99, 25)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Helvetica", 8.999999F)
        txtNama.Location = New Point(486, 90)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(405, 28)
        txtNama.TabIndex = 2
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("Helvetica", 8.999999F)
        txtUmur.Location = New Point(486, 126)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(405, 28)
        txtUmur.TabIndex = 10
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Font = New Font("Helvetica", 8.999999F)
        txtTelpon.Location = New Point(486, 196)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(405, 28)
        txtTelpon.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Helvetica", 8.999999F)
        txtAlamat.Location = New Point(486, 230)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(405, 28)
        txtAlamat.TabIndex = 12
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Font = New Font("Helvetica", 8.999999F)
        dtpLahir.Location = New Point(486, 160)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(405, 28)
        dtpLahir.TabIndex = 13
        ' 
        ' btnGambar
        ' 
        btnGambar.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        btnGambar.FlatStyle = FlatStyle.Flat
        btnGambar.Font = New Font("Helvetica", 8.999999F)
        btnGambar.ForeColor = SystemColors.ButtonFace
        btnGambar.Location = New Point(69, 496)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(235, 34)
        btnGambar.TabIndex = 14
        btnGambar.Text = "Pilih Gambar"
        btnGambar.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Helvetica", 8.999999F)
        btnCetak.ForeColor = SystemColors.ButtonFace
        btnCetak.Location = New Point(349, 496)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(542, 34)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-5, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(950, 73)
        Panel1.TabIndex = 16
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel7.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(0))
        Panel7.Location = New Point(110, 31)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(362, 10)
        Panel7.TabIndex = 18
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-19, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Alagard", 22.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Label6.Location = New Point(498, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(434, 41)
        Label6.TabIndex = 0
        Label6.Text = "ATEENAGERZ FORM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel2.Location = New Point(-24, 549)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1012, 73)
        Panel2.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(939, 587)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnCetak)
        Controls.Add(btnGambar)
        Controls.Add(dtpLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(gbHobi)
        Controls.Add(gbJK)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfil)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel

End Class
