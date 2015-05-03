<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileMan
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
        Me.flpFileMan = New System.Windows.Forms.FlowLayoutPanel
        Me.lbFolders = New System.Windows.Forms.ListBox
        Me.lbFiles = New System.Windows.Forms.ListBox
        Me.btnLoad = New System.Windows.Forms.Button
        Me.lblContent = New System.Windows.Forms.Label
        Me.flpFileMan.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpFileMan
        '
        Me.flpFileMan.Controls.Add(Me.lbFolders)
        Me.flpFileMan.Controls.Add(Me.lbFiles)
        Me.flpFileMan.Controls.Add(Me.btnLoad)
        Me.flpFileMan.Controls.Add(Me.lblContent)
        Me.flpFileMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpFileMan.Location = New System.Drawing.Point(0, 0)
        Me.flpFileMan.Name = "flpFileMan"
        Me.flpFileMan.Size = New System.Drawing.Size(784, 562)
        Me.flpFileMan.TabIndex = 0
        '
        'lbFolders
        '
        Me.lbFolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFolders.FormattingEnabled = True
        Me.lbFolders.HorizontalScrollbar = True
        Me.lbFolders.ItemHeight = 16
        Me.lbFolders.Location = New System.Drawing.Point(9, 3)
        Me.lbFolders.Margin = New System.Windows.Forms.Padding(9, 3, 3, 3)
        Me.lbFolders.Name = "lbFolders"
        Me.lbFolders.Size = New System.Drawing.Size(250, 340)
        Me.lbFolders.TabIndex = 0
        '
        'lbFiles
        '
        Me.lbFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.HorizontalScrollbar = True
        Me.lbFiles.ItemHeight = 16
        Me.lbFiles.Location = New System.Drawing.Point(265, 3)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(510, 340)
        Me.lbFiles.TabIndex = 1
        '
        'btnLoad
        '
        Me.flpFileMan.SetFlowBreak(Me.btnLoad, True)
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(660, 349)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(660, 3, 3, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(115, 33)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Laden"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.flpFileMan.SetFlowBreak(Me.lblContent, True)
        Me.lblContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContent.Location = New System.Drawing.Point(9, 394)
        Me.lblContent.Margin = New System.Windows.Forms.Padding(9)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(15, 20)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "*"
        '
        'frmFileMan
        '
        Me.AcceptButton = Me.btnLoad
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.flpFileMan)
        Me.Name = "frmFileMan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dateimanager"
        Me.flpFileMan.ResumeLayout(False)
        Me.flpFileMan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpFileMan As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbFolders As System.Windows.Forms.ListBox
    Friend WithEvents lbFiles As System.Windows.Forms.ListBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class
