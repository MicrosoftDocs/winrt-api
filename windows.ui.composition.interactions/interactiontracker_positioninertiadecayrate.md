---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.PositionInertiaDecayRate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Vector3> PositionInertiaDecayRate { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.PositionInertiaDecayRate

## -description
Inertia decay rate for position. Range is from 0 to 1.

The PositionInertiaDecayRate property defines the rate at which [InteractionTracker](interactiontracker.md) will slow to a stop when it has entered Inertia and position is changing. The closer to 1, the faster [InteractionTracker](interactiontracker.md) will slow to a stop and vice versa. Defined as a Vector3, each component represents the inertia decay rate for x, y, z accordingly.



## -property-value
Inertia decay rate for position. Range is from 0 to 1.

## -remarks
Below is a graph of the equation that models the PositionInertiaDecayRate property against the position from the starting position of [InteractionTracker](interactiontracker.md) after entering inertia. Note that as the value of the property approaches 1, the impact of inertia increases more significantly.

In the graph, time is on the X axis, and position from the start of the interaction is on the Y. Notice that with a much larger value (closer to 1), the position from start is much smaller and plateaus earlier.

<img src="images/inertiavalues.png" alt="Slopes of inertia values with decay rates of 0.9, 0.6, 0.4, and 0.2." />

## -examples
```csharp

void SetupInteractionTracker()
{
  // Setup InteractionTracker
  _tracker = InteractionTracker.Create(_compositor);

  // Set the PositionInertiaDecayRate value
  _tracker.PositionInertiaDecayRate = new Vector3(0.95f);
}
          
```



## -see-also
