---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsZoomChainingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsZoomChainingEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsZoomChainingEnabled

## -description
Gets or sets a value that indicates whether zoom chaining is enabled from this child to its parent.



## -xaml-syntax
```xaml
<ScrollViewer IsZoomChainingEnabled="bool" />
-or-
<object ScrollViewer.IsZoomChainingEnabled="bool"/>
```


## -property-value
**true** to enable zoom chaining from child to parent; otherwise, **false**.

## -remarks

After a user hits a zoom limit on an element that has been nested within another zoomable element, you can specify whether that parent element should continue the zooming operation begun in its child element. This is called zoom chaining.

For XAML usage, IsZoomChainingEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsZoomChainingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.

The ScrollViewer's chaining properties ([IsHorizontalScrollChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.ishorizontalscrollchainingenabled),[IsVerticalScrollChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.isverticalscrollchainingenabled), [IsZoomChainingEnabled](/uwp/api/windows.ui.xaml.controls.scrollviewer.iszoomchainingenabled) ) do not apply when the control is in inertial mode. Because mouse wheel rotations are handled as **inertial manipulations**, chaining does not work.
<!--May not work because there is no apparent templatebinding linkage in most of the generic templates.-->

## -examples

## -see-also

[Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
