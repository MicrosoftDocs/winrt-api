---
-api-id: T:Windows.System.Display.DisplayRequest
-api-type: winrt class
---

<!-- Class syntax.
public class DisplayRequest : Windows.System.Display.IDisplayRequest
-->

# Windows.System.Display.DisplayRequest

## -description
Represents a display request.

## -remarks
To conserve power and extend battery life, the system reduces power to the computer if it does not detect any user activity for a certain amount of time. Depending on system power settings, the display may first be dimmed, a screen saver may be displayed, and eventually the display may be turned off as the system enters a low-power sleep state.

Apps that show video or run for extended periods without user input can request that the display remain on by calling [DisplayRequest.RequestActive](displayrequest_requestactive_1312599685.md). When a display request is activated, the device's display remains on while the app is visible. When the user moves the app out of the foreground, the system deactivates the app's display requests and reactivates them when the app returns to the foreground.

Display requests are cumulative - each display request must be released with a separate call to [DisplayRequest.RequestRelease](displayrequest_requestrelease_966711579.md). An app should keep track of the number of active display requests and make sure all are released (each with a corresponding call to [DisplayRequest.RequestRelease](displayrequest_requestrelease_966711579.md)) when the app no longer requires the display to remain on. For more information see:
+ [How to keep the display on during audio/video playback ](/previous-versions/windows/apps/jj152728(v=win.10))
+ [MediaElement](/windows/uwp/design/controls-and-patterns/media-playback)
+ [Display power state sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Display%20power%20state%20sample)


Using display requests to keep the display on consumes a lot of power. Use these guidelines for best app behavior when using display requests.
+ Use display requests only when required, that is, times when no user input is expected but the display should remain on. For example, during full screen presentations or when the user is reading an e-book.
+ Release each display request as soon as it is no longer required.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

### Windows Phone 8

This API is supported in native apps only.

## -examples
The following code (taken from the [display power state sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Display%20power%20state%20sample)) shows how to activate, track, and release display requests.

```csharp
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void Activate_Click(object sender, RoutedEventArgs e)
        {
            Error.Text = string.Empty;
            Button b = sender as Button;
            if (b != null)
            {
                try
                {
                    if (g_DisplayRequest == null)
                    {
                        // This call creates an instance of the displayRequest object 
                        g_DisplayRequest = new DisplayRequest();
                    }
                }
                catch (Exception ex)
                {
                    rootPage.NotifyUser("Error Creating Display Request: " + ex.Message, NotifyType.ErrorMessage);
                }

                if (g_DisplayRequest != null)
                {
                    try
                    {
                        // This call activates a display-required request. If successful,  
                        // the screen is guaranteed not to turn off automatically due to user inactivity. 
                        g_DisplayRequest.RequestActive();
                        drCount += 1;
                        rootPage.NotifyUser("Display request activated (" + drCount + ")", NotifyType.StatusMessage);
                    }
                    catch (Exception ex)
                    {
                        rootPage.NotifyUser("Error: " + ex.Message, NotifyType.ErrorMessage);
                    }
                }
            }
        }

        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void Release_Click(object sender, RoutedEventArgs e)
        {
            Error.Text = string.Empty;
            Button b = sender as Button;
            if (b != null)
            {
                if (g_DisplayRequest != null)
                {
                    try
                    {
                        // This call de-activates the display-required request. If successful, the screen 
                        // might be turned off automatically due to a user inactivity, depending on the 
                        // power policy settings of the system. The requestRelease method throws an exception  
                        // if it is called before a successful requestActive call on this object. 
                        g_DisplayRequest.RequestRelease();
                        drCount -= 1;
                        rootPage.NotifyUser("Display request released (" + drCount + ")", NotifyType.StatusMessage);
                    }
                    catch (Exception ex)
                    {
                        rootPage.NotifyUser("Error: " + ex.Message, NotifyType.ErrorMessage);
                    }
                }
            }
        }
```

```vb
''' <param name="sender"></param> 
''' <param name="e"></param> 
Private Sub Activate_Click(sender As Object, e As RoutedEventArgs) 
    ErrorTestBlock.Text = String.Empty 
    Dim b As Button = TryCast(sender, Button) 
    If b IsNot Nothing Then 
        Try 
            If g_DisplayRequest Is Nothing Then 
                ' This call creates an instance of the displayRequest object 
                g_DisplayRequest = New DisplayRequest() 
            End If 
        Catch ex As Exception 
            rootPage.NotifyUser("Error Creating Display Request: " & ex.Message, NotifyType.ErrorMessage) 
        End Try 
 
        If g_DisplayRequest IsNot Nothing Then 
            Try 
                ' This call activates a display-required request. If successful,  
                ' the screen is guaranteed not to turn off automatically due to user inactivity. 
                g_DisplayRequest.RequestActive() 
                drCount += 1 
                rootPage.NotifyUser("Display request activated (" & drCount & ")", NotifyType.StatusMessage) 
            Catch ex As Exception 
                rootPage.NotifyUser("Error:" & ex.Message, NotifyType.ErrorMessage) 
            End Try 
        End If 
    End If 
End Sub

''' <param name="sender"></param> 
''' <param name="e"></param> 
Private Sub Release_Click(sender As Object, e As RoutedEventArgs) 
    ErrorTestBlock.Text = String.Empty 
    Dim b As Button = TryCast(sender, Button) 
    If b IsNot Nothing Then 
        If g_DisplayRequest IsNot Nothing Then 
            Try 
                ' This call de-activates the display-required request. If successful, the screen 
                ' might be turned off automatically due to a user inactivity, depending on the 
                ' power policy settings of the system. The requestRelease method throws an exception  
                ' if it is called before a successful requestActive call on this object. 
                g_DisplayRequest.RequestRelease() 
                drCount -= 1 
                rootPage.NotifyUser("Display request released (" & drCount & ")", NotifyType.StatusMessage) 
            Catch ex As Exception 
                rootPage.NotifyUser("Error: " & ex.Message, NotifyType.ErrorMessage) 
            End Try 
        End If 
    End If 
End Sub 
```



## -see-also