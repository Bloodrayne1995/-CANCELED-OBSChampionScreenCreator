Imports System.Xml

Public Class TeamList

    Public _liste As New List(Of Team)


    Public Sub init()
        load()
    End Sub


    Public Sub save()
        Dim str As String = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" & vbCrLf
        str &= "<regions>" & vbCrLf
        For Each x As Team In _liste
            If x.REGION = x.NAME Then
                str &= vbTab & "<region name='" & x.REGION & "'>" & vbCrLf
                str &= vbTab & vbTab & "<teams>" & vbCrLf

                For Each x2 As Team In SharedMem.getTeamsByRegion(x.REGION)
                    str &= x2.toXML
                Next

                str &= vbTab & vbTab & "</teams>" & vbCrLf
                str &= vbTab & "</region>" & vbCrLf
            End If
        Next
        str &= "</regions>"

        My.Computer.FileSystem.WriteAllText(My.Settings.teamData, str, False)

    End Sub


    Public Sub load()
        Dim doc As New XmlDocument
        doc.Load(My.Settings.teamData)

        For Each d As XmlNode In doc.ChildNodes(1).ChildNodes
            Dim x As New Team
            x.REGION = d.Attributes("name").Value
            x.NAME = d.Attributes("name").Value
            _liste.Add(x)
            For Each d2 As XmlNode In d.FirstChild.ChildNodes
                Dim x2 As New Team(x.REGION)
                x2.fromXML(d2)
                _liste.Add(x2)
            Next
        Next
    End Sub

End Class
