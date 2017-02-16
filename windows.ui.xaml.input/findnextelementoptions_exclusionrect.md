---
-api-id: P:Windows.UI.Xaml.Input.FindNextElementOptions.ExclusionRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect ExclusionRect { get;  set; }
-->

# Windows.UI.Xaml.Input.FindNextElementOptions.ExclusionRect

## -description
Gets or sets a bounding rectangle for which all overlapping objects are excluded as the next element to receive focus.   
## -property-value
The bounding rectangle.

## -remarks
Potential candidates are calculated using the bounding rectangle as reference. This rectangle lets you specify another reference instead of the focused element. 

This rectangle is used only for calculations. It is never added to the visual tree.


## -see-also

## -examples
