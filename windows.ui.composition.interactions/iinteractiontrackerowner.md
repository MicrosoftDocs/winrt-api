---
-api-id: T:Windows.UI.Composition.Interactions.IInteractionTrackerOwner
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IInteractionTrackerOwner : 
-->

# Windows.UI.Composition.Interactions.IInteractionTrackerOwner

## -description
Contains callbacks that will be triggered by InteractionTracker events.

Implementing this interface enables receiving callbacks regarding the state and values of the [InteractionTracker](interactiontracker.md), as well as whether requested updates to the [InteractionTracker](interactiontracker.md) ’s properties are honored.



## -remarks
Implementing IInteractionTrackerOwner is required if the application needs to have updates on the state or values of the [InteractionTracker](interactiontracker.md). Due to the asynchronous nature of this model, these callbacks are the best way to update application logic. To learn more about the [InteractionTracker](interactiontracker.md) states and transitions, see [InteractionTracker](interactiontracker.md).

An [InteractionTracker](interactiontracker.md) can be created with or without an owner. Creating the [InteractionTracker](interactiontracker.md) with an owner is required for registering for callbacks. If these callbacks are not important for application state, then creating an [InteractionTracker](interactiontracker.md) without an owner is appropriate.

Creating an [InteractionTracker](interactiontracker.md) with an owner also requires appropriately disposing the [InteractionTracker](interactiontracker.md) when appropriate.

## -examples


```csharp

class InteractionBehavior : Behavior<UIElement>, IInteractionTrackerOwner
{
  public void CustomAnimationStateEntered(InteractionTracker sender, InteractionTrackerCustomAnimationStateEnteredArgs args)
  {
    //Logic to run when InteractionTracker enters CustomAnimation 
  }

  public void IdleStateEntered(InteractionTracker sender, InteractionTrackerIdleStateEnteredArgs args)
  {
    //Logic to run when InteractionTracker enters Idle
  }

  public void InertiaStateEntered(InteractionTracker sender, InteractionTrackerInertiaStateEnteredArgs args)
  {
    //Logic to run when InteractionTracker enters Inertia
  }

  public void InteractingStateEntered(InteractionTracker sender, InteractionTrackerInteractingStateEnteredArgs args)
  {
    //Logic to run when InteractionTracker enters Interacting
  }

  public void RequestIgnored(InteractionTracker sender, InteractionTrackerRequestIgnoredArgs args)
  {
    //Logic to run when a request to update position or scale is ignored
  }

  public void ValuesChanged(InteractionTracker sender, InteractionTrackerValuesChangedArgs args)
  {

    //Logic to run when position or scale change
  }
}
         
         
```



## -see-also
