---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.FromIdAsync

## -description
Instantiates a new GattDeviceService from the device ID.

## -parameters
### -param deviceId
The GATT device ID.

## -returns
The object for managing the asynchronous operation, which, upon completion, returns the newly instantiated GattDeviceService.

## -remarks
The first time this method is invoked by a store app, it should be called from a UI thread in order to display the consent prompt. After the user has granted consent, the method can be invoked from any application thread.

If a store app has not declared the right capabilities or the user does not grant consent, the method returns a null object.

- For Universal Windows Platform (UWP) apps, use the **bluetooth** capability. For more info see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).
- For Windows 8.x store apps, see [How to specify device capabilities for Bluetooth (Windows)](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth) to declare the right capabilities.

## -examples

## -see-also


## -capabilities
bluetooth