Imports System.IO
Imports System.Xml


Public Class MemoryManagement

    Public WithEvents championDB As New ChampionDatabase()
    Public WithEvents outputSettings As New OutputSettingDB
    Public Event nextStep()
    Public Event finished()
    Public stepDescription As String = "Lade Komponente"


    Public Sub load()
        'Update


        'Champions
        schritt("Lade Champions aus champions.xml")
        AddHandler championDB.championAdded, AddressOf schritt
        championDB.load(".\data\champions.xml")

        'Teams

        
        'Ausgabe-Optionen
        schritt("Lade Ausgabe-Optionen")
        outputSettings.load(".\data\output.xml")

        schritt("Laden komplett. Starte Haupt-Fenster")
        RaiseEvent finished()
    End Sub




    Private Sub schritt(str As String)
        stepDescription = str
        RaiseEvent nextStep()
    End Sub


    Public Class ChampionDatabase

        Public db As New List(Of ChampionData)
        Public Event championAdded(str As String)

        Public Sub load(xmlFile As String)
            Dim doc As New XmlDocument
            doc.Load(xmlFile)
            For Each a As XmlNode In doc.ChildNodes(1).ChildNodes
                Dim x As New ChampionData
                x.Name = a.Attributes("name").Value
                x.Banner = Image.FromFile(".\data\images\champions\banner\" & a.Attributes("banner").Value)
                x.Square = Image.FromFile(".\data\images\champions\squares\" & a.Attributes("square").Value)
                db.Add(x)
                RaiseEvent championAdded("Champion " & x.Name & " hinzugefügt")
            Next
        End Sub

        Public Function getByName(name As String) As ChampionData
            For Each x As ChampionData In db
                If x.Name = name Then
                    Return x
                End If
            Next
            Return New ChampionData
        End Function

    End Class


    Public Class OutputSettingDB
        Public settings As New Dictionary(Of String, String)
        Public team_blue As New List(Of Player)
        Public team_red As New List(Of Player)
        Public bans_blue As New List(Of Ban)
        Public bans_red As New List(Of Ban)


        Public Sub load(xmlFile As String)
            Dim doc As New XmlDocument
            doc.Load(xmlFile)
            For Each x As XmlNode In doc.ChildNodes(1).ChildNodes
                If x.Name = "settings" Then
                    For Each a As XmlNode In x.ChildNodes
                        settings.Add(a.Attributes("name").Value, a.Attributes("value").Value)
                    Next
                Else
                    For Each team As XmlNode In x.ChildNodes
                        For Each banned As XmlNode In team.FirstChild
                            Dim b As New Ban
                            b.INDEX = Integer.Parse(banned.Attributes("row").Value)
                            b.LOCATION = New Point(Integer.Parse(banned.Attributes("x").Value), Integer.Parse(banned.Attributes("y").Value))
                            If team.Attributes("name").Value = "blue" Then
                                bans_blue.Add(b)
                            Else
                                bans_red.Add(b)
                            End If
                        Next
                        For Each spieler As XmlNode In team.ChildNodes
                            If spieler.Name = "player" Then
                                Dim spielerObj As New Player
                                spielerObj.ROLLE = spieler.Attributes("role").Value
                                spielerObj.BANNER = New Point(Integer.Parse(spieler.FirstChild.FirstChild.Attributes("x").Value), Integer.Parse(spieler.FirstChild.FirstChild.Attributes("y").Value))
                                spielerObj.BANNER = New Point(Integer.Parse(spieler.LastChild.FirstChild.Attributes("x").Value), Integer.Parse(spieler.LastChild.FirstChild.Attributes("y").Value))
                                If team.Attributes("name").Value = "blue" Then
                                    team_blue.Add(spielerObj)
                                Else
                                    team_red.Add(spielerObj)
                                End If
                            End If
                        Next
                    Next
                End If
            Next

        End Sub




    End Class
End Class
