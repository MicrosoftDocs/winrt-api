---
-api-id: P:Windows.Perception.People.EyesPose.Gaze
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IReference<SpatialRay> Gaze { get; }
-->

# Windows.Perception.People.EyesPose.Gaze

## -description
Gets the user's eye gaze in the specified coordinate system.

## -property-value
The eye gaze, if calibration is valid for the current user and their eyes are currently detected; otherwise, null.

## -remarks
You should check [IsCalibrationValid](eyespose_iscalibrationvalid.md) first to determine if eye gaze calibration is valid for the current user in the headset.  If not, this property will always return null.

## -see-also

## -examples

## -capabilities
gazeInput
