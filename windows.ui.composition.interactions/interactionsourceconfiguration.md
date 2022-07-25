---
-api-id: T:Windows.UI.Composition.Interactions.InteractionSourceConfiguration
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class InteractionSourceConfiguration : CompositionObject, CompositionObject
-->

# Windows.UI.Composition.Interactions.InteractionSourceConfiguration

## -description

Represents the configuration of a VisualInteractionSource input.



## -remarks

By default, [VisualInteractionSource](visualinteractionsource.md) uses the same configuration for all types of input. InteractionSourceConfiguration lets you override the default configuration for a specific type of input.

For example, you might use touch and touchpad inputs to control panning (X, Y) and zoom, but use pointer wheel input only for zoom. In this case, you can use the InteractionSourceConfiguration returned by [VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md) to override the configuration of [PositionXSourceMode](visualinteractionsource_positionxsourcemode.md) and [PositionYSourceMode](visualinteractionsource_positionysourcemode.md) and disable them for pointer wheel input only.

```csharp
// Set the defaults for the VisualInteractionSource.
interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;
interactionSource.ScaleSourceMode = InteractionSourceMode.EnabledWithInertia;

// Modify the pointer wheel configuration to disable X and Y.
// PointerWheelConfig returns an instance of InteractionSourceConfiguration.
interactionSource.PointerWheelConfig.PositionXSourceMode =
    InteractionSourceRedirectionMode.Disabled;
interactionSource.PointerWheelConfig.PositionYSourceMode =
    InteractionSourceRedirectionMode.Disabled;
```

## -see-also

[VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md)

## -examples
