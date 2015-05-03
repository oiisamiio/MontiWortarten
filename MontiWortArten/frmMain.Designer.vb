<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.strpMain = New System.Windows.Forms.MenuStrip
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten00 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten01 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten02 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten03 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten04 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten05 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten06 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten07 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten08 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten09 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten10 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten11 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten12 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten13 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten14 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten15 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten16 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten17 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten18 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten19 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiWortarten20 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSelectImp = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLoad = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDebug = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiVorlagen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTraining = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTNomen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTZweiNomen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTArtikel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTUnbArtikel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTNumerale = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTAdjektiv = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTVerb = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTKopula = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTAdverb = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTPronomen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTZweiPronomen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTPräposition = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTGeteiltesVerb = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTInfinitiv = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTHilfsVerb = New System.Windows.Forms.ToolStripMenuItem
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel
        Me.flpWord0 = New System.Windows.Forms.FlowLayoutPanel
        Me.pbWord0 = New System.Windows.Forms.PictureBox
        Me.tbWord0 = New System.Windows.Forms.TextBox
        Me.flpPlus = New System.Windows.Forms.FlowLayoutPanel
        Me.pbAdd = New System.Windows.Forms.PictureBox
        Me.pbRemove = New System.Windows.Forms.PictureBox
        Me.strpStats = New System.Windows.Forms.StatusStrip
        Me.lblTest = New System.Windows.Forms.ToolStripStatusLabel
        Me.strpMain.SuspendLayout()
        Me.flpMain.SuspendLayout()
        Me.flpWord0.SuspendLayout()
        CType(Me.pbWord0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpPlus.SuspendLayout()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strpMain
        '
        Me.strpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit, Me.tsmiWortarten, Me.tsmiLoad, Me.tsmiSave, Me.tsmiDebug, Me.tsmiVorlagen, Me.tsmiTraining})
        Me.strpMain.Location = New System.Drawing.Point(0, 0)
        Me.strpMain.Name = "strpMain"
        Me.strpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.strpMain.Size = New System.Drawing.Size(984, 29)
        Me.strpMain.TabIndex = 1
        Me.strpMain.Text = "strpMain"
        '
        'tsmiExit
        '
        Me.tsmiExit.AutoSize = False
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(120, 25)
        Me.tsmiExit.Text = "&Beenden"
        '
        'tsmiWortarten
        '
        Me.tsmiWortarten.AutoSize = False
        Me.tsmiWortarten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiWortarten00, Me.tsmiWortarten01, Me.tsmiWortarten02, Me.tsmiWortarten03, Me.tsmiWortarten04, Me.tsmiWortarten05, Me.tsmiWortarten06, Me.tsmiWortarten07, Me.tsmiWortarten08, Me.tsmiWortarten09, Me.tsmiWortarten10, Me.tsmiWortarten11, Me.tsmiWortarten12, Me.tsmiWortarten13, Me.tsmiWortarten14, Me.tsmiWortarten15, Me.tsmiWortarten16, Me.tsmiWortarten17, Me.tsmiWortarten18, Me.tsmiWortarten19, Me.tsmiWortarten20, Me.tsmiSelectImp, Me.tsmiSelectAll, Me.tsmiClose})
        Me.tsmiWortarten.Name = "tsmiWortarten"
        Me.tsmiWortarten.Size = New System.Drawing.Size(120, 25)
        Me.tsmiWortarten.Tag = "100"
        Me.tsmiWortarten.Text = "&Wortarten"
        '
        'tsmiWortarten00
        '
        Me.tsmiWortarten00.Checked = True
        Me.tsmiWortarten00.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiWortarten00.Image = Global.Monti.My.Resources.Resources.s_nomen
        Me.tsmiWortarten00.Name = "tsmiWortarten00"
        Me.tsmiWortarten00.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten00.Tag = "0"
        Me.tsmiWortarten00.Text = "Nomen"
        '
        'tsmiWortarten01
        '
        Me.tsmiWortarten01.Checked = True
        Me.tsmiWortarten01.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiWortarten01.Image = Global.Monti.My.Resources.Resources.s_artikel
        Me.tsmiWortarten01.Name = "tsmiWortarten01"
        Me.tsmiWortarten01.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten01.Tag = "1"
        Me.tsmiWortarten01.Text = "Artikel"
        '
        'tsmiWortarten02
        '
        Me.tsmiWortarten02.Checked = True
        Me.tsmiWortarten02.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiWortarten02.Image = Global.Monti.My.Resources.Resources.s_numerale
        Me.tsmiWortarten02.Name = "tsmiWortarten02"
        Me.tsmiWortarten02.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten02.Tag = "2"
        Me.tsmiWortarten02.Text = "Numerale"
        '
        'tsmiWortarten03
        '
        Me.tsmiWortarten03.Checked = True
        Me.tsmiWortarten03.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiWortarten03.Image = Global.Monti.My.Resources.Resources.s_adjektiv
        Me.tsmiWortarten03.Name = "tsmiWortarten03"
        Me.tsmiWortarten03.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten03.Tag = "3"
        Me.tsmiWortarten03.Text = "Adjektiv"
        '
        'tsmiWortarten04
        '
        Me.tsmiWortarten04.Checked = True
        Me.tsmiWortarten04.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiWortarten04.Image = Global.Monti.My.Resources.Resources.s_verb
        Me.tsmiWortarten04.Name = "tsmiWortarten04"
        Me.tsmiWortarten04.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten04.Tag = "4"
        Me.tsmiWortarten04.Text = "Verb"
        '
        'tsmiWortarten05
        '
        Me.tsmiWortarten05.Image = Global.Monti.My.Resources.Resources.s_präposition
        Me.tsmiWortarten05.Name = "tsmiWortarten05"
        Me.tsmiWortarten05.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten05.Tag = "5"
        Me.tsmiWortarten05.Text = "Präposition"
        '
        'tsmiWortarten06
        '
        Me.tsmiWortarten06.Image = Global.Monti.My.Resources.Resources.s_adverb
        Me.tsmiWortarten06.Name = "tsmiWortarten06"
        Me.tsmiWortarten06.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten06.Tag = "6"
        Me.tsmiWortarten06.Text = "Adverb"
        '
        'tsmiWortarten07
        '
        Me.tsmiWortarten07.Image = Global.Monti.My.Resources.Resources.s_pronomen
        Me.tsmiWortarten07.Name = "tsmiWortarten07"
        Me.tsmiWortarten07.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten07.Tag = "7"
        Me.tsmiWortarten07.Text = "Pronomen"
        '
        'tsmiWortarten08
        '
        Me.tsmiWortarten08.Image = Global.Monti.My.Resources.Resources.s_konjunktion
        Me.tsmiWortarten08.Name = "tsmiWortarten08"
        Me.tsmiWortarten08.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten08.Tag = "8"
        Me.tsmiWortarten08.Text = "Konjunktion"
        '
        'tsmiWortarten09
        '
        Me.tsmiWortarten09.Image = Global.Monti.My.Resources.Resources.s_interjektion
        Me.tsmiWortarten09.Name = "tsmiWortarten09"
        Me.tsmiWortarten09.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten09.Tag = "9"
        Me.tsmiWortarten09.Text = "Interjektion"
        '
        'tsmiWortarten10
        '
        Me.tsmiWortarten10.Image = Global.Monti.My.Resources.Resources.s_nomenspirituell
        Me.tsmiWortarten10.Name = "tsmiWortarten10"
        Me.tsmiWortarten10.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten10.Tag = "10"
        Me.tsmiWortarten10.Text = "Nomen spirituell"
        '
        'tsmiWortarten11
        '
        Me.tsmiWortarten11.Image = Global.Monti.My.Resources.Resources.s_nomenabstrakt
        Me.tsmiWortarten11.Name = "tsmiWortarten11"
        Me.tsmiWortarten11.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten11.Tag = "11"
        Me.tsmiWortarten11.Text = "Nomen abstrakt"
        '
        'tsmiWortarten12
        '
        Me.tsmiWortarten12.Image = Global.Monti.My.Resources.Resources.s_infinitiv
        Me.tsmiWortarten12.Name = "tsmiWortarten12"
        Me.tsmiWortarten12.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten12.Tag = "12"
        Me.tsmiWortarten12.Text = "Infinitiv"
        '
        'tsmiWortarten13
        '
        Me.tsmiWortarten13.Image = Global.Monti.My.Resources.Resources.s_hilfsverb
        Me.tsmiWortarten13.Name = "tsmiWortarten13"
        Me.tsmiWortarten13.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten13.Tag = "13"
        Me.tsmiWortarten13.Text = "Hilfsverb"
        '
        'tsmiWortarten14
        '
        Me.tsmiWortarten14.Image = Global.Monti.My.Resources.Resources.s_getverban
        Me.tsmiWortarten14.Name = "tsmiWortarten14"
        Me.tsmiWortarten14.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten14.Tag = "14"
        Me.tsmiWortarten14.Text = "geteiltes Verb Anfang"
        '
        'tsmiWortarten15
        '
        Me.tsmiWortarten15.Image = Global.Monti.My.Resources.Resources.s_getverben
        Me.tsmiWortarten15.Name = "tsmiWortarten15"
        Me.tsmiWortarten15.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten15.Tag = "15"
        Me.tsmiWortarten15.Text = "geteiltes Verb Ende"
        '
        'tsmiWortarten16
        '
        Me.tsmiWortarten16.Image = Global.Monti.My.Resources.Resources.s_partizip
        Me.tsmiWortarten16.Name = "tsmiWortarten16"
        Me.tsmiWortarten16.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten16.Tag = "18"
        Me.tsmiWortarten16.Text = "Partizip"
        '
        'tsmiWortarten17
        '
        Me.tsmiWortarten17.Image = Global.Monti.My.Resources.Resources.s_modalverb
        Me.tsmiWortarten17.Name = "tsmiWortarten17"
        Me.tsmiWortarten17.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten17.Tag = "17"
        Me.tsmiWortarten17.Text = "Modalverb"
        '
        'tsmiWortarten18
        '
        Me.tsmiWortarten18.Image = Global.Monti.My.Resources.Resources.s_kopula
        Me.tsmiWortarten18.Name = "tsmiWortarten18"
        Me.tsmiWortarten18.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten18.Tag = "16"
        Me.tsmiWortarten18.Text = "Kopula"
        '
        'tsmiWortarten19
        '
        Me.tsmiWortarten19.Image = Global.Monti.My.Resources.Resources.m_leer
        Me.tsmiWortarten19.Name = "tsmiWortarten19"
        Me.tsmiWortarten19.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten19.Tag = "19"
        Me.tsmiWortarten19.Text = "Leer lassen"
        '
        'tsmiWortarten20
        '
        Me.tsmiWortarten20.Image = Global.Monti.My.Resources.Resources.m_question
        Me.tsmiWortarten20.Name = "tsmiWortarten20"
        Me.tsmiWortarten20.Size = New System.Drawing.Size(232, 24)
        Me.tsmiWortarten20.Tag = "20"
        Me.tsmiWortarten20.Text = "Weiss nicht"
        '
        'tsmiSelectImp
        '
        Me.tsmiSelectImp.Name = "tsmiSelectImp"
        Me.tsmiSelectImp.Size = New System.Drawing.Size(232, 24)
        Me.tsmiSelectImp.Tag = "100"
        Me.tsmiSelectImp.Text = "&Wichtigste auswählen"
        '
        'tsmiSelectAll
        '
        Me.tsmiSelectAll.Name = "tsmiSelectAll"
        Me.tsmiSelectAll.Size = New System.Drawing.Size(232, 24)
        Me.tsmiSelectAll.Tag = "100"
        Me.tsmiSelectAll.Text = "&Alles auswählen"
        '
        'tsmiClose
        '
        Me.tsmiClose.Name = "tsmiClose"
        Me.tsmiClose.Size = New System.Drawing.Size(232, 24)
        Me.tsmiClose.Tag = "100"
        Me.tsmiClose.Text = "&Schliessen"
        '
        'tsmiLoad
        '
        Me.tsmiLoad.AutoSize = False
        Me.tsmiLoad.Name = "tsmiLoad"
        Me.tsmiLoad.Size = New System.Drawing.Size(120, 25)
        Me.tsmiLoad.Text = "&Laden"
        '
        'tsmiSave
        '
        Me.tsmiSave.AutoSize = False
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(120, 25)
        Me.tsmiSave.Text = "&Speichern"
        '
        'tsmiDebug
        '
        Me.tsmiDebug.AutoSize = False
        Me.tsmiDebug.Name = "tsmiDebug"
        Me.tsmiDebug.Size = New System.Drawing.Size(120, 25)
        Me.tsmiDebug.Text = "&Debug"
        Me.tsmiDebug.Visible = False
        '
        'tsmiVorlagen
        '
        Me.tsmiVorlagen.AutoSize = False
        Me.tsmiVorlagen.Name = "tsmiVorlagen"
        Me.tsmiVorlagen.Size = New System.Drawing.Size(120, 25)
        Me.tsmiVorlagen.Text = "&zur Vorlage"
        Me.tsmiVorlagen.Visible = False
        '
        'tsmiTraining
        '
        Me.tsmiTraining.AutoSize = False
        Me.tsmiTraining.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTNomen, Me.tsmiTZweiNomen, Me.tsmiTArtikel, Me.tsmiTUnbArtikel, Me.tsmiTNumerale, Me.tsmiTAdjektiv, Me.tsmiTVerb, Me.tsmiTKopula, Me.tsmiTAdverb, Me.tsmiTPronomen, Me.tsmiTZweiPronomen, Me.tsmiTPräposition, Me.tsmiTGeteiltesVerb, Me.tsmiTInfinitiv, Me.tsmiTHilfsVerb})
        Me.tsmiTraining.Name = "tsmiTraining"
        Me.tsmiTraining.Size = New System.Drawing.Size(120, 25)
        Me.tsmiTraining.Text = "&Training"
        '
        'tsmiTNomen
        '
        Me.tsmiTNomen.Name = "tsmiTNomen"
        Me.tsmiTNomen.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTNomen.Tag = "8"
        Me.tsmiTNomen.Text = "Nomen"
        '
        'tsmiTZweiNomen
        '
        Me.tsmiTZweiNomen.Name = "tsmiTZweiNomen"
        Me.tsmiTZweiNomen.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTZweiNomen.Tag = "13"
        Me.tsmiTZweiNomen.Text = "zwei Nomen"
        '
        'tsmiTArtikel
        '
        Me.tsmiTArtikel.Name = "tsmiTArtikel"
        Me.tsmiTArtikel.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTArtikel.Tag = "3"
        Me.tsmiTArtikel.Text = "Artikel"
        '
        'tsmiTUnbArtikel
        '
        Me.tsmiTUnbArtikel.Name = "tsmiTUnbArtikel"
        Me.tsmiTUnbArtikel.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTUnbArtikel.Tag = "11"
        Me.tsmiTUnbArtikel.Text = "unbestimmter Artikel"
        '
        'tsmiTNumerale
        '
        Me.tsmiTNumerale.Name = "tsmiTNumerale"
        Me.tsmiTNumerale.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTNumerale.Tag = "9"
        Me.tsmiTNumerale.Text = "Numerale"
        '
        'tsmiTAdjektiv
        '
        Me.tsmiTAdjektiv.Name = "tsmiTAdjektiv"
        Me.tsmiTAdjektiv.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTAdjektiv.Tag = "1"
        Me.tsmiTAdjektiv.Text = "Adjektiv"
        '
        'tsmiTVerb
        '
        Me.tsmiTVerb.Name = "tsmiTVerb"
        Me.tsmiTVerb.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTVerb.Tag = "12"
        Me.tsmiTVerb.Text = "Verb"
        '
        'tsmiTKopula
        '
        Me.tsmiTKopula.Name = "tsmiTKopula"
        Me.tsmiTKopula.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTKopula.Tag = "7"
        Me.tsmiTKopula.Text = "Kopula"
        '
        'tsmiTAdverb
        '
        Me.tsmiTAdverb.Name = "tsmiTAdverb"
        Me.tsmiTAdverb.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTAdverb.Tag = "2"
        Me.tsmiTAdverb.Text = "Adverb"
        '
        'tsmiTPronomen
        '
        Me.tsmiTPronomen.Name = "tsmiTPronomen"
        Me.tsmiTPronomen.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTPronomen.Tag = "14"
        Me.tsmiTPronomen.Text = "Pronomen"
        '
        'tsmiTZweiPronomen
        '
        Me.tsmiTZweiPronomen.Name = "tsmiTZweiPronomen"
        Me.tsmiTZweiPronomen.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTZweiPronomen.Tag = "15"
        Me.tsmiTZweiPronomen.Text = "zwei Pronomen"
        '
        'tsmiTPräposition
        '
        Me.tsmiTPräposition.Name = "tsmiTPräposition"
        Me.tsmiTPräposition.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTPräposition.Tag = "10"
        Me.tsmiTPräposition.Text = "Präposition"
        '
        'tsmiTGeteiltesVerb
        '
        Me.tsmiTGeteiltesVerb.Name = "tsmiTGeteiltesVerb"
        Me.tsmiTGeteiltesVerb.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTGeteiltesVerb.Tag = "4"
        Me.tsmiTGeteiltesVerb.Text = "geteiltes Verb"
        '
        'tsmiTInfinitiv
        '
        Me.tsmiTInfinitiv.Name = "tsmiTInfinitiv"
        Me.tsmiTInfinitiv.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTInfinitiv.Tag = "6"
        Me.tsmiTInfinitiv.Text = "Infinitiv"
        '
        'tsmiTHilfsVerb
        '
        Me.tsmiTHilfsVerb.Name = "tsmiTHilfsVerb"
        Me.tsmiTHilfsVerb.Size = New System.Drawing.Size(223, 24)
        Me.tsmiTHilfsVerb.Tag = "5"
        Me.tsmiTHilfsVerb.Text = "Hilfsverb"
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.Controls.Add(Me.flpWord0)
        Me.flpMain.Controls.Add(Me.flpPlus)
        Me.flpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMain.Location = New System.Drawing.Point(0, 29)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Size = New System.Drawing.Size(984, 511)
        Me.flpMain.TabIndex = 1
        '
        'flpWord0
        '
        Me.flpWord0.Controls.Add(Me.pbWord0)
        Me.flpWord0.Controls.Add(Me.tbWord0)
        Me.flpWord0.Location = New System.Drawing.Point(5, 5)
        Me.flpWord0.Margin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.flpWord0.Name = "flpWord0"
        Me.flpWord0.Size = New System.Drawing.Size(150, 150)
        Me.flpWord0.TabIndex = 2
        '
        'pbWord0
        '
        Me.flpWord0.SetFlowBreak(Me.pbWord0, True)
        Me.pbWord0.Image = Global.Monti.My.Resources.Resources.m_question
        Me.pbWord0.Location = New System.Drawing.Point(24, 3)
        Me.pbWord0.Margin = New System.Windows.Forms.Padding(24, 3, 3, 3)
        Me.pbWord0.Name = "pbWord0"
        Me.pbWord0.Size = New System.Drawing.Size(100, 100)
        Me.pbWord0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWord0.TabIndex = 0
        Me.pbWord0.TabStop = False
        Me.pbWord0.Tag = "0"
        '
        'tbWord0
        '
        Me.tbWord0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbWord0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWord0.Location = New System.Drawing.Point(3, 108)
        Me.tbWord0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbWord0.Name = "tbWord0"
        Me.tbWord0.Size = New System.Drawing.Size(144, 26)
        Me.tbWord0.TabIndex = 0
        Me.tbWord0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'flpPlus
        '
        Me.flpPlus.Controls.Add(Me.pbAdd)
        Me.flpPlus.Controls.Add(Me.pbRemove)
        Me.flpPlus.Location = New System.Drawing.Point(165, 5)
        Me.flpPlus.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpPlus.Name = "flpPlus"
        Me.flpPlus.Size = New System.Drawing.Size(100, 170)
        Me.flpPlus.TabIndex = 1
        '
        'pbAdd
        '
        Me.flpPlus.SetFlowBreak(Me.pbAdd, True)
        Me.pbAdd.Image = CType(resources.GetObject("pbAdd.Image"), System.Drawing.Image)
        Me.pbAdd.Location = New System.Drawing.Point(0, 0)
        Me.pbAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAdd.Name = "pbAdd"
        Me.pbAdd.Size = New System.Drawing.Size(70, 70)
        Me.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdd.TabIndex = 1
        Me.pbAdd.TabStop = False
        Me.pbAdd.Tag = "add"
        '
        'pbRemove
        '
        Me.flpPlus.SetFlowBreak(Me.pbRemove, True)
        Me.pbRemove.Image = Global.Monti.My.Resources.Resources.m_minus
        Me.pbRemove.Location = New System.Drawing.Point(0, 70)
        Me.pbRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.pbRemove.Name = "pbRemove"
        Me.pbRemove.Size = New System.Drawing.Size(70, 70)
        Me.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRemove.TabIndex = 2
        Me.pbRemove.TabStop = False
        Me.pbRemove.Tag = "rem"
        '
        'strpStats
        '
        Me.strpStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strpStats.Location = New System.Drawing.Point(0, 540)
        Me.strpStats.Name = "strpStats"
        Me.strpStats.Size = New System.Drawing.Size(984, 22)
        Me.strpStats.TabIndex = 1
        Me.strpStats.Text = "strpStats"
        '
        'lblTest
        '
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(17, 21)
        Me.lblTest.Text = "*"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.strpMain)
        Me.Controls.Add(Me.strpStats)
        Me.MainMenuStrip = Me.strpMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monti Wortarten bestimmen"
        Me.strpMain.ResumeLayout(False)
        Me.strpMain.PerformLayout()
        Me.flpMain.ResumeLayout(False)
        Me.flpWord0.ResumeLayout(False)
        Me.flpWord0.PerformLayout()
        CType(Me.pbWord0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpPlus.ResumeLayout(False)
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents strpMain As System.Windows.Forms.MenuStrip
    Private WithEvents flpMain As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents pbWord0 As System.Windows.Forms.PictureBox
    Private WithEvents tbWord0 As System.Windows.Forms.TextBox
    Private WithEvents flpWord0 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents pbAdd As System.Windows.Forms.PictureBox
    Private WithEvents flpPlus As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents strpStats As System.Windows.Forms.StatusStrip
    Private WithEvents lblTest As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten00 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten02 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten03 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten04 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten05 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten06 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten07 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten08 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten09 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten10 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten01 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten11 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pbRemove As System.Windows.Forms.PictureBox
    Private WithEvents tsmiWortarten12 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten14 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten15 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten13 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten16 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten17 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiWortarten18 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmiClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDebug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVorlagen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiWortarten19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiWortarten20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTraining As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTAdjektiv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTAdverb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTArtikel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTGeteiltesVerb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTHilfsVerb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTInfinitiv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTKopula As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTNomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTNumerale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTPräposition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTUnbArtikel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTVerb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTZweiNomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSelectImp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTPronomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTZweiPronomen As System.Windows.Forms.ToolStripMenuItem

End Class
