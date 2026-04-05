Imports System.IO
Imports System.Text

Module DataModule

    Public Function BuatIsiFile(nama As String, id As String, hp As String, email As String, alamat As String, divisi As String, hobi As String) As String
        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama)
        sb.AppendLine("ID=" & id)
        sb.AppendLine("HP=" & hp)
        sb.AppendLine("Email=" & email)
        sb.AppendLine("Alamat=" & alamat)
        sb.AppendLine("Divisi=" & divisi)
        sb.Append("Hobi=" & hobi)

        Return sb.ToString()
    End Function

    Public Function BukaData(ofd As OpenFileDialog) As Dictionary(Of String, String)
        If ofd.ShowDialog <> DialogResult.OK Then Return Nothing

        Dim data As New Dictionary(Of String, String)

        For Each line In File.ReadAllLines(ofd.FileName)
            Dim p = line.Split("="c)
            If p.Length = 2 Then data(p(0)) = p(1)
        Next

        Return data
    End Function

End Module