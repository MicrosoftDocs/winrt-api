---
-api-id: P:Windows.Media.Devices.FlashControl.RedEyeReduction
-api-type: winrt property
---

<!-- Property syntax
public bool RedEyeReduction { get;  set; }
-->

# Windows.Media.Devices.FlashControl.RedEyeReduction

## -description
Gets a value that specifies if the red eye reduction is enabled or disabled.

## -property-value
**true** if red eye reduction is enabled; otherwise, **false**.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [RedEyeReductionSupported](flashcontrol_redeyereductionsupported.md) property before attempting to access this property. If [RedEyeReductionSupported](flashcontrol_redeyereductionsupported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
