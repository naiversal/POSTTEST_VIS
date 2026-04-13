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
		Label1 = New Label()
		Label2 = New Label()
		Panel1 = New Panel()
		btnMasuk = New Button()
		Panel1.SuspendLayout()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Helvetica", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Label1.Location = New Point(290, 149)
		Label1.Name = "Label1"
		Label1.Size = New Size(205, 57)
		Label1.TabIndex = 0
		Label1.Text = "STUDIO"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Alagard", 28.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(12, 1)
		Label2.Name = "Label2"
		Label2.Size = New Size(379, 53)
		Label2.TabIndex = 1
		Label2.Text = "Kinyis-Kinyis"
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(194), CByte(220), CByte(128))
		Panel1.Controls.Add(Label2)
		Panel1.Location = New Point(190, 206)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(396, 57)
		Panel1.TabIndex = 2
		' 
		' btnMasuk
		' 
		btnMasuk.BackColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		btnMasuk.BackgroundImageLayout = ImageLayout.None
		btnMasuk.FlatAppearance.BorderColor = Color.FromArgb(CByte(245), CByte(105), CByte(137))
		btnMasuk.FlatStyle = FlatStyle.Flat
		btnMasuk.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnMasuk.ForeColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		btnMasuk.Location = New Point(315, 287)
		btnMasuk.Name = "btnMasuk"
		btnMasuk.Size = New Size(155, 44)
		btnMasuk.TabIndex = 3
		btnMasuk.Text = "Masuk"
		btnMasuk.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
		BackgroundImageLayout = ImageLayout.Zoom
		ClientSize = New Size(801, 450)
		Controls.Add(btnMasuk)
		Controls.Add(Label1)
		Controls.Add(Panel1)
		DoubleBuffered = True
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form1"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMasuk As Button

End Class
