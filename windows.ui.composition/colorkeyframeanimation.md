---
-api-id: T:Windows.UI.Composition.ColorKeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class ColorKeyFrameAnimation : Windows.UI.Composition.KeyFrameAnimation, Windows.UI.Composition.IColorKeyFrameAnimation
-->

# Windows.UI.Composition.ColorKeyFrameAnimation

## -description
A time-based animation that targets the Color property with one or more color key frames.

The [ColorKeyFrameAnimation](colorkeyframeanimation.md) class is one of the supported types of [KeyFrameAnimation](keyframeanimation.md) s that is used to animate the [Color](compositioncolorbrush_color.md) property off of the [Brush](spritevisual_brush.md) property on a [SpriteVisual](spritevisual.md). When working with [ColorKeyFrameAnimation](colorkeyframeanimation.md) s, utilize Windows.UI.Color objects for the values of keyframes. Utilize the InterpolationColorSpace property to define which color space the system will interpolate through for the animation.

## -remarks
An animation is associated with an object's property by calling [CompositionObject::StartAnimation](compositionobject_startanimation.md) and specifying the property name and the animation. See the remarks section of [CompositionObject::StartAnimation](compositionobject_startanimation.md) for a list of animatable properties.

## -examples


```csharp

void ColorAnimation(SpriteVisual visual)
{
  // Create the ColorKeyFrameAnimation
  var colorAnimation = _compositor.CreateColorKeyFrameAnimation();

  // Create the KeyFrames using Windows.UI.Color objects
  colorAnimation.InsertKeyFrame(0.5f, Colors.Purple);
  colorAnimation.InsertKeyFrame(1.0f, Colors.Cyan);

  // Set the interpolation to go through the HSL space
  colorAnimation.InterpolationColorSpace = CompositionColorSpace.Hsl;
  colorAnimation.Duration = TimeSpan.FromSeconds(3);
 
  // Apply the cubic-bezier to a KeyFrame
  visual.Brush.StartAnimation("Color", colorAnimation);
}
          
```



## -see-also
[Composition Animations Overview](http://go.microsoft.com/fwlink/p/?LinkID=692060), [KeyFrameAnimation](keyframeanimation.md), [IClosable](../windows.foundation/iclosable.md)