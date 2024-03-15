---
-api-id: M:Windows.Media.Devices.VideoDeviceController.SetDevicePropertyById(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public VideoDeviceControllerSetDevicePropertyStatus VideoDeviceController.SetDevicePropertyById(String propertyId, Object propertyValue)
-->

# Windows.Media.Devices.VideoDeviceController.SetDevicePropertyById


## -description

Sets the value of the property with the specified ID from the capture device driver, using an extended ID with custom header information and providing the value as an object.

## -parameters

### -param propertyId

A byte array containing the extended identifier data.

### -param propertyValue

An object representing the data to be assigned to the specified property.

## -returns

A [VideoDeviceControllerSetDevicePropertyStatus](videodevicecontrollersetdevicepropertystatus.md) object describing the status of the operation.



## -remarks

Common device properties are exposed as properties of the [VideoDeviceController](videodevicecontroller.md) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -see-also

## -examples

