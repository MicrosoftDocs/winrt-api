---
-api-id: M:Windows.UI.Xaml.FrameworkElement.MeasureOverride(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize)
-->

# Windows.UI.Xaml.FrameworkElement.MeasureOverride

## -description
Provides the behavior for the "Measure" pass of the layout cycle. Classes can override this method to define their own "Measure" pass behavior.



## -parameters
### -param availableSize
The available size that this object can give to child objects. Infinity can be specified as a value to indicate that the object will size to whatever content is available.

## -returns
The size that this object determines it needs during layout, based on its calculations of the allocated sizes for child objects or based on other considerations such as a fixed container size.

## -remarks
This method has a default implementation that performs built-in layout for most [FrameworkElement](frameworkelement.md) derived classes. MeasureOverride provides the behavior for [Measure](uielement_measure_1722732750.md), whenever [Measure](uielement_measure_1722732750.md) is called either by internal layout logic or your own app's code, including any MeasureOverride methods of your own for other classes. If you are producing a templated control, the MeasureOverride logic defines your control's specific "Measure" pass layout logic.

The general design of how elements go through a layout process when your app runs is divided into two steps: a "Measure" pass, and then an "Arrange" pass. Control authors (or panel authors) who want to customize the "Measure" pass of layout processing should override MeasureOverride. Your implementation should do the following: 
+ Iterate your class's particular collection of child objects that are part of layout, and call [Measure](uielement_measure_1722732750.md) on each child object.
+ Immediately get [DesiredSize](uielement_desiredsize.md) on each child (this is set as a property after [Measure](uielement_measure_1722732750.md) is called).
+ Compute the net desired size of the parent, based on the running measurement of the size that is needed for child objects.
 The return value of MeasureOverride should be the object's own desired size, which then becomes the [Measure](uielement_measure_1722732750.md) input for the parent of the current object. This same process continues through the layout system until the root of the page/object tree is reached. During this process, child objects might return a larger [DesiredSize](uielement_desiredsize.md) size than the initial *availableSize* to indicate that the child object wants more space. This might be handled in your own implementation by introducing a scrollable region, resizing the parent control, establishing some manner of stacked order, or any number of solutions for measuring or arranging content that can vary depending on your layout container's intended functionality.

## -examples
This example implements MeasureOverride to customize the "Measure" pass logic for a custom panel implementation. Note in particular these aspects of the code:


+ Iterates over children.
+ For each child, calls [Measure](uielement_measure_1722732750.md), using a [Size](../windows.foundation/size.md) that makes sense based on how the panel logic treats the number of children and its own known size limit.
+ Returns its size (in this case, this simple panel returns a fixed size rather than a size calculated on accumulating the measurements).




[!code-csharp[1](../windows.ui.xaml.controls.primitives/code/BlockPanel/csharp/BlankPage.xaml.cs#Snippet1)]

[!code-vb[1](../windows.ui.xaml.controls.primitives/code/BlockPanel/vbnet/BlankPage.xaml.vb#Snippet1)]

## -see-also
[Measure](uielement_measure_1722732750.md), [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
4162-1c9c-48f4-8a94-34976fb17079)
