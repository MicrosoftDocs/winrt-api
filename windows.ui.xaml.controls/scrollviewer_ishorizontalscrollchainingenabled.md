---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsHorizontalScrollChainingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsHorizontalScrollChainingEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsHorizontalScrollChainingEnabled

## -description
Gets or sets a value that indicates whether scroll chaining is enabled from this child to its parent, for the horizontal axis.



## -xaml-syntax
```xaml
<ScrollViewer IsHorizontalScrollChainingEnabled="bool" />
-or-
<object ScrollViewer.IsHorizontalScrollChainingEnabled="bool"/>

```


## -property-value
**true** to enable horizontal scroll chaining from child to parent; otherwise, **false**.

## -remarks

After a user hits a scroll limit on an element that has been nested within another scrollable element, you can specify whether that parent element should continue the scrolling operation begun in its child element. This is called scroll chaining.

For more info, see [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning).

For XAML usage, IsHorizontalScrollChainingEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsHorizontalScrollChainingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.

The ScrollViewer's chaining properties ([IsHorizontalScrollChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.ishorizontalscrollchainingenabled),[IsVerticalScrollChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.isverticalscrollchainingenabled), [IsZoomChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.iszoomchainingenabled) ) do not apply when the control is in inertial mode. Because mouse wheel rotations are handled as **inertial manipulations**, chaining does not work.

## -examples

## -see-also

[Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
