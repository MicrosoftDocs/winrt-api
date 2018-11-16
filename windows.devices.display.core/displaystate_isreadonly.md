---
-api-id: P:Windows.Devices.Display.Core.DisplayState.IsReadOnly
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsReadOnly { get; }
-->

# Windows.Devices.Display.Core.DisplayState.IsReadOnly

## -description
Gets a value indicating whether this [DisplayState](displaystate.md) and its child views and paths can be modified.

## -property-value
`true` if this [DisplayState](displaystate.md) and its child views and paths cannot be modified, otherwise `false`.

## -remarks
To take ownership of targets and create modifiable subset of this state object, use [DisplayManager.TryAcquireTargetsAndCreateSubstate](displaymanager_tryacquiretargetsandcreatesubstate_1986245730.md).

## -see-also

## -examples
