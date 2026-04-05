<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kartu
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kartu))
		Label7 = New Label()
		PictureBox2 = New PictureBox()
		PictureBox1 = New PictureBox()
		Label1 = New Label()
		lblNama = New Label()
		lblId = New Label()
		Label4 = New Label()
		Label2 = New Label()
		lblPeran = New Label()
		lblNo = New Label()
		Label5 = New Label()
		lblEmail = New Label()
		lblHobi = New Label()
		Label6 = New Label()
		Label3 = New Label()
		Label8 = New Label()
		lblTL = New Label()
		Label10 = New Label()
		lblAlamat = New Label()
		Label11 = New Label()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Helvetica Rounded", 17.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.HotPink
		Label7.Location = New Point(130, 47)
		Label7.Name = "Label7"
		Label7.Size = New Size(489, 42)
		Label7.TabIndex = 5
		Label7.Text = "Kinyis-Kinyis Club Member"
		' 
		' PictureBox2
		' 
		PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
		PictureBox2.Location = New Point(54, 28)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(70, 70)
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox2.TabIndex = 6
		PictureBox2.TabStop = False
		' 
		' PictureBox1
		' 
		PictureBox1.Location = New Point(54, 122)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(150, 150)
		PictureBox1.TabIndex = 7
		PictureBox1.TabStop = False
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(253, 122)
		Label1.Name = "Label1"
		Label1.Size = New Size(131, 25)
		Label1.TabIndex = 9
		Label1.Text = "Nama Lengkap"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.Location = New Point(253, 147)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(71, 30)
		lblNama.TabIndex = 10
		lblNama.Text = "Nama"
		' 
		' lblId
		' 
		lblId.AutoSize = True
		lblId.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblId.Location = New Point(253, 282)
		lblId.Name = "lblId"
		lblId.Size = New Size(35, 30)
		lblId.TabIndex = 12
		lblId.Text = "ID"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(253, 257)
		Label4.Name = "Label4"
		Label4.Size = New Size(105, 25)
		Label4.TabIndex = 11
		Label4.Text = "ID Anggota"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(105, 296)
		Label2.Name = "Label2"
		Label2.Size = New Size(46, 25)
		Label2.TabIndex = 13
		Label2.Text = "Role"
		' 
		' lblPeran
		' 
		lblPeran.AutoSize = True
		lblPeran.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblPeran.Location = New Point(82, 323)
		lblPeran.Name = "lblPeran"
		lblPeran.Size = New Size(57, 30)
		lblPeran.TabIndex = 14
		lblPeran.Text = "Role"
		' 
		' lblNo
		' 
		lblNo.AutoSize = True
		lblNo.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNo.Location = New Point(253, 353)
		lblNo.Name = "lblNo"
		lblNo.Size = New Size(114, 30)
		lblNo.TabIndex = 16
		lblNo.Text = "No telpon"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(253, 328)
		Label5.Name = "Label5"
		Label5.Size = New Size(67, 25)
		Label5.TabIndex = 15
		Label5.Text = "Kontak"
		' 
		' lblEmail
		' 
		lblEmail.AutoSize = True
		lblEmail.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblEmail.Location = New Point(253, 383)
		lblEmail.Name = "lblEmail"
		lblEmail.Size = New Size(66, 30)
		lblEmail.TabIndex = 17
		lblEmail.Text = "Email"
		' 
		' lblHobi
		' 
		lblHobi.AutoSize = True
		lblHobi.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHobi.Location = New Point(496, 147)
		lblHobi.Name = "lblHobi"
		lblHobi.Size = New Size(61, 30)
		lblHobi.TabIndex = 19
		lblHobi.Text = "Hobi"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(496, 122)
		Label6.Name = "Label6"
		Label6.Size = New Size(51, 25)
		Label6.TabIndex = 18
		Label6.Text = "Hobi"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(496, 212)
		Label3.Name = "Label3"
		Label3.Size = New Size(61, 30)
		Label3.TabIndex = 21
		Label3.Text = "Hobi"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(496, 187)
		Label8.Name = "Label8"
		Label8.Size = New Size(51, 25)
		Label8.TabIndex = 20
		Label8.Text = "Hobi"
		' 
		' lblTL
		' 
		lblTL.AutoSize = True
		lblTL.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTL.Location = New Point(253, 212)
		lblTL.Name = "lblTL"
		lblTL.Size = New Size(90, 30)
		lblTL.TabIndex = 23
		lblTL.Text = "Tanggal"
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Location = New Point(253, 187)
		Label10.Name = "Label10"
		Label10.Size = New Size(115, 25)
		Label10.TabIndex = 22
		Label10.Text = "Tanggal Lahir"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblAlamat.Location = New Point(496, 282)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(83, 30)
		lblAlamat.TabIndex = 25
		lblAlamat.Text = "Alamat"
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.Location = New Point(496, 257)
		Label11.Name = "Label11"
		Label11.Size = New Size(68, 25)
		Label11.TabIndex = 24
		Label11.Text = "Alamat"
		' 
		' Kartu
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.MistyRose
		ClientSize = New Size(718, 450)
		Controls.Add(lblAlamat)
		Controls.Add(Label11)
		Controls.Add(lblTL)
		Controls.Add(Label10)
		Controls.Add(Label3)
		Controls.Add(Label8)
		Controls.Add(lblHobi)
		Controls.Add(Label6)
		Controls.Add(lblEmail)
		Controls.Add(lblNo)
		Controls.Add(Label5)
		Controls.Add(lblPeran)
		Controls.Add(Label2)
		Controls.Add(lblId)
		Controls.Add(Label4)
		Controls.Add(lblNama)
		Controls.Add(Label1)
		Controls.Add(PictureBox1)
		Controls.Add(Label7)
		Controls.Add(PictureBox2)
		Name = "Kartu"
		Text = "Kartu"
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label7 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents lblId As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblPeran As Label
	Friend WithEvents lblNo As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents lblHobi As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lblTL As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents Label11 As Label
End Class
