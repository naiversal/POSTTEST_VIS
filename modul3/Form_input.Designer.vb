<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Input))
        Panel1 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        Text_password = New TextBox()
        Text_user = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 160)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Helvetica", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(199, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 57)
        Label2.TabIndex = 3
        Label2.Text = "2022"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Helvetica", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(17, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 21)
        Label3.TabIndex = 2
        Label3.Text = "Form Input"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Helvetica", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(128, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 29)
        Label1.TabIndex = 0
        Label1.Text = "VISUAL STUDIO"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Lavender
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Text_password)
        Panel2.Controls.Add(Text_user)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(360, 426)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue
        Button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button1.Location = New Point(223, 359)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Text_password
        ' 
        Text_password.Location = New Point(159, 279)
        Text_password.MaxLength = 6
        Text_password.Name = "Text_password"
        Text_password.PasswordChar = "•"c
        Text_password.Size = New Size(150, 31)
        Text_password.TabIndex = 3
        ' 
        ' Text_user
        ' 
        Text_user.Location = New Point(159, 229)
        Text_user.Name = "Text_user"
        Text_user.Size = New Size(150, 31)
        Text_user.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 1
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 0
        Label4.Text = "Username"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Form_Input
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 450)
        Controls.Add(Panel2)
        Name = "Form_Input"
        Text = "Form_Input"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Text_password As TextBox
    Friend WithEvents Text_user As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label

End Class
