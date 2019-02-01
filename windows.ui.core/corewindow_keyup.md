---
-api-id: E:Windows.UI.Core.CoreWindow.KeyUp
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler KeyUp<Windows.UI.Core.CoreWindow,  Windows.UI.Core.KeyEventArgs>
-->

# Windows.UI.Core.CoreWindow.KeyUp

## -description
Is fired when a non-system key is released after a press.

## -remarks
Apps do not receive this event when an [IME](https://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.

## -examples

## -see-also
[KeyEventArgs](keyeventargs.md)
