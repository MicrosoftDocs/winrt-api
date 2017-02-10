---
-api-id: P:Windows.UI.Core.ICoreWindow.Bounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect Bounds { get; }
-->

# Windows.UI.Core.ICoreWindow.Bounds

## -description
Specifies the property that gets the bounding rectangle of the window.

## -property-value
The bounding rectangle of the window, in device-independent pixel (DIP).

## -remarks
To convert from device-independent pixel (DIP) to physical pixels (and back), use the following equations (where DPI is the dots per inch value for the screen):
+ DIP value = (physical pixel x 96) / DPI
+ physical pixel value = (DIP x DPI) / 96


## -examples

## -see-also
[Rect](../windows.foundation/rect.md)