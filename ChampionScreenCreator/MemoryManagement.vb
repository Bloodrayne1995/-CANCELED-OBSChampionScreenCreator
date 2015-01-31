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
        outputSettings.load(My.Settings.outputSettingFile)

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


        Public Function getFonts() As Dictionary(Of String, Font)
            Return fontdb
        End Function

        Public Sub addNewFont(name As String)
            fontdb.Add(name, New Font("Arial", 8))
            font2align.Add(name, ContentAlignment.MiddleLeft)
            font2color.Add(name, Color.Black)
        End Sub

        Public Sub removeByKey(key As String)
            fontdb.Remove(key)
            font2align.Remove(key)
            font2color.Remove(key)
        End Sub
    End Class

    Public Class OutputSettingDB
        Public settings As New Dictionary(Of String, Setting)
        Public team_blue As New List(Of Player)
        Public team_red As New List(Of Player)
        Public bans_blue As New List(Of Ban)
        Public bans_red As New List(Of Ban)

        Public Sub load(xmlFile As String)
            'Vorher alles leeren
            settings.Clear()
            team_blue.Clear()
            team_red.Clear()
            bans_blue.Clear()
            bans_red.Clear()

            'Laden
            Dim doc As New XmlDocument
            doc.Load(xmlFile)
            For Each x As XmlNode In doc.ChildNodes(1).ChildNodes
                If x.Name = "settings" Then
                    For Each a As XmlNode In x.ChildNodes
                        Dim s As New Setting
                        s.desc = a.Attributes("desc").Value
                        s.value = a.Attributes("value").Value
                        settings.Add(a.Attributes("name").Value, s)
                    Next
                Else
                    For Each team As XmlNode In x.ChildNodes
                        For Each banned As XmlNode In team.FirstChild
                            Dim b As New Ban
                            b.INDEX = Integer.Parse(banned.Attributes("row").Value)
                            b.LOCATION = New Point(Integer.Parse(banned.Attributes("x").Value), Integer.Parse(banned.Attributes("y").Value))
                            If team.Attributes("name").Value = "blau" Then
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


        Public Sub setPlayer(farbe As String, rolle As String, was As String, wasDavon As String, neuerWert As Object)
            Dim pos As Integer = -1
            If farbe = "blau" Then
                For i As Integer = 0 To team_blue.Count - 1
                    If team_blue(i).ROLLE.ToLower = rolle.ToLower Then
                        pos = i
                        Exit For
                    End If
                Next
                If was = "banner" Then
                    If wasDavon = "pos" Then
                        team_blue(pos).BANNER = DirectCast(neuerWert, Point)
                        Exit Sub
                    End If
                    If wasDavon = "size" Then
                        team_blue(pos).BANNER_Size = DirectCast(neuerWert, Size)
                        Exit Sub
                    End If
                End If
            Else
                For i As Integer = 0 To team_red.Count - 1
                    If team_red(i).ROLLE.ToLower = rolle.ToLower Then
                        pos = i
                        Exit For
                    End If
                Next
                If was = "banner" Then
                    If wasDavon = "pos" Then
                        team_red(pos).BANNER = DirectCast(neuerWert, Point)
                        Exit Sub
                    End If
                    If wasDavon = "size" Then
                        team_red(pos).BANNER_Size = DirectCast(neuerWert, Size)
                        Exit Sub
                    End If
                End If
            End If

           
        End Sub

        Public Function getBanIndex(farbe As String, row As Integer) As Integer
            Dim pos As Integer = -1

            If farbe = "blau" Then
                For i As Integer = 0 To bans_blue.Count - 1
                    If bans_blue(i).INDEX = row Then
                        pos = i
                        Exit For
                    End If
                Next
            Else
                For i As Integer = 0 To bans_red.Count - 1
                    If bans_red(i).INDEX = row Then
                        pos = i
                        Exit For
                    End If
                Next
            End If
            Return pos
        End Function

        Public Sub save(Optional loadAfterSave As Boolean = True, Optional saveAS As String = "-1")
            Dim writer As XmlTextWriter
            If saveAS = "-1" Then
                writer = New XmlTextWriter(".\data\output.xml", System.Text.Encoding.UTF8)
            Else
                writer = New XmlTextWriter(".\data\customOutputSettings\" & saveAS & ".xml", System.Text.Encoding.UTF8)
            End If

            With writer
                .Formatting = Formatting.Indented
                .Indentation = 4
                .WriteStartDocument()

                'Root
                .WriteStartElement("output")

                'Settings
                .WriteStartElement("settings")
                For Each x As String In settings.Keys
                    .WriteStartElement("setting")
                    .WriteAttributeString("name", x)
                    .WriteAttributeString("value", settings(x).value)
                    .WriteAttributeString("desc", settings(x).desc)
                    .WriteEndElement()
                Next
                .WriteEndElement()

                'MainPanel
                .WriteStartElement("mainPanel")

                'Team
                .WriteStartElement("team")
                .WriteAttributeString("name", "blau")

                'Bans
                .WriteStartElement("bans")
                For Each a As Ban In bans_blue
                    .WriteStartElement("ban")
                    .WriteAttributeString("row", a.INDEX)
                    .WriteAttributeString("x", a.LOCATION.X)
                    .WriteAttributeString("y", a.LOCATION.Y)
                    .WriteEndElement()
                Next
                .WriteEndElement()

                'Team-Panels:
                For Each p As Player In team_blue
                    .WriteStartElement("player")
                    .WriteAttributeString("role", p.ROLLE)

                    'Banner
                    .WriteStartElement("banner")

                    'Banner-Position
                    .WriteStartElement("location")
                    .WriteAttributeString("x", p.BANNER.X)
                    .WriteAttributeString("y", p.BANNER.Y)
                    .WriteEndElement()

                    'Banner-Size
                    .WriteStartElement("size")
                    .WriteAttributeString("width", p.BANNER_Size.Width)
                    .WriteAttributeString("height", p.BANNER_Size.Height)
                    .WriteEndElement()

                    .WriteEndElement()

                    'Square
                    .WriteStartElement("square")

                    'Square-Position
                    .WriteStartElement("location")
                    .WriteAttributeString("x", p.SQUARE.X)
                    .WriteAttributeString("y", p.SQUARE.Y)
                    .WriteEndElement() 'Location

                    'Square-Size
                    .WriteStartElement("size")
                    .WriteAttributeString("width", p.SQUARE_Size.Width)
                    .WriteAttributeString("height", p.SQUARE_Size.Height)
                    .WriteEndElement() 'Size

                    .WriteEndElement() 'Square

                    .WriteEndElement() 'Player
                Next

                .WriteEndElement() 'team


                .WriteStartElement("team")
                .WriteAttributeString("name", "rot")

                'Bans
                .WriteStartElement("bans")
                For Each a As Ban In bans_red
                    .WriteStartElement("ban")
                    .WriteAttributeString("row", a.INDEX)
                    .WriteAttributeString("x", a.LOCATION.X)
                    .WriteAttributeString("y", a.LOCATION.Y)
                    .WriteEndElement()
                Next
                .WriteEndElement()

                'Team-Panels:
                For Each p As Player In team_red
                    .WriteStartElement("player")
                    .WriteAttributeString("role", p.ROLLE)

                    'Banner
                    .WriteStartElement("banner")

                    'Banner-Position
                    .WriteStartElement("location")
                    .WriteAttributeString("x", p.BANNER.X)
                    .WriteAttributeString("y", p.BANNER.Y)
                    .WriteEndElement()

                    'Banner-Size
                    .WriteStartElement("size")
                    .WriteAttributeString("width", p.BANNER_Size.Width)
                    .WriteAttributeString("height", p.BANNER_Size.Height)
                    .WriteEndElement()

                    .WriteEndElement()

                    'Square
                    .WriteStartElement("square")

                    'Square-Position
                    .WriteStartElement("location")
                    .WriteAttributeString("x", p.SQUARE.X)
                    .WriteAttributeString("y", p.SQUARE.Y)
                    .WriteEndElement() 'Location

                    'Square-Size
                    .WriteStartElement("size")
                    .WriteAttributeString("width", p.SQUARE_Size.Width)
                    .WriteAttributeString("height", p.SQUARE_Size.Height)
                    .WriteEndElement() 'Size

                    .WriteEndElement() 'Square

                    .WriteEndElement() 'Player
                Next

                .WriteEndElement() 'team

                .WriteEndElement() 'mainPanel

                .WriteEndElement() 'output

                .Flush()
                .Close()
            End With

            If loadAfterSave Then
                Me.load(".\data\output.xml")
            End If
        End Sub


        Public Class Setting
            Public desc As String = ""
            Public value As String = ""
        End Class

    End Class
End Class
