Imports System.Xml
Public Class OutputSettings

#Region "Strukturen"

    Public Structure Spieler
        Public square_location As Point
        Public square_size As Size
        Public banner_location As Point
        Public banner_size As Size
    End Structure

    Public Structure Team

        Public ban1 As Spieler
        Public ban2 As Spieler
        Public ban3 As Spieler

        Public top As Spieler
        Public jungle As Spieler
        Public mid As Spieler
        Public adc As Spieler
        Public support As Spieler

    End Structure

    Public Structure Setting
        Public Name As String
        Public Value As String
        Public Beschreibung As String
    End Structure


#End Region

#Region "Internal"

    Private settings As New List(Of Setting)
    Public team_blau As New Team
    Public team_rot As New Team

#End Region

#Region "Properties"

    Public ReadOnly Property Einstellungen(ByVal name As String) As Setting
        Get
            For Each x As Setting In settings
                If x.Name = name Then
                    Return x
                End If
            Next
            Return New Setting
        End Get
    End Property

#End Region


#Region "Konstruktoren"

    Public Sub New(Optional configFile As String = "default")
        Dim xmlDoc As New XmlDocument
        xmlDoc.Load("./data/settings/outputs/" + configFile + ".xml")

        loadSettings(xmlDoc.LastChild.FirstChild.ChildNodes)

        Dim x As XmlNodeList = xmlDoc.LastChild.LastChild.ChildNodes
        For Each xE As XmlNode In x
            If xE.Name = "team" Then
                If xE.Attributes("name").Value = "blau" Then
                    team_blau = ladeTeam(xE.ChildNodes)
                Else
                    team_rot = ladeTeam(xE.ChildNodes)
                End If
            End If
        Next


    End Sub

#End Region

#Region "Methoden"

    Private Sub loadSettings(xsett As XmlNodeList)
        For Each x As XmlNode In xsett
            Dim s As New Setting
            s.Name = x.Attributes("name").Value
            s.Value = x.Attributes("value").Value
            s.Beschreibung = x.Attributes("desc").Value
            settings.Add(s)
        Next
    End Sub

    Private Function ladeTeam(teamNode As XmlNodeList) As Team
        Dim t As New Team
        For Each x As XmlNode In teamNode
            'Banns
            If x.Name = "bans" Then
                For Each x2 As XmlNode In x.ChildNodes
                    Dim banObj As New Spieler
                    banObj.square_location = New Point(Integer.Parse(x2.Attributes("x").Value), Integer.Parse(x2.Attributes("y").Value))
                    If x2.Attributes("row").Value = "0" Then
                        t.ban1 = banObj
                    ElseIf x2.Attributes("row").Value = "1" Then
                        t.ban2 = banObj
                    Else
                        t.ban3 = banObj
                    End If
                Next
            Else
                'Spieler
                Dim sp As New Spieler
                'banner 
                Dim p As New Point(Integer.Parse(x.FirstChild.ChildNodes(0).Attributes("x").Value), Integer.Parse(x.FirstChild.ChildNodes(0).Attributes("y").Value))
                Dim s As New Size(Integer.Parse(x.FirstChild.ChildNodes(1).Attributes("width").Value), Integer.Parse(x.FirstChild.ChildNodes(1).Attributes("height").Value))

                sp.banner_location = p
                sp.banner_size = s
                'square
                p = New Point(Integer.Parse(x.LastChild.ChildNodes(0).Attributes("x").Value), Integer.Parse(x.LastChild.ChildNodes(0).Attributes("y").Value))
                s = New Size(Integer.Parse(x.LastChild.ChildNodes(1).Attributes("width").Value), Integer.Parse(x.LastChild.ChildNodes(1).Attributes("height").Value))
                sp.square_location = p
                sp.square_size = s

                If x.Attributes("role").Value = "top" Then
                    t.top = sp
                ElseIf x.Attributes("role").Value = "jungle" Then
                    t.jungle = sp
                ElseIf x.Attributes("role").Value = "mid" Then
                    t.mid = sp
                ElseIf x.Attributes("role").Value = "adc" Then
                    t.adc = sp
                ElseIf x.Attributes("role").Value = "support" Then
                    t.support = sp
                End If

            End If
        Next
        Return t
    End Function


    Public Function getSpielerSetting(rolle As String, farbe As String) As Spieler
        If farbe = "blau" Then
            If rolle = "top" Then
                Return team_blau.top
            ElseIf rolle = "jungle" Then
                Return team_blau.jungle
            ElseIf rolle = "mid" Then
                Return team_blau.mid
            ElseIf rolle = "adc" Then
                Return team_blau.adc
            Else
                Return team_blau.support
            End If
        Else
            If rolle = "top" Then
                Return team_rot.top
            ElseIf rolle = "jungle" Then
                Return team_rot.jungle
            ElseIf rolle = "mid" Then
                Return team_rot.mid
            ElseIf rolle = "adc" Then
                Return team_rot.adc
            Else
                Return team_rot.support
            End If
        End If
    End Function


    Public Function getBanSetting(index As Integer, farbe As String) As Spieler
        If farbe = "blau" Then
            If index = 0 Then
                Return team_blau.ban1
            ElseIf index = 1 Then
                Return team_blau.ban2
            Else
                Return team_blau.ban3
            End If
        Else
            If index = 0 Then
                Return team_rot.ban1
            ElseIf index = 1 Then
                Return team_rot.ban2
            Else
                Return team_rot.ban3
            End If
        End If
    End Function

#End Region

End Class
