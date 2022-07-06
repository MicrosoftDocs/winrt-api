---
-api-id: T:Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
-api-type: winrt class
---

<!-- Class syntax.
public class CompositeTransform3D : Windows.UI.Xaml.Media.Media3D.Transform3D, Windows.UI.Xaml.Media.Media3D.ICompositeTransform3D
-->

# Windows.UI.Xaml.Media.Media3D.CompositeTransform3D

## -description

Represents 3-D scale, rotation, and translate transforms to be applied to an element.



## -remarks

For examples and more info about using [CompositeTransform3D class, see the [UIElement.Transform3D](../windows.ui.xaml/uielement_transform3d.md) property.

The available transforms are applied in the following order:

+ Scale ([ScaleX](compositetransform3d_scalex.md), [ScaleY](compositetransform3d_scaley.md), [ScaleZ](compositetransform3d_scalez.md))
+ Rotation ([RotationX](compositetransform3d_rotationx.md), [RotationY](compositetransform3d_rotationy.md), [RotationZ](compositetransform3d_rotationz.md))
+ Translate ([TranslateX](compositetransform3d_translatex.md), [TranslateY](compositetransform3d_translatey.md), [TranslateZ](compositetransform3d_translatez.md))

All transformations occur around the same center point defined by [CenterX](compositetransform3d_centerx.md), [CenterY](compositetransform3d_centery.md), and [CenterZ](compositetransform3d_centerz.md).

You can animate each property of a CompositeTransform3D independently.

## -examples

## -see-also

[Transform3D](transform3d.md), [PerspectiveTransform3D class](perspectivetransform3d.md), [UIElement.Transform3D property](../windows.ui.xaml/uielement_transform3d.md), [Transform3D parallax sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlTransform3DParallax), [Transform3D animations sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620637)
