---
-api-id: P:Windows.UI.Core.KeyEventArgs.VirtualKey
-api-type: winrt property
---

<!-- Property syntax
public Windows.System.VirtualKey VirtualKey { get; }
-->

# Windows.UI.Core.KeyEventArgs.VirtualKey

## -description
Gets the virtual key that maps to the key that was pressed.

## -property-value
The virtual key value.

## -remarks
> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[KeyDown](corewindow_keydown.md), [KeyUp](corewindow_keyup.md)