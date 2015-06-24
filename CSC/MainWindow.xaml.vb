Imports System.Data

Class MainWindow
    Dim cdb As New ChampionDB


    Public Sub lade() Handles Me.Loaded
        cdb.load()
        
        Dim x As New ChampionSelector(cdb)
        x.HorizontalAlignment = Windows.HorizontalAlignment.Left
        x.VerticalAlignment = Windows.VerticalAlignment.Top
        x.Margin = New Thickness(0, 0, 0, 0)
        grdMain.Children.Add(x)
        Me.UpdateLayout()

    End Sub





End Class
