---
-api-id: T:Windows.UI.Xaml.Navigation.NavigationFailedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void NavigationFailedEventHandler(System.Object sender, Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
-->
# Windows.UI.Xaml.Navigation.NavigationFailedEventHandler

## -description
Represents a method that will handle the [WebView.NavigationFailed](../windows.ui.xaml.controls/webview_navigationfailed.md) and [Frame.NavigationFailed](../windows.ui.xaml.controls/frame_navigationfailed.md) events.



## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks

## -examples
The following code example demonstrates the use of the [NavigationFailed](../windows.ui.xaml.controls/webview_navigationfailed.md) event.

```csharp
void webViewA_NavigationFailed(object sender, NavigationFailedEventArgs e)
{
    var dialog = new Windows.UI.Popups.MessageDialog();
    dialog.Title = "Navigation Failed";
    dialog.Content = String.Format("Could not navigate to {0}, Reason: {1}", 
        e.SourcePageType.ToString(), e.Exception.Message);
    dialog.ShowAsync();
}

```



## -see-also
