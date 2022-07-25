---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScaleWithAnimation(Windows.UI.Composition.CompositionAnimation,Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
---

<!-- Method syntax
public int TryUpdateScaleWithAnimation(Windows.UI.Composition.CompositionAnimation animation, Windows.Foundation.Numerics.Vector3 centerPoint)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScaleWithAnimation

## -description
Tries to update the scale with the specified animation.

The TryUpdateScaleWithAnimation method updates the scale position of [InteractionTracker](interactiontracker.md) based on the [CompositionAnimation](../windows.ui.composition/compositionanimation.md) inputted as a parameter. This method is used in situations in which the motion of [InteractionTracker](interactiontracker.md) needs to be defined by a specific animation, instead of the traditional Inertia experience. TryUpdateScaleWithAnimation can be called from the Idle or Inertia state – doing so, [InteractionTracker](interactiontracker.md) ’s position will be driven by the defined animation and enter the CustomAnimation state.



## -parameters
### -param animation
The animation to apply to the scale.

### -param centerPoint
The new center point.

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
When creating the animation you want to update [InteractionTracker](interactiontracker.md) ’s position with, you do not need to call [StartAnimation](../windows.ui.composition/compositionobject_startanimation_709050842.md). The system will take care of this behind the scenes once the animation is passed in via TryUpdateScaleWithAnimation.

When defining the animation that will animate [InteractionTracker](interactiontracker.md) ’s scale position, be sure to either use a [ScalarKeyFrameAnimation](../windows.ui.composition/scalarkeyframeanimation.md) or an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that resolves to a Scalar.

The table below summarizes the expected behavior when this method is called in a particular state:

<table>
   <tr><th>Current State</th><th>Outcome</th></tr>
   <tr><td>Idle</td><td>Requested animation starts on requested property, state changes to CustomAnimation</td></tr>
   <tr><td>Interacting</td><td>Request ignored</td></tr>
   <tr><td>Inertia</td><td>Requested animation starts on requested property, state changes to CustomAnimation</td></tr>
   <tr><td>CustomAnimation</td><td>Current animation stops and new requested animation starts on requested property, state re-enters CustomAnimation</td></tr>
</table>

## -examples
```csharp

void CustomAnimationForIT(float newScale, Vector3 newCenterPoint)
{
  // Create a cubic bezier easing function that will be used in the KeyFrames
  CompositionEasingFunction cubicBezier = _compositor.CreateCubicBezierEasingFunction(new Vector2(.17f, .67f), new Vector2(1f, 1f);
            
  // Create the Vector3 KFA
  ScalarKeyFrameAnimation kfa = _compositor.CreateScalarKeyFrameAnimation();
  kfa.Duration = TimeSpan.FromSeconds(3);

  // Create the KeyFrames
  kfa.InsertKeyFrame(1.0f, newScale, cubicBezier);

  // Update InteractionTracker position using this animation
  _tracker.TryUpdatePositionWithAnimation(kfa, newCenterPoint);
}
         
```



## -see-also
