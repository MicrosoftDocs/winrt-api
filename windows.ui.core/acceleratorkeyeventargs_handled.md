---
-api-id: P:Windows.UI.Core.AcceleratorKeyEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Core.AcceleratorKeyEventArgs.Handled

## -description
Gets or sets whether the accelerator key event was handled or not.

## -property-value
True if the accelerator key event has been handled; false if it has not.

## -remarks
> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets Handled to **true**.

> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[AcceleratorKeyActivated](coreacceleratorkeys_acceleratorkeyactivated.md)
