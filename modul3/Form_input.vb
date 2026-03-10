Public Class Form_Input
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Form_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Left = Me.Width
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel2.Left > 12 Then
            Panel2.Left = Int(Panel2.Left - 20)
        Else
            Panel2.Left = 12
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Text_user.Text = "inayah" And Text_password.Text = "123456" Then
            login_berhasil()
        Else
            MsgBox("paswot salah")
        End If

    End Sub

	Private Sub login_berhasil()
		Form_output.user_name.Text = Text_user.Text()
        Form_output.Show()
    End Sub
End Class
