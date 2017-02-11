---
-api-id: M:Windows.Media.Devices.ExposureCompensationControl.SetValueAsync(System.Single)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetValueAsync(System.Single value)
-->

# Windows.Media.Devices.ExposureCompensationControl.SetValueAsync

## -description
Asynchronously sets the exposure compensation.

## -parameters
### -param value
The exposure compensation level to set the [Value](exposurecompensationcontrol_value.md) property to. The minimum and maximum values are specified by [Min](exposurecompensationcontrol_min.md) and [Max](exposurecompensationcontrol_max.md).

## -returns
The object that is used to control the asynchronous operation.

## -remarks
The supplied value must be between [Min](exposurecompensationcontrol_min.md) and [Max](exposurecompensationcontrol_max.md), inclusive, in increments of [Step](exposurecompensationcontrol_step.md). If you supply an arbitrary value that does not meet these requirements, the value will not be rounded. Instead, an exception will be thrown.

## -examples

## -see-also
[ExposureCompensationControl.Value](exposurecompensationcontrol_value.md), [Min](exposurecompensationcontrol_min.md), [Max](exposurecompensationcontrol_max.md)