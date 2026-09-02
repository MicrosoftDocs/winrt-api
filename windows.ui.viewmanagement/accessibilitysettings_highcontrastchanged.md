---
-api-id: E:Windows.UI.ViewManagement.AccessibilitySettings.HighContrastChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HighContrastChanged<Windows.UI.ViewManagement.AccessibilitySettings,  object>
-->

# Windows.UI.ViewManagement.AccessibilitySettings.HighContrastChanged

## -description
Occurs when the system high contrast feature turns on or off.

## -remarks

> [!WARNING]
> This event relies on **CoreWindow**, which isn't available in WinUI 3 desktop apps. To detect High Contrast changes in a WinUI 3 app, use the [ThemeSettings.Changed](/windows/windows-app-sdk/api/winrt/microsoft.ui.system.themesettings.changed) event. Create a **ThemeSettings** object for your app window by calling [ThemeSettings.CreateForWindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.system.themesettings.createforwindowid), and retain a reference to the object for as long as you want to receive change notifications.

## -examples

## -see-also

- [Mapping UWP APIs to the Windows App SDK](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/api-mapping-table)
