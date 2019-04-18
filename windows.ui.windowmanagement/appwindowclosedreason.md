---
-api-id: T:Windows.UI.WindowManagement.AppWindowClosedReason
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum AppWindowClosedReason : int 
-->

# Windows.UI.WindowManagement.AppWindowClosedReason

## -description

Defines constants that specify how a window close operation was initiated.

## -enum-fields
### -field UserInitiated:2

The operation was initiated by the user.

### -field Other:0

The operation was initiated by something other than the user or app code.

### -field AppInitiated:1

The operation was initiated programmatically by code in the app.

## -remarks

This enumeration provides values for the [AppWindowClosedEventArgs.Reason](appwindowclosedeventargs_reason.md) property.

## -see-also

[AppWindow.Closed](appwindow_closed.md), [AppWindowClosedEventArgs.Reason](appwindowclosedeventargs_reason.md)

## -examples

