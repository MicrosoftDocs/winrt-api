---
-api-id: P:Windows.UI.Xaml.Media.Geometry.Transform
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Transform Transform { get;  set; }
-->

# Windows.UI.Xaml.Media.Geometry.Transform

## -description
Gets or sets the [Transform](transform.md) object applied to a [Geometry](geometry.md).



## -xaml-syntax
```xaml
<geometry>
  <geometry.Transform>
    singleTransform
  </geometry.Transform
</geometry>
```


## -xaml-values
<dl><dt>singleTransform</dt><dd>singleTransformExactly one object element for an object that derives from Transform. This is typically one of the following classes: RotateTransform, ScaleTransform, SkewTransform, TranslateTransform, MatrixTransform, or TransformGroup. By using a TransformGroup here, you can apply multiple transforms by defining child object elements of the TransformGroup. See the XAML Values section for TransformGroup.</dd>
</dl>
## -property-value
The transformation applied to the [Geometry](geometry.md). Note that this value may be a single [Transform](transform.md) or a list of [Transform](transform.md) items.

## -remarks

## -examples

## -see-also
