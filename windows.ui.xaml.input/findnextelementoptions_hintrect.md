---
-api-id: P:Windows.UI.Xaml.Input.FindNextElementOptions.HintRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect HintRect { get;  set; }
-->

# Windows.UI.Xaml.Input.FindNextElementOptions.HintRect

## -description
Gets or sets a bounding rectangle used to identify the focus candidates most likely to receive navigation focus.



## -property-value
The bounding rectangle.

## -remarks
Potential candidates are calculated using the bounding rectangle as reference. This rectangle lets you specify another reference instead of the focused element. 

This rectangle is used only for calculations and is never added to the visual tree.

## -see-also
[Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)


## -examples

