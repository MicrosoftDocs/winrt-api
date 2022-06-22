---
-api-id: T:Windows.UI.Xaml.Media.MatrixTransform
-api-type: winrt class
---

<!-- Class syntax.
public class MatrixTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.IMatrixTransform
-->

# Windows.UI.Xaml.Media.MatrixTransform

## -description
Creates an arbitrary affine matrix transformation that is used to manipulate objects or coordinate systems in a two-dimensional plane.



## -xaml-syntax
```xaml
<MatrixTransform .../>
```

```xaml
<object property="m11, m12, m21, m22, offsetX, offsetY"/>
- or -
<object property="Identity"/>
```


## -remarks

## -examples
This example transforms the position and skew of a rectangle using a MatrixTransform.



[!code-xaml[matrixtransform](../windows.ui.xaml/code/transforms/csharp/Matrix_Transform.xaml#Snippetmatrixtransform)]

## -see-also
[Transform](transform.md)
