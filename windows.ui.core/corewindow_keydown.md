---
-api-id: E:Windows.UI.Core.CoreWindow.KeyDown
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler KeyDown<Windows.UI.Core.CoreWindow,  Windows.UI.Core.KeyEventArgs>
-->

# Windows.UI.Core.CoreWindow.KeyDown

## -description
Is fired when a non-system key is pressed.

## -remarks
Apps do not receive this event when an [Input Method Editor (IME)](https://docs.microsoft.com/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.

## -examples

## -see-also
[KeyEventArgs](keyeventargs.md)