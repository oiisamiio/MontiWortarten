Public Class frmSave

#Region "Declaration - Private"

    Private bRunning As Boolean

#End Region

    Private Sub tbSave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSave.TextChanged

        If Me.tbSave.TextLength >= 3 Then
            Me.btnSave.Enabled = True
        Else
            Me.btnSave.Enabled = False
        End If

        Call modValidate.ValidText(Me.tbSave)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not String.IsNullOrEmpty(Me.tbSave.Text) Then
            frmMain.sFileExt = Me.tbSave.Text
            If Not String.IsNullOrEmpty(frmMain.sName) Then
                Me.Close()
            End If
        End If

    End Sub

End Class