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
        PictureBox1 = New PictureBox()
        Me.lblNama = New Label()
        Me.lblNim = New Label()
        lblTLahir = New Label()
        lblJK = New Label()
        lblHobi = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(70, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(218, 280)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New Point(352, 97)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New Size(63, 25)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "lblNama"
        ' 
        ' lblNim
        ' 
        Me.lblNim.AutoSize = True
        Me.lblNim.Location = New Point(352, 151)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New Size(63, 25)
        Me.lblNim.TabIndex = 2
        Me.lblNim.Text = "lblNim"
        ' 
        ' lblTLahir
        ' 
        lblTLahir.AutoSize = True
        lblTLahir.Location = New Point(352, 204)
        lblTLahir.Name = "lblTLahir"
        lblTLahir.Size = New Size(63, 25)
        lblTLahir.TabIndex = 3
        lblTLahir.Text = "Label3"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(352, 260)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(63, 25)
        lblJK.TabIndex = 4
        lblJK.Text = "Label4"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(352, 322)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(63, 25)
        lblHobi.TabIndex = 5
        lblHobi.Text = "Label5"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobi)
        Controls.Add(lblJK)
        Controls.Add(lblTLahir)
        Controls.Add(Me.lblNim)
        Controls.Add(Me.lblNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblTLahir As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobi As Label
End Class
