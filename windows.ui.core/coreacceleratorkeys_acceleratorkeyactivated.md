---
-api-id: E:Windows.UI.Core.CoreAcceleratorKeys.AcceleratorKeyActivated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AcceleratorKeyActivated<Windows.UI.Core.CoreDispatcher,  Windows.UI.Core.AcceleratorKeyEventArgs>
-->

# Windows.UI.Core.CoreAcceleratorKeys.AcceleratorKeyActivated

## -description
Fired when an accelerator key is pressed or activated.

## -remarks


> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](acceleratorkeyeventargs_handled.md) to **true**.



> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[AcceleratorKeyEventArgs](acceleratorkeyeventargs.md)