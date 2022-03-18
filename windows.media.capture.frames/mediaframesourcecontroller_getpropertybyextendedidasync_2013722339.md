---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyByExtendedIdAsync(System.Byte[],Windows.Foundation.IReference{System.UInt32})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<MediaFrameSourceGetPropertyResult> MediaFrameSourceController.GetPropertyByExtendedIdAsync(Byte[] extendedPropertyId, IReference<UInt32> maxPropertyValueSize)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyByExtendedIdAsync


## -description

Asynchronously gets the value of the property with the specified ID from a [MediaFrameSource](mediaframesource.md), using an extended ID with custom header information and specifying the maximum buffer size required to store the result.

## -parameters

### -param extendedPropertyId

A byte array containing the extended identifier data.

### -param maxPropertyValueSize

The size of the buffer that should be allocated to store the result of the operation. If the driver does not require that a size be specified for the returned property, set this value to null. If the size is required, and you do not provide a value, the [Status](videodevicecontrollergetdevicepropertyresult_status.md) property of the returned [VideoDeviceControllerGetDevicePropertyResult](videodevicecontrollergetdevicepropertyresult.md) object will be **MaxPropertyValueSizeRequired**. If the value supplied is too small to store the result of the operation, the returned **Status**  object will be **MaxPropertyValueSizeTooSmall**, which means that you can retry the call with a larger buffer size.

## -returns

An asynchronous operation that, upon successful completion, returns a [MediaFrameSourceGetPropertyResult](mediaframesourcegetpropertyresult.md) object containing the status of the operation and, if successful, the returned property value.

## -remarks

## -see-also

## -examples

