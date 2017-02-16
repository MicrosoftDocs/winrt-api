---
-api-id: P:Windows.Media.Devices.ExposureControl.Supported
-api-type: winrt property
---

<!-- Property syntax
public bool Supported { get; }
-->

# Windows.Media.Devices.ExposureControl.Supported

## -description
Gets a value that specifies if the capture device supports the exposure control.

## -property-value
**true** if the exposure control is supported; otherwise, **false**.

## -remarks
If the device does not support the [ExposureControl](exposurecontrol.md), you can still use the [Exposure](videodevicecontroller_exposure.md) property on the [VideoCaptureDevice](http://msdn.microsoft.com/library/afba2768-11a0-4105-a5b1-c48bc961e9ed) to set the exposure value.

## -examples

## -see-also
