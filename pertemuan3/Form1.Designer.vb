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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        picProfil = New PictureBox()
        dtpLahir = New DateTimePicker()
        gbJK = New GroupBox()
        rbCewe = New RadioButton()
        rbCowo = New RadioButton()
        gbHobi = New GroupBox()
        cbGame = New CheckBox()
        cbBaca = New CheckBox()
        cbMancing = New CheckBox()
        btnGambar = New Button()
        btnCetak = New Button()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbJK.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(348, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(348, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(348, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(503, 47)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(460, 31)
        txtNama.TabIndex = 3
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(504, 99)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(459, 31)
        txtNim.TabIndex = 4
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(33, 40)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(275, 351)
        picProfil.TabIndex = 5
        picProfil.TabStop = False
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(504, 159)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(459, 31)
        dtpLahir.TabIndex = 6
        ' 
        ' gbJK
        ' 
        gbJK.Controls.Add(rbCewe)
        gbJK.Controls.Add(rbCowo)
        gbJK.Location = New Point(348, 206)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(300, 150)
        gbJK.TabIndex = 7
        gbJK.TabStop = False
        gbJK.Text = "Jenis Kelamin"
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.Location = New Point(137, 89)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(126, 29)
        rbCewe.TabIndex = 1
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = True
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.Location = New Point(30, 47)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(104, 29)
        rbCowo.TabIndex = 0
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-Laki"
        rbCowo.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbGame)
        gbHobi.Controls.Add(cbBaca)
        gbHobi.Controls.Add(cbMancing)
        gbHobi.Location = New Point(663, 206)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(300, 150)
        gbHobi.TabIndex = 8
        gbHobi.TabStop = False
        gbHobi.Text = "hobi"
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(168, 68)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(100, 29)
        cbGame.TabIndex = 2
        cbGame.Text = "Gaming"
        cbGame.ThreeState = True
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.Location = New Point(33, 94)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(116, 29)
        cbBaca.TabIndex = 1
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(33, 35)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(106, 29)
        cbMancing.TabIndex = 0
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' btnGambar
        ' 
        btnGambar.Location = New Point(99, 397)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(143, 34)
        btnGambar.TabIndex = 9
        btnGambar.Text = "Pilih Gambar"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(348, 397)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(615, 34)
        btnCetak.TabIndex = 10
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(989, 449)
        Controls.Add(btnCetak)
        Controls.Add(btnGambar)
        Controls.Add(gbHobi)
        Controls.Add(gbJK)
        Controls.Add(dtpLahir)
        Controls.Add(picProfil)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents btnCetak As Button

End Class
