---
-api-id: P:Windows.UI.Xaml.Shapes.Shape.GeometryTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Transform GeometryTransform { get; }
-->

# Windows.UI.Xaml.Shapes.Shape.GeometryTransform

## -description
Gets a value that represents a [Transform](../windows.ui.xaml.media/transform.md) that is applied to the geometry of a [Shape](shape.md) before it is drawn.



## -xaml-syntax
```xaml
<object>
  <object.GeometryTransform>
    singleTransform
  </object.GeometryTransform>
</object>
```


## -xaml-values
<dl><dt>singleTransform</dt><dd>singleTransformExactly one object element for an object that derives from Transform. This is typically one of the transforms: RotateTransform, ScaleTransform, SkewTransform, TranslateTransform, MatrixTransform, TransformGroup. By using TransformGroup here, you can apply multiple transforms by defining child object elements of the TransformGroup. See the "XAML Values" section for TransformGroup. Also, custom transforms might derive from MatrixTransform.</dd>
</dl>
## -property-value
A [Transform](../windows.ui.xaml.media/transform.md) that is applied to the geometry of a [Shape](shape.md) before it is drawn.

## -remarks

## -examples

## -see-also
