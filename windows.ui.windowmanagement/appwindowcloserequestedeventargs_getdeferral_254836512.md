---
-api-id: M:Windows.UI.WindowManagement.AppWindowCloseRequestedEventArgs.GetDeferral
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public Deferral AppWindowCloseRequestedEventArgs.GetDeferral()
-->

# Windows.UI.WindowManagement.AppWindowCloseRequestedEventArgs.GetDeferral

## -description

Gets a deferral object for managing asynchronous work done in the CloseRequested event handler.

## -returns

A deferral object.

## -remarks

A deferral should be used if any asynchronous work is being done in the CloseRequested event handler, so that the next event in the sequence isn't raised until this work is completed.

## -see-also

[AppWindow.Closed](appwindow_closed.md)

## -examples

