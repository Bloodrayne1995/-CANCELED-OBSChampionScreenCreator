Imports System.Threading

Public Class Splash

    Private WithEvents firstMem As New MemoryManagement


    Public Sub New()
        CheckForIllegalCrossThreadCalls = False
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        AddHandler firstMem.nextStep, AddressOf aendereText
        AddHandler firstMem.finished, AddressOf rufeMainFormAuf
        Dim x As New Thread(AddressOf firstMem.load)
        x.Start()
    End Sub


    Private Sub aendereText()
        Debug.WriteLine(firstMem.stepDescription)
        lblText.Text = firstMem.stepDescription
        lblText.Update()
    End Sub


    Private Sub rufeMainFormAuf()
        Dim x As New MainForm
        x.memory = firstMem

        Thread.Sleep(1000)
        x.show(Me)
    End Sub

End Class