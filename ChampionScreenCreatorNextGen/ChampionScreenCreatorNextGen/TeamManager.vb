Imports System.Xml
Imports System.IO

Public Class TeamManager

    Private teams As New List(Of TeamStruct)


    Public Structure TeamStruct

        Public region As String
        Public name As String
        Public top As String
        Public jng As String
        Public mid As String
        Public carry As String
        Public support As String

        Public Overrides Function ToString() As String
            Dim r As String = region
            r = r.Remove(0, 1)
            r = r.Replace(";", "|")
            r = "(" & r & ")"
            Return name & " " & r
        End Function

    End Structure

    Public Sub New()
        load()
    End Sub

    Public Sub load()
        Dim dirInfo As New DirectoryInfo(".\data\teams")
        ladeIntern("", dirInfo)
    End Sub


    Private Sub ladeIntern(region As String, d As DirectoryInfo)
        region = region & ";" & d.Name

        For Each x As DirectoryInfo In d.GetDirectories
            ladeIntern(region, x)
        Next

        For Each x As FileInfo In d.GetFiles("*.xml")
            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(x.FullName)
            Dim t As New TeamStruct
            t.region = region
            t.name = x.Name.Replace(".xml", "")
            For Each n As XmlNode In xmlDoc.LastChild.ChildNodes
                Select Case n.Name
                    Case "top"
                        t.top = n.Attributes("name").Value
                        Exit Select
                    Case "jungle"
                        t.jng = n.Attributes("name").Value
                        Exit Select
                    Case "mid"
                        t.mid = n.Attributes("name").Value
                        Exit Select
                    Case "carry"
                        t.carry = n.Attributes("name").Value
                        Exit Select
                    Case "support"
                        t.support = n.Attributes("name").Value
                        Exit Select
                End Select
            Next
            teams.Add(t)
        Next


    End Sub

    Public Function getTeam(region As String, name As String) As TeamStruct
        For Each x As TeamStruct In teams
            If x.region = region And x.name = name Then
                Return x
            End If
        Next
        Return Nothing
    End Function


    Public Function getTeams() As List(Of TeamStruct)
        Return teams
    End Function





End Class
