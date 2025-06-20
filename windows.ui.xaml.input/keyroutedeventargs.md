---
-api-id: T:Windows.UI.Xaml.Input.KeyRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class KeyRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IKeyRoutedEventArgs, Windows.UI.Xaml.Input.IKeyRoutedEventArgs2, Windows.UI.Xaml.Input.IKeyRoutedEventArgs3
-->

# Windows.UI.Xaml.Input.KeyRoutedEventArgs

## -description

Provides event data for the [KeyUp](../windows.ui.xaml/uielement_keyup.md) and [KeyDown](../windows.ui.xaml/uielement_keydown.md) routed events.

## -remarks

Button input is mapped to different key values for various devices.

This table provides the mapping detail for game pad and remote devices.

| Button | [Key](keyroutedeventargs_key.md) value | [OriginalKey](keyroutedeventargs_originalkey.md) value |
|--------|----------------------------------------|--------------------------------------------------------|
| ![GamepadA button](images/GamePadA.png) | Space | GamepadA or NavigationAccept |
| ![GamepadB button](images/GamePadB.png) | Escape | GamepadB or NavigationCancel |
| ![GamepadX button](images/GamePadX.png) | GamepadX | GamepadX |
| ![GamepadY button](images/GamePadY.png) | GamepadY | GamepadY |
| ![GamepadDPad button](images/GamePadDPad.png) | Left/Right/Up/Down | GamepadDPadUp/Down/Left/Right |
| ![GamePad Joystick/Thumbstick](images/GamePadRightLeftStick.png) | GamepadLeftThumbstickButton/Up/Down/Left/Right or GamepadRightThumbstickButton/Up/Down/Left/Right | GamepadLeftThumbstickButton/Up/Down/Left/Right or GamepadRightThumbstickButton/Up/Down/Left/Right or NavigationUp/Down/Left/Right |
| ![Gamepad Trigger](images/GamePadBumperTrigger.png) | GamePadRightTrigger/LeftTrigger | GamePadRightTrigger/LeftTrigger |
| ![Gamepad Bumper/Shoulder](images/GamePadBumperTrigger.png) | GamePadRightShoulder/LeftShoulder | GamePadRightShoulder/LeftShoulder |
| ![Gamepad Menu button](images/GamePadMenu.png) | GamepadMenu | GamepadMenu or NavigationMenu |
| ![Gamepad View button](images/GamePadView.png) | GamepadView | GamepadView or NavigationView |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DeviceId |

## -examples

## -see-also

[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
