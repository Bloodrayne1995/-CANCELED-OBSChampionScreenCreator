Imports System.Xml
Public Class ChampionDB

#Region "Internal"

    Private _champions As New List(Of Champion)


    Public Sub load()
        Dim doc As New XmlDocument
        doc.Load(".\data\champions\champions.xml")
        Dim x As XmlNodeList = doc.GetElementsByTagName("champion")

        Dim name As String
        Dim banner As String
        Dim square As String

        For Each i As XmlNode In x
            name = i.Attributes("name").Value
            banner = i.Attributes("banner").Value
            square = i.Attributes("square").Value
            _champions.Add(New Champion(name, banner, square))
        Next

        doc = Nothing


    End Sub


    Public Function getChampionSquare(name As String) As BitmapImage
        For Each x As Champion In _champions
            If x.NAME = name Then
                Return x.SQUARE
            End If
        Next
        Return New BitmapImage
    End Function


    Public Function getAnzahl() As Integer
        Return _champions.Count - 1
    End Function

    Public Function getChampion(index As Integer) As Champion
        Return _champions(index)
    End Function

#End Region





End Class
