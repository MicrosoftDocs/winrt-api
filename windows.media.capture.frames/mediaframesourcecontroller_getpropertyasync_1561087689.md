---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyResult> GetPropertyAsync(System.String propertyId)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyAsync

## -description
Asynchronously gets an object that contains the value of a [MediaFrameSource](mediaframesource.md) property, if the property value is successfully retrieved, and describes the result status of the get operation.

## -parameters
### -param propertyId
The identifier of the media frame source property to be retrieved.

## -returns
An asynchronous operation that returns a [MediaFrameSourceGetPropertyResult](mediaframesourcegetpropertyresult.md) upon completion.

## -remarks
To set the value of a media frame source property, use [SetPropertyAsync](mediaframesourcecontroller_setpropertyasync_419187035.md).

Common device properties are exposed as properties of the [VideoDeviceController](/uwp/api/Windows.Media.Devices.VideoDeviceController) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -examples

## -see-also