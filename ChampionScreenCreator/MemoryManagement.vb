Imports System.IO
Imports System.Xml


Public Class MemoryManagement

    Public WithEvents championDB As New ChampionDatabase()
    Public WithEvents outputSettings As New OutputSettingDB
    Public WithEvents fonts As New FontDatabase
    Public Event nextStep()
    Public Event finished()
    Public stepDescription As String = "Lade Komponente"

    Public Sub New()
        AddHandler nextStep, AddressOf debug_output
    End Sub

    Public Sub load()
        'Update


        'Champions
        schritt("Lade Champions aus champions.xml")
        AddHandler championDB.championAdded, AddressOf schritt
        championDB.load(".\data\champions.xml")

        'Teams

        'Fonts
        schritt("Lade Fonts")
        fonts.lade()
        
        'Ausgabe-Optionen
        schritt("Lade Ausgabe-Optionen")
        outputSettings.load(".\data\output.xml")

        schritt("Laden komplett. Starte Haupt-Fenster")
        RaiseEvent finished()
    End Sub

    Private Sub debug_output()
        Console.WriteLine(stepDescription)
    End Sub

    Private Sub schritt(str As String)
        stepDescription = str
        RaiseEvent nextStep()
        debug_output()
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

    Public Class FontDatabase

        Private fontdb As New Dictionary(Of String, Font)
        Private font2color As New Dictionary(Of String, Color)
        Private font2align As New Dictionary(Of String, ContentAlignment)

        Public Sub lade()
            Dim doc As New XmlDocument
            doc.Load(".\data\fonts.xml")
            For Each f As XmlNode In doc.LastChild.ChildNodes
                Dim fontName As String = "Arial"
                Dim fontSize As Integer = 18
                Dim fontAlign As ContentAlignment = ContentAlignment.MiddleCenter
                Dim fontColor As Color = Color.Black
                Dim id As String = f.Attributes("id").Value
                For Each f2 As XmlNode In f.ChildNodes
                    Dim settingName As String = f2.Attributes("name").Value
                    Dim settingValue As String = f2.Attributes("value").Value
                    Select Case settingName
                        Case "name"
                            fontName = settingValue
                            Exit Select
                        Case "size"
                            fontSize = Integer.Parse(settingValue)
                            Exit Select
                        Case "color"
                            fontColor = getColorFromString(settingValue)
                            Exit Select
                        Case "algin"
                            Select Case settingValue
                                Case "center"
                                    fontAlign = ContentAlignment.MiddleCenter
                                    Exit Select
                                Case "left"
                                    fontAlign = ContentAlignment.MiddleLeft
                                    Exit Select
                                Case "right"
                                    fontAlign = ContentAlignment.MiddleRight
                                    Exit Select
                            End Select
                    End Select
                Next
                fontdb.Add(id, New Font(fontName, fontSize))
                font2align.Add(id, fontAlign)
                font2color.Add(id, fontColor)
            Next
        End Sub

        Private Function getColorFromString(str As String) As Color
            Dim spl() As String = str.Split(";")
            Dim r As Integer = Integer.Parse(spl(0))
            Dim g As Integer = Integer.Parse(spl(1))
            Dim b As Integer = Integer.Parse(spl(2))
            'Fehlerbehandlung
            Return Color.FromArgb(r, g, b)
        End Function

        Public Function getFontByID(id As String) As Font
            If fontdb.ContainsKey(id) Then
                Return fontdb(id)
            Else
                Throw New Exception("Font wurde nicht gefunden")
            End If
        End Function

        Public Function getColor(id As String) As Color
            If font2color.ContainsKey(id) Then
                Return font2color(id)
            Else
                Throw New Exception("Farbe wurde nicht gefunden")
            End If
        End Function

        Public Function getAlign(id As String) As ContentAlignment
            If font2align.ContainsKey(id) Then
                Return font2align(id)
            Else
                Throw New Exception("Ausrichtung wurde nicht gefunden")
            End If
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
                                Try

                                    'Banner
                                    Dim banner As XmlNode = spieler.FirstChild
                                    spielerObj.BANNER = New Point(Integer.Parse(banner.FirstChild.Attributes("x").Value), Integer.Parse(banner.FirstChild.Attributes("y").Value))
                                    spielerObj.BANNER_Size = New Size(Integer.Parse(banner.LastChild.Attributes("width").Value), Integer.Parse(banner.LastChild.Attributes("height").Value))

                                    'Square
                                    Dim square As XmlNode = spieler.LastChild
                                    spielerObj.SQUARE = New Point(Integer.Parse(square.FirstChild.Attributes("x").Value), Integer.Parse(square.FirstChild.Attributes("y").Value))
                                    spielerObj.SQUARE_Size = New Size(Integer.Parse(square.LastChild.Attributes("width").Value), Integer.Parse(square.LastChild.Attributes("height").Value))

                                Catch ex As Exception
                                    Debug.WriteLine(ex.Message)
                                    Debug.WriteLine(ex.StackTrace)
                                End Try
                                'spielerObj.BANNER = New Point(Integer.Parse(spieler.FirstChild.FirstChild.Attributes("x").Value), Integer.Parse(spieler.FirstChild.FirstChild.Attributes("y").Value))
                                'spielerObj.BANNER = New Point(Integer.Parse(spieler.LastChild.FirstChild.Attributes("x").Value), Integer.Parse(spieler.LastChild.FirstChild.Attributes("y").Value))
                                If team.Attributes("name").Value = "blau" Then
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

        Public Function getPlayer(farbe As String, rolle As String) As Player
            Dim erg As Player = Nothing
            If farbe = "blau" Then
                For Each x As Player In team_blue
                    If x.ROLLE = rolle Then
                        erg = x
                        Exit For
                    End If
                Next
            Else
                For Each x As Player In team_red
                    If x.ROLLE = rolle Then
                        erg = x
                        Exit For
                    End If
                Next
            End If

            Return erg
        End Function


    End Class
End Class
