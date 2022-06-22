---
-api-id: T:Windows.UI.Composition.Vector3KeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class Vector3KeyFrameAnimation : Windows.UI.Composition.KeyFrameAnimation, Windows.UI.Composition.IVector3KeyFrameAnimation
-->

# Windows.UI.Composition.Vector3KeyFrameAnimation

## -description
A time-based animation that targets any Vector3-based property with one or more keyframes.



## -remarks

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

An animation is associated with an object's property by calling [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and specifying the property name and the animation. See the remarks section of [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) for a list of animatable properties.

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
[Composition Animations Overview](/windows/uwp/composition/composition-animation), [KeyFrameAnimation](keyframeanimation.md), [IClosable](../windows.foundation/iclosable.md)
