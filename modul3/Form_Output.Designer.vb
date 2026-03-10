<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Output
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
        Label1 = New Label()
        user_name = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 43)
        Label1.TabIndex = 0
        Label1.Text = "SELAMAT DATANG"
        ' 
        ' user_name
        ' 
        user_name.AutoSize = True
        user_name.Font = New Font("Helvetica", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        user_name.Location = New Point(211, 153)
        user_name.Name = "user_name"
        user_name.Size = New Size(105, 21)
        user_name.TabIndex = 1
        user_name.Text = "user_name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(237, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 2
        Label3.Text = "halo!"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 365)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(516, 73)
        Panel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form_Output
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 450)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(user_name)
        Controls.Add(Label1)
        Name = "Form_Output"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents user_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
