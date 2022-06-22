---
-api-id: T:Windows.UI.Xaml.Media.SkewTransform
-api-type: winrt class
---

<!-- Class syntax.
public class SkewTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.ISkewTransform
-->

# Windows.UI.Xaml.Media.SkewTransform

## -description
Represents a two-dimensional skew.



## -xaml-syntax
```xaml
<SkewTransform .../>
```


## -remarks

## -examples
This example uses a SkewTransform to skew text. A *skew*, also known as a *shear*, is a transformation that stretches the coordinate space in a non-uniform manner. In this example, the two text strings are skewed -30 degrees and 30 degrees along the x-coordinate.

[!code-xaml[SkewTransform_1](../windows.ui.xaml/code/transforms/csharp/Skew_Transform_1.xaml#SnippetSkewTransform_1)]

The text looks like this after the transform is applied:

![Text with a skew transform applied](Images/skewed_text.png)

This example shows how you can access and modify a transform in code at runtime. Each time the rectangle is pressed, the skew is increased.

[!code-xaml[SkewTransform](../windows.ui.xaml/code/transforms/csharp/Skew_Transform.xaml#SnippetSkewTransform)]

[!code-csharp[SkewTransform_code](../windows.ui.xaml/code/transforms/csharp/Skew_Transform.xaml.cs#SnippetSkewTransform_code)]


## -see-also
[Transform](transform.md), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
