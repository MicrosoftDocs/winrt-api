---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.HorizontalScrollBarVisibility
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ScrollBarVisibility HorizontalScrollBarVisibility { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.HorizontalScrollBarVisibility

## -description
Gets or sets a value that indicates whether a horizontal [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) should be displayed.



## -xaml-syntax
```xaml
<ScrollViewer HorizontalScrollBarVisibility="scrollBarVisibilityMemberName"/>
-or-
<object ScrollViewer.HorizontalScrollBarVisibility="scrollBarVisibilityMemberName"/>
```


## -xaml-values
<dl><dt>scrollBarVisibilityMemberName</dt><dd>scrollBarVisibilityMemberNameA named constant of the ScrollBarVisibility enumeration, such as Auto.</dd>
</dl>
## -property-value
A [ScrollBarVisibility](scrollbarvisibility.md) value that indicates whether a horizontal [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) should be displayed. The default value is **Disabled**.

## -remarks
For XAML usage, HorizontalScrollBarVisibility can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a `ScrollViewer.HorizontalScrollBarVisibility` attached property usage on an element that is a child of a control that supports scrollview implicitly in its template. Controls with a [ScrollViewer](scrollviewer.md) as part of their composition typically use template binding such that setting the attached property at the level of the control will change the scroll behavior of the [ScrollViewer](scrollviewer.md) part within the control. Otherwise, it may be necessary to replace the template in order to change the scroll behavior of a [ScrollViewer](scrollviewer.md) part.

## -examples

## -see-also
