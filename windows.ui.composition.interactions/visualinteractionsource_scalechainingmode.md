---
-api-id: P:Windows.UI.Composition.Interactions.VisualInteractionSource.ScaleChainingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.Interactions.InteractionChainingMode ScaleChainingMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.ScaleChainingMode

## -description
The ScaleChainingMode property defines the chaining behavior for an InteractionSource in the Scale direction. There are three types of [InteractionChainingMode](interactionchainingmode.md) s: Auto, Always, Never. When Scale chaining is enabled, input will flow to the nearest ancestor’s [VisualInteractionSource](visualinteractionsource.md) whenever the interaction (such as panning) would otherwise take [InteractionTracker](interactiontracker.md) ’s position past it’s minimum or maximum Scale position.



## -property-value
Chaining mode for the scale axis.

## -remarks

## -examples
```csharp

void SetupInteractionSource(ContainerVisual container, InteractionTracker 	tracker)
{
  // Setup the Interaction Source
  _interactionSource = VisualInteractionSource.Create(container);
  // Auto chaining for Scale
  _interactionSource.ScaleChainingMode = InteractionChainingMode.Auto;    
  // Attach the VisualInteractionSource to InteractionTracker
  tracker.InteractionSources.Add(_interactionSource);
}
          
```



## -see-also
