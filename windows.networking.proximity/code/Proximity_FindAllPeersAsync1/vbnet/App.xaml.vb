' The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

''' <summary>
''' Provides application-specific behavior to supplement the default Application class.
''' </summary>
NotInheritable Class App
    Inherits Application

    ' <SnippetLaunch_CS>
    Protected Overrides Sub OnLaunched(args As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        If Window.Current.Content Is Nothing Then
            Dim rootFrame = New Frame()
            rootFrame.Navigate(GetType(MainPage), args)
            Window.Current.Content = rootFrame
        Else
            Dim rootFrame = TryCast(Window.Current.Content, Frame)
            rootFrame.Navigate(GetType(MainPage), args)
        End If

        ' Ensure the current window is active
        Window.Current.Activate()
    End Sub
    ' <SnippetLaunch_CS>

    ''' <summary>
    ''' Invoked when application execution is being suspended.  Application state is saved
    ''' without knowing whether the application will be terminated or resumed with the contents
    ''' of memory still intact.
    ''' </summary>
    ''' <param name="sender">The source of the suspend request.</param>
    ''' <param name="e">Details about the suspend request.</param>
    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        ' TODO: Save application state and stop any background activity
        deferral.Complete()
    End Sub

End Class
