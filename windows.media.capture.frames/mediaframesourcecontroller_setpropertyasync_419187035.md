---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceController.SetPropertyAsync(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameSourceSetPropertyStatus> SetPropertyAsync(System.String propertyId, System.Object propertyValue)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController.SetPropertyAsync

## -description
Asynchronously sets the value of a [MediaFrameSource](mediaframesource.md) property and returns a [MediaFrameSourceSetPropertyStatus](mediaframesourcesetpropertystatus.md) object describing the result status of the set operation.

## -parameters
### -param propertyId
The identifier of the media frame source property to be set.

### -param propertyValue
The value of the media frame source property to be set.

## -returns
An asynchronous operation that returns a [MediaFrameSourceSetPropertyStatus](mediaframesourcesetpropertystatus.md) upon completion.

## -remarks
To get the value of a media frame source property, use [GetPropertyAsync](mediaframesourcecontroller_getpropertyasync_1561087689.md).

Common device properties are exposed as properties of the [VideoDeviceController](/uwp/api/Windows.Media.Devices.VideoDeviceController) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -examples

## -see-also
