---
-api-id: T:Windows.UI.Xaml.Media.TranslateTransform
-api-type: winrt class
---

<!-- Class syntax.
public class TranslateTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.ITranslateTransform
-->

# Windows.UI.Xaml.Media.TranslateTransform

## -description
Translates (moves) an object in the two-dimensional x-y coordinate system.

## -xaml-syntax
```xaml
<TranslateTransform .../>
```


## -remarks

## -examples
This example uses a [TranslateTransform](translatetransform.md) to offset text. In this example, a slightly offset copy of text below the primary text creates a shadow effect.



[!code-xml[TranslateTransform_1](../windows.ui.xaml/code/transforms/csharp/Translate_Transform_1.xaml#SnippetTranslateTransform_1)]



[!code-xml[TranslateTransform_2](../windows.ui.xaml/code/transforms/csharp/Translate_Transform_2.xaml#SnippetTranslateTransform_2)]

[!code-csharp[TranslateTransform_2_code](../windows.ui.xaml/code/transforms/csharp/Translate_Transform_2.xaml.cs#SnippetTranslateTransform_2_code)]

## -see-also
[XAML two-dimensional transforms sample](http://go.microsoft.com/fwlink/p/?linkid=238580), [Transform](transform.md)