Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung ein Ausnahmefehler auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Protected Overrides Function OnUnhandledException(e As ApplicationServices.UnhandledExceptionEventArgs) As Boolean
            Dim jetzt As String = Today.Year & "-" & Today.Month & "-" & Today.Day & "__" & TimeOfDay.Hour & "-" & TimeOfDay.Minute & "-" & TimeOfDay.Second & "-" & TimeOfDay.Millisecond
            Dim pfadZuBericht As String = My.Settings.errorMessages & "error_" & jetzt & ".log"

            Dim ex As Exception = DirectCast(e.Exception, Exception)
            Dim str As String = "Fehler vom " & jetzt & vbCrLf
            str &= "Message: " & ex.Message & vbCrLf
            str &= "Source: " & ex.Source & vbCrLf
            str &= "Method: " & ex.TargetSite.Name & vbCrLf
            str &= "StackTrace: " & ex.StackTrace & vbCrLf

            My.Computer.FileSystem.WriteAllText(pfadZuBericht, str, False)
            MsgBox("Ein unerwarter Fehler ist aufgetreten. Der Bericht wurde in '" & pfadZuBericht & "' gespeichert." & vbCrLf & "Bitte senden Sie diesen an serrm@live.de Mit dem Betreff 'Fehler ChampionScreenCreator'" & vbCrLf & "Informationen: " & ex.Message)
            Return MyBase.OnUnhandledException(e)
        End Function


    End Class


End Namespace

