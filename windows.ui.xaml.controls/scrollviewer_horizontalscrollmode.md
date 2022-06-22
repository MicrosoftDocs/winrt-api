---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.HorizontalScrollMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ScrollMode HorizontalScrollMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.HorizontalScrollMode

## -description
Gets or sets a value that determines how manipulation input influences scrolling behavior on the horizontal axis.



## -xaml-syntax
```xaml
<ScrollViewer HorizontalScrollMode="scrollModeMemberName" />
-or-
<object ScrollViewer.HorizontalScrollMode="scrollModeMemberName"/>
```


## -property-value
A value of the enumeration. The typical default (as set through the default template, not class initialization) is **Enabled**.

## -remarks
Scrolling behavior can also be set through a `ScrollViewer.HorizontalScrollMode` XAML attached property usage, or by calling [SetHorizontalScrollMode](scrollviewer_sethorizontalscrollmode_2014527863.md). This is for cases where the [ScrollViewer](scrollviewer.md) is implicit, such as when the [ScrollViewer](scrollviewer.md) exists in the default template for a [GridView](gridview.md), and you want to be able to influence the scrolling behavior without accessing template parts. Controls with a [ScrollViewer](scrollviewer.md) as part of their composition typically use template binding such that setting the attached property at the level of the control will change the scroll behavior of the [ScrollViewer](scrollviewer.md) part within the control. Otherwise, it may be necessary to replace the template in order to change the scroll behavior of a [ScrollViewer](scrollviewer.md) part.

## -examples

## -see-also

[Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
