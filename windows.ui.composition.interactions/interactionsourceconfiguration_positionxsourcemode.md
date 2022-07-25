---
-api-id: P:Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public InteractionSourceRedirectionMode PositionXSourceMode { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode

## -description

Gets or sets a value that indicates how interactions are processed for this [VisualInteractionSource](visualinteractionsource.md) input on the X axis.



## -property-value

The source mode for the X axis. By default, it takes the value of [VisualInteractionTracker.PositionXSourceMode](visualinteractionsource_positionxsourcemode.md).

## -remarks

This property overrides the configuration of [VisualInteractionSource.PositionXSourceMode](visualinteractionsource_positionxsourcemode.md). It must be enabled to allow the [VisualInteractionSource](visualinteractionsource.md) to send X-axis data to [InteractionTracker](interactiontracker.md).

For more info, see [VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md).

## -see-also

[VisualInteractionSource.PointerWheelConfig](visualinteractionsource_pointerwheelconfig.md), [VisualInteractionSource.PositionXSourceMode](visualinteractionsource_positionxsourcemode.md)

## -examples
