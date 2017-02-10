---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarCustomPen
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarCustomPen : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.IInkToolbarCustomPen, Windows.UI.Xaml.Controls.IInkToolbarCustomPenOverrides
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomPen

## -description
Represents an [InkToolbar](inktoolbar.md) pen for which the ink color palette and pen tip properties, such as shape, rotation, and size, are defined by the host app.



> To create an app-defined pen and corresponding button on the [InkToolbar](inktoolbar.md), use this class in conjunction with [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md).

See a custom pen example at the end of this topic.

## -remarks

## -examples
Here's a definition of a custom calligraphic pen.


1. In code-behind, we first create a custom pen class derived from [InkToolbarCustomPen](inktoolbarcustompen.md).

A custom pen class must override the [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore.md) method and provide the [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md) for the custom configuration. 
In this example, we customize the following [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md):

+ [PenTip](../windows.ui.input.inking/inkdrawingattributes_pentip.md) is set to [PenTipShape.Circle](../windows.ui.input.inking/pentipshape.md);
+ [Size](../windows.ui.input.inking/inkdrawingattributes_size.md) is set to a [Windows.Foundation.Size](../windows.foundation/size.md) of `(strokeWidth, strokeWidth * 20)`.
+ [Color](../windows.ui.input.inking/inkdrawingattributes_color.md) is set to the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) selected from the palette, or [Colors.Black](../windows.ui/colors.md) by default.
+ [PenTipTransform](../windows.ui.input.inking/inkdrawingattributes_pentiptransform.md) (through [Matrix3x2.CreateRotation](https://msdn.microsoft.com/library/dn889081.aspx)) is set to rotate the pen tip by 45°.





[!code-csharp[CustomCalligraphicPen](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/CalligraphicPen.cs#SnippetCustomCalligraphicPen)]
1. In markup, we then bind our custom pen class using a [{StaticResource} markup extension](http://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395) reference in the [CustomPen](inktoolbarcustompenbutton_custompen.md) attribute of the [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) element (alternatively, you can instantiate the custom pen and assign it to [InkToolbarCustomPenButton.CustomPen](inktoolbarcustompenbutton_custompen.md) in code).

You can use the built-in [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) (as shown here) or you can specify a custom [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) definition in the standard [InkToolbar](inktoolbar.md) pen declaration.

Here's the declaration for the custom pen defined in the previous snippet.




[!code-xml[UI_AddCustomPen](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustomPen.xaml#SnippetUI_AddCustomPen)]

Here's the definition of `CalligraphicPenIcon` from the `MainPage.xaml.cs` file of this example.



[!code-csharp[CustomCalligraphicPenMain](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustomPen.xaml.cs#SnippetCustomCalligraphicPenMain)]

## -see-also
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarPenButton](inktoolbarpenbutton.md), [DependencyObject](../windows.ui.xaml/dependencyobject.md)
oolbarpenbutton.md), [DependencyObject](../windows.ui.xaml/dependencyobject.md)