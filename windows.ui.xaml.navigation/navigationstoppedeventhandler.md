---
-api-id: T:Windows.UI.Xaml.Navigation.NavigationStoppedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void NavigationStoppedEventHandler(System.Object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
-->
# Windows.UI.Xaml.Navigation.NavigationStoppedEventHandler

## -description
Provides event data for the [NavigationStopped](../windows.ui.xaml.controls/frame_navigationstopped.md) event.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Navigation.NavigationStoppedEventHandler](/windows/winui/api/microsoft.ui.xaml.navigation.navigationstoppedeventhandler) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks

## -examples
The following code example demonstrates the use of the [NavigationStopped](../windows.ui.xaml.controls/frame_navigationstopped.md) event.

```csharp
public MainPage()
{
    this.InitializeComponent();
    this.Frame.NavigationStopped += Frame_NavigationStopped;
}

void Frame_NavigationStopped(object sender, NavigationEventArgs e)
{
    Windows.UI.Popups.MessageDialog dialog = 
        new Windows.UI.Popups.MessageDialog(
        String.Format("Navigation to page: {0} was stopped", 
        e.SourcePageType.ToString()), 
        "Navigation Stopped");
    dialog.ShowAsync();
}

```



## -see-also
