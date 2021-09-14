---
-api-id: T:Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
-api-type: winrt class
---

<!-- Class syntax.
public class PerspectiveTransform3D : Windows.UI.Xaml.Media.Media3D.Transform3D, Windows.UI.Xaml.Media.Media3D.IPerspectiveTransform3D
-->

# Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D

## -description

Represents a 3-D perspective effect.


## -remarks

For more info about using PerspectiveTransform3D, see the [UIElement.Transform3D](../windows.ui.xaml/uielement_transform3d.md) property.

Adding a PerspectiveTransform3D element to a scene with no other 3-D transforms will not change the appearance of any 2-D elements. It will preserve the X and Y coordinates in the plane of Z=0. To take advantage of the perspective effect, you need to use [CompositeTransform3D](compositetransform3d.md) in conjunction with PerspectiveTransform3D.

Following the guidelines of the [The Direct3D Transformation Pipeline](XREF:TODO:dxtecharts.the_direct3d_transformation_pipeline), PerspectiveTransform3D represents a projection transform. In comparison, [CompositeTransform3D](compositetransform3d.md) represents a world or view transform. Because of this, PerspectiveTransform3D should usually be applied at the root of the XAML scene. In most cases, this would be the [Page](../windows.ui.xaml.controls/page.md) element.

## -examples

## -see-also

[Transform3D](transform3d.md), [CompositeTransform3D class](compositetransform3d.md), [UIElement.Transform3D property](../windows.ui.xaml/uielement_transform3d.md), [Transform3D parallax sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlTransform3DParallax), [Transform3D animations sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620637)
