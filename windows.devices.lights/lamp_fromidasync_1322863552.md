---
-api-id: M:Windows.Devices.Lights.Lamp.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Lights.Lamp> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Lights.Lamp.FromIdAsync

## -description
Gets a [Lamp](lamp.md) object representing the lamp device with the specified ID.

## -parameters
### -param deviceId
The ID of the requested lamp device.

## -returns
An asynchronous operation that returns a [Lamp](lamp.md) object upon successful completion.

## -remarks
Use [GetDefaultAsync](lamp_getdefaultasync.md) to get the default lamp for a device. Enumerate lamp devices by passing the class selection string returned by the [GetDeviceSelector](lamp_getdeviceselector.md) method to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher.md) method. Once retrieved, use the [DeviceId](lamp_deviceid.md) property to retrieve the ID for the associated lamp.

## -examples

## -see-also
