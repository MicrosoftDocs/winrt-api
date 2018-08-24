---
-api-id: M:Windows.UI.Core.ICoreWindow.SetPointerCapture
-api-type: winrt method
---

<!-- Method syntax
public void SetPointerCapture()
-->

# Windows.UI.Core.ICoreWindow.SetPointerCapture

## -description
Specifies a method that associates pointer input with the app. Once a pointer is captured, all subsequent events associated with that pointer are fired by the app.

A pointer can be captured only by a single app at any time.

Pointer events continue even if the pointer moves outside the bounds of the app.

## -remarks
Only the foreground window can capture the pointer.

A pointer can only be captured when contact is detected (mouse button pressed, touch contact down, stylus in contact), and the pointer is within the bounding rectangle of the app.

The pointer is released on a [PointerReleased](corewindow_pointerreleased.md) or a [PointerCaptureLost](corewindow_pointercapturelost.md) event, or [ReleasePointerCapture](corewindow_releasepointercapture_193058457.md) is explicitly called.

## -examples

## -see-also
