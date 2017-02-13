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
[UpdateLayout](uielement_updatelayout.md) is basically equivalent to calling [InvalidateMeasure](uielement_invalidatemeasure.md) and [InvalidateArrange](uielement_invalidatearrange.md) in sequence.

Layout updates can be forced by app code rather than relying on the built-in layout system behavior. However, that is not generally recommended. Calling [InvalidateArrange](uielement_invalidatearrange.md), [InvalidateMeasure](uielement_invalidatemeasure.md) or [UpdateLayout](uielement_updatelayout.md) is usually unnecessary and can cause poor performance if overused. In many situations where app code might be changing layout properties, the layout system will probably already be processing updates asynchronously. The layout system also has optimizations for dealing with cascades of layout changes through parent-child relationships, and forcing layout with app code can work against such optimizations. Nevertheless, it's possible that layout situations exist in more complicated scenarios where forcing layout is the best option for resolving a timing issue or other issue with layout. Just use it deliberately and sparingly.

## -examples

## -see-also
[Measure](uielement_measure.md), [MeasureOverride](frameworkelement_measureoverride.md), [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)