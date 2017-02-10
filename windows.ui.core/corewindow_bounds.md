---
-api-id: P:Windows.UI.Core.CoreWindow.Bounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect Bounds { get; }
-->

# Windows.UI.Core.CoreWindow.Bounds

## -description
Gets the bounding rectangle of the window.

## -property-value
The bounding rectangle of the window, in device-independent pixels (DIPs).

## -remarks
To convert from DIPs to physical pixels (and back), use these equations (where DPI is the dots per inch value for the screen):
+ DIP value = (physical pixel x 96) / DPI
+ physical pixel value = (DIP x DPI) / 96


## -examples

## -see-also
