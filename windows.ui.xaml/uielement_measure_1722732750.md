---
-api-id: M:Windows.UI.Xaml.UIElement.Measure(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public void Measure(Windows.Foundation.Size availableSize)
-->

# Windows.UI.Xaml.UIElement.Measure

## -description
Updates the [DesiredSize](uielement_desiredsize.md) of a [UIElement](uielement.md). Typically, objects that implement custom layout for their layout children call this method from their own [MeasureOverride](frameworkelement_measureoverride_1586581644.md) implementations to form a recursive layout update.



## -parameters
### -param availableSize
The available space that a parent can allocate to a child object. A child object can request a larger space than what is available; the provided size might be accommodated if scrolling or other resize behavior is possible in that particular container.

## -remarks
The Measure call potentially reaches a [MeasureOverride](frameworkelement_measureoverride_1586581644.md) implementation of that specific class. Otherwise, most [FrameworkElement](frameworkelement.md) classes have an implicit default layout behavior for Measure.

*availableSize* can be any number from zero to infinite. Elements participating in layout should return the minimum [Size](../windows.foundation/size.md) they require for a given *availableSize*.

Computation of initial layout positioning in a XAML UI consists of a Measure call and an [Arrange](uielement_arrange_958316931.md) call, in that order. During the Measure call, the layout system determines an element's size requirements using the *availableSize* measurement. During the [Arrange](uielement_arrange_958316931.md) call, the layout system finalizes the size and position of an element's bounding box.

When a layout is first produced, it always has a Measure call that happens before [Arrange](uielement_arrange_958316931.md). However, after the first layout pass, an [Arrange](uielement_arrange_958316931.md) call can happen without a Measure preceding it. This can happen when a property that affects only [Arrange](uielement_arrange_958316931.md) is changed (such as alignment), or when the parent receives an [Arrange](uielement_arrange_958316931.md) without a Measure.

A Measure call will automatically invalidate any [Arrange](uielement_arrange_958316931.md) information. Layout updates generally occur asynchronously (at a time determined by the layout system). An element might not immediately reflect changes to properties that affect element sizing (such as [Width](frameworkelement_actualwidth.md)).

## -examples
This example implements [MeasureOverride](frameworkelement_measureoverride_1586581644.md) to customize the "Measure" pass logic for a custom panel implementation. Note in particular these aspects of the code:


+ Iterates over children.
+ For each child, calls Measure, using a [Size](../windows.foundation/size.md) that makes sense based on how the panel logic treats the number of children and its own known size limit.
+ Returns its size (in this case, this simple panel returns a fixed size rather than a size calculated on accumulating the measurements).




[!code-csharp[1](../windows.ui.xaml.controls.primitives/code/BlockPanel/csharp/BlankPage.xaml.cs#Snippet1)]

[!code-vb[1](../windows.ui.xaml.controls.primitives/code/BlockPanel/vbnet/BlankPage.xaml.vb#Snippet1)]

## -see-also
[MeasureOverride](frameworkelement_measureoverride_1586581644.md), [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
4162-1c9c-48f4-8a94-34976fb17079)
