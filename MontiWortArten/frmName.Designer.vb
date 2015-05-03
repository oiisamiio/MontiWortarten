<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.flpName = New System.Windows.Forms.FlowLayoutPanel
        Me.pbName = New System.Windows.Forms.PictureBox
        Me.tbName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.btnName = New System.Windows.Forms.Button
        Me.flpName.SuspendLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpName
        '
        Me.flpName.Controls.Add(Me.pbName)
        Me.flpName.Controls.Add(Me.tbName)
        Me.flpName.Controls.Add(Me.lblName)
        Me.flpName.Controls.Add(Me.btnName)
        Me.flpName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpName.Location = New System.Drawing.Point(0, 0)
        Me.flpName.Name = "flpName"
        Me.flpName.Size = New System.Drawing.Size(334, 162)
        Me.flpName.TabIndex = 0
        '
        'pbName
        '
        Me.pbName.Image = Global.Monti.My.Resources.Resources.m_question
        Me.pbName.Location = New System.Drawing.Point(24, 3)
        Me.pbName.Margin = New System.Windows.Forms.Padding(24, 3, 3, 3)
        Me.pbName.Name = "pbName"
        Me.pbName.Size = New System.Drawing.Size(100, 100)
        Me.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbName.TabIndex = 2
        Me.pbName.TabStop = False
        Me.pbName.Tag = "0"
        '
        'tbName
        '
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(24, 116)
        Me.tbName.Margin = New System.Windows.Forms.Padding(24, 10, 3, 2)
        Me.tbName.MaxLength = 12
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(100, 26)
        Me.tbName.TabIndex = 1
        Me.tbName.Tag = "100"
        Me.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(137, 10)
        Me.lblName.Margin = New System.Windows.Forms.Padding(10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(166, 80)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Hallo!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gib deinen Namen ein" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "und drücke ""Start"""
        '
        'btnName
        '
        Me.btnName.Enabled = False
        Me.btnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnName.Location = New System.Drawing.Point(167, 115)
        Me.btnName.Margin = New System.Windows.Forms.Padding(40, 15, 3, 3)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(120, 30)
        Me.btnName.TabIndex = 4
        Me.btnName.Text = "Start"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'frmName
        '
        Me.AcceptButton = Me.btnName
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.flpName)
        Me.Name = "frmName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Start] - gib deinen Namen ein"
        Me.flpName.ResumeLayout(False)
        Me.flpName.PerformLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpName As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents tbName As System.Windows.Forms.TextBox
    Private WithEvents pbName As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnName As System.Windows.Forms.Button
End Class
