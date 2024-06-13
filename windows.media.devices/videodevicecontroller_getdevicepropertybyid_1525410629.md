---
-api-id: M:Windows.Media.Devices.VideoDeviceController.GetDevicePropertyById(System.String,Windows.Foundation.IReference{System.UInt32})
-api-type: winrt method
---

<!-- Method syntax.
public VideoDeviceControllerGetDevicePropertyResult VideoDeviceController.GetDevicePropertyById(String propertyId, IReference<UInt32> maxPropertyValueSize)
-->

# Windows.Media.Devices.VideoDeviceController.GetDevicePropertyById
Gets the value of the property with the specified ID from the capture device driver, specifying the maximum buffer size required to store the result. You can use this method to query properties that are specific to a particular camera.


## -description

Gets a the value of the property from the capture device driver with the ID with custom header information. You can use this method to query properties that are specific to a particular camera.

## -parameters

### -param propertyId

The identifier of the property for which the value is retrieved.

### -param maxPropertyValueSize

The size of the buffer that should be allocated to store the result of the operation. If the driver does not require that a size be specified for the returned property, set this value to null. If the size is required, and you do not provide a value, the [Status](videodevicecontrollergetdevicepropertyresult_status.md) property of the returned [VideoDeviceControllerGetDevicePropertyResult](videodevicecontrollergetdevicepropertyresult.md) object will be **MaxPropertyValueSizeRequired**. If the value supplied is too small to store the result of the operation, the returned **Status**  object will be **MaxPropertyValueSizeTooSmall**, which means that you can retry the call with a larger buffer size.

## -returns

A [VideoDeviceControllerGetDevicePropertyResult](videodevicecontrollergetdevicepropertyresult.md) object containing the status of the operation and, if successful, the returned property value.

## -remarks

Common device properties are exposed as properties of the [VideoDeviceController](videodevicecontroller.md) class. Additional properties are defined in the [KSPROPERTYSETID_ExtendedCameraControl](/windows-hardware/drivers/stream/kspropertysetid-extendedcameracontrol) property set. Legacy properties are defined in the [PROPSETID_VIDCAP_CAMERACONTROL](/windows-hardware/drivers/stream/propsetid-vidcap-cameracontrol) property set. For an example of accessing camera properties by ID, see the [Extended Control and Metadata sample](https://github.com/microsoft/Windows-Camera/tree/master/Samples/ExtendedControlAndMetadata).

## -see-also

## -examples

