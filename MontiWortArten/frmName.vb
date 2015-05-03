Public Class frmName

#Region "Declaration - Private"

    Private bRunning As Boolean

#End Region

    Private Sub tbName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbName.TextChanged

        Call modValidate.ValidText(Me.tbName)

        If Me.tbName.TextLength >= 3 Then
            Me.btnName.Enabled = True
        Else
            Me.btnName.Enabled = False
        End If

    End Sub

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click

        If Not String.IsNullOrEmpty(Me.tbName.Text) Then
            frmMain.sName = Me.tbName.Text
            If Not String.IsNullOrEmpty(frmMain.sName) Then
                Me.Close()
            End If
        End If

    End Sub

End Class