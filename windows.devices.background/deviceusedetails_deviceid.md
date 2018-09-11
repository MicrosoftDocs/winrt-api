---
-api-id: P:Windows.Devices.Background.DeviceUseDetails.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.Devices.Background.DeviceUseDetails.DeviceId

## -description
Gets the [DeviceInformation.ID](../windows.devices.enumeration/deviceinformation_id.md) of the device the task is targeting. The background task can provide this to the `FromIdAsync` method of the appropriate device access class to open the device. For example, call [UsbDevice.FromIdAsync](../windows.devices.usb/usbdevice_fromidasync_1322863552.md) in the [Windows.Devices.Usb](../windows.devices.usb/windows_devices_usb.md) namespace to open a USB device.

## -property-value
The *deviceId* parameter value from the originating [RequestAsync](/uwp/api/windows.applicationmodel.background.deviceservicingtrigger.requestasync) call.

## -remarks

## -examples

## -see-also
