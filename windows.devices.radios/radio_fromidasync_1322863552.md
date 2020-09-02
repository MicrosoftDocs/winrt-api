---
-api-id: M:Windows.Devices.Radios.Radio.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Radios.Radio> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Radios.Radio.FromIdAsync

## -description
A static method that retrieves a [Radio](radio.md) object. The method accepts the 'Device.Id' found through [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md). This procedure is more reliable than using [GetRadiosAsync](/uwp/api/windows.devices.radios.radio.GetRadiosAsync) to obtain a radio in situations where a USB Radio has failed or been removed on a Windows 10 workstation.  In this instance of a failed or removed radio, [GetRadiosAsync](/uwp/api/windows.devices.radios.radio.GetRadiosAsync) returns no bluetooth radio. [FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.FindAllAsync), in contrast, returns a valid [Id](/uwp/api/windows.devices.enumeration.deviceinformation.Id) that can be passed to [FromIdAsync](/uwp/api/windows.devices.radios.radio#Windows_Devices_Radios_Radio_FromIdAsync_System_String_) to obtain the radio object, which will report itself as now being in the state of 'Disabled'.

## -parameters
### -param deviceId
A string that identifies a particular radio device.

## -returns
An asynchronous retrieval operation. On successful completion, it contains a [Radio](radio.md) object that represents the specified radio device. Otherwise it throws an exception.

## -remarks

## -examples

## -see-also
