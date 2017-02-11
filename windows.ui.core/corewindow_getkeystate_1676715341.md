---
-api-id: M:Windows.UI.Core.CoreWindow.GetKeyState(Windows.System.VirtualKey)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreVirtualKeyStates GetKeyState(Windows.System.VirtualKey virtualKey)
-->

# Windows.UI.Core.CoreWindow.GetKeyState

## -description
Retrieves the state of a virtual key.

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
[CoreVirtualKeyStates](corevirtualkeystates.md), [GetAsyncKeyState](corewindow_getasynckeystate.md)