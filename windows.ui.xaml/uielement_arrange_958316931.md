---
-api-id: M:Windows.UI.Xaml.UIElement.Arrange(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public void Arrange(Windows.Foundation.Rect finalRect)
-->

# Windows.UI.Xaml.UIElement.Arrange

## -description
Positions child objects and determines a size for a [UIElement](uielement.md). Parent objects that implement custom layout for their child elements should call this method from their layout override implementations to form a recursive layout update.



## -parameters
### -param finalRect
The final size that the parent computes for the child in layout, provided as a [Rect](../windows.foundation/rect.md) value.

## -remarks
The Arrange call potentially reaches an [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md) implementation of that specific class. Otherwise, most [FrameworkElement](frameworkelement.md) classes have an implicit default layout behavior for Arrange.

Computation of initial layout positioning in a XAML UI consists of a [Measure](uielement_measure_1722732750.md) call and an Arrange call, in that order. During the [Measure](uielement_measure_1722732750.md) call, the layout system determines an element's size requirements using the *availableSize* measurement. During the Arrange call, the layout system finalizes the size and position of an element's bounding box.

When a layout is first produced, it always has a [Measure](uielement_measure_1722732750.md) call that happens before Arrange. However, after the first layout pass, an Arrange call can happen without a [Measure](uielement_measure_1722732750.md) preceding it. This can happen when a property that affects only Arrange is changed (such as alignment), or when the parent receives an Arrange without a [Measure](uielement_measure_1722732750.md).

A [Measure](uielement_measure_1722732750.md) call will automatically invalidate any Arrange information. Layout updates generally occur asynchronously (at a time determined by the layout system). An element might not immediately reflect changes to properties that affect element sizing (such as [Width](frameworkelement_actualwidth.md)).

Layout updates can be forced by app code rather than relying on the built-in layout system behavior by using the [UpdateLayout](uielement_updatelayout_1243658106.md) method. However, that is not recommended. It is usually unnecessary and can cause poor performance if overused. In many situations where calling [UpdateLayout](uielement_updatelayout_1243658106.md) from app code might be appropriate because of changes to properties, the layout system will probably already be processing updates. The layout system also has optimizations for dealing with cascades of layout changes through parent-child relationships, and calling [UpdateLayout](uielement_updatelayout_1243658106.md) can work against such optimizations. Nevertheless, it's possible that layout situations exist in more complicated scenarios where calling [UpdateLayout](uielement_updatelayout_1243658106.md) is the best option for resolving a timing issue or other issue with layout. Just use it deliberately and sparingly.

## -examples
This example shows how you would use Arrange within an [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md) implementation. The basic idea is that you should query [DesiredSize](uielement_desiredsize.md) on anything you attempt to call Arrange on so that you have a value for *finalRect*, unless your layout implementation has some specific design that alters or ignores the desired size before passing it as *finalRect*.



[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/csharp/BlankPage.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/vbnet/BlankPage.xaml.vb#Snippet2)]

## -see-also
[ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [MeasureOverride](frameworkelement_measureoverride_1586581644.md)
