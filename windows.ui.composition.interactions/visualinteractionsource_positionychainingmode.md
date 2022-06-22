---
-api-id: P:Windows.UI.Composition.Interactions.VisualInteractionSource.PositionYChainingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.Interactions.InteractionChainingMode PositionYChainingMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.PositionYChainingMode

## -description
The PositionYChainingMode property defines the chaining behavior for an InteractionSource in the Y direction. There are three types of [InteractionChainingMode](interactionchainingmode.md) s: 
    **Auto**
  , 
    **Always**
  , 
    **Never**
  . When chaining in the Y direction is enabled, input will flow to the nearest ancestor’s [VisualInteractionSource](visualinteractionsource.md) whenever the interaction (such as panning) would otherwise take [InteractionTracker](interactiontracker.md) ’s position past its minimum or maximum Y position.



## -property-value
Chaining mode for the Y-axis.

## -remarks

## -examples
```csharp

void SetupInteractionSource(ContainerVisual container, InteractionTracker 	tracker)
{
  // Setup the Interaction Source
  _interactionSource = VisualInteractionSource.Create(container);
  // Enable chaining for the Y direction.
  _interactionSource.PositionYChainingMode = InteractionChainingMode.Always;
  // Attach the VisualInteractionSource to InteractionTracker
  tracker.InteractionSources.Add(_interactionSource);
}
          
```



## -see-also
