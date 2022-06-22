---
-api-id: P:Windows.UI.Composition.Interactions.VisualInteractionSource.PointerWheelConfig
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public InteractionSourceConfiguration PointerWheelConfig { get; }
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.PointerWheelConfig

## -description

Gets the configuration for pointer wheel input.



## -property-value

The configuration for pointer wheel input.

## -remarks

By default, VisualInteractionSource uses the same configuration for all types of input. This property lets you provide a different configuration specifically for pointer wheel input.

For example, you might use touch and touchpad inputs to control panning (X, Y) and zoom, but use pointer wheel input only for zoom. In this case, you can override the configuration of [PositionXSourceMode](visualinteractionsource_positionxsourcemode.md) and [PositionYSourceMode](visualinteractionsource_positionysourcemode.md) to disable them for pointer wheel input only.

```csharp
// Set the defaults for the VisualInteractionSource.
interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;
interactionSource.ScaleSourceMode = InteractionSourceMode.EnabledWithInertia;

// Modify the pointer wheel configuration to disable X and Y.
interactionSource.PointerWheelConfig.PositionXSourceMode =
    InteractionSourceRedirectionMode.Disabled;
interactionSource.PointerWheelConfig.PositionYSourceMode =
    InteractionSourceRedirectionMode.Disabled;
```

## -see-also

## -examples

