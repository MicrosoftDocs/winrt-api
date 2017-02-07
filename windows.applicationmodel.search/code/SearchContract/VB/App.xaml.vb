' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
' 
' Copyright (c) Microsoft Corporation. All rights reserved

Imports Windows.ApplicationModel
Imports Windows.UI.Xaml.Navigation
Imports SDKTemplate

Namespace Global.SDKTemplate
    ''' <summary>
    ''' Provides application-specific behavior to supplement the default Application class.
    ''' </summary>
    Partial NotInheritable Class App
        Inherits Application

        ''' <summary>
        ''' Invoked when the application is launched normally by the end user.  Other entry
        ''' points will be used when the application is launched to open a specific file,
        ''' to display search results, and so forth.
        ''' </summary>
        ''' <param name="args">Details about the launch request and process.</param>
        Protected Overrides Async Sub OnLaunched(args As LaunchActivatedEventArgs)
            Dim rootFrame As Frame = DirectCast(Window.Current.Content, Frame)

            ' Do not repeat app initialization when the Window already has content,
            ' just ensure that the window is active
            If rootFrame Is Nothing Then
                ' Create a Frame to act as the navigation context and associate it with
                ' a SuspensionManager key
                rootFrame = New Frame()
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame")
                If args.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                    ' Restore the saved session state only when appropriate
                    Try
                        Await SuspensionManager.RestoreAsync()
                    Catch ex As SuspensionManagerException
                        ' Something went wrong restoring state.
                        ' Assume there is no state and continue
                    End Try
                End If
                ' Place the frame in the current Window
                Window.Current.Content = rootFrame
            End If
            If rootFrame.Content Is Nothing Or Not String.IsNullOrEmpty(args.Arguments) Then
                ' When the navigation stack isn't restored or there are launch arguments
                ' indicating an alternate launch (e.g.: via toast or secondary tile), 
                ' navigate to the appropriate page, configuring the new page by passing required 
                ' information as a navigation parameter
                If Not rootFrame.Navigate(GetType(MainPage), args.Arguments) Then
                    Throw New Exception("Failed to create initial page")
                End If
            End If
            ' Ensure the current window is active
            Window.Current.Activate()
        End Sub

        ''' <summary>
        ''' Invoked when application execution is being suspended.  Application state is saved
        ''' without knowing whether the application will be terminated or resumed with the contents
        ''' of memory still intact.
        ''' </summary>
        ''' <param name="sender">The source of the suspend request.</param>
        ''' <param name="e">Details about the suspend request.</param>
        Private Async Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
            Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
            Await SuspensionManager.SaveAsync()
            deferral.Complete()
        End Sub
    End Class
End Namespace

