---
-api-id: P:Windows.Media.Devices.FlashControl.RedEyeReductionSupported
-api-type: winrt property
---

<!-- Property syntax
public bool RedEyeReductionSupported { get; }
-->

# Windows.Media.Devices.FlashControl.RedEyeReductionSupported

## -description
Gets a value that specifies if the capture device supports red eye reduction.

## -property-value
**true** if the capture device supports red eye reduction; otherwise, **false**.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [Supported](flashcontrol_supported.md) property before attempting to access this property. If [Supported](flashcontrol_supported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
