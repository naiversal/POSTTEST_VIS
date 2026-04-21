Public Class Form2
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If txtUsername.Text = "inayah" And txtPassword.Text = "068" Then
			Form3.Show()
			Me.Hide()
		Else
			MessageBox.Show("Username atau Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Application.Exit()
	End Sub

End Class