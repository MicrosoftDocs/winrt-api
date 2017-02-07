' The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

''' <summary>
''' Provides application-specific behavior to supplement the default Application class.
''' </summary>
NotInheritable Class App
    Inherits Application

    ''' <summary>
    ''' Invoked when the application is launched normally by the end user.  Other entry points
    ''' will be used when the application is launched to open a specific file, to display
    ''' search results, and so forth.
    ''' </summary>
    ''' <param name="args">Details about the launch request and process.</param>
    Protected Overrides Sub OnLaunched(args As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)

        ' Create a Frame to act navigation context and navigate to the first page
        Dim rootFrame As New Frame()
        rootFrame.Navigate(GetType(BlankPage))

        ' Place the frame in the current Window and ensure that it is active
        Window.Current.Content = rootFrame
        Window.Current.Activate()
    End Sub

End Class
