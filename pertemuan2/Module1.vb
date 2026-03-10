Module Module1
    Public daftarMahasiswa(99, 1) As String
    Public jumlahMahasiswa As Integer = 0

    Public Sub tambahMahasiswa(ByVal nama As String, ByVal nim As String)
        If jumlahMahasiswa < 100 Then
            daftarMahasiswa(jumlahMahasiswa, 0) = nama
            daftarMahasiswa(jumlahMahasiswa, 1) = nim
            jumlahMahasiswa += 1
        End If
    End Sub

    Public Sub editMahasiswa(ByVal index As Integer, ByVal nama As String, ByVal nim As String)
        If index >= 0 And index < jumlahMahasiswa Then
            daftarMahasiswa(index, 0) = nama
            daftarMahasiswa(index, 1) = nim
        End If
    End Sub

    Public Sub hapusMahasiswa(ByVal index As Integer)
        If index >= 0 And index < jumlahMahasiswa Then
            For i As Integer = index To jumlahMahasiswa - 2
                daftarMahasiswa(i, 0) = daftarMahasiswa(i + 1, 0)
                daftarMahasiswa(i, 1) = daftarMahasiswa(i + 1, 1)
            Next
            jumlahMahasiswa -= 1
            daftarMahasiswa(jumlahMahasiswa, 0) = Nothing
            daftarMahasiswa(jumlahMahasiswa, 1) = Nothing
        End If
    End Sub
End Module