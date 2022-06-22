---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.BringIntoViewOnFocusChange
-api-type: winrt property
---

<!-- Property syntax
public bool BringIntoViewOnFocusChange { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.BringIntoViewOnFocusChange

## -description
Gets or sets a value that determines whether the [ScrollViewer](scrollviewer.md) uses a bring-into-view scroll behavior when an item in the view gets focus.



## -xaml-syntax
```xaml
<ScrollViewer BringIntoViewOnFocusChange="bool" />
-or-
<object ScrollViewer.BringIntoViewOnFocusChange="bool"/>
```


## -property-value
**true** to use a behavior that brings focused items into view. **false** to use a behavior that focused items do not automatically scroll into view. The default is **true**.

## -remarks
For XAML usage, BringIntoViewOnFocusChange can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.BringIntoViewOnFocusChange** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.

## -examples

## -see-also
