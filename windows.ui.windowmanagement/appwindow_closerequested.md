---
-api-id: E:Windows.UI.WindowManagement.AppWindow.CloseRequested
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
public event TypedEventHandler CloseRequested<AppWindow, AppWindowCloseRequestedEventArgs>
-->

# Windows.UI.WindowManagement.AppWindow.CloseRequested

## -description

Occurs after the window starts to close, but before it is closed and before the Closed event occurs.

## -remarks

> [!IMPORTANT]
> This event occurs only when the app has the App Close Confirmation restricted capability (`<rescap:Capability Name="confirmAppClose"/>`), so it is not applicable to most apps. For more info, see [App capability declarations - Restricted capabilities](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

## -see-also

[Closed](appwindow_closed.md), [App capability declarations](/windows/uwp/packaging/app-capability-declarations)

## -examples

