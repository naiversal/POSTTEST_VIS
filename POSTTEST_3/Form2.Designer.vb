<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblLahir = New Label()
        lblJK = New Label()
        lblTelpon = New Label()
        lblHobi = New Label()
        lblAlamat = New Label()
        Panel2 = New Panel()
        Panel6 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label16 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(843, 73)
        Panel1.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel7.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(0))
        Panel7.Location = New Point(110, 31)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(408, 10)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Alagard", 22.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Label1.Location = New Point(524, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 41)
        Label1.TabIndex = 0
        Label1.Text = "ATEENAGERZ"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(61, 94)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(215, 295)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(320, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 3
        Label2.Text = "Nama :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(538, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 21)
        Label3.TabIndex = 4
        Label3.Text = "Umur :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(538, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 21)
        Label4.TabIndex = 5
        Label4.Text = "Tanggal Lahir :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(320, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 21)
        Label5.TabIndex = 6
        Label5.Text = "Jenis Kelamin :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(320, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 21)
        Label6.TabIndex = 7
        Label6.Text = "No Telpon :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(538, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 21)
        Label7.TabIndex = 8
        Label7.Text = "Hobi :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("Helvetica", 9.0F, FontStyle.Bold)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(322, 305)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 21)
        Label8.TabIndex = 9
        Label8.Text = "Alamat :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Helvetica", 8.999999F)
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(320, 142)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(64, 21)
        lblNama.TabIndex = 10
        lblNama.Text = "Label9"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Helvetica", 8.999999F)
        lblUmur.ForeColor = Color.Black
        lblUmur.Location = New Point(538, 208)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(74, 21)
        lblUmur.TabIndex = 11
        lblUmur.Text = "Label10"
        ' 
        ' lblLahir
        ' 
        lblLahir.AutoSize = True
        lblLahir.BackColor = Color.Transparent
        lblLahir.Font = New Font("Helvetica", 8.999999F)
        lblLahir.ForeColor = Color.Black
        lblLahir.Location = New Point(538, 142)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(74, 21)
        lblLahir.TabIndex = 12
        lblLahir.Text = "Label11"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.BackColor = Color.Transparent
        lblJK.Font = New Font("Helvetica", 8.999999F)
        lblJK.ForeColor = Color.Black
        lblJK.Location = New Point(320, 208)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(74, 21)
        lblJK.TabIndex = 13
        lblJK.Text = "Label12"
        ' 
        ' lblTelpon
        ' 
        lblTelpon.AutoSize = True
        lblTelpon.BackColor = Color.Transparent
        lblTelpon.Font = New Font("Helvetica", 8.999999F)
        lblTelpon.ForeColor = Color.Black
        lblTelpon.Location = New Point(322, 271)
        lblTelpon.Name = "lblTelpon"
        lblTelpon.Size = New Size(74, 21)
        lblTelpon.TabIndex = 14
        lblTelpon.Text = "Label13"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Helvetica", 8.999999F)
        lblHobi.ForeColor = Color.Black
        lblHobi.Location = New Point(538, 271)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(74, 21)
        lblHobi.TabIndex = 15
        lblHobi.Text = "Label14"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Helvetica", 8.999999F)
        lblAlamat.ForeColor = Color.Black
        lblAlamat.Location = New Point(322, 336)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(74, 21)
        lblAlamat.TabIndex = 16
        lblAlamat.Text = "Label15"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label16)
        Panel2.Location = New Point(0, 413)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(843, 57)
        Panel2.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel6.Location = New Point(-10, 35)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(300, 10)
        Panel6.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel5.Location = New Point(-50, 16)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(355, 10)
        Panel5.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel4.Location = New Point(580, 32)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 10)
        Panel4.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Panel3.Location = New Point(590, 16)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(297, 10)
        Panel3.TabIndex = 18
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Helvetica", 16.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(220), CByte(86), CByte(141))
        Label16.Location = New Point(311, 7)
        Label16.Name = "Label16"
        Label16.Size = New Size(263, 38)
        Label16.TabIndex = 17
        Label16.Text = "IDENTITY CARD"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(538, 305)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(233, 58)
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(843, 467)
        Controls.Add(PictureBox3)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobi)
        Controls.Add(lblTelpon)
        Controls.Add(lblJK)
        Controls.Add(lblLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblLahir As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTelpon As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
