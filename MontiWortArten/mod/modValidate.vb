Module modValidate

    Public Sub ValidText(ByRef tbText As TextBox)

        If Not tbText.Text Is Nothing Then
            If Not String.IsNullOrEmpty(tbText.Text) Then

                Dim iLength As Integer = tbText.Text.Length - 1
                Dim bExtend As Boolean

                For i As Integer = 0 To iLength
                    If Not Char.IsLetter(tbText.Text.Chars(i)) Then
                        If tbText.Text.Chars(i) = "." Or tbText.Text.Chars(i) = "," Or tbText.Text.Chars(i) = "?" Or tbText.Text.Chars(i) = "!" Then
                            bExtend = True
                        Else
                            bExtend = False
                        End If

                        If tbText.Tag Is Nothing Then
                            If Not bExtend Then
                                tbText.Text = tbText.Text.Remove(i, 1)
                                iLength = tbText.Text.Length - 1
                                tbText.Select(iLength + 1, 0)
                            End If
                        Else
                            tbText.Text = tbText.Text.Remove(i, 1)
                            iLength = tbText.Text.Length - 1
                            tbText.Select(iLength + 1, 0)
                        End If

                    End If
                    If i = iLength Then Exit For
                Next

            End If
        End If

    End Sub

End Module
