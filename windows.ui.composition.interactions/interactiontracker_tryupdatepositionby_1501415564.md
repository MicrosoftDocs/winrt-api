---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionBy(Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax
public int TryUpdatePositionBy(Windows.Foundation.Numerics.Vector3 amount)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionBy

## -description
Tries to adjust the [InteractionTracker](interactiontracker.md)'s position by the specified amount.

The TryUpdatePositionBy method updates the current location of [InteractionTracker](interactiontracker.md) by the Vector3 delta specified as a parameter. Similarly to [TryUpdatePosition](interactiontracker_tryupdateposition_207785016.md), TryUpdatePositionBy is used to declaratively move [InteractionTracker](interactiontracker.md) by a defined delta without the need of an animation or Inertia. TryUpdatePositionBy can be called from either the Idle, CustomAnimation or Inertia state – doing so will move the position of [InteractionTracker](interactiontracker.md) by the defined delta and enter the idle state.



## -parameters
### -param amount
The value to add to the current position.

## -returns
Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks
If InteractionTracker is in its Interacting State (user actively manipulating), and TryUpdatePositionBy is called, the system will ignore this request – an event gets fired when this occurs that can be listened for. If sent from one of the other states, listen for the event fired for IdleStateEntered and check the RequestId property that identifies which request triggered the callback. The table below summarizes the expected behavior when this method is called in a particular state:

<table>
   <tr><th>Current State</th><th>Outcome</th></tr>
   <tr><td>Idle</td><td>Property updates to requested value, no state changes</td></tr>
   <tr><td>Interacting</td><td>Request ignored</td></tr>
   <tr><td>Inertia</td><td>Property updates to requested value, state changes to Idle</td></tr>
   <tr><td>CustomAnimation</td><td>Property updates to requested value, state changes to Idle</td></tr>
</table>

## -examples
```csharp

public void InertiaStateEntered(InteractionTracker sender, 	InteractionTrackerInertiaStateEnteredArgs args)
{
  // For sample purpose, will overwrite Inertia motion definitions by moving InteractionTracker to a specified position based on a delta
  _tracker.TryUpdatePositionBy(new Vector3(50f));}
}
         
```



## -see-also
