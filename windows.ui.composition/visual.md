---
-api-id: T:Windows.UI.Composition.Visual
-api-type: winrt class
---

<!-- Class syntax.
public class Visual : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.IVisual, Windows.UI.Composition.IVisual2
-->

# Windows.UI.Composition.Visual

## -description

The base visual object in the visual hierarchy.

## -remarks

Visual objects compose and render serialized drawing content and form the basis of a retained mode visual system. The Visual class supports basic position and clipping and can have 2D and 3D transformations applied to them. Additional functionality like solid colors, images, and content with effects is provided through subclasses like [SpriteVisual](spritevisual.md) or [ContainerVisual](containervisual.md), and by setting the [Brush](spritevisual_brush.md) property of the visual to CompositionBrush subclasses such as [CompositionColorBrush](compositioncolorbrush.md), [CompositionEffectBrush](compositioneffectbrush.md), or [CompositionSurfaceBrush](compositionsurfacebrush.md).

Visual objects are thread-agile and not bound to the UI thread.

### Animatable properties

The following properties can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate the property with a [CompositionAnimation](https://docs.microsoft.com/windows/uwp/composition/composition-animation).

+ [Size](visual_size.md)
+ [Offset](visual_offset.md)
+ [Opacity](visual_opacity.md)
+ [Orientation](visual_orientation.md)
+ [CenterPoint](visual_centerpoint.md)
+ [RotationAngle](visual_rotationangle.md)
+ [RotationAngleInDegrees](visual_rotationangleindegrees.md)
+ [RotationAxis](visual_rotationaxis.md)
+ [TransformMatrix](visual_transformmatrix.md)

### Rotation

Visual supports two forms of rotation:

+ axis-angle

    Axis-angle rotation uses the [RotationAngle](visual_rotationangle.md), [RotationAxis](visual_rotationaxis.md), and [CenterPoint](visual_centerpoint.md) properties to specify the rotation in degrees, which axis to rotate around, and the center point of the visual to rotate around.
+ orientation

    Rotation by orientation uses the [Orientation](visual_orientation.md) property to specify a quaternion describing an orientation and rotation in 3D space.

## -examples

## -see-also

[Composition Visual Tree Overview](https://go.microsoft.com/fwlink/p/?LinkID=699335), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620483)
