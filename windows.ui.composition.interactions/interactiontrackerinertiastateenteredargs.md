---
-api-id: T:Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs
-api-type: winrt class
---

<!-- Class syntax.
public class InteractionTrackerInertiaStateEnteredArgs : Windows.UI.Composition.Interactions.IInteractionTrackerInertiaStateEnteredArgs
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs

## -description
Arguments for the [IInteractionTrackerOwner.InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) callback.

The [InteractionTrackerOwner.InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) class defines the accessible and up-to-date property values when [InteractionTracker](interactiontracker.md) enters the inertia state. If registered for the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event, values of this object's properties represent the results calculated by the system at the beginning of the inertia state. Using the modified and natural resting positions helps enables scenarios such as scrolling virtualization.



## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | IsInertiaFromImpulse |
| 1903 | 18362 | IsFromBinding |

## -examples


```csharp

public void InertiaStateEntered(InteractionTracker sender, 	InteractionTrackerInertiaStateEnteredArgs args)
{
  // Natural and Modified Resting Positions and Scale
  Vector3 naturalRestPos = args.NaturalRestingPosition;
  Vector3 modifiedRestPos = (Vector3)args.ModifiedRestingPosition;
  float naturalRestScale = args.NaturalRestingScale;
  float modifiedRestScale = (float) args.ModifiedRestingScale;

  // Position and Scale velocity of InteractionTracker when entering Inertia
  Vector3 posVelocity = args.PositionVelocityInPixelsPerSecond;
  float scaleVelocity = args.ScaleVelocityInPercentPerSecond;

  // The ID for the request that triggered the callback
  int id = args.RequestId;
}
         
```



## -see-also
