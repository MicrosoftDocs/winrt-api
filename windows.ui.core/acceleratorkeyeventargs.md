---
-api-id: T:Windows.UI.Core.AcceleratorKeyEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AcceleratorKeyEventArgs : Windows.UI.Core.IAcceleratorKeyEventArgs, Windows.UI.Core.IAcceleratorKeyEventArgs2, Windows.UI.Core.ICoreWindowEventArgs
-->

# Windows.UI.Core.AcceleratorKeyEventArgs

## -description
Provides the arguments returned by an accelerator key event callback.

## -remarks

> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](acceleratorkeyeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DeviceId |

## -examples

## -see-also
[AcceleratorKeyActivated](coreacceleratorkeys_acceleratorkeyactivated.md)
