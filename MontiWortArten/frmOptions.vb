Public Class frmOptions

#Region "Declaration"



#End Region

    Friend Sub pbWordxxx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            If Not DirectCast(sender, PictureBox).Tag Is Nothing Then
                Dim sTag() As String = DirectCast(sender, PictureBox).Tag.ToString.Split(CChar(":"))

                frmMain.dtValue.Rows(frmMain.iSelection).Item(1) = CByte(sTag(0))
            End If

            Me.Close()

        End If

    End Sub

    Friend Sub pbWordxxx_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then

            Dim sTag() As String = DirectCast(sender, PictureBox).Tag.ToString.Split(CChar(":"))

            DirectCast(sender, PictureBox).Size = New System.Drawing.Size(128, 128)

            Call modControls.SetText(Me.pbSymText, sTag(0))

        End If

    End Sub

    Friend Sub pbWordxxx_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            DirectCast(sender, PictureBox).Size = New System.Drawing.Size(85, 85)
        End If

    End Sub
End Class