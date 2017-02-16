---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsVerticalScrollChainingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsVerticalScrollChainingEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsVerticalScrollChainingEnabled

## -description
Gets or sets a value that indicates whether scroll chaining is enabled from this child to its parent, for the vertical axis.

## -xaml-syntax
```xaml
<ScrollViewer IsVerticalScrollChainingEnabled="bool" />
-or-
<object ScrollViewer.IsVerticalScrollChainingEnabled="bool"/>
```


## -property-value
**true** to enable vertical scroll chaining from child to parent; otherwise, **false**.

## -remarks
For XAML usage, [IsVerticalScrollChainingEnabled](scrollviewer_isverticalscrollchainingenabled.md) can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsVerticalScrollChainingEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template. 
<!--May not work because there is no apparent templatebinding linkage in most of the generic templates.-->

## -examples

## -see-also
