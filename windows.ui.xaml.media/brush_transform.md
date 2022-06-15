---
-api-id: P:Windows.UI.Xaml.Media.Brush.Transform
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Transform Transform { get;  set; }
-->

# Windows.UI.Xaml.Media.Brush.Transform

## -description
Gets or sets the transformation that is applied to the brush.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Brush.Transform](/windows/winui/api/microsoft.ui.xaml.media.brush.transform) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<brush>
  <brush.Transform>
    singleTransform
  </brush.Transform>
</brush>
```


## -xaml-values
<dl><dt>singleTransform</dt><dd>singleTransformExactly one object element for an object that derives from Transform. This can be one of the following: RotateTransform, ScaleTransform, SkewTransform, TranslateTransform, MatrixTransform, or TransformGroup. By using a TransformGroup here, you can apply multiple transforms by defining child object elements of the TransformGroup. See the XAML Values section for TransformGroup.</dd>
</dl>
## -property-value
The transformation to apply to the brush.

## -remarks

## -examples

## -see-also
