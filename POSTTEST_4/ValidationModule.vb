Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMasked(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiCombo(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadio(ep As ErrorProvider, gb As GroupBox, pesan As String) As Boolean
        For Each c As Control In gb.Controls
            If TypeOf c Is RadioButton AndAlso CType(c, RadioButton).Checked Then
                ep.SetError(gb, "")
                Return True
            End If
        Next
        ep.SetError(gb, pesan)
        Return False
    End Function

    Public Function ValidasiCheck(ep As ErrorProvider, gb As GroupBox, pesan As String) As Boolean
        For Each c As Control In gb.Controls
            If TypeOf c Is CheckBox AndAlso CType(c, CheckBox).Checked Then
                ep.SetError(gb, "")
                Return True
            End If
        Next
        ep.SetError(gb, pesan)
        Return False
    End Function

End Module