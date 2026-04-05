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
		components = New ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		MenuStrip1 = New MenuStrip()
		menuInput = New ToolStripMenuItem()
		menuLihat = New ToolStripMenuItem()
		menuSimpan = New ToolStripMenuItem()
		menuBuka = New ToolStripMenuItem()
		menuKeluar = New ToolStripMenuItem()
		tbProfil = New TabControl()
		tbData = New TabPage()
		gbJK = New GroupBox()
		rbPerempuan = New RadioButton()
		rbLaki = New RadioButton()
		btnReset = New Button()
		btnLanjut = New Button()
		cbDivisi = New ComboBox()
		txtId = New TextBox()
		dtpTL = New DateTimePicker()
		txtNama = New TextBox()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		Label1 = New Label()
		tbKontak = New TabPage()
		btnReset2 = New Button()
		btnLanjut2 = New Button()
		btnSebelum = New Button()
		txtAlamat = New TextBox()
		mtbNo = New MaskedTextBox()
		txtEmail = New TextBox()
		Label8 = New Label()
		Label9 = New Label()
		Label10 = New Label()
		tpProfil = New TabPage()
		btnReset3 = New Button()
		btnSimpan = New Button()
		btnSebelum2 = New Button()
		gbHobi = New GroupBox()
		cbSeni = New CheckBox()
		cbOlahraga = New CheckBox()
		cbMusik = New CheckBox()
		cbGaming = New CheckBox()
		cbMenari = New CheckBox()
		cbDesain = New CheckBox()
		cbFotografi = New CheckBox()
		cbProgramming = New CheckBox()
		gbPeran = New GroupBox()
		rbAnggota = New RadioButton()
		rbBendahara = New RadioButton()
		rbSekre = New RadioButton()
		rbWakil = New RadioButton()
		rbKetua = New RadioButton()
		btnBrowse = New Button()
		Label6 = New Label()
		picProfil = New PictureBox()
		Label7 = New Label()
		Label11 = New Label()
		PictureBox2 = New PictureBox()
		OpenFileDialog1 = New OpenFileDialog()
		SaveFileDialog1 = New SaveFileDialog()
		v = New ErrorProvider(components)
		MenuStrip1.SuspendLayout()
		tbProfil.SuspendLayout()
		tbData.SuspendLayout()
		gbJK.SuspendLayout()
		tbKontak.SuspendLayout()
		tpProfil.SuspendLayout()
		gbHobi.SuspendLayout()
		gbPeran.SuspendLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		CType(v, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(24, 24)
		MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(829, 33)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' menuInput
		' 
		menuInput.Name = "menuInput"
		menuInput.Size = New Size(112, 29)
		menuInput.Text = "Input Data"
		' 
		' menuLihat
		' 
		menuLihat.Name = "menuLihat"
		menuLihat.Size = New Size(111, 29)
		menuLihat.Text = "Lihat Kartu"
		' 
		' menuSimpan
		' 
		menuSimpan.Name = "menuSimpan"
		menuSimpan.Size = New Size(130, 29)
		menuSimpan.Text = "Simpan Data"
		' 
		' menuBuka
		' 
		menuBuka.Name = "menuBuka"
		menuBuka.Size = New Size(108, 29)
		menuBuka.Text = "Buka Data"
		' 
		' menuKeluar
		' 
		menuKeluar.Name = "menuKeluar"
		menuKeluar.Size = New Size(76, 29)
		menuKeluar.Text = "Keluar"
		' 
		' tbProfil
		' 
		tbProfil.Controls.Add(tbData)
		tbProfil.Controls.Add(tbKontak)
		tbProfil.Controls.Add(tpProfil)
		tbProfil.Location = New Point(76, 144)
		tbProfil.Name = "tbProfil"
		tbProfil.SelectedIndex = 0
		tbProfil.Size = New Size(684, 608)
		tbProfil.TabIndex = 1
		' 
		' tbData
		' 
		tbData.Controls.Add(gbJK)
		tbData.Controls.Add(btnReset)
		tbData.Controls.Add(btnLanjut)
		tbData.Controls.Add(cbDivisi)
		tbData.Controls.Add(txtId)
		tbData.Controls.Add(dtpTL)
		tbData.Controls.Add(txtNama)
		tbData.Controls.Add(Label4)
		tbData.Controls.Add(Label3)
		tbData.Controls.Add(Label2)
		tbData.Controls.Add(Label1)
		tbData.Location = New Point(4, 34)
		tbData.Name = "tbData"
		tbData.Padding = New Padding(3)
		tbData.Size = New Size(676, 570)
		tbData.TabIndex = 0
		tbData.Text = "Data Utama"
		tbData.UseVisualStyleBackColor = True
		' 
		' gbJK
		' 
		gbJK.Controls.Add(rbPerempuan)
		gbJK.Controls.Add(rbLaki)
		gbJK.Location = New Point(117, 378)
		gbJK.Name = "gbJK"
		gbJK.Size = New Size(424, 86)
		gbJK.TabIndex = 26
		gbJK.TabStop = False
		gbJK.Text = "Jenis Kelamin"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(200, 37)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(126, 29)
		rbPerempuan.TabIndex = 22
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(29, 37)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(104, 29)
		rbLaki.TabIndex = 21
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-Laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' btnReset
		' 
		btnReset.Location = New Point(258, 506)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(131, 34)
		btnReset.TabIndex = 25
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' btnLanjut
		' 
		btnLanjut.Location = New Point(504, 506)
		btnLanjut.Name = "btnLanjut"
		btnLanjut.Size = New Size(131, 34)
		btnLanjut.TabIndex = 24
		btnLanjut.Text = "Selanjutnya"
		btnLanjut.UseVisualStyleBackColor = True
		' 
		' cbDivisi
		' 
		cbDivisi.FormattingEnabled = True
		cbDivisi.Items.AddRange(New Object() {"UI/UX Designer", "Backend Developer", "Database Administrator", "Quality Assurance", "Technical Writer"})
		cbDivisi.Location = New Point(117, 330)
		cbDivisi.Name = "cbDivisi"
		cbDivisi.Size = New Size(424, 33)
		cbDivisi.TabIndex = 20
		' 
		' txtId
		' 
		txtId.Location = New Point(117, 160)
		txtId.Name = "txtId"
		txtId.Size = New Size(424, 31)
		txtId.TabIndex = 19
		' 
		' dtpTL
		' 
		dtpTL.Location = New Point(117, 238)
		dtpTL.Name = "dtpTL"
		dtpTL.Size = New Size(424, 31)
		dtpTL.TabIndex = 18
		' 
		' txtNama
		' 
		txtNama.Location = New Point(117, 81)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(424, 31)
		txtNama.TabIndex = 17
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(117, 300)
		Label4.Name = "Label4"
		Label4.Size = New Size(54, 25)
		Label4.TabIndex = 15
		Label4.Text = "Divisi"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(117, 132)
		Label3.Name = "Label3"
		Label3.Size = New Size(105, 25)
		Label3.TabIndex = 14
		Label3.Text = "ID Anggota"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(117, 210)
		Label2.Name = "Label2"
		Label2.Size = New Size(115, 25)
		Label2.TabIndex = 13
		Label2.Text = "Tanggal Lahir"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(117, 53)
		Label1.Name = "Label1"
		Label1.Size = New Size(131, 25)
		Label1.TabIndex = 12
		Label1.Text = "Nama Lengkap"
		' 
		' tbKontak
		' 
		tbKontak.Controls.Add(btnReset2)
		tbKontak.Controls.Add(btnLanjut2)
		tbKontak.Controls.Add(btnSebelum)
		tbKontak.Controls.Add(txtAlamat)
		tbKontak.Controls.Add(mtbNo)
		tbKontak.Controls.Add(txtEmail)
		tbKontak.Controls.Add(Label8)
		tbKontak.Controls.Add(Label9)
		tbKontak.Controls.Add(Label10)
		tbKontak.Location = New Point(4, 34)
		tbKontak.Name = "tbKontak"
		tbKontak.Padding = New Padding(3)
		tbKontak.Size = New Size(676, 570)
		tbKontak.TabIndex = 1
		tbKontak.Text = "Kontak & Info"
		tbKontak.UseVisualStyleBackColor = True
		' 
		' btnReset2
		' 
		btnReset2.Location = New Point(283, 501)
		btnReset2.Name = "btnReset2"
		btnReset2.Size = New Size(131, 34)
		btnReset2.TabIndex = 28
		btnReset2.Text = "Reset"
		btnReset2.UseVisualStyleBackColor = True
		' 
		' btnLanjut2
		' 
		btnLanjut2.Location = New Point(509, 501)
		btnLanjut2.Name = "btnLanjut2"
		btnLanjut2.Size = New Size(131, 34)
		btnLanjut2.TabIndex = 27
		btnLanjut2.Text = "Selanjutnya"
		btnLanjut2.UseVisualStyleBackColor = True
		' 
		' btnSebelum
		' 
		btnSebelum.Location = New Point(53, 501)
		btnSebelum.Name = "btnSebelum"
		btnSebelum.Size = New Size(131, 34)
		btnSebelum.TabIndex = 26
		btnSebelum.Text = "Sebelumnya"
		btnSebelum.UseVisualStyleBackColor = True
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(159, 262)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(374, 31)
		txtAlamat.TabIndex = 21
		' 
		' mtbNo
		' 
		mtbNo.Location = New Point(159, 96)
		mtbNo.Mask = "0000-0000-0000"
		mtbNo.Name = "mtbNo"
		mtbNo.Size = New Size(374, 31)
		mtbNo.TabIndex = 20
		' 
		' txtEmail
		' 
		txtEmail.Location = New Point(159, 178)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(374, 31)
		txtEmail.TabIndex = 19
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(159, 150)
		Label8.Name = "Label8"
		Label8.Size = New Size(54, 25)
		Label8.TabIndex = 14
		Label8.Text = "Email"
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Location = New Point(159, 234)
		Label9.Name = "Label9"
		Label9.Size = New Size(140, 25)
		Label9.TabIndex = 13
		Label9.Text = "Alamat Lengkap"
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Location = New Point(159, 68)
		Label10.Name = "Label10"
		Label10.Size = New Size(93, 25)
		Label10.TabIndex = 12
		Label10.Text = "No Telpon"
		' 
		' tpProfil
		' 
		tpProfil.Controls.Add(btnReset3)
		tpProfil.Controls.Add(btnSimpan)
		tpProfil.Controls.Add(btnSebelum2)
		tpProfil.Controls.Add(gbHobi)
		tpProfil.Controls.Add(gbPeran)
		tpProfil.Controls.Add(btnBrowse)
		tpProfil.Controls.Add(Label6)
		tpProfil.Controls.Add(picProfil)
		tpProfil.Location = New Point(4, 34)
		tpProfil.Name = "tpProfil"
		tpProfil.Padding = New Padding(3)
		tpProfil.Size = New Size(676, 570)
		tpProfil.TabIndex = 2
		tpProfil.Text = "Profil & Aktivitas"
		tpProfil.UseVisualStyleBackColor = True
		' 
		' btnReset3
		' 
		btnReset3.Location = New Point(277, 523)
		btnReset3.Name = "btnReset3"
		btnReset3.Size = New Size(131, 34)
		btnReset3.TabIndex = 31
		btnReset3.Text = "Reset"
		btnReset3.UseVisualStyleBackColor = True
		' 
		' btnSimpan
		' 
		btnSimpan.Location = New Point(523, 523)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(131, 34)
		btnSimpan.TabIndex = 30
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = True
		' 
		' btnSebelum2
		' 
		btnSebelum2.Location = New Point(28, 523)
		btnSebelum2.Name = "btnSebelum2"
		btnSebelum2.Size = New Size(131, 34)
		btnSebelum2.TabIndex = 29
		btnSebelum2.Text = "Sebelumnya"
		btnSebelum2.UseVisualStyleBackColor = True
		' 
		' gbHobi
		' 
		gbHobi.Controls.Add(cbSeni)
		gbHobi.Controls.Add(cbOlahraga)
		gbHobi.Controls.Add(cbMusik)
		gbHobi.Controls.Add(cbGaming)
		gbHobi.Controls.Add(cbMenari)
		gbHobi.Controls.Add(cbDesain)
		gbHobi.Controls.Add(cbFotografi)
		gbHobi.Controls.Add(cbProgramming)
		gbHobi.Location = New Point(28, 374)
		gbHobi.Name = "gbHobi"
		gbHobi.Size = New Size(624, 126)
		gbHobi.TabIndex = 4
		gbHobi.TabStop = False
		gbHobi.Text = "Hobi"
		' 
		' cbSeni
		' 
		cbSeni.AutoSize = True
		cbSeni.Location = New Point(476, 75)
		cbSeni.Name = "cbSeni"
		cbSeni.Size = New Size(71, 29)
		cbSeni.TabIndex = 7
		cbSeni.Text = "Seni"
		cbSeni.UseVisualStyleBackColor = True
		' 
		' cbOlahraga
		' 
		cbOlahraga.AutoSize = True
		cbOlahraga.Location = New Point(476, 40)
		cbOlahraga.Name = "cbOlahraga"
		cbOlahraga.Size = New Size(110, 29)
		cbOlahraga.TabIndex = 6
		cbOlahraga.Text = "Olahraga"
		cbOlahraga.UseVisualStyleBackColor = True
		' 
		' cbMusik
		' 
		cbMusik.AutoSize = True
		cbMusik.Location = New Point(351, 75)
		cbMusik.Name = "cbMusik"
		cbMusik.Size = New Size(85, 29)
		cbMusik.TabIndex = 5
		cbMusik.Text = "Musik"
		cbMusik.UseVisualStyleBackColor = True
		' 
		' cbGaming
		' 
		cbGaming.AutoSize = True
		cbGaming.Location = New Point(351, 40)
		cbGaming.Name = "cbGaming"
		cbGaming.Size = New Size(100, 29)
		cbGaming.TabIndex = 4
		cbGaming.Text = "Gaming"
		cbGaming.UseVisualStyleBackColor = True
		' 
		' cbMenari
		' 
		cbMenari.AutoSize = True
		cbMenari.Location = New Point(209, 75)
		cbMenari.Name = "cbMenari"
		cbMenari.Size = New Size(92, 29)
		cbMenari.TabIndex = 3
		cbMenari.Text = "Menari"
		cbMenari.UseVisualStyleBackColor = True
		' 
		' cbDesain
		' 
		cbDesain.AutoSize = True
		cbDesain.Location = New Point(209, 40)
		cbDesain.Name = "cbDesain"
		cbDesain.Size = New Size(91, 29)
		cbDesain.TabIndex = 2
		cbDesain.Text = "Desain"
		cbDesain.UseVisualStyleBackColor = True
		' 
		' cbFotografi
		' 
		cbFotografi.AutoSize = True
		cbFotografi.Location = New Point(39, 75)
		cbFotografi.Name = "cbFotografi"
		cbFotografi.Size = New Size(111, 29)
		cbFotografi.TabIndex = 1
		cbFotografi.Text = "Fotografi"
		cbFotografi.UseVisualStyleBackColor = True
		' 
		' cbProgramming
		' 
		cbProgramming.AutoSize = True
		cbProgramming.Location = New Point(39, 40)
		cbProgramming.Name = "cbProgramming"
		cbProgramming.Size = New Size(148, 29)
		cbProgramming.TabIndex = 0
		cbProgramming.Text = "Programming"
		cbProgramming.UseVisualStyleBackColor = True
		' 
		' gbPeran
		' 
		gbPeran.Controls.Add(rbAnggota)
		gbPeran.Controls.Add(rbBendahara)
		gbPeran.Controls.Add(rbSekre)
		gbPeran.Controls.Add(rbWakil)
		gbPeran.Controls.Add(rbKetua)
		gbPeran.Location = New Point(28, 234)
		gbPeran.Name = "gbPeran"
		gbPeran.Size = New Size(624, 123)
		gbPeran.TabIndex = 3
		gbPeran.TabStop = False
		gbPeran.Text = "Peran Dalam Komunitas"
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Location = New Point(435, 37)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(107, 29)
		rbAnggota.TabIndex = 4
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbBendahara
		' 
		rbBendahara.AutoSize = True
		rbBendahara.Location = New Point(230, 72)
		rbBendahara.Name = "rbBendahara"
		rbBendahara.Size = New Size(120, 29)
		rbBendahara.TabIndex = 3
		rbBendahara.TabStop = True
		rbBendahara.Text = "Bendahara"
		rbBendahara.UseVisualStyleBackColor = True
		' 
		' rbSekre
		' 
		rbSekre.AutoSize = True
		rbSekre.Location = New Point(230, 37)
		rbSekre.Name = "rbSekre"
		rbSekre.Size = New Size(113, 29)
		rbSekre.TabIndex = 2
		rbSekre.TabStop = True
		rbSekre.Text = "Sekretaris"
		rbSekre.UseVisualStyleBackColor = True
		' 
		' rbWakil
		' 
		rbWakil.AutoSize = True
		rbWakil.Location = New Point(37, 72)
		rbWakil.Name = "rbWakil"
		rbWakil.Size = New Size(128, 29)
		rbWakil.TabIndex = 1
		rbWakil.TabStop = True
		rbWakil.Text = "Wakil Ketua"
		rbWakil.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(37, 37)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(81, 29)
		rbKetua.TabIndex = 0
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' btnBrowse
		' 
		btnBrowse.Location = New Point(51, 194)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(112, 34)
		btnBrowse.TabIndex = 2
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = True
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(51, 10)
		Label6.Name = "Label6"
		Label6.Size = New Size(95, 25)
		Label6.TabIndex = 1
		Label6.Text = "Foto Profil"
		' 
		' picProfil
		' 
		picProfil.BackgroundImage = CType(resources.GetObject("picProfil.BackgroundImage"), Image)
		picProfil.BackgroundImageLayout = ImageLayout.Zoom
		picProfil.Location = New Point(28, 38)
		picProfil.Name = "picProfil"
		picProfil.Size = New Size(150, 150)
		picProfil.TabIndex = 0
		picProfil.TabStop = False
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Helvetica Rounded", 17.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.HotPink
		Label7.Location = New Point(78, 68)
		Label7.Name = "Label7"
		Label7.Size = New Size(502, 42)
		Label7.TabIndex = 2
		Label7.Text = "Kinyis-Kinyis Club ID Maker"
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.BackColor = Color.Transparent
		Label11.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label11.ForeColor = Color.HotPink
		Label11.Location = New Point(82, 103)
		Label11.Name = "Label11"
		Label11.Size = New Size(479, 25)
		Label11.TabIndex = 3
		Label11.Text = "Lengkapi formulir di bawah untuk membuat ID Card digital"
		' 
		' PictureBox2
		' 
		PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
		PictureBox2.Location = New Point(643, 51)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(100, 100)
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox2.TabIndex = 4
		PictureBox2.TabStop = False
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' v
		' 
		v.ContainerControl = Me
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.MistyRose
		ClientSize = New Size(829, 808)
		Controls.Add(Label7)
		Controls.Add(PictureBox2)
		Controls.Add(Label11)
		Controls.Add(tbProfil)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form1"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		tbProfil.ResumeLayout(False)
		tbData.ResumeLayout(False)
		tbData.PerformLayout()
		gbJK.ResumeLayout(False)
		gbJK.PerformLayout()
		tbKontak.ResumeLayout(False)
		tbKontak.PerformLayout()
		tpProfil.ResumeLayout(False)
		tpProfil.PerformLayout()
		gbHobi.ResumeLayout(False)
		gbHobi.PerformLayout()
		gbPeran.ResumeLayout(False)
		gbPeran.PerformLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		CType(v, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents menuInput As ToolStripMenuItem
	Friend WithEvents menuLihat As ToolStripMenuItem
	Friend WithEvents menuSimpan As ToolStripMenuItem
	Friend WithEvents menuBuka As ToolStripMenuItem
	Friend WithEvents menuKeluar As ToolStripMenuItem
	Friend WithEvents tbProfil As TabControl
	Friend WithEvents tbData As TabPage
	Friend WithEvents tbKontak As TabPage
	Friend WithEvents tpProfil As TabPage
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents cbDivisi As ComboBox
	Friend WithEvents txtId As TextBox
	Friend WithEvents dtpTL As DateTimePicker
	Friend WithEvents txtNama As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents mtbNo As MaskedTextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents picProfil As PictureBox
	Friend WithEvents Label6 As Label
	Friend WithEvents btnBrowse As Button
	Friend WithEvents gbPeran As GroupBox
	Friend WithEvents Label7 As Label
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents rbWakil As RadioButton
	Friend WithEvents rbBendahara As RadioButton
	Friend WithEvents rbSekre As RadioButton
	Friend WithEvents rbAnggota As RadioButton
	Friend WithEvents btnLanjut As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnReset2 As Button
	Friend WithEvents btnLanjut2 As Button
	Friend WithEvents btnSebelum As Button
	Friend WithEvents gbHobi As GroupBox
	Friend WithEvents cbFotografi As CheckBox
	Friend WithEvents cbProgramming As CheckBox
	Friend WithEvents cbDesain As CheckBox
	Friend WithEvents cbSeni As CheckBox
	Friend WithEvents cbOlahraga As CheckBox
	Friend WithEvents cbMusik As CheckBox
	Friend WithEvents cbGaming As CheckBox
	Friend WithEvents cbMenari As CheckBox
	Friend WithEvents Label11 As Label
	Friend WithEvents btnReset3 As Button
	Friend WithEvents btnSimpan As Button
	Friend WithEvents btnSebelum2 As Button
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents gbJK As GroupBox
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents v As ErrorProvider

End Class
