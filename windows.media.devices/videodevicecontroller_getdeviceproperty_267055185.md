---
-api-id: M:Windows.Media.Devices.VideoDeviceController.GetDeviceProperty(System.String)
-api-type: winrt method
---

<!-- Method syntax
public object GetDeviceProperty(System.String propertyId)
-->

# Windows.Media.Devices.VideoDeviceController.GetDeviceProperty

## -description
Gets the value of the property with the specified ID from the capture device driver. You can use this method to query properties that are specific to a particular camera.

## -parameters
### -param propertyId
The identifier of the property for which the value is retrieved.

## -returns
The property value.

## -remarks

Common device properties are exposed as properties of the [VideoDeviceController](videodevicecontroller.md) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -examples

## -see-also
[VideoDeviceController](videodevicecontroller.md)