---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceController.SetPropertyByExtendedIdAsync(System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<MediaFrameSourceSetPropertyStatus> MediaFrameSourceController.SetPropertyByExtendedIdAsync(Byte[] extendedPropertyId, Byte[] propertyValue)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController.SetPropertyByExtendedIdAsync


## -description

Asynchronously sets the value of the property with the specified ID on a [MediaFrameSource](mediaframesource.md), using an extended ID with custom header information.

## -parameters

### -param extendedPropertyId

A byte array containing the extended identifier data.

### -param propertyValue

A byte array containing the value to be set for the property.

## -returns

An asynchronous operation that, upon successful completion, returns a [MediaFrameSourceSetPropertyStatus](mediaframesourcesetpropertystatus.md) value indicating the status of the operation.

Common device properties are exposed as properties of the [VideoDeviceController](/uwp/api/Windows.Media.Devices.VideoDeviceController) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -remarks

## -see-also

## -examples

