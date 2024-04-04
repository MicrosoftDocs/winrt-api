---
-api-id: M:Windows.Media.Devices.VideoDeviceController.SetDeviceProperty(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetDeviceProperty(System.String propertyId, System.Object propertyValue)
-->

# Windows.Media.Devices.VideoDeviceController.SetDeviceProperty

## -description
Sets the value of the property with the specified ID on the capture device driver. You can use this method to set properties that are specific to a particular camera.

## -parameters
### -param propertyId
The identifier of the property for which the value is set.

### -param propertyValue
The new value of the property.

## -remarks

The property ID and expected data are determined by the hardware device manufacturer.

Common device properties are exposed as properties of the [VideoDeviceController](videodevicecontroller.md) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -examples

## -see-also
[VideoDeviceController](videodevicecontroller.md)