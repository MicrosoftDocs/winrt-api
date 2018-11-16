---
-api-id: T:Windows.Perception.Spatial.SpatialAnchorExportSufficiency
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class SpatialAnchorExportSufficiency 
-->

# Windows.Perception.Spatial.SpatialAnchorExportSufficiency

## -description
Represents information about whether a spatial anchor's data is sufficient for sharing or relocalization.

## -remarks
An anchor has gathered the minimal amount of data needed to export if it has a [SufficiencyLevel](spatialanchorexportsufficiency_sufficiencylevel.md) >= 1.0, also indicated by [IsMinimallySufficient](spatialanchorexportsufficiency_isminimallysufficient.md).

An anchor has gathered the ideal amount of data needed to export if it has a **SufficiencyLevel** >= [RecommendedSufficiencyLevel](spatialanchorexportsufficiency_recommendedsufficiencylevel.md).

## -see-also

## -examples

## -capabilities
spatialPerception
