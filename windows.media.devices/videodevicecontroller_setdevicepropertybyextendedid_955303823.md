---
-api-id: M:Windows.Media.Devices.VideoDeviceController.SetDevicePropertyByExtendedId(System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public VideoDeviceControllerSetDevicePropertyStatus VideoDeviceController.SetDevicePropertyByExtendedId(Byte[] extendedPropertyId, Byte[] propertyValue)
-->

# Windows.Media.Devices.VideoDeviceController.SetDevicePropertyByExtendedId

## -description
Sets the value of the property with the specified ID from the capture device driver, using an extended ID with custom header information and providing the value as a byte array.

## -params

## -param extendedPropertyId
A byte array containing the extended identifier data.

## -param propertyValue
A byte array containing the data to be assigned to the specified property.

## -returns
A [VideoDeviceControllerSetDevicePropertyStatus](videodevicecontrollersetdevicepropertystatus.md) object describing the status of the operation.

## -remarks
The property ID and expected data are determined by the hardware device manufacturer.

## -see-also

## -examples

