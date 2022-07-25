---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.VerticalScrollBarVisibility
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ScrollBarVisibility VerticalScrollBarVisibility { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.VerticalScrollBarVisibility

## -description
Gets or sets a value that indicates whether a vertical [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) should be displayed.



## -xaml-syntax
```xaml
<ScrollViewer VerticalScrollBarVisibility="scrollBarVisibilityMemberName"/>
-or-
<object ScrollViewer.VerticalScrollBarVisibility="scrollBarVisibilityMemberName"/>
```


## -xaml-values
<dl><dt>scrollBarVisibilityMemberName</dt><dd>scrollBarVisibilityMemberNameA named constant of the ScrollBarVisibility enumeration, such as Auto.</dd>
</dl>
## -property-value
A [ScrollBarVisibility](scrollbarvisibility.md) value that indicates whether a vertical [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) should be displayed. The default value is **Visible**.

## -remarks
Scrolling behavior can also be set through a `ScrollViewer.VerticalScrollBarVisibility` XAML attached property usage, or by calling [SetVerticalScrollBarVisibility](scrollviewer_setverticalscrollbarvisibility_1675279630.md). This is for cases where the [ScrollViewer](scrollviewer.md) is implicit, such as when the [ScrollViewer](scrollviewer.md) exists in the default template for a [GridView](gridview.md), and you want to be able to influence the scrolling behavior without accessing template parts. Controls with a [ScrollViewer](scrollviewer.md) as part of their composition typically use template binding such that setting the attached property at the level of the control will change the scroll behavior of the [ScrollViewer](scrollviewer.md) part within the control. Otherwise, it may be necessary to replace the template in order to change the scroll behavior of a [ScrollViewer](scrollviewer.md) part.

## -examples

## -see-also
