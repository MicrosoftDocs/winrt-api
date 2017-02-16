---
-api-id: P:Windows.Media.Devices.WhiteBalanceControl.Supported
-api-type: winrt property
---

<!-- Property syntax
public bool Supported { get; }
-->

# Windows.Media.Devices.WhiteBalanceControl.Supported

## -description
Gets a value that specifies if the capture device supports the white balance control.

## -property-value
**true** if the capture device supports the white balance control; otherwise, **false**.

## -remarks
If the device does not support the [WhiteBalanceControl](whitebalancecontrol.md), you can still use the [WhiteBalance](videodevicecontroller_whitebalance.md) on the [VideoCaptureDevice](http://msdn.microsoft.com/library/afba2768-11a0-4105-a5b1-c48bc961e9ed) to set the white balance color temperature.

## -examples

## -see-also
