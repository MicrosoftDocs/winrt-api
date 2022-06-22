---
-api-id: P:Windows.UI.Xaml.Input.FindNextElementOptions.ExclusionRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect ExclusionRect { get;  set; }
-->

# Windows.UI.Xaml.Input.FindNextElementOptions.ExclusionRect

## -description
Gets or sets a bounding rectangle where all overlapping navigation candidates are excluded from navigation focus.



## -property-value
The bounding rectangle.

## -remarks
Potential candidates are calculated using the bounding rectangle as reference. This rectangle lets you specify another reference instead of the focused element. 

This rectangle is used only for calculations and is never added to the visual tree.

## -see-also
[Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)


## -examples
