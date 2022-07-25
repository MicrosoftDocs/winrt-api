---
-api-id: M:Windows.UI.Composition.Compositor.CreateStepEasingFunction
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.StepEasingFunction CreateStepEasingFunction()
-->

# Windows.UI.Composition.Compositor.CreateStepEasingFunction

## -description
Creates an instance of [StepEasingFunction](stepeasingfunction.md).



## -returns
Returns the created [StepEasingFunction](stepeasingfunction.md) object.

## -remarks

## -examples
```csharp

StepsEasing(Compositor compositor, SpriteVisual heroVisual) 
{ 
  // This step function makes the property offset change in 5 steps  
  // i.e. goes from (0,0,0) à (20,20,20) in 5 steps. 
  StepEasingFunction steps = compositor.CreateStepEasingFunction(); 
  steps.StepCount = 5; 
  Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
  animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f)); 
  animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f), steps); 
  animation.Duration = TimeSpan.FromSeconds(2); 

  // Run animation for 4 times 
  animation.IterationCount = 4; 

  heroVisual.StartAnimation("Offset", animation); 
} 
         
         
```



## -see-also
[CreateStepEasingFunction(Int32)](compositor_createstepeasingfunction_694397864.md)
