Imports System.IO
Imports System.IO.Compression
Public Class LaunchForm
    Private Sub LaunchForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

#Region "Create Application Folders and Binary exe"

        ''Create SRM Folder in AppData\Roaming
        If (Not Directory.Exists(SRMPath)) Then
            Directory.CreateDirectory(SRMPath)
        End If

        ''Create SaveBackup Folder in AppData\Roaming\SRM
        If (Not Directory.Exists(SRMPath & "Save Backup\")) Then
            Directory.CreateDirectory(SRMPath & "Save Backup\")
        End If

        ''Create Binary Folder in AppData\Roaming\SRM
        If (Not Directory.Exists(SRMPath & "Bin\")) Then
            Directory.CreateDirectory(SRMPath & "Bin\")
        End If

        ''Copy exe File to Bin Folder (for file extension association)
        If Not File.Exists(SRMPath & "Bin\SRM.exe") Then
            FileCopy(Environment.GetCommandLineArgs(0), SRMPath & "Bin\SRM.exe")
        End If

        ''Copy file extension association exe to Bin Folder
        If Not File.Exists(SRMPath & "Bin\RRF.exe") Then
            File.WriteAllBytes(SRMPath & "Bin\RRF.exe", My.Resources.RRF)
        End If

#End Region

#Region "Checks if a Folder got deleted!"

        ''Checks Images Folder
        If (Not Directory.Exists(SRMPath & "Images\")) Then
            MsgBox("It looks like an important folder got deleted!" & vbNewLine &
                   "You will now be sent back to the Setup")
            My.Settings.FirstStartOptionSet = False
        End If

        ''Checks Info Folder
        If (Not Directory.Exists(SRMPath & "Info\")) Then
            MsgBox("It looks like an important folder got deleted!" & vbNewLine &
                   "You will now be sent back to the Setup")
            My.Settings.FirstStartOptionSet = False
        End If

#End Region

#Region "Checks if the Application is opened with an Folder (Drag'n Drop)"
        If Environment.GetCommandLineArgs.Count > 1 Then

            If My.Settings.FirstStartOptionSet = True Then

                MsgBox(Environment.GetCommandLineArgs(1) & vbNewLine & "Not Avalible Yet")

            Else
                MsgBox("Please open the Application once, to set everything up!")
                Close()
            End If
#End Region

        Else

            ''If this is the first start, then set the Visibility to 100%
            If My.Settings.FirstStartOptionSet = False Then
                Opacity = 100
            Else

                ''Else if the paths are already set, open the MainForm and close this Form 
                If My.Settings.PathsSet = True Then
                    MainForm.Show()
                    Close()

                    ''If the the paths are not set, open the SettingsForm, and close this Form
                Else
                    SettingsForm.Show()
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub Finish_btn_Click(sender As Object, e As EventArgs) Handles Finish_btn.Click

        ''If none Checkbox is checked
        If OnlineRadioBtn.Checked = False And InternalRadioBtn.Checked = False And NoneRadioBtn.Checked = False Then

            MsgBox("You need to check at least one Option!")

        Else
            ''If "Online" Checkbox is checked
            If OnlineRadioBtn.Checked = True Then
                DownloadExtractZip("https://dl.dropboxusercontent.com/u/118569906/SRM/Images.zip", SRMPath & "Images")
                DownloadExtractZip("https://dl.dropboxusercontent.com/u/118569906/SRM/Info.zip", SRMPath & "Info")
                My.Settings.FirstStartOptionSet = True
                My.Settings.Save()
                MsgBox("Finished Download")
                SettingsForm.Show()
                Close()
            End If

            ''If "Internal" Checkbox is checked
            If InternalRadioBtn.Checked = True Then
                If (Not Directory.Exists(SRMPath & "Info\")) Then
                    Directory.CreateDirectory(SRMPath & "Info\")
                End If

                File.WriteAllBytes(SRMPath & "Info\Info.zip", My.Resources.Images)
                ZipFile.ExtractToDirectory(SRMPath & "Info\Info.zip", SRMPath & "Info\")
                File.Delete(SRMPath & "Info\Info.zip")


                If (Not Directory.Exists(SRMPath & "Images\")) Then
                    Directory.CreateDirectory(SRMPath & "Images\")
                End If

                File.WriteAllBytes(SRMPath & "Images\Images.zip", My.Resources.Images)
                ZipFile.ExtractToDirectory(SRMPath & "Images\Images.zip", SRMPath & "Images\")
                File.Delete(SRMPath & "Images\Images.zip")

                My.Settings.FirstStartOptionSet = True
                My.Settings.Save()
                MsgBox("Finished Extraction")
                SettingsForm.Show()
                Close()
            End If

            ''If "None" Checkbox is checked
            If NoneRadioBtn.Checked = True Then
                My.Settings.FirstStartOptionSet = True
                My.Settings.Save()
                SettingsForm.Show()
                Close()
            End If

        End If
    End Sub

End Class