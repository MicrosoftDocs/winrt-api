---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsZoomInertiaEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsZoomInertiaEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsZoomInertiaEnabled

## -description
Gets or sets a value that indicates whether zoom actions should include inertia in their behavior and value.



## -xaml-syntax
```xaml
<ScrollViewer IsZoomInertiaEnabled="bool" />
-or-
<object ScrollViewer.IsZoomInertiaEnabled="bool"/>
```


## -property-value
**true** if zoom actions should include inertia in their behavior and value; otherwise, **false**.

## -remarks
For XAML usage, IsZoomInertiaEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsZoomInertiaEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.

## -examples

## -see-also

[Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
