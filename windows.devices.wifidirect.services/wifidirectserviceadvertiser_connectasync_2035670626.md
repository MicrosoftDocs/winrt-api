---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.ConnectAsync(Windows.Devices.Enumeration.DeviceInformation,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession> ConnectAsync(Windows.Devices.Enumeration.DeviceInformation deviceInfo, System.String pin)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.ConnectAsync

## -description
Accepts a session request by connecting with the given PIN.

## -parameters
### -param deviceInfo
Describes the device to be connected. Pass in the [WiFiDirectServiceSessionRequestedEventArgs.DeviceInformation](wifidirectservicesessionrequest_deviceinformation.md) property value.

### -param pin
The PIN to be used to configure the session.

## -returns
An asynchronous connection operation. On successful completion, returns an object that describes the session that has been created.

## -remarks

## -examples

## -see-also
[ConnectAsync(DeviceInformation)](wifidirectserviceadvertiser_connectasync_900322270.md)