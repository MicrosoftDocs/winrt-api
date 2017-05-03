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
A **HidDevice** object.

## -remarks
The first time this method is invoked by a store app, it should be called from a UI thread in order to display the consent prompt. After the user has granted consent, the method can be invoked from any application thread.

The manifest for your app must declare a specific HID device capability before you invoke this method; and, this capability must map to the capabilities of the target device.

If there is no declaration in the manifest, or, if the declaration specifies a device not supported by the HID API, this method fails with an error of E_ACCESSDENIED.

## -examples

## -see-also
