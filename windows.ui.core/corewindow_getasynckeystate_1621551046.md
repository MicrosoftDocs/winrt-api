---
-api-id: M:Windows.UI.Core.CoreWindow.GetAsyncKeyState(Windows.System.VirtualKey)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreVirtualKeyStates GetAsyncKeyState(Windows.System.VirtualKey virtualKey)
-->

# Windows.UI.Core.CoreWindow.GetAsyncKeyState

## -description
Asynchronously retrieves the state of a virtual key.

## -parameters
### -param virtualKey
The virtual key for which state is returned.

## -returns
The flags indicating the current state of the supplied virtual key when the input event fired.

> [!NOTE]
> All keys support the **Locked** state (not just the standard Caps Lock and Num Lock keys).

## -remarks

## -examples

## -see-also
[CoreVirtualKeyStates](corevirtualkeystates.md), [GetKeyState](corewindow_getkeystate.md)