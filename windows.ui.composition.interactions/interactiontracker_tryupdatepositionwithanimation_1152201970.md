---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionWithAnimation(Windows.UI.Composition.CompositionAnimation)
-api-type: winrt method
---

<!-- Method syntax
public int TryUpdatePositionWithAnimation(Windows.UI.Composition.CompositionAnimation animation)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionWithAnimation

## -description
Tries to update the [InteractionTracker](interactiontracker.md)'s position by applying an animation.

The TryUpdatePositionWithAnimation method updates the position of [InteractionTracker](interactiontracker.md) based on the [CompositionAnimation](../windows.ui.composition/compositionanimation.md) input as a parameter. This method is used in situations in which the motion of [InteractionTracker](interactiontracker.md) needs to be defined by a specific animation, instead of the traditional Inertia experience. TryUpdatePositionWithAnimation can be called from the Idle or Inertia state – doing so, [InteractionTracker](interactiontracker.md) ’s position will be driven by the defined animation and enter the CustomAnimation state.



## -parameters
### -param animation
The animation to apply to the [InteractionTracker](interactiontracker.md).

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
When creating the animation you want to update [InteractionTracker](interactiontracker.md) ’s position with, you do not need to call [StartAnimation](../windows.ui.composition/compositionobject_startanimation_709050842.md). The system will take care of this behind the scenes once the animation is passed in via TryUpdatePositionWithAnimation.

When defining the animation that will animate [InteractionTracker](interactiontracker.md) ’s position, be sure to either use a [Vector3KeyFrameAnimation](../windows.ui.composition/vector3keyframeanimation.md) or an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that resolves to a Vector3.

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

void CustomAnimationForIT(Vector3 newPosition)
{
  // Create a cubic bezier easing function that will be used in the KeyFrames
  CompositionEasingFunction cubicBezier = _compositor.CreateCubicBezierEasingFunction(new Vector2(.17f, .67f), new Vector2(1f, 1f);
            
  // Create the Vector3 KFA
  Vector3KeyFrameAnimation kfa = _compositor.CreateVector3KeyFrameAnimation();
  kfa.Duration = TimeSpan.FromSeconds(3);

  // Create the KeyFrames
  kfa.InsertKeyFrame(1.0f, newPosition, cubicBezier);

  // Update InteractionTracker position using this animation
  _tracker.TryUpdatePositionWithAnimation(kfa);
}
         
```



## -see-also
