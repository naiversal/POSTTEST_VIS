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
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtTambahGenre = New TextBox()
        txtTambahJudul = New TextBox()
        txtHapusJudul = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        GroupBox3 = New GroupBox()
        lstBuku = New ListBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 25)
        Label2.TabIndex = 2
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 3
        Label3.Text = "Genre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 25)
        Label5.TabIndex = 5
        Label5.Text = "Judul Buku"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtTambahGenre)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.ForeColor = SystemColors.MenuText
        GroupBox1.Location = New Point(41, 120)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(342, 253)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "TAMBAH BUKU"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.RoyalBlue
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.ForeColor = SystemColors.ButtonHighlight
        btnTambah.Location = New Point(19, 185)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(304, 47)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtTambahGenre
        ' 
        txtTambahGenre.Location = New Point(19, 144)
        txtTambahGenre.Name = "txtTambahGenre"
        txtTambahGenre.Size = New Size(304, 31)
        txtTambahGenre.TabIndex = 10
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(19, 73)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(304, 31)
        txtTambahJudul.TabIndex = 9
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(14, 73)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(318, 31)
        txtHapusJudul.TabIndex = 11
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.AliceBlue
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(41, 396)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(342, 202)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Crimson
        btnHapus.ForeColor = SystemColors.Control
        btnHapus.Location = New Point(14, 142)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(318, 47)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.AliceBlue
        GroupBox3.Controls.Add(lstBuku)
        GroupBox3.Location = New Point(389, 120)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(368, 478)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Daftar Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(8, 30)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(354, 429)
        lstBuku.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Harlow Solid Italic", 28F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(254, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 71)
        Label1.TabIndex = 9
        Label1.Text = "Nayo's Library"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(185, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(81, 84)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(800, 662)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents txtTambahGenre As TextBox
    Friend WithEvents txtHapusJudul As TextBox

End Class
