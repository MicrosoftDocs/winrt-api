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

<table>
   <tr><th>Object</th><th>Property Name</th><th>Property Type</th></tr>
   <tr><td>[Visual](visual.md)</td><td>[AnchorPoint](visual_anchorpoint.md)</td><td>Vector2</td></tr>
   <tr><td /><td>[CenterPoint](visual_centerpoint.md)</td><td>Vector3</td></tr>
   <tr><td /><td>[Offset](visual_offset.md)</td><td>Vector3</td></tr>
   <tr><td /><td>[Opacity](visual_opacity.md)</td><td>Scalar</td></tr>
   <tr><td /><td>[Orientation](visual_orientation.md)</td><td>Vector4</td></tr>
   <tr><td /><td>[RotationAngle](visual_rotationangle.md)</td><td>Scalar</td></tr>
   <tr><td /><td>[RotationAxis](visual_rotationaxis.md)</td><td>Vector3</td></tr>
   <tr><td /><td>[Size](visual_size.md)</td><td>Vector2</td></tr>
   <tr><td /><td>[TransformMatrix](visual_transformmatrix.md)</td><td>Matrix4x4</td></tr>
   <tr><td>[InsetClip](insetclip.md)</td><td>[BottomInset](insetclip_bottominset.md)</td><td>Scalar</td></tr>
   <tr><td /><td>[LeftInset](insetclip_leftinset.md)</td><td>Scalar</td></tr>
   <tr><td /><td>[RightInset](insetclip_rightinset.md)</td><td>Scalar</td></tr>
   <tr><td /><td>[TopInset](insetclip_topinset.md)</td><td>Scalar</td></tr>
   <tr><td>[CompositionColorBrush](compositioncolorbrush.md)</td><td>[Color](compositioncolorbrush_color.md)</td><td>Windows.UI.Color</td></tr>
   <tr><td>[CompositionPropertySet](compositionpropertyset.md)</td><td>Set of properties specified by the developer.</td><td /></tr>
</table>

In addition, properties of some effects under the [CompositionEffectBrush](compositioneffectbrush.md) object can be animated:

<table>
   <tr><th>Effect Name</th><th>Property Name</th><th>Property Type</th></tr>
   <tr><td>SaturationEffect</td><td>Saturation</td><td>Scalar</td></tr>
   <tr><td>ColorSourceEffect</td><td>Color</td><td>Vector4</td></tr>
   <tr><td>ArithmeticComposite</td><td>Offset</td><td>Scalar</td></tr>
   <tr><td /><td>Source1Amount</td><td>Scalar</td></tr>
   <tr><td /><td>Source2Amount</td><td>Scalar</td></tr>
   <tr><td /><td>MultiplyAmount</td><td>Scalar</td></tr>
   <tr><td>Transform2D</td><td>TransformMatrix</td><td>Matrix3x2</td></tr>
   <tr><td>ContrastEffect</td><td>Contrast</td><td>Float</td></tr>
   <tr><td>ExposureEffect</td><td>Exposure</td><td>Float</td></tr>
   <tr><td>HueRotationEffect</td><td>Angle</td><td>Float</td></tr>
   <tr><td>SepiaEffect</td><td>Intensity</td><td>Float</td></tr>
   <tr><td>TemperatureAndTintEffect</td><td>Temperature</td><td>Float</td></tr>
   <tr><td /><td>Tint</td><td>Float</td></tr>
   <tr><td>GammaTransferEffect</td><td>RedAmplitude</td><td>Float</td></tr>
   <tr><td /><td>RedExponent</td><td>Float</td></tr>
   <tr><td /><td>RedOffset</td><td>Float</td></tr>
   <tr><td /><td>GreenAmplitude</td><td>Float</td></tr>
   <tr><td /><td>GreenExponent</td><td>Float</td></tr>
   <tr><td /><td>GreenOffset</td><td>Float</td></tr>
   <tr><td /><td>BlueAmplitude</td><td>Float</td></tr>
   <tr><td /><td>BlueExponent</td><td>Float</td></tr>
   <tr><td /><td>BlueOffset</td><td>Float</td></tr>
   <tr><td /><td>AlphaAmplitude</td><td>Float</td></tr>
   <tr><td /><td>AlphaExponent</td><td>Float</td></tr>
   <tr><td /><td>AlphaOffset</td><td>Float</td></tr>
</table>

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
