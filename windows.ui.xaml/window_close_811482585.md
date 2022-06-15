---
-api-id: M:Windows.UI.Xaml.Window.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.UI.Xaml.Window.Close

## -description
Closes the application window.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Window.Close](/windows/winui/api/microsoft.ui.xaml.window.close) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
UWP app typically use a single [Window](window.md) instance, and do not open and close additional [Window](window.md) instances. Additionally, you will not typically provide custom UI to enable users to close the app window.

The [Closed](window_closed.md) event occurs when a [Window](window.md) closes.

## -examples

## -see-also
