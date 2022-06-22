---
-api-id: P:Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public InteractionSourceRedirectionMode ScaleSourceMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode

## -description

Gets or sets a value that indicates how interactions are processed for this [VisualInteractionSource](visualinteractionsource.md) input on the scale axis.



## -property-value

The source mode for the scale axis. By default, it takes the value of [VisualInteractionTracker.ScaleSourceMode](visualinteractionsource_scalesourcemode.md).

## -remarks

This property overrides the configuration of [VisualInteractionSource.ScaleSourceMode](visualinteractionsource_scalesourcemode.md). It must be enabled to allow the [VisualInteractionSource](visualinteractionsource.md) to send scale data to [InteractionTracker](interactiontracker.md).

For more info, see [VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md).

## -see-also

[VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md), [VisualInteractionSource.ScaleSourceMode](visualinteractionsource_scalesourcemode.md)

## -examples
