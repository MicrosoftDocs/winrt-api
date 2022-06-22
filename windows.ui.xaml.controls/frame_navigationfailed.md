---
-api-id: E:Windows.UI.Xaml.Controls.Frame.NavigationFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Navigation.NavigationFailedEventHandler NavigationFailed
-->

# Windows.UI.Xaml.Controls.Frame.NavigationFailed

## -description
Occurs when an error is raised while navigating to the requested content.



## -xaml-syntax
```xaml
<Frame NavigationFailed="eventhandler" />
```


## -remarks
Currently, you must handle NavigationFailed to respond when the [Navigate](frame_navigate_1426351961.md) method fails. You can handle the failure directly in the event handler, or you can set the [NavigationFailedEventArgs.Handled](../windows.ui.xaml.navigation/navigationfailedeventargs_handled.md) property to **true** and use the [Navigate](frame_navigate_1426351961.md) method return value to respond to the failure.

## -examples

## -see-also
[Navigate](frame_navigate_1426351961.md), [NavigationFailedEventArgs](../windows.ui.xaml.navigation/navigationfailedeventargs.md)
