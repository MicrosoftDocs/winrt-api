---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScale(System.Single,Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
---

<!-- Method syntax
public int TryUpdateScale(System.Single value, Windows.Foundation.Numerics.Vector3 centerPoint)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdateScale

## -description
Tries to update the scale to the specified value.

The TryUpdateScale method updates the scale location of [InteractionTracker](interactiontracker.md) to the Scale position and centerpoint specified as a parameter. TryUpdateScale is used to declaratively define the scale of [InteractionTracker](interactiontracker.md) at any point in time (either at start, from some state-entered event, etc.). TryUpdateScale can be called from either the Idle, CustomAnimation or Inertia state – doing so will move the scale position of [InteractionTracker](interactiontracker.md) to the defined position and enter the idle state.



## -parameters
### -param value
The new value for scale.

### -param centerPoint
The new center point.

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
If [InteractionTracker](interactiontracker.md) is in its Interacting State (user actively manipulating), and TryUpdateScale is called, the system will ignore this request – an event gets fired when this occurs that can be listened for. If sent from one of the other states, listen for the event fired for IdleStateEntered and check the RequestID property that identifies which request triggered the callback.

The table below summarizes the expected behavior when this method is called in a particular state:

<table>
   <tr><th>Current State</th><th>Outcome</th></tr>
   <tr><td>Idle</td><td>Property updates to requested value, no state changes</td></tr>
   <tr><td>Interacting</td><td>Request ignored</td></tr>
   <tr><td>Inertia</td><td>Property updates to requested value, state changes to Idle</td></tr>
   <tr><td>CustomAnimation</td><td>Property updates to requested value, state changes to Idle</td></tr>
</table>

## -examples
```csharp

void SetupInteractionTracker()
{
  // Setup InteractionTracker
  _tracker = InteractionTracker.Create(_compositor);
  _interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;

  _tracker.InteractionSources.Add(_interactionSource);
  _tracker.PositionInertiaDecayRate = new Vector3(0.95f);

  // Update the scale position of InteractionTracker
  _tracker.TryUpdateScale(0.5f, new Vector3(50f));
}
         
```



## -see-also
