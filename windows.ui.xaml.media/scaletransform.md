---
-api-id: T:Windows.UI.Xaml.Media.ScaleTransform
-api-type: winrt class
---

<!-- Class syntax.
public class ScaleTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.IScaleTransform
-->

# Windows.UI.Xaml.Media.ScaleTransform

## -description
Scales an object in the two-dimensional x-y coordinate system.

## -xaml-syntax
```xaml
<ScaleTransform .../>
```


## -remarks

## -examples
This XAML example uses a ScaleTransform to scale text from its original size.

[!code-xaml[ScaleTransform](../windows.ui.xaml/code/transforms/csharp/Scale_Transform.xaml#SnippetScaleTransform)]

The text looks like this after the transform is applied.

<img src="Images/skewed_text.png" alt="Text with a skew transform applied" />

This example shows how you can access and modify a transform in code at runtime. Each time the rectangle is pressed, the skew is increased.

[!code-xaml[transforms_ovw_interactive_transforms](../windows.ui.xaml.media/code/transforms_ovw_interactive_transforms/csharp/Page.xaml#Snippettransforms_ovw_interactive_transforms)]

[!code-csharp[transforms_ovw_interactive_transforms_code](../windows.ui.xaml.media/code/transforms_ovw_interactive_transforms/csharp/Page.xaml.cs#Snippettransforms_ovw_interactive_transforms_code)]

[!code-vb[transforms_ovw_interactive_transforms_code](../windows.ui.xaml.media/code/transforms_ovw_interactive_transforms/vbnet/Page.xaml.vb#Snippettransforms_ovw_interactive_transforms_code)]

Here's the rectangle after it's been pressed twice.

<img src="Images/skewed_rectangle.png" alt="A rectangle with a skew transform applied" />

## -see-also
[Transform](transform.md), [XAML two-dimensional transforms sample](https://go.microsoft.com/fwlink/p/?linkid=238580)
