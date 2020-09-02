---
-api-id: P:Windows.UI.Core.KeyEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Core.KeyEventArgs.Handled

## -description
Gets or sets whether the key press event was handled.

## -property-value
True if the key press event has been handled by the appropriate delegate; false if it has not.

## -remarks
> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets Handled to **true**.

> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[KeyDown](corewindow_keydown.md), [KeyUp](corewindow_keyup.md)
