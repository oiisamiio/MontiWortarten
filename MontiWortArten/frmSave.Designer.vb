<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSave
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
        Me.tbSave = New System.Windows.Forms.TextBox
        Me.lblSave = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.flpName.SuspendLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpName
        '
        Me.flpName.Controls.Add(Me.pbName)
        Me.flpName.Controls.Add(Me.tbSave)
        Me.flpName.Controls.Add(Me.lblSave)
        Me.flpName.Controls.Add(Me.btnSave)
        Me.flpName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpName.Location = New System.Drawing.Point(0, 0)
        Me.flpName.Name = "flpName"
        Me.flpName.Size = New System.Drawing.Size(384, 162)
        Me.flpName.TabIndex = 1
        '
        'pbName
        '
        Me.pbName.Image = Global.Monti.My.Resources.Resources.m_question
        Me.pbName.Location = New System.Drawing.Point(30, 10)
        Me.pbName.Margin = New System.Windows.Forms.Padding(30, 10, 3, 3)
        Me.pbName.Name = "pbName"
        Me.pbName.Size = New System.Drawing.Size(100, 100)
        Me.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbName.TabIndex = 2
        Me.pbName.TabStop = False
        Me.pbName.Tag = "0"
        '
        'tbSave
        '
        Me.tbSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSave.Location = New System.Drawing.Point(10, 123)
        Me.tbSave.Margin = New System.Windows.Forms.Padding(10, 10, 3, 2)
        Me.tbSave.MaxLength = 12
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(140, 26)
        Me.tbSave.TabIndex = 1
        Me.tbSave.Tag = "100"
        Me.tbSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.Location = New System.Drawing.Point(158, 15)
        Me.lblSave.Margin = New System.Windows.Forms.Padding(5, 15, 10, 10)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(213, 80)
        Me.lblSave.TabIndex = 3
        Me.lblSave.Text = "Beschreibung!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gib eine kurze Beschreibung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ein und drücke ""Speichern"""
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(203, 120)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(50, 15, 3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSave
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.flpName)
        Me.Name = "frmSave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Speichern] - Beschreibung"
        Me.flpName.ResumeLayout(False)
        Me.flpName.PerformLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpName As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents pbName As System.Windows.Forms.PictureBox
    Private WithEvents tbSave As System.Windows.Forms.TextBox
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
