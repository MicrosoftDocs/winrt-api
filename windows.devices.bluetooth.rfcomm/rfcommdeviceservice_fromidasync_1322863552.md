---
-api-id: M:Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService.FromIdAsync

## -description
Gets an RfcommDeviceService object from a DeviceInformation Id for an RFCOMM service instance.

## -parameters
### -param deviceId
The DeviceInformation Id that identifies the RFCOMM service instance. This id can be retrieved from [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md).

## -returns
The RfcommDeviceService object that represents the RFCOMM service instance.

## -remarks
The first time this method is invoked by a store app, it should be called from a UI thread in order to display the consent prompt. After the user has granted consent, the method can be invoked from any application thread.

If a store app has not declared the right capabilities or the user does not grant consent, the method returns a null object.


+ For Universal Windows Platform (UWP) apps, use the **bluetooth** capability. For more info, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).
+ For Windows 8.x store apps, see [How to specify device capabilities for Bluetooth (Windows)](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth) to declare the right capabilities.


> [!WARNING]
> If the device acting as the RFCOMM server does not have the correct channel registered in its manifest, this method throws an exception when called on the device acting as the RFCOMM client.

## -examples

## -see-also


## -capabilities
bluetooth