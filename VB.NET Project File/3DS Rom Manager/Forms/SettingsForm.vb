Imports System.ComponentModel
Public Class SettingsForm

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        My.Settings.Reload()

        RomPathTextBox.Text = My.Settings.RomPath
        SavePathTextBox.Text = My.Settings.SavePath
        RomDateiendung_TextBox.Text = My.Settings.RomExtension.Remove(0, 1)
        SaveDateiendung_TextBox.Text = My.Settings.SaveExtension.Remove(0, 1)
        PictureDateiendung_TextBox.Text = My.Settings.PictureExtension.Remove(0, 1)

        If My.Computer.Registry.ClassesRoot.OpenSubKey("SRMROM") Is Nothing Then
            My.Settings.ExtensionAssociationSet = False
            My.Settings.ExtensionAssociationFileType = ""
            CheckBoxRegisterRomExt.Checked = False
        Else
            CheckBoxRegisterRomExt.Checked = True

        End If
    End Sub

    Private Sub RomPathButton_Click(sender As Object, e As EventArgs) Handles RomPathButton.Click
        FolderBrowser.ShowDialog()
        RomPathTextBox.Text = FolderBrowser.SelectedPath
    End Sub

    Private Sub SavePathButton_Click(sender As Object, e As EventArgs) Handles SavePathButton.Click
        FolderBrowser.ShowDialog()
        SavePathTextBox.Text = FolderBrowser.SelectedPath
    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        If CheckBoxRegisterRomExt.Checked Then

            If My.Settings.ExtensionAssociationSet = False Then

                Process.Start(SRMPath & "Bin\RRF.exe", RomDateiendung_TextBox.Text & " Add")
                My.Settings.ExtensionAssociationFileType = RomDateiendung_TextBox.Text
                My.Settings.ExtensionAssociationSet = True

            End If

        Else

            If My.Settings.ExtensionAssociationSet = True Then

                If My.Settings.ExtensionAssociationFileType = "" Then

                    MsgBox("It seams like, you manualy created an File Extension Association")

                Else
                    If MsgBox("Do you want to remove the current File Extension Association? (" &
                       My.Settings.ExtensionAssociationFileType & ")", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(SRMPath & "Bin\RRF.exe", My.Settings.ExtensionAssociationFileType & " Remove")
                        My.Settings.ExtensionAssociationFileType = ""
                        My.Settings.ExtensionAssociationSet = False
                    End If
                End If
            End If

        End If

        RefreshConfig()

        MainForm.Show()
        Hide()
    End Sub

    Private Sub SettingsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Show()
    End Sub


End Class