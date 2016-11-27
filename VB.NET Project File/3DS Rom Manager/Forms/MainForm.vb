Imports System.ComponentModel
Public Class MainForm

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        If My.Computer.Registry.ClassesRoot.OpenSubKey("SRMROM") Is Nothing Then
            My.Settings.ExtensionAssociationSet = False
            My.Settings.ExtensionAssociationFileType = ""
            SettingsForm.CheckBoxRegisterRomExt.Checked = False
        Else
            SettingsForm.CheckBoxRegisterRomExt.Checked = True

        End If
        SettingsForm.Show()
        Hide()
    End Sub


#Region "ContextMenuStrip Events"
    Private Sub SaveGameSichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameSichernToolStripMenuItem.Click
        FileCopy(SavePath & RomListView.SelectedItems(0).Text & SaveExtension, SRMPath & "Save Backup\" & RomListView.SelectedItems(0).Text & SaveExtension)
    End Sub

    Private Sub SaveGameWiederherstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameWiederherstellenToolStripMenuItem.Click

    End Sub

    Private Sub CopyOnlyRomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyOnlyRomToolStripMenuItem.Click
        FolderBrowser.ShowDialog()
        FileCopy(RomPath & RomListView.SelectedItems(0).Text & RomExtension, FolderBrowser.SelectedPath & RomListView.SelectedItems(0).Text & RomExtension)
    End Sub

    Private Sub CopyRomAndSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRomAndSaveToolStripMenuItem.Click
        FolderBrowser.ShowDialog()
        FileCopy(RomPath & RomListView.SelectedItems(0).Text & RomExtension, FolderBrowser.SelectedPath & RomListView.SelectedItems(0).Text & RomExtension)
        FileCopy(SavePath & RomListView.SelectedItems(0).Text & SaveExtension, FolderBrowser.SelectedPath & RomListView.SelectedItems(0).Text & SaveExtension)
    End Sub

#End Region


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SettingsForm.Hide()
        GetRomList()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SettingsForm.Close()
    End Sub

    Private Sub RomListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RomListView.SelectedIndexChanged
        GetRomInfo()
    End Sub
End Class
