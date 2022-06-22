---
-api-id: T:Windows.UI.Composition.Interactions.InteractionSourceMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.Interactions.InteractionSourceMode : int
-->

# InteractionSourceMode

## -description
Provides the various definitions for how a [VisualInteractionSource](visualinteractionsource.md) will process interactions. Options available for the enumeration are 
    **Disabled**
  , 
    **EnabledWithInertia**
   and 
    **EnabledWithoutInertia**
  . The InteractionSourceMode can be used to define the behavior for the X, Y and Scale Axis of a [VisualInteractionSource](visualinteractionsource.md).



## -enum-fields
### -field Disabled:0
Interaction is disabled.

### -field EnabledWithInertia:1
Interaction is enabled with inertia.

### -field EnabledWithoutInertia:2
Interaction is enabled without inertia.


## -remarks

## -examples


```csharp

void SetupInteractionSource(ContainerVisual container, InteractionTracker 	tracker)
{
  // Setup the Interaction Source
  _interactionSource = VisualInteractionSource.Create(container);
  // Define the Source Modes for X, Y, and Scale.
  _interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithoutInertia;
  _interactionSource.ScaleSourceMode = InteractionSourceMode.Disabled;
  // Attach the VisualInteractionSource to InteractionTracker
  tracker.InteractionSources.Add(_interactionSource);
}
         
```



## -see-also
