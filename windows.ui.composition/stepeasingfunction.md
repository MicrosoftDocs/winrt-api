---
-api-id: T:Windows.UI.Composition.StepEasingFunction
-api-type: winrt class
---

<!-- Class syntax.
public class StepEasingFunction : Windows.UI.Composition.CompositionEasingFunction, Windows.UI.Composition.IStepEasingFunction
-->

# Windows.UI.Composition.StepEasingFunction

## -description

A step function for interpolating between animation key frames that advances animations in increments like steps which can be can be defined. Behaviors for initial and final steps can be customized.



## -remarks

The step easing function gives more flexibility for animations to advance in increments. Increments are defined using [StepCount](stepeasingfunction_stepcount.md) property. Steps can be customized using [InitialStep](stepeasingfunction_initialstep.md), and [FinalStep](stepeasingfunction_finalstep.md). Behavior for initial step can be customized using [IsInitialStepSingleFrame](stepeasingfunction_isinitialstepsingleframe.md) and final step using [IsFinalStepSingleFrame](stepeasingfunction_isfinalstepsingleframe.md).

To create a new instance of `StepEasingFunction`, call one of these methods:

- [CompositionEasingFunction.CreateStepEasingFunction(owner, stepCount)](compositioneasingfunction_createstepeasingfunction_1100018177.md)
- [CompositionEasingFunction.CreateStepEasingFunction(owner)](compositioneasingfunction_createstepeasingfunction_1998521201.md)
- [Compositor.CreateStepEasingFunction(stepCount)](compositor_createstepeasingfunction_694397864.md)
- [Compositor.CreateStepEasingFunction()](compositor_createstepeasingfunction_1306242288.md)

## -examples

```csharp
class StepsEasing
{
  StepsEasing(Compositor compositor, SpriteVisual heroVisual)
  {
    // This step function makes the property offset change in 5 steps
    // i.e. goes from (0,0,0) à (20,20,20) in 5 steps.
    StepEasingFunction steps = compositor.CreateStepEasingFunction(5);

    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation();
    animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f));
    animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f), steps);
    animation.Duration = TimeSpan.FromSeconds(2);

    heroVisual.StartAnimation("Offset", animation);
  }
}
```

## -see-also

[Composition Animations Overview](/windows/uwp/composition/composition-animation), [CompositionEasingFunction](compositioneasingfunction.md), [IClosable](../windows.foundation/iclosable.md)

