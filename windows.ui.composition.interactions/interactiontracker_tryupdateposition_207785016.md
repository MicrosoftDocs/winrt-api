---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePosition(Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax
public int TryUpdatePosition(Windows.Foundation.Numerics.Vector3 value)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePosition

## -description
Tries to update the [InteractionTracker](interactiontracker.md)'s position.

The TryUpdatePosition method updates the location of [InteractionTracker](interactiontracker.md) to the Vector3 position specified as a parameter. TryUpdatePosition is used to declaratively define the position of [InteractionTracker](interactiontracker.md) at any point in time (either at start, from some state-entered event, etc.). TryUpdatePosition can be called from either the Idle, CustomAnimation or Inertia state – doing so will move the position of [InteractionTracker](interactiontracker.md) to the defined position and enter the idle state.



## -parameters
### -param value
The new position for the [InteractionTracker](interactiontracker.md).

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
If [InteractionTracker](interactiontracker.md) is in its Interacting State (user actively manipulating), and TryUpdatePosition is called, the system will ignore this request – an event gets fired when this occurs that can be listened for. If sent from one of the other states, listen for the event fired for IdleStateEntered and check the RequestId property that identifies which request triggered the callback. The table below summarizes the expected behavior when this method is called in a particular state:

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

  // Update the position of InteractionTracker, so doesn’t start at (0,0)
  _tracker.TryUpdatePosition(new Vector3(50f));
}
         
         
```



## -see-also
