---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.FromIdAsync(System.String,Windows.Storage.FileAccessMode)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.HumanInterfaceDevice.HidDevice> FromIdAsync(System.String deviceId, Windows.Storage.FileAccessMode accessMode)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.FromIdAsync

## -description
Opens a handle to the device identified by the *deviceId* parameter. The access type is specified by the *accessMode* parameter.

## -parameters
### -param deviceId
The [DeviceInformation]( http://go.microsoft.com/fwlink/p/?LinkID=296709) ID that identifies the HID device.

### -param accessMode
Specifies the access mode. The supported access modes are Read and ReadWrite.

## -returns
A **HidDevice** object.  If HID device capabilities are absent or incorrect, this will be `null`.

## -remarks
The first time this method is invoked by a store app, it should be called from a UI thread in order to display the consent prompt. After the user has granted consent, the method can be invoked from any application thread.

The application manifest must declare HID device capabilities before invoking this method. If HID device capabilities are missing or incorrectly specified, the returned value will be `null` and no exception will be thrown.

## -examples

## -see-also

[HID Capabilities](windows_devices_humaninterfacedevice.md), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
