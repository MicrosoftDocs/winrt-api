---
-api-id: M:Windows.UI.Xaml.UIElement.InvalidateMeasure
-api-type: winrt method
---

<!-- Method syntax
public void InvalidateMeasure()
-->

# Windows.UI.Xaml.UIElement.InvalidateMeasure

## -description
Invalidates the measurement state (layout) for a [UIElement](uielement.md).



## -remarks
[UpdateLayout](uielement_updatelayout_1243658106.md) is basically equivalent to calling InvalidateMeasure and [InvalidateArrange](uielement_invalidatearrange_2012947484.md) in sequence.

Layout updates can be forced by app code rather than relying on the built-in layout system behavior. However, that is not generally recommended. Calling [InvalidateArrange](uielement_invalidatearrange_2012947484.md), InvalidateMeasure or [UpdateLayout](uielement_updatelayout_1243658106.md) is usually unnecessary and can cause poor performance if overused. In many situations where app code might be changing layout properties, the layout system will probably already be processing updates asynchronously. The layout system also has optimizations for dealing with cascades of layout changes through parent-child relationships, and forcing layout with app code can work against such optimizations. Nevertheless, it's possible that layout situations exist in more complicated scenarios where forcing layout is the best option for resolving a timing issue or other issue with layout. Just use it deliberately and sparingly.

## -examples

## -see-also
[Measure](uielement_measure_1722732750.md), [MeasureOverride](frameworkelement_measureoverride_1586581644.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
