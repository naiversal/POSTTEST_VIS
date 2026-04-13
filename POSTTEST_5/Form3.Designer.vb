<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
		MenuStrip1 = New MenuStrip()
		MenuKelolaData = New ToolStripMenuItem()
		MenuKeluar = New ToolStripMenuItem()
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		txtEmail = New TextBox()
		Label17 = New Label()
		txtKodePelanggan = New TextBox()
		Label16 = New Label()
		btnReset1 = New Button()
		btnHapus1 = New Button()
		btnUbah1 = New Button()
		btnTambah1 = New Button()
		txtCariPelanggan = New TextBox()
		dgvPelanggan = New DataGridView()
		mtbNoHp = New MaskedTextBox()
		txtNama = New TextBox()
		Label7 = New Label()
		Label5 = New Label()
		Label2 = New Label()
		TabPage2 = New TabPage()
		Label19 = New Label()
		txtKodePaket = New TextBox()
		Label15 = New Label()
		txtHarga = New TextBox()
		Label10 = New Label()
		txtDurasi = New TextBox()
		Label9 = New Label()
		btnBrowse = New Button()
		picPaket = New PictureBox()
		btnReset2 = New Button()
		btnHapus2 = New Button()
		btnUbah2 = New Button()
		btnTambah2 = New Button()
		txtCariPaket = New TextBox()
		dgvPaket = New DataGridView()
		txtPaket = New TextBox()
		Label6 = New Label()
		Label8 = New Label()
		Label3 = New Label()
		TabPage3 = New TabPage()
		txtKodeReservasi = New TextBox()
		Label18 = New Label()
		txtJam = New TextBox()
		btnCetak = New Button()
		Label14 = New Label()
		dtpTanggal = New DateTimePicker()
		Label13 = New Label()
		cbPelanggan = New ComboBox()
		cbPaket = New ComboBox()
		btnReset3 = New Button()
		btnHapus3 = New Button()
		btnUbah3 = New Button()
		btnTambah3 = New Button()
		txtCariReservasi = New TextBox()
		dgvReservasi = New DataGridView()
		Label11 = New Label()
		Label12 = New Label()
		Label4 = New Label()
		Label1 = New Label()
		ErrorProvider1 = New ErrorProvider(components)
		SaveFileDialog1 = New SaveFileDialog()
		OpenFileDialog1 = New OpenFileDialog()
		Panel1 = New Panel()
		Panel2 = New Panel()
		Label20 = New Label()
		MenuStrip1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
		TabPage2.SuspendLayout()
		CType(picPaket, ComponentModel.ISupportInitialize).BeginInit()
		CType(dgvPaket, ComponentModel.ISupportInitialize).BeginInit()
		TabPage3.SuspendLayout()
		CType(dgvReservasi, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		Panel2.SuspendLayout()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.BackColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		MenuStrip1.ImageScalingSize = New Size(24, 24)
		MenuStrip1.Items.AddRange(New ToolStripItem() {MenuKelolaData, MenuKeluar})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 38)
		MenuStrip1.TabIndex = 1
		MenuStrip1.Text = "MenuStrip1"
		' 
		' MenuKelolaData
		' 
		MenuKelolaData.Font = New Font("Segoe UI", 11.0F)
		MenuKelolaData.ForeColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		MenuKelolaData.Name = "MenuKelolaData"
		MenuKelolaData.Size = New Size(138, 34)
		MenuKelolaData.Text = "Kelola Data"
		' 
		' MenuKeluar
		' 
		MenuKeluar.Font = New Font("Segoe UI", 11.0F)
		MenuKeluar.ForeColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		MenuKeluar.Name = "MenuKeluar"
		MenuKeluar.Size = New Size(90, 34)
		MenuKeluar.Text = "Keluar"
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Controls.Add(TabPage3)
		TabControl1.Location = New Point(13, 127)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(750, 600)
		TabControl1.TabIndex = 2
		' 
		' TabPage1
		' 
		TabPage1.BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		TabPage1.Controls.Add(txtEmail)
		TabPage1.Controls.Add(Label17)
		TabPage1.Controls.Add(txtKodePelanggan)
		TabPage1.Controls.Add(Label16)
		TabPage1.Controls.Add(btnReset1)
		TabPage1.Controls.Add(btnHapus1)
		TabPage1.Controls.Add(btnUbah1)
		TabPage1.Controls.Add(btnTambah1)
		TabPage1.Controls.Add(txtCariPelanggan)
		TabPage1.Controls.Add(dgvPelanggan)
		TabPage1.Controls.Add(mtbNoHp)
		TabPage1.Controls.Add(txtNama)
		TabPage1.Controls.Add(Label7)
		TabPage1.Controls.Add(Label5)
		TabPage1.Controls.Add(Label2)
		TabPage1.Location = New Point(4, 34)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(742, 562)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Pelanggan"
		' 
		' txtEmail
		' 
		txtEmail.Location = New Point(389, 196)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(286, 31)
		txtEmail.TabIndex = 25
		' 
		' Label17
		' 
		Label17.AutoSize = True
		Label17.Location = New Point(389, 168)
		Label17.Name = "Label17"
		Label17.Size = New Size(54, 25)
		Label17.TabIndex = 24
		Label17.Text = "Email"
		' 
		' txtKodePelanggan
		' 
		txtKodePelanggan.Location = New Point(75, 123)
		txtKodePelanggan.Name = "txtKodePelanggan"
		txtKodePelanggan.Size = New Size(290, 31)
		txtKodePelanggan.TabIndex = 23
		' 
		' Label16
		' 
		Label16.AutoSize = True
		Label16.Location = New Point(75, 95)
		Label16.Name = "Label16"
		Label16.Size = New Size(140, 25)
		Label16.TabIndex = 22
		Label16.Text = "Kode Pelanggan"
		' 
		' btnReset1
		' 
		btnReset1.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnReset1.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnReset1.FlatStyle = FlatStyle.Flat
		btnReset1.Location = New Point(565, 262)
		btnReset1.Name = "btnReset1"
		btnReset1.Size = New Size(112, 34)
		btnReset1.TabIndex = 21
		btnReset1.Text = "Reset"
		btnReset1.UseVisualStyleBackColor = False
		' 
		' btnHapus1
		' 
		btnHapus1.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnHapus1.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnHapus1.FlatStyle = FlatStyle.Flat
		btnHapus1.Location = New Point(402, 262)
		btnHapus1.Name = "btnHapus1"
		btnHapus1.Size = New Size(112, 34)
		btnHapus1.TabIndex = 20
		btnHapus1.Text = "Hapus"
		btnHapus1.UseVisualStyleBackColor = False
		' 
		' btnUbah1
		' 
		btnUbah1.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnUbah1.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnUbah1.FlatStyle = FlatStyle.Flat
		btnUbah1.Location = New Point(237, 262)
		btnUbah1.Name = "btnUbah1"
		btnUbah1.Size = New Size(112, 34)
		btnUbah1.TabIndex = 19
		btnUbah1.Text = "Ubah"
		btnUbah1.UseVisualStyleBackColor = False
		' 
		' btnTambah1
		' 
		btnTambah1.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnTambah1.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnTambah1.FlatStyle = FlatStyle.Flat
		btnTambah1.Location = New Point(71, 262)
		btnTambah1.Name = "btnTambah1"
		btnTambah1.Size = New Size(112, 34)
		btnTambah1.TabIndex = 18
		btnTambah1.Text = "Tambah"
		btnTambah1.UseVisualStyleBackColor = False
		' 
		' txtCariPelanggan
		' 
		txtCariPelanggan.Location = New Point(72, 318)
		txtCariPelanggan.Name = "txtCariPelanggan"
		txtCariPelanggan.Size = New Size(606, 31)
		txtCariPelanggan.TabIndex = 7
		txtCariPelanggan.Text = "Cari Pelanggan..."
		' 
		' dgvPelanggan
		' 
		dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPelanggan.Location = New Point(72, 355)
		dgvPelanggan.Name = "dgvPelanggan"
		dgvPelanggan.RowHeadersWidth = 62
		dgvPelanggan.Size = New Size(606, 173)
		dgvPelanggan.TabIndex = 6
		' 
		' mtbNoHp
		' 
		mtbNoHp.Location = New Point(75, 196)
		mtbNoHp.Mask = "0000-0000-0000"
		mtbNoHp.Name = "mtbNoHp"
		mtbNoHp.Size = New Size(286, 31)
		mtbNoHp.TabIndex = 5
		' 
		' txtNama
		' 
		txtNama.Location = New Point(389, 123)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(290, 31)
		txtNama.TabIndex = 4
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(75, 168)
		Label7.Name = "Label7"
		Label7.Size = New Size(64, 25)
		Label7.TabIndex = 3
		Label7.Text = "No HP"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(389, 95)
		Label5.Name = "Label5"
		Label5.Size = New Size(131, 25)
		Label5.TabIndex = 1
		Label5.Text = "Nama Lengkap"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Helvetica", 13.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(239, 28)
		Label2.Name = "Label2"
		Label2.Size = New Size(263, 32)
		Label2.TabIndex = 0
		Label2.Text = "Tambah Pelanggan"
		' 
		' TabPage2
		' 
		TabPage2.BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		TabPage2.Controls.Add(Label19)
		TabPage2.Controls.Add(txtKodePaket)
		TabPage2.Controls.Add(Label15)
		TabPage2.Controls.Add(txtHarga)
		TabPage2.Controls.Add(Label10)
		TabPage2.Controls.Add(txtDurasi)
		TabPage2.Controls.Add(Label9)
		TabPage2.Controls.Add(btnBrowse)
		TabPage2.Controls.Add(picPaket)
		TabPage2.Controls.Add(btnReset2)
		TabPage2.Controls.Add(btnHapus2)
		TabPage2.Controls.Add(btnUbah2)
		TabPage2.Controls.Add(btnTambah2)
		TabPage2.Controls.Add(txtCariPaket)
		TabPage2.Controls.Add(dgvPaket)
		TabPage2.Controls.Add(txtPaket)
		TabPage2.Controls.Add(Label6)
		TabPage2.Controls.Add(Label8)
		TabPage2.Controls.Add(Label3)
		TabPage2.Location = New Point(4, 34)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(742, 562)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Paket Foto"
		' 
		' Label19
		' 
		Label19.AutoSize = True
		Label19.Location = New Point(286, 192)
		Label19.Name = "Label19"
		Label19.Size = New Size(57, 25)
		Label19.TabIndex = 26
		Label19.Text = "Menit"
		' 
		' txtKodePaket
		' 
		txtKodePaket.Location = New Point(226, 127)
		txtKodePaket.Name = "txtKodePaket"
		txtKodePaket.Size = New Size(225, 31)
		txtKodePaket.TabIndex = 25
		' 
		' Label15
		' 
		Label15.AutoSize = True
		Label15.Location = New Point(226, 100)
		Label15.Name = "Label15"
		Label15.Size = New Size(100, 25)
		Label15.TabIndex = 24
		Label15.Text = "Kode Paket"
		' 
		' txtHarga
		' 
		txtHarga.Location = New Point(468, 189)
		txtHarga.Name = "txtHarga"
		txtHarga.Size = New Size(225, 31)
		txtHarga.TabIndex = 23
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Location = New Point(468, 161)
		Label10.Name = "Label10"
		Label10.Size = New Size(60, 25)
		Label10.TabIndex = 22
		Label10.Text = "Harga"
		' 
		' txtDurasi
		' 
		txtDurasi.Location = New Point(226, 189)
		txtDurasi.Name = "txtDurasi"
		txtDurasi.Size = New Size(47, 31)
		txtDurasi.TabIndex = 21
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Location = New Point(63, 65)
		Label9.Name = "Label9"
		Label9.Size = New Size(96, 25)
		Label9.TabIndex = 20
		Label9.Text = "Foto Paket"
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnBrowse.FlatStyle = FlatStyle.Flat
		btnBrowse.Location = New Point(63, 258)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(112, 34)
		btnBrowse.TabIndex = 19
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' picPaket
		' 
		picPaket.BackgroundImage = CType(resources.GetObject("picPaket.BackgroundImage"), Image)
		picPaket.BackgroundImageLayout = ImageLayout.Zoom
		picPaket.Location = New Point(47, 100)
		picPaket.Name = "picPaket"
		picPaket.Size = New Size(140, 152)
		picPaket.TabIndex = 18
		picPaket.TabStop = False
		' 
		' btnReset2
		' 
		btnReset2.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnReset2.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnReset2.FlatStyle = FlatStyle.Flat
		btnReset2.Location = New Point(562, 311)
		btnReset2.Name = "btnReset2"
		btnReset2.Size = New Size(112, 34)
		btnReset2.TabIndex = 17
		btnReset2.Text = "Reset"
		btnReset2.UseVisualStyleBackColor = False
		' 
		' btnHapus2
		' 
		btnHapus2.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnHapus2.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnHapus2.FlatStyle = FlatStyle.Flat
		btnHapus2.Location = New Point(398, 311)
		btnHapus2.Name = "btnHapus2"
		btnHapus2.Size = New Size(112, 34)
		btnHapus2.TabIndex = 16
		btnHapus2.Text = "Hapus"
		btnHapus2.UseVisualStyleBackColor = False
		' 
		' btnUbah2
		' 
		btnUbah2.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnUbah2.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnUbah2.FlatStyle = FlatStyle.Flat
		btnUbah2.Location = New Point(237, 311)
		btnUbah2.Name = "btnUbah2"
		btnUbah2.Size = New Size(112, 34)
		btnUbah2.TabIndex = 15
		btnUbah2.Text = "Ubah"
		btnUbah2.UseVisualStyleBackColor = False
		' 
		' btnTambah2
		' 
		btnTambah2.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnTambah2.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnTambah2.FlatStyle = FlatStyle.Flat
		btnTambah2.Location = New Point(68, 311)
		btnTambah2.Name = "btnTambah2"
		btnTambah2.Size = New Size(112, 34)
		btnTambah2.TabIndex = 14
		btnTambah2.Text = "Tambah"
		btnTambah2.UseVisualStyleBackColor = False
		' 
		' txtCariPaket
		' 
		txtCariPaket.Location = New Point(68, 358)
		txtCariPaket.Name = "txtCariPaket"
		txtCariPaket.Size = New Size(606, 31)
		txtCariPaket.TabIndex = 13
		txtCariPaket.Text = "Cari Paket..."
		' 
		' dgvPaket
		' 
		dgvPaket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPaket.Location = New Point(68, 395)
		dgvPaket.Name = "dgvPaket"
		dgvPaket.RowHeadersWidth = 62
		dgvPaket.Size = New Size(606, 143)
		dgvPaket.TabIndex = 12
		' 
		' txtPaket
		' 
		txtPaket.Location = New Point(468, 127)
		txtPaket.Name = "txtPaket"
		txtPaket.Size = New Size(225, 31)
		txtPaket.TabIndex = 10
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(226, 161)
		Label6.Name = "Label6"
		Label6.Size = New Size(62, 25)
		Label6.TabIndex = 9
		Label6.Text = "Durasi"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(468, 99)
		Label8.Name = "Label8"
		Label8.Size = New Size(106, 25)
		Label8.TabIndex = 8
		Label8.Text = "Nama Paket"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Helvetica", 13.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(227, 24)
		Label3.Name = "Label3"
		Label3.Size = New Size(264, 32)
		Label3.TabIndex = 1
		Label3.Text = "Tambah Paket Foto"
		' 
		' TabPage3
		' 
		TabPage3.BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		TabPage3.Controls.Add(txtKodeReservasi)
		TabPage3.Controls.Add(Label18)
		TabPage3.Controls.Add(txtJam)
		TabPage3.Controls.Add(btnCetak)
		TabPage3.Controls.Add(Label14)
		TabPage3.Controls.Add(dtpTanggal)
		TabPage3.Controls.Add(Label13)
		TabPage3.Controls.Add(cbPelanggan)
		TabPage3.Controls.Add(cbPaket)
		TabPage3.Controls.Add(btnReset3)
		TabPage3.Controls.Add(btnHapus3)
		TabPage3.Controls.Add(btnUbah3)
		TabPage3.Controls.Add(btnTambah3)
		TabPage3.Controls.Add(txtCariReservasi)
		TabPage3.Controls.Add(dgvReservasi)
		TabPage3.Controls.Add(Label11)
		TabPage3.Controls.Add(Label12)
		TabPage3.Controls.Add(Label4)
		TabPage3.Location = New Point(4, 34)
		TabPage3.Name = "TabPage3"
		TabPage3.Padding = New Padding(3)
		TabPage3.Size = New Size(742, 562)
		TabPage3.TabIndex = 2
		TabPage3.Text = "Reservasi"
		' 
		' txtKodeReservasi
		' 
		txtKodeReservasi.Location = New Point(69, 159)
		txtKodeReservasi.Name = "txtKodeReservasi"
		txtKodeReservasi.Size = New Size(263, 31)
		txtKodeReservasi.TabIndex = 40
		' 
		' Label18
		' 
		Label18.AutoSize = True
		Label18.Location = New Point(68, 124)
		Label18.Name = "Label18"
		Label18.Size = New Size(130, 25)
		Label18.TabIndex = 39
		Label18.Text = "Kode Reservasi"
		' 
		' txtJam
		' 
		txtJam.Location = New Point(403, 236)
		txtJam.Name = "txtJam"
		txtJam.Size = New Size(263, 31)
		txtJam.TabIndex = 38
		' 
		' btnCetak
		' 
		btnCetak.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnCetak.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnCetak.FlatStyle = FlatStyle.Flat
		btnCetak.Location = New Point(563, 314)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(112, 34)
		btnCetak.TabIndex = 37
		btnCetak.Text = "Cetak"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' Label14
		' 
		Label14.AutoSize = True
		Label14.Location = New Point(402, 201)
		Label14.Name = "Label14"
		Label14.Size = New Size(43, 25)
		Label14.TabIndex = 36
		Label14.Text = "Jam"
		' 
		' dtpTanggal
		' 
		dtpTanggal.Location = New Point(69, 238)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(299, 31)
		dtpTanggal.TabIndex = 35
		' 
		' Label13
		' 
		Label13.AutoSize = True
		Label13.Location = New Point(68, 201)
		Label13.Name = "Label13"
		Label13.Size = New Size(73, 25)
		Label13.TabIndex = 34
		Label13.Text = "Tanggal"
		' 
		' cbPelanggan
		' 
		cbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
		cbPelanggan.FormattingEnabled = True
		cbPelanggan.Location = New Point(69, 81)
		cbPelanggan.Name = "cbPelanggan"
		cbPelanggan.Size = New Size(597, 33)
		cbPelanggan.TabIndex = 33
		' 
		' cbPaket
		' 
		cbPaket.DropDownStyle = ComboBoxStyle.DropDownList
		cbPaket.FormattingEnabled = True
		cbPaket.Location = New Point(402, 159)
		cbPaket.Name = "cbPaket"
		cbPaket.Size = New Size(264, 33)
		cbPaket.TabIndex = 32
		' 
		' btnReset3
		' 
		btnReset3.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnReset3.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnReset3.FlatStyle = FlatStyle.Flat
		btnReset3.Location = New Point(441, 314)
		btnReset3.Name = "btnReset3"
		btnReset3.Size = New Size(112, 34)
		btnReset3.TabIndex = 31
		btnReset3.Text = "Reset"
		btnReset3.UseVisualStyleBackColor = False
		' 
		' btnHapus3
		' 
		btnHapus3.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnHapus3.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnHapus3.FlatStyle = FlatStyle.Flat
		btnHapus3.Location = New Point(319, 314)
		btnHapus3.Name = "btnHapus3"
		btnHapus3.Size = New Size(112, 34)
		btnHapus3.TabIndex = 30
		btnHapus3.Text = "Hapus"
		btnHapus3.UseVisualStyleBackColor = False
		' 
		' btnUbah3
		' 
		btnUbah3.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnUbah3.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnUbah3.FlatStyle = FlatStyle.Flat
		btnUbah3.Location = New Point(195, 314)
		btnUbah3.Name = "btnUbah3"
		btnUbah3.Size = New Size(112, 34)
		btnUbah3.TabIndex = 29
		btnUbah3.Text = "Ubah"
		btnUbah3.UseVisualStyleBackColor = False
		' 
		' btnTambah3
		' 
		btnTambah3.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		btnTambah3.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(220), CByte(128))
		btnTambah3.FlatStyle = FlatStyle.Flat
		btnTambah3.Location = New Point(68, 314)
		btnTambah3.Name = "btnTambah3"
		btnTambah3.Size = New Size(112, 34)
		btnTambah3.TabIndex = 28
		btnTambah3.Text = "Tambah"
		btnTambah3.UseVisualStyleBackColor = False
		' 
		' txtCariReservasi
		' 
		txtCariReservasi.Location = New Point(69, 375)
		txtCariReservasi.Name = "txtCariReservasi"
		txtCariReservasi.Size = New Size(606, 31)
		txtCariReservasi.TabIndex = 27
		txtCariReservasi.Text = "Cari Reservasi..."
		' 
		' dgvReservasi
		' 
		dgvReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvReservasi.Location = New Point(69, 412)
		dgvReservasi.Name = "dgvReservasi"
		dgvReservasi.RowHeadersWidth = 62
		dgvReservasi.Size = New Size(606, 125)
		dgvReservasi.TabIndex = 26
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.Location = New Point(402, 131)
		Label11.Name = "Label11"
		Label11.Size = New Size(96, 25)
		Label11.TabIndex = 23
		Label11.Text = "Paket Foto"
		' 
		' Label12
		' 
		Label12.AutoSize = True
		Label12.Location = New Point(69, 53)
		Label12.Name = "Label12"
		Label12.Size = New Size(94, 25)
		Label12.TabIndex = 22
		Label12.Text = "Pelanggan"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Helvetica", 13.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label4.Location = New Point(230, 22)
		Label4.Name = "Label4"
		Label4.Size = New Size(251, 32)
		Label4.TabIndex = 0
		Label4.Text = "Tambah Reservasi"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Alagard", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Label1.Location = New Point(157, 45)
		Label1.Name = "Label1"
		Label1.Size = New Size(415, 38)
		Label1.TabIndex = 3
		Label1.Text = "Studio Kinyis-Kinyis"
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		Panel1.Controls.Add(Panel2)
		Panel1.Controls.Add(TabControl1)
		Panel1.Location = New Point(12, 26)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(776, 737)
		Panel1.TabIndex = 4
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		Panel2.Controls.Add(Label20)
		Panel2.Controls.Add(Label1)
		Panel2.Location = New Point(17, 26)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(742, 95)
		Panel2.TabIndex = 5
		' 
		' Label20
		' 
		Label20.AutoSize = True
		Label20.BackColor = Color.Transparent
		Label20.Font = New Font("Helvetica", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label20.ForeColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Label20.Location = New Point(260, 10)
		Label20.Name = "Label20"
		Label20.Size = New Size(227, 38)
		Label20.TabIndex = 4
		Label20.Text = "MANAJEMEN"
		' 
		' Form3
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		ClientSize = New Size(800, 775)
		Controls.Add(MenuStrip1)
		Controls.Add(Panel1)
		MainMenuStrip = MenuStrip1
		Name = "Form3"
		Text = "Form3"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage1.PerformLayout()
		CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
		TabPage2.ResumeLayout(False)
		TabPage2.PerformLayout()
		CType(picPaket, ComponentModel.ISupportInitialize).EndInit()
		CType(dgvPaket, ComponentModel.ISupportInitialize).EndInit()
		TabPage3.ResumeLayout(False)
		TabPage3.PerformLayout()
		CType(dgvReservasi, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents MenuKelolaData As ToolStripMenuItem
	Friend WithEvents MenuKeluar As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents mtbNoHp As MaskedTextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtCariPelanggan As TextBox
	Friend WithEvents dgvPelanggan As DataGridView
	Friend WithEvents txtCariPaket As TextBox
	Friend WithEvents dgvPaket As DataGridView
	Friend WithEvents txtPaket As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents btnUbah2 As Button
	Friend WithEvents btnTambah2 As Button
	Friend WithEvents btnHapus2 As Button
	Friend WithEvents btnReset1 As Button
	Friend WithEvents btnHapus1 As Button
	Friend WithEvents btnUbah1 As Button
	Friend WithEvents btnTambah1 As Button
	Friend WithEvents btnReset2 As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents btnBrowse As Button
	Friend WithEvents picPaket As PictureBox
	Friend WithEvents txtDurasi As TextBox
	Friend WithEvents txtHarga As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents btnReset3 As Button
	Friend WithEvents btnHapus3 As Button
	Friend WithEvents btnUbah3 As Button
	Friend WithEvents btnTambah3 As Button
	Friend WithEvents txtCariReservasi As TextBox
	Friend WithEvents dgvReservasi As DataGridView
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents cbPelanggan As ComboBox
	Friend WithEvents cbPaket As ComboBox
	Friend WithEvents Label14 As Label
	Friend WithEvents dtpTanggal As DateTimePicker
	Friend WithEvents Label13 As Label
	Friend WithEvents btnCetak As Button
	Friend WithEvents txtJam As TextBox
	Friend WithEvents txtKodePaket As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents txtKodePelanggan As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents txtKodeReservasi As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents Label19 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label20 As Label
	Friend WithEvents Panel2 As Panel
End Class
