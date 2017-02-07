NotInheritable Class App
    Inherits Application

    Protected Overrides Sub OnLaunched(args As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Window.Current.Content = New Page()
        Window.Current.Activate()
    End Sub

End Class
