---
-api-id: P:Windows.Perception.Spatial.SpatialAnchorExportSufficiency.SufficiencyLevel
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public double SufficiencyLevel { get; }
-->

# Windows.Perception.Spatial.SpatialAnchorExportSufficiency.SufficiencyLevel

## -description
Gets the amount of data the spatial anchor has gathered relative to the minimal amount needed to successfully export for the specified purpose.

## -property-value
The amount of data gathered for this export.

## -remarks
An anchor has gathered the minimal amount of data needed to export if it has a [SufficiencyLevel](spatialanchorexportsufficiency_sufficiencylevel.md) >= 1.0, also indicated by [IsMinimallySufficient](spatialanchorexportsufficiency_isminimallysufficient.md).

An anchor has gathered the ideal amount of data needed to export if it has a [SufficiencyLevel](spatialanchorexportsufficiency_sufficiencylevel.md) >= [RecommendedSufficiencyLevel](spatialanchorexportsufficiency_recommendedsufficiencylevel.md).

## -see-also

## -examples

## -capabilities
spatialPerception
