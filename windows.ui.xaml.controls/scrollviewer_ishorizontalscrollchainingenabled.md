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
For XAML usage, [IsHorizontalScrollChainingEnabled](scrollviewer_ishorizontalscrollchainingenabled.md) can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsHorizontalScrollChainingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.
<!--May not work because there is no apparent templatebinding linkage in most of the generic templates.-->

## -examples

## -see-also
