---
-api-id: P:Windows.UI.Input.Spatial.SpatialPointerPose.Eyes
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public EyesPose Eyes { get; }
-->

# Windows.UI.Input.Spatial.SpatialPointerPose.Eyes

## -description
Gets the user's eye gaze for this timestamp.

## -property-value
The eye gaze if supported by the current headset; otherwise, null.

## -remarks
You can determine if spatial eye gaze is supported on this device by checking [EyesPose.IsSupported](../windows.perception.people/eyespose_issupported_930300905.md).

This property is for reasoning about spatial eye gaze in a headset.  For screen-space eye gaze relative to a monitor, see [GazeDevicePreview](../windows.devices.input.preview/gazedevicepreview.md) instead.

## -see-also

## -examples

## -capabilities
gazeInput
