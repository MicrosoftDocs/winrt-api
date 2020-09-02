---
-api-id: E:Windows.UI.Core.CoreWindow.KeyDown
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler KeyDown<Windows.UI.Core.CoreWindow,  Windows.UI.Core.KeyEventArgs>
-->

# Windows.UI.Core.CoreWindow.KeyDown

## -description

The event that's raised when a non-system key is pressed.

The delegate type for this event is [TypedEventHandler\<TSender,TResult\>](/uwp/api/windows.foundation.typedeventhandler-2), where **TSender** is of type [CoreWindow](/uwp/api/windows.ui.core.corewindow?view=winrt-19041), and **TResult** is of type [KeyEventArgs](/uwp/api/windows.ui.core.keyeventargs).

## -remarks

Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.

## -examples

## -see-also

[TypedEventHandler\<TSender,TResult\>](/uwp/api/windows.foundation.typedeventhandler-2), [CoreWindow](/uwp/api/windows.ui.core.corewindow?view=winrt-19041), [KeyEventArgs](/uwp/api/windows.ui.core.keyeventargs)
