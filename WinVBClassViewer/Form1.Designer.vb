<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grpFiles = New System.Windows.Forms.GroupBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.clbFiles = New System.Windows.Forms.CheckedListBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssFiles1Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnuFiles1 = New System.Windows.Forms.MenuStrip
        Me.mnuFiles1Menu = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFiles1Browse = New System.Windows.Forms.ToolStripMenuItem
        Me.DosyaUzantisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DigerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFiles1Root = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFiles1Exit = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grpTextboxes = New System.Windows.Forms.GroupBox
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer
        Me.tbcFiles = New System.Windows.Forms.TabControl
        Me.cmnuFiles2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuEmptyPage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuClosingSelectPage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuClosingAllPage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip
        Me.tssFiles2Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpFiles.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mnuFiles1.SuspendLayout()
        Me.grpTextboxes.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.cmnuFiles2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 10)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpTextboxes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(640, 454)
        Me.SplitContainer1.SplitterDistance = 230
        Me.SplitContainer1.TabIndex = 1
        '
        'grpFiles
        '
        Me.grpFiles.Controls.Add(Me.ToolStripContainer1)
        Me.grpFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFiles.Location = New System.Drawing.Point(10, 0)
        Me.grpFiles.Name = "grpFiles"
        Me.grpFiles.Size = New System.Drawing.Size(220, 444)
        Me.grpFiles.TabIndex = 3
        Me.grpFiles.TabStop = False
        Me.grpFiles.Text = "Dosyalar"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.clbFiles)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.StatusStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(214, 401)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(214, 425)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnuFiles1)
        '
        'clbFiles
        '
        Me.clbFiles.CheckOnClick = True
        Me.clbFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbFiles.FormattingEnabled = True
        Me.clbFiles.Location = New System.Drawing.Point(0, 0)
        Me.clbFiles.Name = "clbFiles"
        Me.clbFiles.Size = New System.Drawing.Size(214, 379)
        Me.clbFiles.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssFiles1Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(214, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssFiles1Status
        '
        Me.tssFiles1Status.Name = "tssFiles1Status"
        Me.tssFiles1Status.Size = New System.Drawing.Size(0, 17)
        '
        'mnuFiles1
        '
        Me.mnuFiles1.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuFiles1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFiles1Menu})
        Me.mnuFiles1.Location = New System.Drawing.Point(0, 0)
        Me.mnuFiles1.Name = "mnuFiles1"
        Me.mnuFiles1.Size = New System.Drawing.Size(214, 24)
        Me.mnuFiles1.TabIndex = 0
        Me.mnuFiles1.Text = "MenuStrip1"
        '
        'mnuFiles1Menu
        '
        Me.mnuFiles1Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFiles1Browse, Me.DosyaUzantisiToolStripMenuItem, Me.ToolStripMenuItem1, Me.mnuFiles1Root, Me.ToolStripMenuItem3, Me.mnuFiles1Exit})
        Me.mnuFiles1Menu.Name = "mnuFiles1Menu"
        Me.mnuFiles1Menu.Size = New System.Drawing.Size(45, 20)
        Me.mnuFiles1Menu.Text = "Menü"
        '
        'mnuFiles1Browse
        '
        Me.mnuFiles1Browse.Name = "mnuFiles1Browse"
        Me.mnuFiles1Browse.Size = New System.Drawing.Size(174, 22)
        Me.mnuFiles1Browse.Text = "Gözat"
        '
        'DosyaUzantisiToolStripMenuItem
        '
        Me.DosyaUzantisiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VbToolStripMenuItem, Me.ToolStripMenuItem2, Me.DigerToolStripMenuItem})
        Me.DosyaUzantisiToolStripMenuItem.Name = "DosyaUzantisiToolStripMenuItem"
        Me.DosyaUzantisiToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DosyaUzantisiToolStripMenuItem.Text = "Dosya Uzantýsý"
        '
        'VbToolStripMenuItem
        '
        Me.VbToolStripMenuItem.Checked = True
        Me.VbToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VbToolStripMenuItem.Name = "VbToolStripMenuItem"
        Me.VbToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.VbToolStripMenuItem.Text = "vb"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 6)
        '
        'DigerToolStripMenuItem
        '
        Me.DigerToolStripMenuItem.Name = "DigerToolStripMenuItem"
        Me.DigerToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DigerToolStripMenuItem.Text = "Diðer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(171, 6)
        '
        'mnuFiles1Root
        '
        Me.mnuFiles1Root.Name = "mnuFiles1Root"
        Me.mnuFiles1Root.Size = New System.Drawing.Size(174, 22)
        Me.mnuFiles1Root.Text = "Root Klasör Ayarla"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(171, 6)
        '
        'mnuFiles1Exit
        '
        Me.mnuFiles1Exit.Name = "mnuFiles1Exit"
        Me.mnuFiles1Exit.Size = New System.Drawing.Size(174, 22)
        Me.mnuFiles1Exit.Text = "Çýkýþ"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 444)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 444)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 10)
        Me.Panel2.TabIndex = 0
        '
        'grpTextboxes
        '
        Me.grpTextboxes.Controls.Add(Me.ToolStripContainer2)
        Me.grpTextboxes.Controls.Add(Me.StatusStrip2)
        Me.grpTextboxes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTextboxes.Location = New System.Drawing.Point(0, 0)
        Me.grpTextboxes.Name = "grpTextboxes"
        Me.grpTextboxes.Size = New System.Drawing.Size(396, 444)
        Me.grpTextboxes.TabIndex = 2
        Me.grpTextboxes.TabStop = False
        Me.grpTextboxes.Text = "Dosya Ýçerikleri"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.tbcFiles)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(340, 378)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(390, 403)
        Me.ToolStripContainer2.TabIndex = 3
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'tbcFiles
        '
        Me.tbcFiles.ContextMenuStrip = Me.cmnuFiles2
        Me.tbcFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcFiles.Location = New System.Drawing.Point(0, 0)
        Me.tbcFiles.Name = "tbcFiles"
        Me.tbcFiles.SelectedIndex = 0
        Me.tbcFiles.Size = New System.Drawing.Size(340, 378)
        Me.tbcFiles.TabIndex = 3
        '
        'cmnuFiles2
        '
        Me.cmnuFiles2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuEmptyPage, Me.ToolStripMenuItem5, Me.cmnuClosingSelectPage, Me.ToolStripMenuItem4, Me.cmnuClosingAllPage})
        Me.cmnuFiles2.Name = "cmnuFiles2"
        Me.cmnuFiles2.Size = New System.Drawing.Size(190, 82)
        '
        'cmnuEmptyPage
        '
        Me.cmnuEmptyPage.Name = "cmnuEmptyPage"
        Me.cmnuEmptyPage.Size = New System.Drawing.Size(189, 22)
        Me.cmnuEmptyPage.Text = "Boþ Sayfa Aç"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(186, 6)
        '
        'cmnuClosingSelectPage
        '
        Me.cmnuClosingSelectPage.Name = "cmnuClosingSelectPage"
        Me.cmnuClosingSelectPage.Size = New System.Drawing.Size(189, 22)
        Me.cmnuClosingSelectPage.Text = "Sayfa Kapat"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(186, 6)
        '
        'cmnuClosingAllPage
        '
        Me.cmnuClosingAllPage.Name = "cmnuClosingAllPage"
        Me.cmnuClosingAllPage.Size = New System.Drawing.Size(189, 22)
        Me.cmnuClosingAllPage.Text = "Bütün Sayfalarý Kapat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(156, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&Yeni"
        Me.NewToolStripButton.ToolTipText = "Yeni"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Aç"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Kaydet"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "K&es"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Kopyala"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "Yapýþtý&r"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssFiles2Status, Me.ToolStripStatusLabel1})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 419)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(390, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'tssFiles2Status
        '
        Me.tssFiles2Status.Name = "tssFiles2Status"
        Me.tssFiles2Status.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(396, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 444)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 444)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 10)
        Me.Panel3.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 464)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VB Class File Viewer"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpFiles.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuFiles1.ResumeLayout(False)
        Me.mnuFiles1.PerformLayout()
        Me.grpTextboxes.ResumeLayout(False)
        Me.grpTextboxes.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.cmnuFiles2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpFiles As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents clbFiles As System.Windows.Forms.CheckedListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssFiles1Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuFiles1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFiles1Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFiles1Browse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosyaUzantisiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DigerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFiles1Root As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFiles1Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents grpTextboxes As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tbcFiles As System.Windows.Forms.TabControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssFiles2Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmnuFiles2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuEmptyPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuClosingSelectPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuClosingAllPage As System.Windows.Forms.ToolStripMenuItem

End Class
