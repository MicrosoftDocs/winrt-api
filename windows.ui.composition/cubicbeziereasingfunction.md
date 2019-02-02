---
-api-id: T:Windows.UI.Composition.CubicBezierEasingFunction
-api-type: winrt class
---

<!-- Class syntax.
public class CubicBezierEasingFunction : Windows.UI.Composition.CompositionEasingFunction, Windows.UI.Composition.ICubicBezierEasingFunction
-->

# Windows.UI.Composition.CubicBezierEasingFunction

## -description
Represents a cubic-bezier function for interpolating between animation key frames.

The cubic-bezier function is one of the more common easing functions used with [KeyFrameAnimation](keyframeanimation.md) s and are used frequently to describe smooth curves that can be scaled. Cubic-bezier functions are defined by two “control points” of type Vector2 that define the shape of the curve. When used, the animating property will change in between two keyframes based on the defined curve.

## -remarks
There are numerous web services like [this one](https://go.microsoft.com/fwlink/?LinkId=809223) that allow you to visualize how the two control points affect the shape of the cubic-bezier. The values you define here are the same values that get inputted into each Vector2 component.

## -examples


```csharp

// Construct the cubic-bezier off your Compositor
CubicBezierEasingFunction cubicBezier = _compositor.CreateCubicBezierEasingFunction(new Vector2(.17f, .67f), new Vector2(1f, 1f));
ScalarKeyFrameAnimation animation = _compositor.CreateScalarKeyFrameAnimation();

// Apply the cubic-bezier to a KeyFrame
animation.InsertKeyFrame(0.0f, 1.0f);
          
```



## -see-also
[Composition Animations Overview](https://go.microsoft.com/fwlink/p/?LinkID=692060), [CompositionEasingFunction](compositioneasingfunction.md), [IClosable](../windows.foundation/iclosable.md)
