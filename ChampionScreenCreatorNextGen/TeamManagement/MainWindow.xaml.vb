Class MainWindow 


    Public Sub test() Handles cmdRegionenTest.Click
        For i As Integer = 0 To 10
            Dim d As New RegionPanel(i, "Region#" & i, 50)
            stkRegionen.Children.Add(d)
        Next
    End Sub

End Class
