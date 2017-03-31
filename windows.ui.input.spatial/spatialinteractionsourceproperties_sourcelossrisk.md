---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.SourceLossRisk
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public double SourceLossRisk { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.SourceLossRisk

## -description
Gets the risk that detection of a hand or spatial controller will be lost as a value from 0.0 to 1.0.

## -property-value
The source loss risk.

## -remarks
 As the value nears 1.0, you should suggest that the user moves this source in the direction indicated by [TryGetSourceLossMitigationDirection](spatialinteractionsourceproperties_trygetsourcelossmitigationdirection.md).

## -examples

## -see-also
