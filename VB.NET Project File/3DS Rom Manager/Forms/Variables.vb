Module Variables

    Public RomPath As String = My.Settings.RomPath
    Public SavePath As String = My.Settings.SavePath
    Public RomExtension As String = My.Settings.RomExtension
    Public SaveExtension As String = My.Settings.SaveExtension
    Public PictureExtension As String = My.Settings.PictureExtension
    Public SRMPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SRM\"

    Public Close As Boolean = False
End Module
