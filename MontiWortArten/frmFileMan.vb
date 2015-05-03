Imports System.IO

Public Class frmFileMan

#Region "Declaration - Public"



#End Region

#Region "Declaration - Private"

    Dim dtFile As New DataTable("Value")

    Dim bFirstrun As Boolean

#End Region

    Private Sub frmFileMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.bFirstrun Then
            Call modDataTable.Init(Me.dtFile)
            Me.bFirstrun = True
        End If

        Dim sDirectory() As String = Directory.GetDirectories(Application.StartupPath & "\Public\", "*.*", SearchOption.AllDirectories)
        Dim iLenght As Integer = Application.StartupPath.Length + 8

        Me.lblContent.Text = ""

        Me.lbFolders.Items.Clear()

        For Each s As String In sDirectory
            Me.lbFolders.Items.Add(s.Remove(0, iLenght))
        Next

        If Not Me.lbFolders.Items.Count = 0 Then
            Me.lbFolders.SelectedIndex = 0
        End If

    End Sub

    Private Sub lbFolders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFolders.SelectedIndexChanged

        If Not Me.lbFolders.SelectedIndex < 0 Then

            Dim sFiles() As String = Directory.GetFiles(Application.StartupPath & "\Public\" & Me.lbFolders.SelectedItem.ToString)
            Dim iLenght As Integer = Application.StartupPath.Length + 8

            Me.lbFiles.Items.Clear()

            For Each s As String In sFiles
                Me.lbFiles.Items.Add(s.Remove(0, iLenght))
            Next

        End If

    End Sub

    Private Sub lbFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFiles.SelectedIndexChanged

        If Not Me.lbFiles.SelectedIndex < 0 Then
            If File.Exists(Application.StartupPath & "\Public\" & Me.lbFiles.SelectedItem.ToString) Then
                Dim sText As String = ""
                Me.lblContent.Text = sText
                Me.dtFile.Clear()
                Me.dtFile.ReadXml(Application.StartupPath & "\Public\" & Me.lbFiles.SelectedItem.ToString)
                For i As Integer = 0 To Me.dtFile.Rows.Count - 1
                    sText = sText & CStr(Me.dtFile.Rows(i).Item(0)) & " "
                Next
                Me.lblContent.Text = sText
            End If
        End If

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        If Not Me.lbFiles.SelectedIndex < 0 Then
            If Not String.IsNullOrEmpty(Application.StartupPath & "\Public\" & Me.lbFiles.SelectedItem.ToString) Then
                frmMain.sFile = Application.StartupPath & "\Public\" & Me.lbFiles.SelectedItem.ToString
                Me.Close()
            End If
        End If

    End Sub

End Class