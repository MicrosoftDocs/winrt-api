---
-api-id: T:Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum XYFocusKeyboardNavigationMode : int {
	Auto = 0
	Disabled = 2
	Enabled = 1
}
-->

# Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode

## -description
Defines constants that specify whether a user can perform XY navigation using the keyboard directional arrows.

## -enum-fields

### -field Auto:0
Behavior is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback behavior is **Disabled**.

### -field Enabled:1
Keyboard directional arrows can be used for XY navigation.

### -field Disabled:2
Keyboard directional arrows cannot be used for XY navigation.

## -remarks
This enumeration is used by the [UIElement.XYFocusKeyboardNavigation](../windows.ui.xaml/uielement_xyfocuskeyboardnavigation.md) property.

XY navigation is used to navigate a user interface (UI) with a gamepad, remote control, or keyboard directional arrows. For more info, see [Gamepad and remote control interactions](https://msdn.microsoft.com/windows/uwp/input-and-devices/gamepad-and-remote-interactions) and [UIElement.XYFocusKeyboardNavigation](../windows.ui.xaml/uielement_xyfocuskeyboardnavigation.md).

## -see-also
[Desiging for Xbox - XY focus navigation and interaction](https://msdn.microsoft.com/windows/uwp/input-and-devices/designing-for-tv#xy-focus-navigation-and-interaction)

## -examples

