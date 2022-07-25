---
-api-id: P:Windows.UI.Composition.Interactions.VisualInteractionSource.PositionXChainingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.Interactions.InteractionChainingMode PositionXChainingMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.PositionXChainingMode

## -description
The PositionXChainingMode property defines the chaining behavior for an InteractionSource in the X direction. There are three types of [InteractionChainingMode](interactionchainingmode.md) s: 
    **Auto**
  , 
    **Always**
  , 
    **Never**
  . When chaining in the X direction is enabled, input will flow to the nearest ancestor's [VisualInteractionSource](visualinteractionsource.md) whenever the interaction (such as panning) would otherwise take [InteractionTracker](interactiontracker.md) ’s position past its minimum or maximum X position.



## -property-value
Chaining mode for the X-axis.

## -remarks

## -examples
```csharp

void SetupInteractionSource(ContainerVisual container, InteractionTracker tracker)
{
  // Setup the Interaction Source
  _interactionSource = VisualInteractionSource.Create(container);
  // Disable chaining on the X component.
  _interactionSource.PositionXChainingMode = InteractionChainingMode.Never; 
  // Attach the VisualInteractionSource to InteractionTracker
  tracker.InteractionSources.Add(_interactionSource);
}
          
```



## -see-also
