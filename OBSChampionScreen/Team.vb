Imports System.Xml

Public Class Team

    Public TOP As String = ""
    Public JNG As String = ""
    Public MID As String = ""
    Public ADC As String = ""
    Public SUP As String = ""
    Public NAME As String = ""
    Public REGION As String = ""
    Public LOGO As Image = Nothing
    Public LOGOPFAD As String = ""
    Public LOGOEXISTS As Boolean = False

    Public Sub fromXML(xml As XmlNode)
        NAME = xml.Attributes("name").Value
        For Each x As XmlNode In xml.ChildNodes
            Select Case x.Name
                Case "top"
                    TOP = x.Attributes("name").Value
                    Exit Select
                Case "jng"
                    JNG = x.Attributes("name").Value
                    Exit Select
                Case "mid"
                    MID = x.Attributes("name").Value
                    Exit Select
                Case "adc"
                    ADC = x.Attributes("name").Value
                    Exit Select
                Case "sup"
                    SUP = x.Attributes("name").Value
                    Exit Select
                Case "logo"
                    Try
                        LOGO = Image.FromFile(x.Attributes("src").Value)
                        LOGOEXISTS = True
                        LOGOPFAD = x.Attributes("src").Value
                    Catch ex As Exception
                        LOGOEXISTS = False
                        LOGOPFAD = ""
                    End Try
                    Exit Select
            End Select
        Next
    End Sub

    Public Function toXML() As String
        Dim erg As String = vbTab & vbTab & vbTab & "<team name='" & NAME & "'>" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<logo src='" & LOGOPFAD & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<top name='" & TOP & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<jng name='" & JNG & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<mid name='" & MID & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<adc name='" & ADC & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & vbTab & "<sup name='" & SUP & "' />" & vbCrLf
        erg &= vbTab & vbTab & vbTab & "</team>" & vbCrLf
        Return erg
    End Function

    Public Function getData(x As Integer) As String
        Select Case x
            Case 0
                Return TOP
            Case 1
                Return JNG
            Case 2
                Return MID
            Case 3
                Return ADC
            Case 4
                Return SUP
            Case Else
                Return NAME
        End Select
    End Function

    Public Sub New(Optional region As String = "")
        Me.REGION = region
    End Sub


End Class
