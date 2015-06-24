Imports System.Xml

Public Class FontMemory

#Region "Structures"

    Public Structure MyFont

        Public id As String
        Public schriftart As Font
        Public alignment As ContentAlignment
        Public farbe As Color

    End Structure

#End Region

#Region "Internal"

    Public Liste As New Dictionary(Of String, MyFont)

#End Region

#Region "Konstruktoren"

    Public Sub New()

    End Sub

#End Region


#Region "Methoden"

    Public Sub ladeFonts()
        Liste.Clear()

        Dim xmlDoc As New XmlDocument
        xmlDoc.Load("./data/settings/fonts.xml")

        For Each x As XmlNode In xmlDoc.LastChild.ChildNodes
            If x.Name = "font" Then
                Dim f As New MyFont
                f.id = x.Attributes("id").Value
                Dim fName As String = ""
                Dim size As Single = 0
                Dim farbe As Color = Color.Black
                Dim a As ContentAlignment = ContentAlignment.MiddleLeft

                For Each s As XmlNode In x.ChildNodes
                    If s.Attributes("name").Value = "name" Then
                        fName = s.Attributes("value").Value
                    ElseIf s.Attributes("name").Value = "color" Then
                        Dim daten() As String = s.Attributes("value").Value.Split(";")
                        farbe = Color.FromArgb(daten(0), daten(1), daten(2))
                    ElseIf s.Attributes("name").Value = "align" Then
                        Select Case s.Attributes("value").Value
                            Case "center"
                                a = ContentAlignment.MiddleCenter
                            Case "left"
                                a = ContentAlignment.MiddleLeft
                            Case "right"
                                a = ContentAlignment.MiddleRight
                        End Select
                    ElseIf s.Attributes("name").Value = "size" Then
                        size = Single.Parse(s.Attributes("value").Value)
                    End If
                Next

                f.schriftart = New Font(fName, size)
                f.alignment = a
                f.farbe = farbe
                Liste.Add(f.id, f)
            End If
        Next

    End Sub

#End Region


End Class
