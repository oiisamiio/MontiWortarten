Module modVariants

    Public Sub SetLevel(ByVal iWortart As Byte, ByVal bChecked() As Boolean, ByVal flowOptions As FlowLayoutPanel)

        Dim iHeight, iCount, iDyn As Integer

        iDyn = 1

        For i As Integer = 0 To bChecked.Length - 1

            Select Case i
                Case Is = 7
                    iDyn += 1
                Case Is = 14
                    iDyn += 1
            End Select

            If bChecked(i) Then
                If i = iWortart Then
                    flowOptions.Controls.Item(iWortart + iDyn).Visible = True
                End If
                iCount += 1
            Else
                If i = iWortart Then
                    flowOptions.Controls.Item(iWortart + iDyn).Visible = False
                End If
            End If
        Next

        Select Case iCount
            Case Is <= 7
                iHeight = 85
                Exit Select
            Case Is <= 14
                iHeight = 128 + 85
                Exit Select
            Case Is <= 21
                iHeight = 128 + 128 + 85
                Exit Select
        End Select

        iHeight = (500 - 340) + iHeight

        frmOptions.ClientSize = New System.Drawing.Size(660, iHeight)

    End Sub

    Public Sub SetOptions(ByVal bMax As Boolean, ByVal i As Integer, ByVal bChecked() As Boolean, ByVal iDyn As Integer, ByVal flowOptions As FlowLayoutPanel)

        If bChecked(i) Then
            flowOptions.Controls.Item(i + iDyn).Visible = True
        Else
            flowOptions.Controls.Item(i + iDyn).Visible = False
        End If

        If bMax Then
            frmOptions.ClientSize = New System.Drawing.Size(660, 500)
        Else
            frmOptions.ClientSize = New System.Drawing.Size(660, 245)
        End If

    End Sub

End Module
