<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CoverPreview = New System.Windows.Forms.PictureBox()
        Me.RomSettingsContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SpielstandSichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGameSichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGameWiederherstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyOnlyRomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRomAndSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.Developer_Inf_Label = New System.Windows.Forms.Label()
        Me.Publisher_Inf_Label = New System.Windows.Forms.Label()
        Me.Category_Inf_Label = New System.Windows.Forms.Label()
        Me.Multiplayer_Inf_Label = New System.Windows.Forms.Label()
        Me.PEGI_Inf_Label = New System.Windows.Forms.Label()
        Me.PEGI_Label = New System.Windows.Forms.Label()
        Me.Multiplayer_Label = New System.Windows.Forms.Label()
        Me.Category_Label = New System.Windows.Forms.Label()
        Me.Publisher_Label = New System.Windows.Forms.Label()
        Me.Developer_Label = New System.Windows.Forms.Label()
        Me.RomListView = New System.Windows.Forms.ListView()
        Me.ColumnHeaderRomName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRomDeveloper = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRomPublisher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRomCategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRomMultiplayer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRomPEGI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.CoverPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RomSettingsContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CoverPreview
        '
        Me.CoverPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CoverPreview.Location = New System.Drawing.Point(4, 321)
        Me.CoverPreview.Name = "CoverPreview"
        Me.CoverPreview.Size = New System.Drawing.Size(129, 129)
        Me.CoverPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CoverPreview.TabIndex = 0
        Me.CoverPreview.TabStop = False
        '
        'RomSettingsContextMenu
        '
        Me.RomSettingsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpielstandSichernToolStripMenuItem, Me.SpielToolStripMenuItem})
        Me.RomSettingsContextMenu.Name = "RomSettingsContextMenu"
        Me.RomSettingsContextMenu.Size = New System.Drawing.Size(186, 48)
        Me.RomSettingsContextMenu.Text = "Rom Settings"
        '
        'SpielstandSichernToolStripMenuItem
        '
        Me.SpielstandSichernToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveGameSichernToolStripMenuItem, Me.SaveGameWiederherstellenToolStripMenuItem})
        Me.SpielstandSichernToolStripMenuItem.Name = "SpielstandSichernToolStripMenuItem"
        Me.SpielstandSichernToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SpielstandSichernToolStripMenuItem.Text = "Spielstand"
        '
        'SaveGameSichernToolStripMenuItem
        '
        Me.SaveGameSichernToolStripMenuItem.Name = "SaveGameSichernToolStripMenuItem"
        Me.SaveGameSichernToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveGameSichernToolStripMenuItem.Text = "Sichern"
        '
        'SaveGameWiederherstellenToolStripMenuItem
        '
        Me.SaveGameWiederherstellenToolStripMenuItem.Name = "SaveGameWiederherstellenToolStripMenuItem"
        Me.SaveGameWiederherstellenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveGameWiederherstellenToolStripMenuItem.Text = "Wiederherstellen"
        '
        'SpielToolStripMenuItem
        '
        Me.SpielToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyOnlyRomToolStripMenuItem, Me.CopyRomAndSaveToolStripMenuItem})
        Me.SpielToolStripMenuItem.Name = "SpielToolStripMenuItem"
        Me.SpielToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SpielToolStripMenuItem.Text = "Spiel auf SD kopieren"
        '
        'CopyOnlyRomToolStripMenuItem
        '
        Me.CopyOnlyRomToolStripMenuItem.Name = "CopyOnlyRomToolStripMenuItem"
        Me.CopyOnlyRomToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CopyOnlyRomToolStripMenuItem.Text = "Nur Rom"
        '
        'CopyRomAndSaveToolStripMenuItem
        '
        Me.CopyRomAndSaveToolStripMenuItem.Name = "CopyRomAndSaveToolStripMenuItem"
        Me.CopyRomAndSaveToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CopyRomAndSaveToolStripMenuItem.Text = "Rom + Save"
        '
        'FolderBrowser
        '
        Me.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.Location = New System.Drawing.Point(656, 421)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(75, 23)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'Developer_Inf_Label
        '
        Me.Developer_Inf_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Developer_Inf_Label.AutoSize = True
        Me.Developer_Inf_Label.Location = New System.Drawing.Point(139, 338)
        Me.Developer_Inf_Label.Name = "Developer_Inf_Label"
        Me.Developer_Inf_Label.Size = New System.Drawing.Size(59, 13)
        Me.Developer_Inf_Label.TabIndex = 3
        Me.Developer_Inf_Label.Text = "Developer:"
        '
        'Publisher_Inf_Label
        '
        Me.Publisher_Inf_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Publisher_Inf_Label.AutoSize = True
        Me.Publisher_Inf_Label.Location = New System.Drawing.Point(145, 360)
        Me.Publisher_Inf_Label.Name = "Publisher_Inf_Label"
        Me.Publisher_Inf_Label.Size = New System.Drawing.Size(53, 13)
        Me.Publisher_Inf_Label.TabIndex = 4
        Me.Publisher_Inf_Label.Text = "Publisher:"
        '
        'Category_Inf_Label
        '
        Me.Category_Inf_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Category_Inf_Label.AutoSize = True
        Me.Category_Inf_Label.Location = New System.Drawing.Point(146, 382)
        Me.Category_Inf_Label.Name = "Category_Inf_Label"
        Me.Category_Inf_Label.Size = New System.Drawing.Size(52, 13)
        Me.Category_Inf_Label.TabIndex = 5
        Me.Category_Inf_Label.Text = "Category:"
        '
        'Multiplayer_Inf_Label
        '
        Me.Multiplayer_Inf_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Multiplayer_Inf_Label.AutoSize = True
        Me.Multiplayer_Inf_Label.Location = New System.Drawing.Point(138, 404)
        Me.Multiplayer_Inf_Label.Name = "Multiplayer_Inf_Label"
        Me.Multiplayer_Inf_Label.Size = New System.Drawing.Size(60, 13)
        Me.Multiplayer_Inf_Label.TabIndex = 6
        Me.Multiplayer_Inf_Label.Text = "Multiplayer:"
        '
        'PEGI_Inf_Label
        '
        Me.PEGI_Inf_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PEGI_Inf_Label.AutoSize = True
        Me.PEGI_Inf_Label.Location = New System.Drawing.Point(163, 426)
        Me.PEGI_Inf_Label.Name = "PEGI_Inf_Label"
        Me.PEGI_Inf_Label.Size = New System.Drawing.Size(35, 13)
        Me.PEGI_Inf_Label.TabIndex = 7
        Me.PEGI_Inf_Label.Text = "PEGI:"
        '
        'PEGI_Label
        '
        Me.PEGI_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PEGI_Label.AutoSize = True
        Me.PEGI_Label.Location = New System.Drawing.Point(204, 426)
        Me.PEGI_Label.Name = "PEGI_Label"
        Me.PEGI_Label.Size = New System.Drawing.Size(33, 13)
        Me.PEGI_Label.TabIndex = 12
        Me.PEGI_Label.Text = "None"
        '
        'Multiplayer_Label
        '
        Me.Multiplayer_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Multiplayer_Label.AutoSize = True
        Me.Multiplayer_Label.Location = New System.Drawing.Point(204, 404)
        Me.Multiplayer_Label.Name = "Multiplayer_Label"
        Me.Multiplayer_Label.Size = New System.Drawing.Size(33, 13)
        Me.Multiplayer_Label.TabIndex = 11
        Me.Multiplayer_Label.Text = "None"
        '
        'Category_Label
        '
        Me.Category_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Category_Label.AutoSize = True
        Me.Category_Label.Location = New System.Drawing.Point(204, 382)
        Me.Category_Label.Name = "Category_Label"
        Me.Category_Label.Size = New System.Drawing.Size(33, 13)
        Me.Category_Label.TabIndex = 10
        Me.Category_Label.Text = "None"
        '
        'Publisher_Label
        '
        Me.Publisher_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Publisher_Label.AutoSize = True
        Me.Publisher_Label.Location = New System.Drawing.Point(204, 360)
        Me.Publisher_Label.Name = "Publisher_Label"
        Me.Publisher_Label.Size = New System.Drawing.Size(33, 13)
        Me.Publisher_Label.TabIndex = 9
        Me.Publisher_Label.Text = "None"
        '
        'Developer_Label
        '
        Me.Developer_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Developer_Label.AutoSize = True
        Me.Developer_Label.Location = New System.Drawing.Point(204, 338)
        Me.Developer_Label.Name = "Developer_Label"
        Me.Developer_Label.Size = New System.Drawing.Size(33, 13)
        Me.Developer_Label.TabIndex = 8
        Me.Developer_Label.Text = "None"
        '
        'RomListView
        '
        Me.RomListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RomListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderRomName, Me.ColumnHeaderRomDeveloper, Me.ColumnHeaderRomPublisher, Me.ColumnHeaderRomCategory, Me.ColumnHeaderRomMultiplayer, Me.ColumnHeaderRomPEGI})
        Me.RomListView.ContextMenuStrip = Me.RomSettingsContextMenu
        Me.RomListView.Location = New System.Drawing.Point(4, 3)
        Me.RomListView.MultiSelect = False
        Me.RomListView.Name = "RomListView"
        Me.RomListView.ShowGroups = False
        Me.RomListView.Size = New System.Drawing.Size(738, 312)
        Me.RomListView.TabIndex = 13
        Me.RomListView.UseCompatibleStateImageBehavior = False
        Me.RomListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderRomName
        '
        Me.ColumnHeaderRomName.Text = "Rom Name"
        Me.ColumnHeaderRomName.Width = 280
        '
        'ColumnHeaderRomDeveloper
        '
        Me.ColumnHeaderRomDeveloper.Text = "Developer"
        Me.ColumnHeaderRomDeveloper.Width = 94
        '
        'ColumnHeaderRomPublisher
        '
        Me.ColumnHeaderRomPublisher.Text = "Publisher"
        Me.ColumnHeaderRomPublisher.Width = 90
        '
        'ColumnHeaderRomCategory
        '
        Me.ColumnHeaderRomCategory.Text = "Category"
        Me.ColumnHeaderRomCategory.Width = 103
        '
        'ColumnHeaderRomMultiplayer
        '
        Me.ColumnHeaderRomMultiplayer.Text = "Multiplayer?"
        Me.ColumnHeaderRomMultiplayer.Width = 100
        '
        'ColumnHeaderRomPEGI
        '
        Me.ColumnHeaderRomPEGI.Text = "PEGI"
        Me.ColumnHeaderRomPEGI.Width = 55
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 453)
        Me.Controls.Add(Me.RomListView)
        Me.Controls.Add(Me.PEGI_Label)
        Me.Controls.Add(Me.Multiplayer_Label)
        Me.Controls.Add(Me.Category_Label)
        Me.Controls.Add(Me.Publisher_Label)
        Me.Controls.Add(Me.Developer_Label)
        Me.Controls.Add(Me.PEGI_Inf_Label)
        Me.Controls.Add(Me.Multiplayer_Inf_Label)
        Me.Controls.Add(Me.Category_Inf_Label)
        Me.Controls.Add(Me.Publisher_Inf_Label)
        Me.Controls.Add(Me.Developer_Inf_Label)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.CoverPreview)
        Me.Name = "MainForm"
        Me.Text = "Simple Rom Manager"
        CType(Me.CoverPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RomSettingsContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CoverPreview As PictureBox
    Friend WithEvents RomSettingsContextMenu As ContextMenuStrip
    Friend WithEvents SpielstandSichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveGameSichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveGameWiederherstellenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpielToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyOnlyRomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyRomAndSaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowser As FolderBrowserDialog
    Friend WithEvents SettingsButton As Button
    Friend WithEvents Developer_Inf_Label As Label
    Friend WithEvents Publisher_Inf_Label As Label
    Friend WithEvents Category_Inf_Label As Label
    Friend WithEvents Multiplayer_Inf_Label As Label
    Friend WithEvents PEGI_Inf_Label As Label
    Friend WithEvents PEGI_Label As Label
    Friend WithEvents Multiplayer_Label As Label
    Friend WithEvents Category_Label As Label
    Friend WithEvents Publisher_Label As Label
    Friend WithEvents Developer_Label As Label
    Friend WithEvents RomListView As ListView
    Friend WithEvents ColumnHeaderRomName As ColumnHeader
    Friend WithEvents ColumnHeaderRomDeveloper As ColumnHeader
    Friend WithEvents ColumnHeaderRomPublisher As ColumnHeader
    Friend WithEvents ColumnHeaderRomCategory As ColumnHeader
    Friend WithEvents ColumnHeaderRomMultiplayer As ColumnHeader
    Friend WithEvents ColumnHeaderRomPEGI As ColumnHeader
End Class
