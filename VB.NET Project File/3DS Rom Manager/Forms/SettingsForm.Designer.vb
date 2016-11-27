<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.RomPathButton = New System.Windows.Forms.Button()
        Me.SavePathButton = New System.Windows.Forms.Button()
        Me.RomPathTextBox = New System.Windows.Forms.TextBox()
        Me.SavePathTextBox = New System.Windows.Forms.TextBox()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.RomDateiendung_Label = New System.Windows.Forms.Label()
        Me.RomDateiendung_TextBox = New System.Windows.Forms.TextBox()
        Me.SaveDateiendung_TextBox = New System.Windows.Forms.TextBox()
        Me.SaveDateiendung_Label = New System.Windows.Forms.Label()
        Me.PictureDateiendung_Label = New System.Windows.Forms.Label()
        Me.PictureDateiendung_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxRegisterRomExt = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'RomPathButton
        '
        Me.RomPathButton.Location = New System.Drawing.Point(12, 12)
        Me.RomPathButton.Name = "RomPathButton"
        Me.RomPathButton.Size = New System.Drawing.Size(75, 23)
        Me.RomPathButton.TabIndex = 0
        Me.RomPathButton.Text = "Rom Path"
        Me.RomPathButton.UseVisualStyleBackColor = True
        '
        'SavePathButton
        '
        Me.SavePathButton.Location = New System.Drawing.Point(12, 41)
        Me.SavePathButton.Name = "SavePathButton"
        Me.SavePathButton.Size = New System.Drawing.Size(75, 23)
        Me.SavePathButton.TabIndex = 1
        Me.SavePathButton.Text = "Save Path"
        Me.SavePathButton.UseVisualStyleBackColor = True
        '
        'RomPathTextBox
        '
        Me.RomPathTextBox.Location = New System.Drawing.Point(93, 14)
        Me.RomPathTextBox.Name = "RomPathTextBox"
        Me.RomPathTextBox.Size = New System.Drawing.Size(382, 20)
        Me.RomPathTextBox.TabIndex = 2
        '
        'SavePathTextBox
        '
        Me.SavePathTextBox.Location = New System.Drawing.Point(93, 43)
        Me.SavePathTextBox.Name = "SavePathTextBox"
        Me.SavePathTextBox.Size = New System.Drawing.Size(382, 20)
        Me.SavePathTextBox.TabIndex = 3
        '
        'FolderBrowser
        '
        Me.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(400, 117)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishButton.TabIndex = 4
        Me.FinishButton.Text = "Confirm"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'RomDateiendung_Label
        '
        Me.RomDateiendung_Label.AutoSize = True
        Me.RomDateiendung_Label.Location = New System.Drawing.Point(12, 72)
        Me.RomDateiendung_Label.Name = "RomDateiendung_Label"
        Me.RomDateiendung_Label.Size = New System.Drawing.Size(77, 13)
        Me.RomDateiendung_Label.TabIndex = 5
        Me.RomDateiendung_Label.Text = "Rom extension"
        '
        'RomDateiendung_TextBox
        '
        Me.RomDateiendung_TextBox.Location = New System.Drawing.Point(93, 69)
        Me.RomDateiendung_TextBox.Name = "RomDateiendung_TextBox"
        Me.RomDateiendung_TextBox.Size = New System.Drawing.Size(120, 20)
        Me.RomDateiendung_TextBox.TabIndex = 6
        '
        'SaveDateiendung_TextBox
        '
        Me.SaveDateiendung_TextBox.Location = New System.Drawing.Point(355, 69)
        Me.SaveDateiendung_TextBox.Name = "SaveDateiendung_TextBox"
        Me.SaveDateiendung_TextBox.Size = New System.Drawing.Size(120, 20)
        Me.SaveDateiendung_TextBox.TabIndex = 8
        '
        'SaveDateiendung_Label
        '
        Me.SaveDateiendung_Label.AutoSize = True
        Me.SaveDateiendung_Label.Location = New System.Drawing.Point(269, 72)
        Me.SaveDateiendung_Label.Name = "SaveDateiendung_Label"
        Me.SaveDateiendung_Label.Size = New System.Drawing.Size(80, 13)
        Me.SaveDateiendung_Label.TabIndex = 7
        Me.SaveDateiendung_Label.Text = "Save extension"
        '
        'PictureDateiendung_Label
        '
        Me.PictureDateiendung_Label.AutoSize = True
        Me.PictureDateiendung_Label.Location = New System.Drawing.Point(-1, 98)
        Me.PictureDateiendung_Label.Name = "PictureDateiendung_Label"
        Me.PictureDateiendung_Label.Size = New System.Drawing.Size(88, 13)
        Me.PictureDateiendung_Label.TabIndex = 9
        Me.PictureDateiendung_Label.Text = "Picture extension"
        '
        'PictureDateiendung_TextBox
        '
        Me.PictureDateiendung_TextBox.Location = New System.Drawing.Point(93, 95)
        Me.PictureDateiendung_TextBox.Name = "PictureDateiendung_TextBox"
        Me.PictureDateiendung_TextBox.Size = New System.Drawing.Size(120, 20)
        Me.PictureDateiendung_TextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "The file extension of the attached pictures is jpg!"
        '
        'CheckBoxRegisterRomExt
        '
        Me.CheckBoxRegisterRomExt.AutoSize = True
        Me.CheckBoxRegisterRomExt.Location = New System.Drawing.Point(272, 97)
        Me.CheckBoxRegisterRomExt.Name = "CheckBoxRegisterRomExt"
        Me.CheckBoxRegisterRomExt.Size = New System.Drawing.Size(138, 17)
        Me.CheckBoxRegisterRomExt.TabIndex = 12
        Me.CheckBoxRegisterRomExt.Text = "Register Rom extension"
        Me.CheckBoxRegisterRomExt.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 144)
        Me.Controls.Add(Me.CheckBoxRegisterRomExt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureDateiendung_TextBox)
        Me.Controls.Add(Me.PictureDateiendung_Label)
        Me.Controls.Add(Me.SaveDateiendung_TextBox)
        Me.Controls.Add(Me.SaveDateiendung_Label)
        Me.Controls.Add(Me.RomDateiendung_TextBox)
        Me.Controls.Add(Me.RomDateiendung_Label)
        Me.Controls.Add(Me.FinishButton)
        Me.Controls.Add(Me.SavePathTextBox)
        Me.Controls.Add(Me.RomPathTextBox)
        Me.Controls.Add(Me.SavePathButton)
        Me.Controls.Add(Me.RomPathButton)
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RomPathButton As Button
    Friend WithEvents SavePathButton As Button
    Friend WithEvents RomPathTextBox As TextBox
    Friend WithEvents SavePathTextBox As TextBox
    Friend WithEvents FolderBrowser As FolderBrowserDialog
    Friend WithEvents FinishButton As Button
    Friend WithEvents RomDateiendung_Label As Label
    Friend WithEvents RomDateiendung_TextBox As TextBox
    Friend WithEvents SaveDateiendung_TextBox As TextBox
    Friend WithEvents SaveDateiendung_Label As Label
    Friend WithEvents PictureDateiendung_Label As Label
    Friend WithEvents PictureDateiendung_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxRegisterRomExt As CheckBox
End Class
