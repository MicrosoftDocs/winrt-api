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
For XAML usage, IsZoomChainingEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsZoomChainingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.
<!--May not work because there is no apparent templatebinding linkage in most of the generic templates.-->

## -examples

## -see-also
