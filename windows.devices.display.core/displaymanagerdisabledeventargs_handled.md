---
-api-id: P:Windows.Devices.Display.Core.DisplayManagerDisabledEventArgs.Handled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayManagerDisabledEventArgs.Handled

## -description
Gets and sets a value indicating whether the [Disabled](displaymanager_disabled.md) event has been handled.

## -property-value
`true` if the [Disabled](displaymanager_disabled.md) event has been handled, otherwise `false`.

## -remarks
This property's value must be set to `true` in order to indicate that the [Disabled](displaymanager_disabled.md) event has been handled. If you fail to handle the **Disabled** event, then the process is forced to exit.

## -see-also

## -examples
