---
-api-id: M:Windows.UI.Xaml.Media.Animation.ConnectedAnimation.SetAnimationComponent(Windows.UI.Xaml.Media.Animation.ConnectedAnimationComponent,Windows.UI.Composition.ICompositionAnimationBase)
-api-type: winrt method
---

<!-- Method syntax.
public void ConnectedAnimation.SetAnimationComponent(ConnectedAnimationComponent component, ICompositionAnimationBase animation)
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimation.SetAnimationComponent

## -description
Sets a custom [CompositionAnimation](./../windows.ui.composition/compositionanimation.md) to change the motion of a particular part of the connected animation.



## -parameters

### -param component

The part of the connected animation to change.

### -param animation

The animation to use in place of the default one.

## -remarks

When creating the animation, use Composition expression strings "StartingValue" and "FinalValue" to represent the starting and ending values from the system. For example:

```csharp
var customKeyFrameAnimation = Window.Compositor.CreateScalarKeyFrameAnimation();
customKeyFrameAnimation.Duration = ConnectedAnimationService.GetForCurrentView().DefaultDuration;
customKeyFrameAnimation.InsertExpressionKeyFrame(0.0f, "StartingValue");
customKeyFrameAnimation.InsertExpressionKeyFrame(0.5f, "FinalValue + 25");
customKeyFrameAnimation.InsertExpressionKeyFrame(1.0f, "FinalValue");

myConnectedAnimation.SetAnimationComponent(ConnectedAnimationComponent.OffsetX, customKeyFrameAnimation);
```

See [Expression Keyframes](/windows/uwp/graphics/composition-animation#expression-keyframes) for more information on using Composition expressions.

## -see-also

## -examples

