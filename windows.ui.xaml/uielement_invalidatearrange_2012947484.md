---
-api-id: M:Windows.UI.Xaml.UIElement.InvalidateArrange
-api-type: winrt method
---

<!-- Method syntax
public void InvalidateArrange()
-->

# Windows.UI.Xaml.UIElement.InvalidateArrange

## -description
Invalidates the arrange state (layout) for a [UIElement](uielement.md). After the invalidation, the [UIElement](uielement.md) will have its layout updated, which will occur asynchronously.



## -remarks
Controls that maintain their own orientation property might call InvalidateArrange when that orientation changes, as a way to reconstruct the layout for the new orientation. InvalidateArrange might also be called from within custom layout logic in cases such as when available size isn't adequate and the logic allows for an alternate layout strategy that uses available size differently.

[UpdateLayout](uielement_updatelayout_1243658106.md) is basically equivalent to calling [InvalidateMeasure](uielement_invalidatemeasure_969784920.md) and InvalidateArrange in sequence.

Layout updates can be forced by app code rather than relying on the built-in layout system behavior. However, that is not generally recommended. Calling InvalidateArrange, [InvalidateMeasure](uielement_invalidatemeasure_969784920.md) or [UpdateLayout](uielement_updatelayout_1243658106.md) is usually unnecessary and can cause poor performance if overused. In many situations where app code might be changing layout properties, the layout system will probably already be processing updates asynchronously. The layout system also has optimizations for dealing with cascades of layout changes through parent-child relationships, and forcing layout with app code can work against such optimizations. Nevertheless, it's possible that layout situations exist in more complicated scenarios where forcing layout is the best option for resolving a timing issue or other issue with layout. Just use it deliberately and sparingly.

## -examples

## -see-also
[Arrange](uielement_arrange_958316931.md), [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [InvalidateMeasure](uielement_invalidatemeasure_969784920.md), [UpdateLayout](uielement_updatelayout_1243658106.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
