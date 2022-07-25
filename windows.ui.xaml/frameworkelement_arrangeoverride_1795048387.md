---
-api-id: M:Windows.UI.Xaml.FrameworkElement.ArrangeOverride(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize)
-->

# Windows.UI.Xaml.FrameworkElement.ArrangeOverride

## -description
Provides the behavior for the "Arrange" pass of layout. Classes can override this method to define their own "Arrange" pass behavior.



## -parameters
### -param finalSize
The final area within the parent that this object should use to arrange itself and its children.

## -returns
The actual size that is used after the element is arranged in layout.

## -remarks
This method has a default implementation that performs built-in layout for most [FrameworkElement](frameworkelement.md) derived classes. ArrangeOverride provides the behavior for [Arrange](uielement_arrange_958316931.md), whenever [Arrange](uielement_arrange_958316931.md) is called either by internal layout logic or your own app's code, including any ArrangeOverride methods of your own for other classes. If you are producing a templated control, the ArrangeOverride logic defines your control's specific "Arrange" pass layout logic.

The general design of how elements go through a layout process when your app runs is divided into two steps: a "Measure" pass, and then an "Arrange" pass. Control authors (or panel authors) who want to customize the "Arrange" pass of layout processing should override ArrangeOverride. The implementation pattern should call [Arrange](uielement_arrange_958316931.md) on each visible child object, and pass the final desired size for each child object as the *finalRect* parameter. If [Arrange](uielement_arrange_958316931.md) isn't called, the child object is not rendered.

Several existing non-sealed classes provide override implementations of this method. Prominent ones include [StackPanel](../windows.ui.xaml.controls/stackpanel.md) and [Grid](../windows.ui.xaml.controls/grid.md). Typically, the behavior of ArrangeOverride produces a *finalSize* that does not violate any user-defined values that are placed on the layout container itself. For example, the *finalSize* is not typically larger than the container's [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md), accounting for **Margin** or **Padding** values that affect the content area. Controls that specifically have a scenario for exceeding the container size could return a larger value, but anyone using that control must account for the clipping and positioning issues that result from it. The value that an ArrangeOverride implementation passes to [Arrange](uielement_arrange_958316931.md) for each child object is generally the value that is set in [DesiredSize](uielement_desiredsize.md) by the previous [Measure](uielement_measure_1722732750.md) call.

## -examples
This example implements ArrangeOverride to customize the "Arrange" pass logic for a custom panel implementation. Note in particular these aspects of the code:


+ Iterates over children.
+ For each child, calls [Arrange](uielement_arrange_958316931.md), using a [Rect](../windows.foundation/rect.md) where **Height** and **Width** are based on [DesiredSize](uielement_desiredsize.md), and **X** and **Y** are based on logic that is specific to the panel.
+ Returns its size (in this case, this simple panel returns a fixed size rather than a size calculated on accumulating the arranged [Rect](../windows.foundation/rect.md) value measurements).




[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/csharp/BlankPage.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/vbnet/BlankPage.xaml.vb#Snippet2)]

## -see-also
[Arrange](uielement_arrange_958316931.md), [MeasureOverride](frameworkelement_measureoverride_1586581644.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
4162-1c9c-48f4-8a94-34976fb17079)
