---
-api-id: P:Windows.UI.Xaml.Input.FindNextElementOptions.SearchRoot
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject SearchRoot { get;  set; }
-->

# Windows.UI.Xaml.Input.FindNextElementOptions.SearchRoot

## -description
Gets or sets the object that must be the root from which to identify the next focus candidate to receive navigation focus.



## -property-value
The root object. 

If **null**, the entire visual tree of the app.

## -remarks

If one or more transforms are applied to the descendants of **SearchRoot**
that place them outside of the directional area, these elements are still considered candidates.


## -see-also
[Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)


## -examples

