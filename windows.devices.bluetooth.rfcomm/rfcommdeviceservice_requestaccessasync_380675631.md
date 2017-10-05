---
-api-id: M:Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService.RequestAccessAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService.RequestAccessAsync

## -description
Used to request explicit access to the Rfcomm service. This invokes Device Consent and must be called on the UI thread. By default, unpaired devices do not require consent, while paired devices do. [FromIdAsync](rfcommdeviceservice_fromidasync.md) will only display a consent prompt when called for a paired device. [RequestAccessAsync](rfcommdeviceservice_requestaccessasync.md) allows the app to make the access request explicit in the event where the device may become paired in the future through other uses of the device.

## -returns
After the async operation completes, returns a [DeviceAccessStatus](../windows.devices.enumeration/deviceaccessstatus.md) object.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
