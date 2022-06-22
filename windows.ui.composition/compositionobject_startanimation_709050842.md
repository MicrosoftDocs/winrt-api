---
-api-id: M:Windows.UI.Composition.CompositionObject.StartAnimation(System.String,Windows.UI.Composition.CompositionAnimation)
-api-type: winrt method
---

<!-- Method syntax
public void StartAnimation(System.String propertyName, Windows.UI.Composition.CompositionAnimation animation)
-->

# Windows.UI.Composition.CompositionObject.StartAnimation

## -description
Connects an animation with the specified property of the object and starts the animation.



## -parameters
### -param propertyName
The property to associate the animation with.

### -param animation
The animation to associate with the specified property.

## -remarks
If an animation is already bound to an object's property when StartAnimation is called, the previous applied animation will be disconnected and the new animation will be assigned. Similarly, setting the property directly will cause the previous animation to be disconnected and the new property value will take effect.

The following table shows the list of animatable properties:

| Object | Property Name | Property Type |
|---------|---------|---------|
| [Visual](visual.md) | [AnchorPoint](visual_anchorpoint.md) | Vector2 |
|  | [CenterPoint](visual_centerpoint.md) | Vector3 |
|  | [Offset](visual_offset.md) | Vector3 |
|  | [Opacity](visual_opacity.md) | Scalar |
|  | [Orientation](visual_orientation.md) | Vector4 |
|  | [RotationAngle](visual_rotationangle.md) | Scalar |
|  | [RotationAxis](visual_rotationaxis.md) | Vector3 |
|  | [Size](visual_size.md) | Vector2 |
|  | [TransformMatrix](visual_transformmatrix.md) | Matrix4x4 |
| [InsetClip](insetclip.md) | [BottomInset](insetclip_bottominset.md) | Scalar |
|  | [LeftInset](insetclip_leftinset.md) | Scalar |
|  | [RightInset](insetclip_rightinset.md) | Scalar |
|  | [TopInset](insetclip_topinset.md) | Scalar |
| [CompositionColorBrush](compositioncolorbrush.md) | [Color](compositioncolorbrush_color.md) | Windows.UI.Color |
| [CompositionPropertySet](compositionpropertyset.md) | Set of properties specified by the developer. |  |

In addition, properties of some effects under the [CompositionEffectBrush](compositioneffectbrush.md) object can be animated:

| Effect Name | Property Name | Property Type |
|---|---|---|
| SaturationEffect | Saturation | Scalar |
| ColorSourceEffect | Color | Vector4 |
| ArithmeticComposite | Offset | Scalar |
| | Source1Amount | Scalar |
| | Source2Amount | Scalar |
| | MultiplyAmount | Scalar |
| Transform2D | TransformMatrix | Matrix3x2 |
| ContrastEffect | Contrast | Float |
| ExposureEffect | Exposure | Float |
| HueRotationEffect | Angle | Float |
| SepiaEffect | Intensity | Float |
| TemperatureAndTintEffect | Temperature | Float |
| | Tint | Float |
| GammaTransferEffect | RedAmplitude | Float |
| | RedExponent | Float |
| | RedOffset | Float |
| | GreenAmplitude | Float |
| | GreenExponent | Float |
| | GreenOffset | Float |
| | BlueAmplitude | Float |
| | BlueExponent | Float |
| | BlueOffset | Float |
| | AlphaAmplitude | Float |
| | AlphaExponent | Float |
| | AlphaOffset | Float |

## -examples
```csharp

void AnimatingVisualOffset(Visual targetVisual) 
{ 
    var animation = _compositor.CreateVector3KeyFrameAnimation(); 

    // 
    // Define specific easing functions. 
    // 


    var linear = _compositor.CreateLinearEasingFunction(); 

    var easeIn = _compositor.CreateCubicBezierEasingFunction( 
            new Vector2(0.5f, 0.0f), new Vector2(1.0f, 1.0f)); 

    var easeOut = _compositor.CreateCubicBezierEasingFunction( 
            new Vector2(0.0f, 0.0f), new Vector2(0.5f, 1.0f)); 

    // 
    // Add a set of key frames to describe how the Offset should change over time.   
    // 

    animation.InsertKeyFrame(0.00f, new Vector3(100.0f, 100.0f, 0.0f)); 
    animation.InsertKeyFrame(0.25f, new Vector3(300.0f, 100.0f, 0.0f), easeIn); 
    animation.InsertKeyFrame(0.50f, new Vector3(300.0f, 300.0f, 0.0f), linear); 
    animation.InsertKeyFrame(0.75f, new Vector3(100.0f, 300.0f, 0.0f), linear); 
    animation.InsertKeyFrame(1.00f, new Vector3(100.0f, 100.0f, 0.0f), easeOut); 

    // 
    // The animation curve defined by the key frames will scale to match the duration. 
    // 

    animation.Duration = TimeSpan.FromMilliseconds(4000); 

    targetVisual.StartAnimation("Offset", animation); 
} 
          
          
```



## -see-also
