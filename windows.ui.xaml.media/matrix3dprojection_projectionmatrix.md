---
-api-id: P:Windows.UI.Xaml.Media.Matrix3DProjection.ProjectionMatrix
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Media3D.Matrix3D ProjectionMatrix { get;  set; }
-->

# Windows.UI.Xaml.Media.Matrix3DProjection.ProjectionMatrix

## -description
Gets or sets the [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) that is used for the projection that is applied to the object.



## -xaml-syntax
```xaml
<Matrix3DProjection ProjectionMatrix="matrix3DInitializationString" />
- or -
<!--xmlns:m3d="using:Windows.UI.Xaml.Media.Media3D"-->
<Matrix3DProjection>
  <m3d:Matrix3D>matrix3DInitializationString</m3d:Matrix3D>
</Matrix3DProjection>
```


## -xaml-values
<dl><dt>matrix3DInitializationString</dt><dd>matrix3DInitializationStringA string that uses space or comma delimiters to specify values for each of the Point values that constitute a Matrix3D. For more info, see Matrix3D.</dd>
</dl>
## -property-value
The [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) that is used for the projection that is applied to the object.

## -remarks
The XAML syntax shown requires specifying the 16 properties of a [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) structure in a particular order. For a guide to the string format and the order that's needed for this, see [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md).

If you use an explicit [Matrix3D](matrix3dprojection.md) object element rather than the ProjectionMatrix attribute syntax, you need to map a XAML namespace for [Windows.UI.Xaml.Media.Media3D](../windows.ui.xaml.media.media3d/windows_ui_xaml_media_media3d.md) to use the [Matrix3D](matrix3dprojection.md) type. For more info, see "XAML syntax for **Matrix3D** " in Remarks for [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md).

ProjectionMatrix is the XAML content property for [Matrix3DProjection](matrix3dprojection.md), so you can omit XAML property elements if you do use the explicit [Matrix3D](matrix3dprojection.md) object element rather than the attribute form with initialization string.

## -examples

## -see-also
[Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md), [UIElement.Projection](../windows.ui.xaml/uielement_projection.md), [3-D perspective effects for XAML UI](/windows/uwp/graphics/3-d-perspective-effects)
