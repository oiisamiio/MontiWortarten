Module modControls

    Public Sub Init(ByVal cInput() As Control, ByVal sConfig(,) As String, ByVal flowOptions As FlowLayoutPanel, ByVal cLevel As ToolStripMenuItem, ByVal cTraining As ToolStripMenuItem)

        For Each c As Control In cInput
            If TypeOf c Is PictureBox Then
                AddHandler c.Click, AddressOf frmMain.pbWordx_Click
                AddHandler c.MouseEnter, AddressOf frmMain.pbWordx_MouseEnter
                AddHandler c.MouseLeave, AddressOf frmMain.pbWordx_MouseLeave
            End If
            If TypeOf c Is TextBox Then
                AddHandler c.Click, AddressOf frmMain.tbWordx_Click
                AddHandler c.TextChanged, AddressOf frmMain.tbWordx_TextChanged
                AddHandler c.KeyPress, AddressOf frmMain.tbWordx_keypressed
                AddHandler c.Validated, AddressOf frmMain.tbWordx_Validated

            End If
        Next

        For Each c As Control In flowOptions.Controls
            If TypeOf c Is PictureBox Then
                If Not DirectCast(c, PictureBox).Name = "pbSymText" Then
                    AddHandler c.Click, AddressOf frmOptions.pbWordxxx_Click
                    AddHandler c.MouseEnter, AddressOf frmOptions.pbWordxxx_MouseEnter
                    AddHandler c.MouseLeave, AddressOf frmOptions.pbWordxxx_MouseLeave
                End If
            End If
        Next

        For Each t As ToolStripMenuItem In cLevel.DropDownItems
            AddHandler t.Click, AddressOf frmMain.tsmiLx_Click
        Next

        For Each t As ToolStripMenuItem In cTraining.DropDownItems
            AddHandler t.Click, AddressOf frmMain.tsmiTxxx_Click
        Next

    End Sub

    Public Sub AddNew(ByRef iCount As Integer, ByVal flowMain As FlowLayoutPanel)

        iCount += 1

        Dim flowWord As New FlowLayoutPanel
        Dim tbWord As New TextBox
        Dim pbWord As New PictureBox

        '
        'flowWord
        '
        flowWord.Controls.Add(pbWord)
        flowWord.Controls.Add(tbWord)
        flowWord.Margin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        flowWord.Name = "flpWord" & iCount.ToString
        flowWord.Size = New System.Drawing.Size(150, 150)
        flowWord.TabIndex = 0
        '
        'txtWord
        '
        tbWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        tbWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
        tbWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        tbWord.Name = "tbWord" & iCount.ToString
        tbWord.Size = New System.Drawing.Size(144, 24)
        tbWord.TabIndex = iCount
        tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picWord
        '
        flowWord.SetFlowBreak(pbWord, True)
        pbWord.Image = Global.Monti.My.Resources.Resources.m_question
        pbWord.Margin = New System.Windows.Forms.Padding(24, 3, 3, 3)
        pbWord.Name = "pbWord" & iCount.ToString
        pbWord.Size = New System.Drawing.Size(100, 100)
        pbWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pbWord.TabIndex = 0
        pbWord.TabStop = False
        pbWord.Tag = iCount

        flowMain.Controls.Add(flowWord)
        flowMain.Controls.SetChildIndex(flowWord, iCount)

        Call InitNew(pbWord, tbWord)

    End Sub

    Public Sub AddNewLoad(ByRef iCount As Integer, ByVal sText As String, ByVal iPicture As Byte, ByVal flowMain As FlowLayoutPanel)

        iCount += 1

        Dim flowWord As New FlowLayoutPanel
        Dim tbWord As New TextBox
        Dim pbWord As New PictureBox

        '
        'flowWord
        '
        flowWord.Controls.Add(pbWord)
        flowWord.Controls.Add(tbWord)
        flowWord.Margin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        flowWord.Name = "flpWord" & iCount.ToString
        flowWord.Size = New System.Drawing.Size(150, 150)
        flowWord.TabIndex = 0
        '
        'txtWord
        '
        tbWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        tbWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
        tbWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        tbWord.Name = "tbWord" & CStr(iCount)
        tbWord.Size = New System.Drawing.Size(144, 24)
        tbWord.TabIndex = iCount
        tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        tbWord.Text = sText
        '
        'picWord
        '
        flowWord.SetFlowBreak(pbWord, True)
        pbWord.Image = SetPicture(iPicture)
        pbWord.Margin = New System.Windows.Forms.Padding(24, 3, 3, 3)
        pbWord.Name = "pbWord" & iCount.ToString
        pbWord.Size = New System.Drawing.Size(100, 100)
        pbWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pbWord.TabIndex = 0
        pbWord.TabStop = False
        pbWord.Tag = iCount

        flowMain.Controls.Add(flowWord)
        flowMain.Controls.SetChildIndex(flowWord, iCount)

        Call InitNew(pbWord, tbWord)

    End Sub

    Private Sub InitNew(ByVal pbInput As PictureBox, ByVal tbInput As TextBox)

        AddHandler pbInput.Click, AddressOf frmMain.pbWordx_Click
        AddHandler pbInput.MouseEnter, AddressOf frmMain.pbWordx_MouseEnter
        AddHandler pbInput.MouseLeave, AddressOf frmMain.pbWordx_MouseLeave

        AddHandler tbInput.Click, AddressOf frmMain.tbWordx_Click
        AddHandler tbInput.TextChanged, AddressOf frmMain.tbWordx_TextChanged
        AddHandler tbInput.KeyPress, AddressOf frmMain.tbWordx_keypressed
        AddHandler tbInput.Validated, AddressOf frmMain.tbWordx_Validated

    End Sub

    Public Sub Remove(ByRef iCount As Integer, ByVal flpMain As FlowLayoutPanel)

        flpMain.Controls.Remove(flpMain.Controls.Item(iCount))
        iCount -= 1

    End Sub

    Public Sub SetText(ByVal pbSymText As PictureBox, ByVal sOption As String)

        Select Case CInt(sOption)
            Case 1
                pbSymText.Image = My.Resources.t_verb
            Case 2
                pbSymText.Image = My.Resources.t_hilfsverb
            Case 3
                pbSymText.Image = My.Resources.t_modalverb
            Case 4
                pbSymText.Image = My.Resources.t_kopula
            Case 5
                pbSymText.Image = My.Resources.t_getverban
            Case 6
                pbSymText.Image = My.Resources.t_getverben
            Case 7
                pbSymText.Image = My.Resources.t_partizip
            Case 8
                pbSymText.Image = My.Resources.t_infinitiv
            Case 9
                pbSymText.Image = My.Resources.t_adverb
            Case 10
                pbSymText.Image = My.Resources.t_konjunktion
            Case 11
                pbSymText.Image = My.Resources.t_nomen
            Case 12
                pbSymText.Image = My.Resources.t_nomenspirituell
            Case 13
                pbSymText.Image = My.Resources.t_nomenabstrakt
            Case 14
                pbSymText.Image = My.Resources.t_artikel
            Case 15
                pbSymText.Image = My.Resources.t_adjektiv
            Case 16
                pbSymText.Image = My.Resources.t_numerale
            Case 17
                pbSymText.Image = My.Resources.t_pronomen
            Case 18
                pbSymText.Image = My.Resources.t_präposition
            Case 19
                pbSymText.Image = My.Resources.t_interjektion
            Case 20
                pbSymText.Image = My.Resources.t_leer
            Case 21
                pbSymText.Image = My.Resources.t_weissnicht
        End Select

    End Sub

    Public Function SetPicture(ByVal sOption As Byte) As Image

        Dim imgWord As Image

        Select Case CInt(sOption)
            Case 1
                imgWord = My.Resources.s_verb
            Case 2
                imgWord = My.Resources.s_hilfsverb
            Case 3
                imgWord = My.Resources.s_modalverb
            Case 4
                imgWord = My.Resources.s_kopula
            Case 5
                imgWord = My.Resources.s_getverban
            Case 6
                imgWord = My.Resources.s_getverben
            Case 7
                imgWord = My.Resources.s_partizip
            Case 8
                imgWord = My.Resources.s_infinitiv
            Case 9
                imgWord = My.Resources.s_adverb
            Case 10
                imgWord = My.Resources.s_konjunktion
            Case 11
                imgWord = My.Resources.s_nomen
            Case 12
                imgWord = My.Resources.s_nomenspirituell
            Case 13
                imgWord = My.Resources.s_nomenabstrakt
            Case 14
                imgWord = My.Resources.s_artikel
            Case 15
                imgWord = My.Resources.s_adjektiv
            Case 16
                imgWord = My.Resources.s_numerale
            Case 17
                imgWord = My.Resources.s_pronomen
            Case 18
                imgWord = My.Resources.s_präposition
            Case 19
                imgWord = My.Resources.s_interjektion
            Case 20
                imgWord = My.Resources.m_leer
            Case 21
                imgWord = My.Resources.m_question
            Case 100
                imgWord = My.Resources.m_wrong
            Case Else
                imgWord = My.Resources.m_question
        End Select

        Return imgWord

    End Function

    Public Function GetNumber(ByVal iIn As Integer) As Integer

        Dim iOut As Integer

        Select Case iIn
            Case 11
                iOut = 1
            Case 14
                iOut = 2
            Case 16
                iOut = 3
            Case 15
                iOut = 4
            Case 1
                iOut = 5
            Case 18
                iOut = 6
            Case 9
                iOut = 7
            Case 17
                iOut = 8
            Case 10
                iOut = 9
            Case 19
                iOut = 10
            Case 12
                iOut = 11
            Case 13
                iOut = 12
            Case 8
                iOut = 13
            Case 2
                iOut = 14
            Case 5
                iOut = 15
            Case 6
                iOut = 16
            Case 4
                iOut = 17
            Case 3
                iOut = 18
            Case 7
                iOut = 19
            Case 20
                iOut = 20
        End Select

        Return iOut - 1

    End Function

End Module
