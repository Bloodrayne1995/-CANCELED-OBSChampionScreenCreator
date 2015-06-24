Public Class ChampionSelector

    Private breiteElement As Integer = 16
    Private hoeheElement As Integer = 16


    Public Sub New(ByRef cdb As ChampionDB)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.Width = (cdb.getAnzahl / 2) * breiteElement
        Me.Height = hoeheElement * 2
        load(cdb)
    End Sub


    Private Sub load(ByRef cdb As ChampionDB)
        Dim x As Integer = 0
        Dim y As Integer = 0

        For i As Integer = 0 To cdb.getAnzahl - 1
            Dim img As New Image

            img.Tag = cdb.getChampion(i).DISPLAYNAME.ToLower
            img.BeginInit()
            img.Source = cdb.getChampion(i).SQUARE
            img.EndInit()
            img.Width = breiteElement
            img.Height = hoeheElement
            img.HorizontalAlignment = Windows.HorizontalAlignment.Left
            img.VerticalAlignment = Windows.VerticalAlignment.Top
            img.Margin = New Thickness(x, y, 0, 0)
            Try
                Me.AddVisualChild(img)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            x += breiteElement
            If (x > Me.Width) Then
                x = 0
                y += hoeheElement
            End If

        Next
        Me.UpdateLayout()
    End Sub

End Class
