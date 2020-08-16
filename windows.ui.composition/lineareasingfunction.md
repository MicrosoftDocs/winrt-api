---
-api-id: T:Windows.UI.Composition.LinearEasingFunction
-api-type: winrt class
---

<!-- Class syntax.
public class LinearEasingFunction : Windows.UI.Composition.CompositionEasingFunction, Windows.UI.Composition.ILinearEasingFunction
-->

# Windows.UI.Composition.LinearEasingFunction

## -description
Represents a linear function for interpolating between animation key frames.

The linear function of another supported easing function that can be used with KeyFrame Animations. When used, the animating property will change in between two KeyFrames linearly over time.

## -remarks

## -examples


```csharp

// Construct the linear function
LinearEasingFunction linear = _compositor.CreateLinearEasingFunction();
ScalarKeyFrameAnimation animation = _compositor.CreateScalarKeyFrameAnimation();

// Apply the cubic-bezier to a KeyFrame
animation.InsertKeyFrame(0.0f, 1.0f);
animation.InsertKeyFrame(1.0f, 0.0f, linear);
       
```



## -see-also
[Composition Animations Overview](https://docs.microsoft.com/en-us/windows/uwp/composition/composition-animation), [CompositionEasingFunction](compositioneasingfunction.md), [IClosable](../windows.foundation/iclosable.md)
