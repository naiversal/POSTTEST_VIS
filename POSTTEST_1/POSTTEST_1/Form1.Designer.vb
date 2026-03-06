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
        lblIPS = New Label()
        lblIPK = New Label()
        lblPredikat = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Font = New Font("Helvetica", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIPS.ForeColor = SystemColors.WindowText
        lblIPS.Location = New Point(210, 150)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(109, 21)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Font = New Font("Helvetica", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIPK.ForeColor = Color.Black
        lblIPK.Location = New Point(208, 236)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(107, 21)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.BackColor = Color.Transparent
        lblPredikat.Font = New Font("Helvetica", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPredikat.ForeColor = Color.Black
        lblPredikat.Location = New Point(355, 279)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(76, 21)
        lblPredikat.TabIndex = 2
        lblPredikat.Text = "Predikat"
        ' 
        ' txtIPS
        ' 
        txtIPS.BackColor = Color.GhostWhite
        txtIPS.Location = New Point(355, 147)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(230, 31)
        txtIPS.TabIndex = 3
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = Color.GhostWhite
        txtIPK.Location = New Point(355, 236)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(230, 31)
        txtIPK.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Lavender
        btnTambah.Font = New Font("Helvetica", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = SystemColors.ControlText
        btnTambah.Location = New Point(355, 184)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Lavender
        btnReset.Font = New Font("Helvetica", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(473, 184)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(lblPredikat)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
