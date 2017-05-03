---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteractionSourceKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Spatial.SpatialInteractionSourceKind : int
-->

# SpatialInteractionSourceKind

## -description
Specifies the kind of an interaction source.

## -enum-fields
### -field Other:0
The interaction source is of a kind not known in this version of the API.

### -field Hand:1
The interaction source is one of the user's hands.

### -field Voice:2
The interaction source is the user's speech, when speaking a system command such as "Select".

### -field Controller:3
The interaction source is a spatial controller.


## -remarks
This only enumerates sources of interactions, such as hand gestures and voice commands. The user's head gaze is used for pointing and is represented separately by the [SpatialPointerPose](spatialpointerpose.md) type.

## -examples

## -see-also