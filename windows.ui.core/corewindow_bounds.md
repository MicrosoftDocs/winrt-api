---
-api-id: P:Windows.UI.Core.CoreWindow.Bounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect Bounds { get; }
-->

# Windows.UI.Core.CoreWindow.Bounds

## -description

Gets a [Rect](../windows.foundation/rect.md) value that contains the origin, height, and width of the client area of the window, in device-independent pixels (DIPs).

## -property-value

A value that reports the origin, height, and width of the client area of the application window.

## -remarks

The origin of the `Rect` is relative to the system window that includes both the _client_ and _non-client_ areas.

To convert from DIPs to physical pixels (and back), use these equations (where DPI is the dots per inch value for the screen):

+ DIP value = (physical pixel x 96) / DPI
+ physical pixel value = (DIP x DPI) / 96

## -examples

## -see-also
