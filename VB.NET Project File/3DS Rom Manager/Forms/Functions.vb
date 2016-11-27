Imports System.IO
Imports System.IO.Compression
Module Functions
    ''' <summary>
    ''' Function to search all files and add them to the ListView
    ''' </summary>
    Public Function GetRomList()

        MainForm.RomListView.Items.Clear()

        Dim di As New DirectoryInfo(RomPath)
        Dim diar1 As FileInfo() = di.GetFiles()
        Dim dra As FileInfo
        For Each dra In diar1
            If dra.Extension = RomExtension Then
                MainForm.RomListView.Items.Add(Path.GetFileNameWithoutExtension(dra.ToString))

                Try
                    Dim RomListViewReader As New StreamReader(SRMPath & "Info\" & Path.GetFileNameWithoutExtension(dra.ToString) & ".txt")


                    Dim RomListViewAllLines As List(Of String) = New List(Of String)
                Do While Not RomListViewReader.EndOfStream
                    RomListViewAllLines.Add(RomListViewReader.ReadLine())
                Loop
                RomListViewReader.Close()


                    MainForm.RomListView.Items.Item(MainForm.RomListView.Items.Count - 1).SubItems.Add(RomListViewAllLines(0))
                    MainForm.RomListView.Items.Item(MainForm.RomListView.Items.Count - 1).SubItems.Add(RomListViewAllLines(1))
                    MainForm.RomListView.Items.Item(MainForm.RomListView.Items.Count - 1).SubItems.Add(RomListViewAllLines(2))
                    MainForm.RomListView.Items.Item(MainForm.RomListView.Items.Count - 1).SubItems.Add(RomListViewAllLines(3))
                    MainForm.RomListView.Items.Item(MainForm.RomListView.Items.Count - 1).SubItems.Add(RomListViewAllLines(4))
                Catch
                End Try

            End If
        Next

        If MainForm.RomListView.Items.Count = 0 Then
            If MessageBox.Show("No Rom's were found!" & vbNewLine & "It appears that the paths or the file extensions are not set correctly.", "No Rom's found!", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GetRomList()
            End If
        Else

        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Function which displays the Rom information on the selected Rom
    ''' </summary>
    Function GetRomInfo()
        If MainForm.RomListView.SelectedItems.Count > 0 Then

            Try

                Dim GetRomInfoReader As New StreamReader(SRMPath & "Info\" & MainForm.RomListView.SelectedItems(0).Text & ".txt")
                Dim GetRomInfoAllLines As List(Of String) = New List(Of String)
                Do While Not GetRomInfoReader.EndOfStream
                    GetRomInfoAllLines.Add(GetRomInfoReader.ReadLine())
                Loop
                GetRomInfoReader.Close()



                MainForm.Developer_Label.Text = GetRomInfoAllLines(0)
                MainForm.Publisher_Label.Text = GetRomInfoAllLines(1)
                MainForm.Category_Label.Text = GetRomInfoAllLines(2)
                MainForm.Multiplayer_Label.Text = GetRomInfoAllLines(3)
                MainForm.PEGI_Label.Text = GetRomInfoAllLines(4)

            Catch

                'MessageBox.Show("Some details in the information file of this game seems to be missing!")

                MainForm.Developer_Label.Text = "Missing"
            MainForm.Publisher_Label.Text = "Missing"
            MainForm.Category_Label.Text = "Missing"
            MainForm.Multiplayer_Label.Text = "Missing"
            MainForm.PEGI_Label.Text = "Missing"

            End Try

            MainForm.CoverPreview.ImageLocation = SRMPath & "Images\" & MainForm.RomListView.SelectedItems(0).Text & PictureExtension

        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Function to Download and extract a zip File
    ''' </summary>
    ''' <param name="URL">The Url of the File (http://a.com/a)</param>
    ''' <param name="Path">The path where the zip gets extracted (C:\a.zip)</param>
    ''' <remarks></remarks>
    Public Function DownloadExtractZip(URL As String, Path As String) As Boolean
        Try
            My.Computer.Network.DownloadFile(URL, Path & ".zip")
            ZipFile.ExtractToDirectory(Path & ".zip", Path)
            My.Computer.FileSystem.DeleteFile(Path & ".zip")
        Catch
            Return False

        End Try
        Return True

    End Function

    ''' <summary>
    ''' Function that updates the current variable
    ''' </summary>
    Public Function RefreshConfig()
        My.Settings.PictureExtension = "." & SettingsForm.PictureDateiendung_TextBox.Text
        My.Settings.RomPath = SettingsForm.RomPathTextBox.Text
        My.Settings.SavePath = SettingsForm.SavePathTextBox.Text
        My.Settings.PathsSet = True
        My.Settings.RomExtension = "." & SettingsForm.RomDateiendung_TextBox.Text
        My.Settings.SaveExtension = "." & SettingsForm.SaveDateiendung_TextBox.Text
        My.Settings.PathsSet = True
        My.Settings.Save()


        If My.Settings.RomPath.Substring(My.Settings.RomPath.Length - 1) = "\" Then
        Else
            My.Settings.RomPath = My.Settings.RomPath & "\"
        End If

        If My.Settings.SavePath.Substring(My.Settings.SavePath.Length - 1) = "\" Then
        Else
            My.Settings.SavePath = My.Settings.SavePath & "\"
        End If
        My.Settings.Save()

        RomPath = My.Settings.RomPath
        SavePath = My.Settings.SavePath
        RomExtension = My.Settings.RomExtension
        SaveExtension = My.Settings.SaveExtension
        PictureExtension = My.Settings.PictureExtension
        GetRomList()
        Return Nothing
    End Function

End Module
