---
-api-id: T:Windows.UI.Xaml.Input.KeyRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class KeyRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IKeyRoutedEventArgs, Windows.UI.Xaml.Input.IKeyRoutedEventArgs2, Windows.UI.Xaml.Input.IKeyRoutedEventArgs3
-->

# Windows.UI.Xaml.Input.KeyRoutedEventArgs

## -description
Provides data for the [KeyUp](../windows.ui.xaml/uielement_keyup.md) and [KeyDown](../windows.ui.xaml/uielement_keydown.md)  routed events.

## -remarks
Button input is mapped to differerent key values for various devices, including gamepad and the Xbox One infrared remote.

This table provides the mapping detail for these devices.

<table>
   <tr><th>Button</th><th>[Key](keyroutedeventargs_key.md) value</th><th>[OriginalKey](keyroutedeventargs_originalkey.md) value</th></tr>
   <tr><td><img src="images/GamePadA.png" alt="GamepadA button" height="25" width="25" /></td><td>Space</td><td>GamepadA or NavigationAccept</td></tr>
   <tr><td><img src="images/GamePadB.png" alt="GamepadB button" height="25" width="25" /></td><td>Escape</td><td>GamepadB or NavigationCancel</td></tr>
   <tr><td><img src="images/GamePadX.png" alt="GamepadX button" height="25" width="25" /></td><td>GamepadX</td><td>GamepadX</td></tr>
   <tr><td><img src="images/GamePadY.png" alt="GamepadY button" height="25" width="25" /></td><td>GamepadY</td><td>GamepadY</td></tr>
   <tr><td><img src="images/GamePadDPad.png" alt="GamepadDPad button" height="50" width="50" />

 50</td><td>GamepadDPadUp/Down/Left/Right</td><td>GamepadDPadUp/Down/Left/Right or NavigationUp/Down/Left/Right</td></tr>
   <tr><td><img src="images/GamePadRightLeftStick.png" alt="GamePad Joystick/Thumbstick" height="50" width="50" /></td><td>GamepadLeftThumbstickButton/Up/Down/Left/Right or GamepadRightThumbstickButton/Up/Down/Left/Right</td><td>GamepadLeftThumbstickButton/Up/Down/Left/Right or GamepadRightThumbstickButton/Up/Down/Left/Right or NavigationUp/Down/Left/Right</td></tr>
   <tr><td><img src="images/GamePadBumperTrigger.png" alt="Gamepad Trigger" height="100" width="100" /></td><td>GamePadRightTrigger/LeftTrigger</td><td>GamePadRightTrigger/LeftTrigger</td></tr>
   <tr><td><img src="images/GamePadBumperTrigger.png" alt="Gamepad Bumper/Shoulder" height="100" width="100" /></td><td>GamePadRightShoulder/LeftShoulder</td><td>GamePadRightShoulder/LeftShoulder</td></tr>
   <tr><td><img src="images/GamePadMenu.png" alt="Gamepad Menu button" height="100" width="100" /></td><td>GamepadMenu</td><td>GamepadMenu or NavigationMenu</td></tr>
   <tr><td><img src="images/GamePadView.png" alt="Gamepad View button" height="100" width="100" /></td><td>GamepadView</td><td>GamepadView or NavigationView</td></tr>
</table>

## -examples
The following example code demonstrates the use of this type. For the complete code listing, see the [XAML WebView control sample](http://go.microsoft.com/fwlink/p/?linkid=238582).



[!code-cpp[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/cpp/Scenario1.xaml.cpp#SnippetWebViewNavigation)]

[!code-csharp[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/csharp/Scenario1.xaml.cs#SnippetWebViewNavigation)]

[!code-vb[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/vbnet/Scenario1.xaml.vb#SnippetWebViewNavigation)]

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [WebView](../windows.ui.xaml.controls/webview.md), [XAML WebView control sample](http://go.microsoft.com/fwlink/p/?linkid=238582)
soft.com/fwlink/p/?linkid=238582)
