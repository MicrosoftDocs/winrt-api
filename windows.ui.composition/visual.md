---
-api-id: T:Windows.UI.Composition.Visual
-api-type: winrt class
---

<!-- Class syntax.
public class Visual : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.IVisual, Windows.UI.Composition.IVisual2
-->

# Windows.UI.Composition.Visual

## -description


> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**


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

## Visual.IsHitTestVisible property

> [!IMPORTANT]
> The **Visual.IsHitTestVisible** property is available only in pre-release versions of the [Windows 10 Insider Preview](https://www.microsoft.com/software-download/windowsinsiderpreviewSDK), build 19582 and later.

Gets or sets whether the visual sub-tree rooted at this visual participates in hit testing.

```csharp
public bool IsHitTestVisible { get; set; }
```

```cppwinrt
bool IsHitTestVisible();

void IsHitTestVisible(bool ishittestvisible);
```

```cppcx
public : Platform::Boolean IsHitTestVisible { get; set; }
```

```vb
Public ReadWrite Property IsHitTestVisible As bool
```

### Property value

`true` if the visual sub-tree rooted at this visual participates in hit testing; otherwise, `false`. The default is `true`.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ParentForTransform |
| 1703 | 15063 | RelativeOffsetAdjustment |
| 1703 | 15063 | RelativeSizeAdjustment |

## -examples

## -see-also

[Composition Visual Tree Overview](https://docs.microsoft.com/en-us/windows/uwp/composition/composition-visual-tree), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CompositionVisual)
