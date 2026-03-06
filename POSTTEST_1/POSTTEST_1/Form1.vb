Public Class Form1

    Dim totalIPS As Double
    Dim jumlahSemester As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double
        Dim ipk As Double
        Dim predikat As String

        If Double.TryParse(txtIPS.Text, ips) Then

			If ips >= 0 AndAlso ips <= 4 Then
				totalIPS = totalIPS + ips
				jumlahSemester = jumlahSemester + 1
				ipk = totalIPS / jumlahSemester
				txtIPK.Text = ipk.ToString("0.00")

				If ipk >= 2.0 And ipk <= 2.75 Then
					predikat = "Cukup"
				ElseIf ipk >= 2.76 And ipk <= 3.0 Then
					predikat = "Memuaskan"
				ElseIf ipk >= 3.01 Then
					predikat = "Sangat Memuaskan"
				Else
					predikat = "nt"
				End If

				lblPredikat.Text = predikat
				txtIPS.Text = ""
			Else
				MessageBox.Show("Input harus antara 0.00 dan 4.00!")
			End If

		Else
            MessageBox.Show("Input harus angka!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIPS = 0
        jumlahSemester = 0
        txtIPK.Text = "0.00"
        lblPredikat.Text = "Predikat"
        txtIPS.Text = ""

    End Sub

End Class