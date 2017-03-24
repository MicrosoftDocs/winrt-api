---
-api-id: T:Windows.Perception.Spatial.SpatialPerceptionAccessStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Perception.Spatial.SpatialPerceptionAccessStatus : int
-->

# SpatialPerceptionAccessStatus

## -description
This enumeration describes an app's ability to see the user's surroundings in ways that require the spatialPerception capability. This includes use of either [SpatialSurfaceObserver](../windows.perception.spatial.surfaces/spatialsurfaceobserver.md) or [SpatialAnchorTransferManager](spatialanchortransfermanager.md).

## -enum-fields
### -field Unspecified:0
The user has not yet decided whether the app can use this spatial perception functionality.

### -field Allowed:1
The user has allowed the app to use this spatial perception functionality.

### -field DeniedByUser:2
The user has denied the app use of this spatial perception functionality.

### -field DeniedBySystem:3
The system has denied the app use of this spatial perception functionality.


## -remarks
To use those APIs, call the RequestAccessAsync method on the relevant type first.

## -examples

## -see-also