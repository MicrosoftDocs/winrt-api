---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsDeferredScrollingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsDeferredScrollingEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsDeferredScrollingEnabled

## -description
Gets or sets a value that determines the deferred scrolling behavior for a [ScrollViewer](scrollviewer.md).



## -xaml-syntax
```xaml
<ScrollViewer IsDeferredScrollingEnabled="bool" />
-or-
<object ScrollViewer.IsDeferredScrollingEnabled="bool"/>
```


## -property-value
**true** if deferred scrolling should occur; otherwise, **false**.

## -remarks
Deferred scrolling behavior means that the view does not scroll until a user action is completed. For example, if a region scrolls when the user manipulates a thumb control, and IsDeferredScrollingEnabled is true, the scroll does not occur until the touch point on the thumb is released. In contrast, if IsDeferredScrollingEnabled is false, the region scrolls any time that the touch point selection point along the slider track is moved.

For XAML usage, IsDeferredScrollingEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsDeferredScrollingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.

## -examples

## -see-also
