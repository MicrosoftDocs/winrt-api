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
This example uses a [SkewTransform](skewtransform.md) to skew text. A *skew*, also known as a *shear*, is a transformation that stretches the coordinate space in a non-uniform manner. In this example, the two text strings are skewed -30 degrees and 30 degrees along the x-coordinate.



[!code-xml[SkewTransform_1](../windows.ui.xaml/code/transforms/csharp/Skew_Transform_1.xaml#SnippetSkewTransform_1)]



[!code-xml[SkewTransform](../windows.ui.xaml/code/transforms/csharp/Skew_Transform.xaml#SnippetSkewTransform)]

[!code-csharp[SkewTransform_code](../windows.ui.xaml/code/transforms/csharp/Skew_Transform.xaml.cs#SnippetSkewTransform_code)]


## -see-also
[Transform](transform.md), [XAML two-dimensional transforms sample](https://go.microsoft.com/fwlink/p/?linkid=238580)
