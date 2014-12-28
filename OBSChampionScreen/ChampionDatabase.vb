Imports System.IO


Public Class ChampionDatabase

    Private _dir As DirectoryInfo
    Private _list As List(Of ChampionData)



    Public Sub init()
        setImgPath()
        _dir = New DirectoryInfo(My.Settings.imgPath)
        Dim erg() As FileInfo = _dir.GetFiles("*.png")
        _list = New List(Of ChampionData)
        For Each x As FileInfo In erg
            Dim d As New ChampionData
            Dim name As String = x.Name.Split("_")(0)
            d.Name = name
            Debug.WriteLine(name & " gefunden")
            d.Square = Image.FromFile(x.FullName)
            d.Banner = Image.FromFile(My.Settings.imgPath & "\" & name & "_0.jpg")
            _list.Add(d)
            Debug.WriteLine(name & " wurde der Liste hinzugefügt!")
        Next
    End Sub

    Public ReadOnly Property ChampionDataList As List(Of ChampionData)
        Get
            Return _list
        End Get
    End Property

    Public Sub setImgPath()
        Debug.WriteLine(My.Settings.imgPath)
        If My.Settings.imgPath = "" Or My.Computer.FileSystem.DirectoryExists(My.Settings.imgPath) = False Then
            Dim s As New FolderBrowserDialog
            s.ShowNewFolderButton = False
            s.Description = "Riot-Ordner wählen"
            If s.ShowDialog = DialogResult.OK Then
                My.Settings.imgPath = s.SelectedPath
            Else
                MsgBox("Riot-Ordner nicht gefunden. Programm wird beendet")
                Environment.Exit(1000)
            End If
            My.Settings.imgPath &= "\League of Legends\RADS\projects\lol_air_client\releases"

            Dim md As New DirectoryInfo(My.Settings.imgPath)
            md = md.GetDirectories()(0)
            My.Settings.imgPath = md.FullName & "\deploy\assets\images\champions"
            My.Settings.Save()
        End If
    End Sub



    Public Function getList() As ListBox
        Dim lst As New ListBox
        For Each x As ChampionData In _list
            lst.Items.Add(x.Name)
        Next
        Return lst
    End Function




End Class
