---
-api-id: P:Windows.Devices.Display.Core.DisplayManagerChangedEventArgs.Handled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayManagerChangedEventArgs.Handled

## -description
Gets and sets a value indicating whether the [Changed](displaymanager_changed.md) event has been handled.

## -property-value
`true` if the [Changed](displaymanager_changed.md) event has been handled, otherwise `false`.

## -remarks
This property's value must be set to `true` in order to indicate that the [Changed](displaymanager_changed.md) event has been handled. If you fail to handle the **Changed** event, then the process is forced to exit.

## -see-also

## -examples
