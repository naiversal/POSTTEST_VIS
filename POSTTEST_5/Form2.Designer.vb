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
		Label2 = New Label()
		Label1 = New Label()
		Panel1 = New Panel()
		Label5 = New Label()
		Button1 = New Button()
		txtPassword = New TextBox()
		txtUsername = New TextBox()
		Label4 = New Label()
		Label3 = New Label()
		Panel1.SuspendLayout()
		SuspendLayout()
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Alagard", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Label2.Location = New Point(53, 107)
		Label2.Name = "Label2"
		Label2.Size = New Size(324, 45)
		Label2.TabIndex = 3
		Label2.Text = "Kinyis-Kinyis"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Helvetica", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Label1.Location = New Point(127, 60)
		Label1.Name = "Label1"
		Label1.Size = New Size(173, 47)
		Label1.TabIndex = 2
		Label1.Text = "STUDIO"
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		Panel1.Controls.Add(Label5)
		Panel1.Controls.Add(Button1)
		Panel1.Controls.Add(txtPassword)
		Panel1.Controls.Add(txtUsername)
		Panel1.Controls.Add(Label4)
		Panel1.Controls.Add(Label3)
		Panel1.Controls.Add(Label2)
		Panel1.Controls.Add(Label1)
		Panel1.Location = New Point(12, 12)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(425, 507)
		Panel1.TabIndex = 4
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(144, 157)
		Label5.Name = "Label5"
		Label5.Size = New Size(135, 25)
		Label5.TabIndex = 9
		Label5.Text = "Silahkan Login;)"
		' 
		' Button1
		' 
		Button1.BackColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(245), CByte(105), CByte(137))
		Button1.FlatStyle = FlatStyle.Flat
		Button1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Button1.ForeColor = Color.FromArgb(CByte(243), CByte(238), CByte(241))
		Button1.Location = New Point(121, 416)
		Button1.Name = "Button1"
		Button1.Size = New Size(191, 41)
		Button1.TabIndex = 8
		Button1.Text = "Masuk"
		Button1.UseVisualStyleBackColor = False
		' 
		' txtPassword
		' 
		txtPassword.Location = New Point(37, 334)
		txtPassword.Name = "txtPassword"
		txtPassword.PasswordChar = "*"c
		txtPassword.Size = New Size(356, 31)
		txtPassword.TabIndex = 7
		' 
		' txtUsername
		' 
		txtUsername.Location = New Point(37, 250)
		txtUsername.Name = "txtUsername"
		txtUsername.Size = New Size(356, 31)
		txtUsername.TabIndex = 6
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(37, 306)
		Label4.Name = "Label4"
		Label4.Size = New Size(87, 25)
		Label4.TabIndex = 5
		Label4.Text = "Password"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(37, 222)
		Label3.Name = "Label3"
		Label3.Size = New Size(91, 25)
		Label3.TabIndex = 4
		Label3.Text = "Username"
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(213), CByte(105), CByte(137))
		ClientSize = New Size(447, 530)
		Controls.Add(Panel1)
		Name = "Form2"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Login"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label5 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
End Class
