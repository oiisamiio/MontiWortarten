Imports System.IO
Imports System.Text

Public Class frmMain

#Region "Declaration - Public"

    Friend iSelection As Byte
    Friend bChecked(20) As Boolean

    Friend sName As String = Nothing

    Friend dtValue As New DataTable("Value")
    Friend sFile As String
    Friend sFileExt As String

#End Region

#Region "Declaration - Private"

    Private iTabIndex As Integer

    Private iWortart As Byte = 0
    Private iCount As Integer = 0
    Private iCounter As Integer = 0

    Private iTraining As Integer
    Private iCountComplete As Integer
    Private iCurTrain As Byte

    Private imgStore As Image

    Private bRunning As Boolean

    Private tCounter As New Timer

#End Region

#Region "Controls - Form - Load"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.monti

        'controls to init
        Dim cControls() As Control = {Me.pbWord0, Me.tbWord0, Me.pbAdd, Me.pbRemove}
        Dim sConfig(,) As String = {}

        Call modControls.Init(cControls, sConfig, frmOptions.flpOptions, Me.tsmiWortarten, Me.tsmiTraining)
        Call modDataTable.Init(Me.dtValue)

        For i As Integer = 0 To 4
            Me.bChecked(i) = True
            Call modVariants.SetLevel(CByte(i), Me.bChecked, frmOptions.flpOptions)
        Next

        frmName.ShowDialog()

        Select Case sName
            Case "sAdminL"
                Me.tsmiDebug.Visible = True
            Case "Vorlagen", "Vorlage"
                Me.tsmiVorlagen.Visible = True
            Case Else
                Me.tsmiDebug.Visible = False
                Me.tsmiVorlagen.Visible = False
        End Select

    End Sub

#End Region

#Region "Controls - PictureBox - Mouse"

    Friend Sub pbWordx_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            If Not DirectCast(sender, PictureBox).Tag Is Nothing Then
                If DirectCast(sender, PictureBox).Tag.Equals("add") Or DirectCast(sender, PictureBox).Tag.Equals("rem") Then
                    DirectCast(sender, PictureBox).Size = New System.Drawing.Size(95, 95)
                Else
                    Me.imgStore = DirectCast(sender, PictureBox).Image
                    DirectCast(sender, PictureBox).Image = My.Resources.m_auswahl
                End If
            End If
        End If

    End Sub

    Friend Sub pbWordx_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            If Not DirectCast(sender, PictureBox).Tag Is Nothing Then
                If DirectCast(sender, PictureBox).Tag.Equals("add") Or DirectCast(sender, PictureBox).Tag.Equals("rem") Then
                    DirectCast(sender, PictureBox).Size = New System.Drawing.Size(70, 70)
                Else
                    If Not Me.imgStore Is Nothing Then
                        DirectCast(sender, PictureBox).Image = Me.imgStore
                    End If
                End If
            End If
        End If

    End Sub

#End Region

#Region "Controls - PictureBox - Click"

    Friend Sub pbWordx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Validate TextBox
        Me.ValidateChildren()

        If TypeOf sender Is PictureBox Then
            If Not CType(sender, PictureBox).Tag Is Nothing Then

                If CType(sender, PictureBox).Tag.Equals("add") Or CType(sender, PictureBox).Tag.Equals("rem") Then
                    If CType(sender, PictureBox).Tag.Equals("add") Then
                        If Not Me.iCount >= 254 Then
                            Call modControls.AddNew(Me.iCount, Me.flpMain)
                            Me.dtValue.Rows.Add("", 0, 0)
                        Else
                            MessageBox.Show("Maximale Anzahl Wörter (255) erreicht...", "Anzahl erreicht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        If Not Me.iCount <= 0 Then
                            Call modControls.Remove(Me.iCount, Me.flpMain)
                            Me.dtValue.Rows.RemoveAt(Me.iCount + 1)
                        Else
                            MessageBox.Show("Letztes Wort kann nicht entfernt werden...", "Anzahl erreicht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    Dim bValid = False

                    For i As Integer = 0 To Me.bChecked.Length - 1
                        If Me.bChecked(i) Then
                            bValid = True
                        End If
                    Next

                    If Not bValid Then
                        MessageBox.Show("Bitte erst Wortarten auswählen!", "Wortart wählen!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Me.iSelection = CByte(CType(sender, PictureBox).Tag)
                        frmOptions.ShowDialog()
                        If Not CByte(Me.dtValue.Rows(Me.iSelection).Item(2)) = 0 Then
                            If CByte(Me.dtValue.Rows(Me.iSelection).Item(2)) = CByte(Me.dtValue.Rows(Me.iSelection).Item(1)) Then
                                CType(sender, PictureBox).Image = modControls.SetPicture(CByte(Me.dtValue.Rows(Me.iSelection).Item(1)))
                                Me.iCountComplete += 1
                                CType(sender, PictureBox).Enabled = False
                            Else
                                CType(sender, PictureBox).Image = modControls.SetPicture(100)
                            End If
                        Else
                            CType(sender, PictureBox).Image = modControls.SetPicture(CByte(Me.dtValue.Rows(Me.iSelection).Item(1)))
                        End If
                        If Me.iCountComplete >= Me.dtValue.Rows.Count Then
                            Me.iCountComplete = 0
                            If MessageBox.Show("Prima! Nächsten Satz laden?", "Satz richtig!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                Call SetTrain(Me.iCurTrain)
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

#End Region

#Region "Controls - TextBox"

    Friend Sub tbWordx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is TextBox Then
            If Not CType(sender, TextBox).TabIndex = Me.iTabIndex Then
                Me.iTabIndex = CType(sender, TextBox).TabIndex
                CType(sender, TextBox).SelectAll()
            End If
        End If

    End Sub

    Friend Sub tbWordx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is TextBox Then
            modValidate.ValidText(CType(sender, TextBox))
        End If

    End Sub

    Friend Sub tbWordx_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is TextBox Then
            If Not String.IsNullOrEmpty(CType(sender, TextBox).Text) Then
                Me.dtValue.Rows(CType(sender, TextBox).TabIndex).Item(0) = CType(sender, TextBox).Text
            End If
        End If

    End Sub

    Friend Sub tbWordx_keypressed(ByVal o As [Object], ByVal e As KeyPressEventArgs)

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If Not Me.iCount >= 254 Then
                If Me.iTraining = 0 Then
                    Call modControls.AddNew(Me.iCount, Me.flpMain)
                    Me.dtValue.Rows.Add("", 0, 0)
                End If
            Else
                MessageBox.Show("Maximale Anzahl Wörter (255) erreicht...", "Anzahl erreicht", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

#End Region

#Region "Controls - ToolStripMenu - Click"

    Friend Sub tsmiLx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is ToolStripMenuItem Then

            If Not CByte(DirectCast(sender, ToolStripMenuItem).Tag) = 100 Then

                Me.tsmiWortarten.ShowDropDown()

                If DirectCast(sender, ToolStripMenuItem).Checked Then
                    DirectCast(sender, ToolStripMenuItem).Checked = False
                Else
                    DirectCast(sender, ToolStripMenuItem).Checked = True
                End If

                Me.iWortart = CByte(DirectCast(sender, ToolStripMenuItem).Tag)

                Me.bChecked(Me.iWortart) = DirectCast(sender, ToolStripMenuItem).Checked

                Call modVariants.SetLevel(Me.iWortart, Me.bChecked, frmOptions.flpOptions)
            End If

        End If

    End Sub

    Private Sub tsmiSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSelectAll.Click

        For Each t As ToolStripMenuItem In Me.tsmiWortarten.DropDownItems
            If Not CByte(t.Tag) = 100 Then
                t.Checked = True
            End If
        Next

        Dim iDyn As Integer = 1

        For i As Integer = 0 To Me.bChecked.Length - 1

            Me.bChecked(i) = True

            Select Case i
                Case Is = 7
                    iDyn += 1
                Case Is = 14
                    iDyn += 1
            End Select

            Call modVariants.SetOptions(True, i, Me.bChecked, iDyn, frmOptions.flpOptions)

        Next

    End Sub

    Private Sub tsmiSelectImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSelectImp.Click

        Dim bState As Boolean

        For i As Integer = 0 To Me.tsmiWortarten.DropDownItems.Count - 1
            If Not i > 4 Then
                bState = True
            Else
                bState = False
            End If
            If Not CByte(Me.tsmiWortarten.DropDownItems(i).Tag) = 100 Then
                DirectCast(Me.tsmiWortarten.DropDownItems.Item(i), ToolStripMenuItem).Checked = bState
            End If
        Next

        Dim iDyn As Integer = 1

        For i As Integer = 0 To Me.bChecked.Length - 1
            If Not i > 4 Then
                Me.bChecked(i) = True
            Else
                Me.bChecked(i) = False
            End If
            Call modVariants.SetOptions(False, i, Me.bChecked, iDyn, frmOptions.flpOptions)
        Next

    End Sub

#End Region

#Region "Controls - ToolStripMenu - Save"

    Private Sub tsmiSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSave.Click

        If Me.iCount >= 1 Then
            If MessageBox.Show("Willst du deinen Satz speichern?", "Satz Speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Me.Validate()

                If Not Directory.Exists(Application.StartupPath & sName) Then
                    Directory.CreateDirectory(Application.StartupPath & "\Public\" & sName)
                End If

                frmSave.ShowDialog()

                If Not sName Is Nothing And Not sFileExt Is Nothing Then
                    If Not String.IsNullOrEmpty(sName) And Not String.IsNullOrEmpty(sFileExt) Then
                        Try
                            Dim sFileName As String = String.Format("{0}\{1}\{2} {3} {4}... {5:dd.MM.yy hh-mm}.xml", Application.StartupPath & "\Public", Me.sName, Me.sFileExt, Me.dtValue.Rows(0).Item(0).ToString, Me.dtValue.Rows(1).Item(0).ToString, DateTime.Now)
                            Me.dtValue.WriteXml(sFileName)
                            If File.Exists(sFileName) Then
                                MessageBox.Show("Satz wurde erfolgreich gespeichert.", "Satz wurde gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                Throw New Exception
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Leider konnte dein Satz nicht gespeichert werden, prüfe den Datei Namen.", "Satz konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try
                    End If
                End If
            End If
        Else
            MessageBox.Show("Dein Satz sollte mindestens 2 Worte enthalten.", "zu wenig Worte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

#Region "Controls - ToolStripMenu - Load"

    Private Sub tsmiLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLoad.Click

        frmFileMan.ShowDialog()

        If Not sFile Is Nothing Then
            If Not String.IsNullOrEmpty(sFile) Then
                Me.iTraining = 0
                Try
                    For i As Integer = 1 To Me.dtValue.Rows.Count - 1
                        Call modControls.Remove(Me.iCount, Me.flpMain)
                        Me.dtValue.Rows.RemoveAt(Me.iCount + 1)
                        If Me.iCount <= 0 Then
                            Exit For
                        End If
                    Next

                    Me.dtValue.Clear()
                    Me.dtValue.ReadXml(sFile)
                    Me.iCount = 0

                    Me.pbWord0.Image = modControls.SetPicture(CByte(Me.dtValue.Rows(0).Item(1)))
                    Me.tbWord0.Text = CStr(Me.dtValue.Rows(0).Item(0))

                    For i As Integer = 0 To Me.tsmiWortarten.DropDownItems.Count - 1
                        If DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked Then
                            DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked = False
                            Me.iWortart = CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Tag)

                            Me.bChecked(Me.iWortart) = DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked

                            Call modVariants.SetLevel(Me.iWortart, Me.bChecked, frmOptions.flpOptions)
                        End If
                    Next

                    For i As Integer = 0 To Me.dtValue.Rows.Count - 1

                        If Not i = 0 Then
                            Call modControls.AddNewLoad(Me.iCount, CStr(Me.dtValue.Rows(i).Item(0)), CByte(Me.dtValue.Rows(i).Item(1)), Me.flpMain)
                        End If

                        For i1 As Integer = 0 To Me.tsmiWortarten.DropDownItems.Count - 1

                            If CType(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag, Byte) = modControls.GetNumber(CInt(Me.dtValue.Rows(i).Item(2))) Then

                                If Not DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked Then

                                    DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked = True

                                    If Not CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag) = 100 Then

                                        Me.iWortart = CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag)

                                        Me.bChecked(Me.iWortart) = DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked

                                        Call modVariants.SetLevel(Me.iWortart, Me.bChecked, frmOptions.flpOptions)
                                    End If

                                End If
                            End If
                        Next
                    Next
                    If Not Me.flpPlus.Visible Then
                        Me.flpPlus.Visible = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Leider konnte dein Satz nicht geladen werden, prüfe den Datei Namen.", "Satz konnte nicht geladen werden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End If

    End Sub

    Private Sub tsmiDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDebug.Click



    End Sub

#End Region

#Region "Controls - ToolStripMenu - SaveAs Vorlage"

    Private Sub tsmiVorlagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiVorlagen.Click

        Dim sFiles() As String = Directory.GetFiles(Application.StartupPath & "\Vorlagen\", "*", SearchOption.AllDirectories)

        Dim dtTemp As New DataTable("Value")
        Dim dtTempNew As New DataTable("Value")

        With dtTemp.Columns
            .Add("Text", GetType(String))
            .Add("Check", GetType(Byte))
            .Add("Value", GetType(Byte))
        End With

        With dtTempNew.Columns
            .Add("Text", GetType(String))
            .Add("Value", GetType(Byte))
            .Add("Check", GetType(Byte))
        End With

        Try
            For Each s As String In sFiles
                dtTemp.Clear()
                dtTempNew.Clear()
                dtTemp.ReadXml(s)
                If Not CByte(dtTemp.Rows(0).Item(2)) = 0 Then
                    For Each r As DataRow In dtTemp.Rows
                        dtTempNew.Rows.Add(r.Item(0), r.Item(1), r.Item(2))
                    Next
                    dtTempNew.WriteXml(s)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        dtTemp.Dispose()
        dtTempNew.Dispose()

        MessageBox.Show("done")

    End Sub

#End Region

#Region "Controls - ToolStripMenu - Training"

    Public Sub tsmiTxxx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is ToolStripMenuItem Then

            Me.iCountComplete = 0

            Dim iId As Byte = CByte(CType(sender, ToolStripMenuItem).Tag)

            If Me.flpPlus.Visible Then
                Me.flpPlus.Visible = False
            End If

            If Not iId = Me.iCurTrain Then
                Me.iCurTrain = iId
                Me.iTraining = 0
            End If

            Call SetTrain(Me.iCurTrain)

        End If

    End Sub

    Private Sub SetTrain(ByVal iGetId As Byte)

        For Each c As Control In flpMain.Controls.Item(0).Controls
            If TypeOf c Is PictureBox Then
                If DirectCast(c, PictureBox).Enabled = False Then
                    DirectCast(c, PictureBox).Enabled = True
                End If
            End If
        Next

        Dim sbPath As New StringBuilder

        sbPath.Append(Application.StartupPath & "\Vorlagen\")

        Select Case iGetId
            Case 1
                sbPath.Append("Adjektiv\")
                Exit Select
            Case 2
                sbPath.Append("Adverb\")
                Exit Select
            Case 3
                sbPath.Append("Artikel\")
                Exit Select
            Case 4
                sbPath.Append("geteiltes Verb\")
                Exit Select
            Case 5
                sbPath.Append("Hilfsverb\")
                Exit Select
            Case 6
                sbPath.Append("Infinitiv\")
                Exit Select
            Case 7
                sbPath.Append("Kopula\")
                Exit Select
            Case 8
                sbPath.Append("Nomen\")
                Exit Select
            Case 9
                sbPath.Append("Numerale\")
                Exit Select
            Case 10
                sbPath.Append("Präposition\")
                Exit Select
            Case 11
                sbPath.Append("unbestimmter Artikel\")
                Exit Select
            Case 12
                sbPath.Append("Verb\")
                Exit Select
            Case 13
                sbPath.Append("zwei Nomen\")
                Exit Select
            Case 14
                sbPath.Append("Pronomen\")
                Exit Select
            Case 15
                sbPath.Append("zwei Pronomen\")
                Exit Select
        End Select

        Try
            If Not Directory.Exists(sbPath.ToString) Then
                Throw New Exception("Vorlagen Pfad nicht vorhanden!" & vbNewLine & sbPath.ToString)
            End If

            Dim sFiles() As String

            sFiles = Directory.GetFiles(sbPath.ToString)

            If Not sFiles.Length > 0 Then
                Throw New Exception("Vorlagen Pfad keine Dateien vorhanden!" & vbNewLine & sbPath.ToString)
            End If

            If Me.iTraining > sFiles.Length - 1 Then
                Me.iTraining = 0
                MessageBox.Show("Prima das waren alle Sätze. Probiere doch noch eine andere Wortart", "Training", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tsmiTraining.ShowDropDown()
            End If

            If Not sFiles(Me.iTraining) Is Nothing Then
                If Not String.IsNullOrEmpty(sFiles(Me.iTraining)) Then
                    Try
                        For i As Integer = 1 To Me.dtValue.Rows.Count - 1
                            Call modControls.Remove(Me.iCount, Me.flpMain)
                            Me.dtValue.Rows.RemoveAt(Me.iCount + 1)
                            If Me.iCount <= 0 Then
                                Exit For
                            End If
                        Next

                        Me.dtValue.Clear()
                        Me.dtValue.ReadXml(sFiles(Me.iTraining))
                        Me.iCount = 0

                        Me.pbWord0.Image = modControls.SetPicture(CByte(Me.dtValue.Rows(0).Item(1)))
                        Me.tbWord0.Text = CStr(Me.dtValue.Rows(0).Item(0))

                        For i As Integer = 0 To Me.tsmiWortarten.DropDownItems.Count - 1
                            If DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked Then
                                DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked = False
                                Me.iWortart = CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Tag)

                                Me.bChecked(Me.iWortart) = DirectCast(Me.tsmiWortarten.DropDownItems(i), ToolStripMenuItem).Checked

                                Call modVariants.SetLevel(Me.iWortart, Me.bChecked, frmOptions.flpOptions)
                            End If
                        Next

                        For i As Integer = 0 To Me.dtValue.Rows.Count - 1

                            If Not i = 0 Then
                                Call modControls.AddNewLoad(Me.iCount, CStr(Me.dtValue.Rows(i).Item(0)), CByte(Me.dtValue.Rows(i).Item(1)), Me.flpMain)
                            End If

                            For i1 As Integer = 0 To Me.tsmiWortarten.DropDownItems.Count - 1

                                If CType(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag, Byte) = modControls.GetNumber(CInt(Me.dtValue.Rows(i).Item(2))) Then

                                    If Not DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked Then

                                        DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked = True

                                        If Not CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag) = 100 Then

                                            Me.iWortart = CByte(DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Tag)

                                            Me.bChecked(Me.iWortart) = DirectCast(Me.tsmiWortarten.DropDownItems(i1), ToolStripMenuItem).Checked

                                            Call modVariants.SetLevel(Me.iWortart, Me.bChecked, frmOptions.flpOptions)
                                        End If

                                    End If
                                End If
                            Next
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Leider konnte dein Satz nicht geladen werden, prüfe den Datei Namen.", "Satz konnte nicht geladen werden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                End If
            End If
            Me.iTraining += 1
        Catch ex As Exception
            Me.iTraining = 0
            MessageBox.Show(ex.Message, "Fehler oeffnen Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        sbPath = Nothing

    End Sub

#End Region

#Region "Controls - Finally"

    Private Sub tsmiMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click

        Me.Close()

    End Sub

#End Region

End Class
