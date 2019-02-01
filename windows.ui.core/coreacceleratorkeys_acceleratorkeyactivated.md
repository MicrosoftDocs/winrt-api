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
> Apps do not receive this event when an [Input Method Editor (IME)](https://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](acceleratorkeyeventargs_handled.md) to **true**.



> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[AcceleratorKeyEventArgs](acceleratorkeyeventargs.md)