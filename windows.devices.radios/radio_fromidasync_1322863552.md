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
Retrieves a [Radio](radio.md) object by device identifier.

## -parameters
### -param deviceId
A string that identifies a particular radio device.

## -returns
An asynchronous retrieval operation. On successful completion, it contains a [Radio](radio.md) object that represents
the specified radio device. Otherwise it throws an exception.

## -remarks
This method retrieves the current representation of a radio by device identifier. The identifier is typically
obtained from [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md).

This approach is more reliable than using [GetRadiosAsync](/uwp/api/windows.devices.radios.radio.GetRadiosAsync) in scenarios
where a USB radio has failed or been removed. When a radio fails or is removed,
[GetRadiosAsync](/uwp/api/windows.devices.radios.radio.GetRadiosAsync) returns no radio object.
[FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.FindAllAsync) still returns a valid
[Id](/uwp/api/windows.devices.enumeration.deviceinformation.Id) that can be passed to
[FromIdAsync](/uwp/api/windows.devices.radios.radio#Windows_Devices_Radios_Radio_FromIdAsync_System_String_) to obtain the
radio object, which will report itself as `Disabled`.

If the underlying hardware has been removed or is unavailable, the returned object reflects the last known configuration
and typically reports a `Disabled` state. A radio that no longer exists will not appear in new enumeration snapshots.

## -examples

## -see-also
[DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md),
[Radio](radio.md),
[Radio.GetRadiosAsync](radio_getradiosasync_548754145.md)
