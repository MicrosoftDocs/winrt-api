---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScaleWithAdditionalVelocity(System.Single,Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
---

<!-- Method syntax
public int TryUpdateScaleWithAdditionalVelocity(System.Single velocityInPercentPerSecond, Windows.Foundation.Numerics.Vector3 centerPoint)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScaleWithAdditionalVelocity

## -description
Tries to update the scale by adding the specified velocity.

The TryUpdateScaleWithAdditionalVelocity method adds the inputted scalar representing additional velocity to the current velocity of [InteractionTracker](interactiontracker.md) as well as shifts the centerpoint to the inputted Vector3. As a result, because the velocity of [InteractionTracker](interactiontracker.md) has now changed, the targeted rest scale position for [InteractionTracker](interactiontracker.md) now changes. TryUpdateScaleWithAdditionalVelocity can be called from either Idle, Inertia or CustomAnimation states – doing so will either add or update the velocity of InteractionTracker and enter the Inertia state.



## -parameters
### -param velocityInPercentPerSecond
The velocity to add to the scale.

### -param centerPoint
The new center point.

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
If [InteractionTracker](interactiontracker.md) is in its Interacting State (user actively manipulating), and TryUpdateScaleWithAdditionalVelocity is called, the system will ignore this request – an event gets fired when this occurs that can be listened for. If sent from one of the other states, listen for the event fired for [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) and check the RequestId property that identifies which request triggered the callback.

The table below summarizes the expected behavior when this method is called in a particular state:

<table>
   <tr><th>Current State</th><th>Outcome</th></tr>
   <tr><td>Idle</td><td>State changes to inertia and inertia modifiers are evaluated with requested velocity as initial velocity</td></tr>
   <tr><td>Interacting</td><td>Request ignored</td></tr>
   <tr><td>Inertia</td><td>Inertia is restarted (state re-enters inertia) and inertia modifiers are evaluated with requested velocity added to current velocity</td></tr>
   <tr><td>CustomAnimation</td><td>Current animation stops and state changes to inertia with inertia modifiers evaluated using requested velocity as initial velocity</td></tr>
</table>

## -examples
```csharp

// Listen for the InertiaStateEntered event
public void InertiaStateEntered(InteractionTracker sender, 	InteractionTrackerInertiaStateEnteredArgs args)
{
  // Adding velocity to InteractionTracker if condition met
  if (_extraVelocityNeeded)
  {
    // Adding velocity to the scale motion.
    _tracker.TryUpdateScaleWithAdditionalVelocity(3.0f, new Vector3(75f));
  }
}
         
```



## -see-also
