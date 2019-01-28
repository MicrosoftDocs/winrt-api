---
-api-id: P:Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs.Handled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs.Handled

## -description
Gets and sets a value indicating whether the [Enabled](displaymanager_enabled.md) event has been handled.

## -property-value
`true` if the [Enabled](displaymanager_enabled.md) event has been handled, otherwise `false`.

## -remarks
This property's value must be set to `true` in order to indicate that the [Enabled](displaymanager_enabled.md) event has been handled. If you fail to handle the **Enabled** event, then the process is forced to exit.

## -see-also

## -examples
