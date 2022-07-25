---
-api-id: P:Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public InteractionSourceRedirectionMode PositionYSourceMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode

## -description

Gets or sets a value that indicates how interactions are processed for this [VisualInteractionSource](visualinteractionsource.md) input on the Y axis.



## -property-value

The source mode for the Y axis. By default, it takes the value of [VisualInteractionTracker.PositionYSourceMode](visualinteractionsource_positionysourcemode.md).

## -remarks

This property overrides the configuration of [VisualInteractionSource.PositionYSourceMode](visualinteractionsource_positionysourcemode.md). It must be enabled to allow the [VisualInteractionSource](visualinteractionsource.md) to send Y-axis data to [InteractionTracker](interactiontracker.md).

For more info, see [VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md).

## -see-also

[VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md)
[VisualInteractionSource.PositionYSourceMode](visualinteractionsource_positionysourcemode.md)

## -examples

