---
-api-id: T:Windows.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum NavigationViewShoulderNavigationEnabled : int 
-->

# Windows.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled

## -description

Defines constants that specify when gamepad bumpers can be used to navigate the top-level navigation items in a NavigationView.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled](/windows/winui/api/microsoft.ui.xaml.controls.navigationviewshouldernavigationenabled) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field WhenSelectionFollowsFocus:0

Gamepad bumpers navigate the top-level navigation items when the [SelectionFollowsFocus](navigationview_selectionfollowsfocus.md) property is **Enabled**.

### -field Never:2

Gamepad bumpers never navigate the top-level navigation items.

### -field Always:1

Gamepad bumpers always navigate the top-level navigation items.

## -remarks

## -see-also

[Designing for Xbox and TV](/windows/uwp/design/devices/designing-for-tv), [Gamepad and remote control interactions](/windows/uwp/design/input/gamepad-and-remote-interactions#hardware-buttons)

## -examples

