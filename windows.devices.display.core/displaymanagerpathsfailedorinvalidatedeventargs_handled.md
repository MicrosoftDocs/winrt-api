---
-api-id: P:Windows.Devices.Display.Core.DisplayManagerPathsFailedOrInvalidatedEventArgs.Handled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayManagerPathsFailedOrInvalidatedEventArgs.Handled

## -description
Gets and sets a value indicating whether the [PathsFailedOrInvalidated](displaymanager_pathsfailedorinvalidated.md) event has been handled.

## -property-value
`true` if the [PathsFailedOrInvalidated](displaymanager_pathsfailedorinvalidated.md) event has been handled, otherwise `false`.

## -remarks
This property's value must be set to `true` in order to indicate that the [PathsFailedOrInvalidated](displaymanager_pathsfailedorinvalidated.md) event has been handled. If you fail to handle the **PathsFailedOrInvalidated** event, then the process is forced to exit.

## -see-also

## -examples
