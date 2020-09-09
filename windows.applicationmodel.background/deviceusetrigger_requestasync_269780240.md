---
-api-id: M:Windows.ApplicationModel.Background.DeviceUseTrigger.RequestAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.DeviceTriggerResult> RequestAsync(System.String deviceId)
-->

# Windows.ApplicationModel.Background.DeviceUseTrigger.RequestAsync

## -description
Triggers the background task and returns a [DeviceTriggerResult](devicetriggerresult.md) indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* of the device or sensor that the background task will access.

## -parameters
### -param deviceId
The *DeviceInformation.ID* of the device or sensor that the background task will access. It must match the device or sensor that will perform the background operation. It is used by Windows to ensure that policy requirements are met.

## -returns
This method returns a [DeviceTriggerResult](devicetriggerresult.md) when it completes asynchronously.

## -remarks

## -examples

## -see-also
[RequestAsync(String, String)](deviceusetrigger_requestasync_1558743216.md), [Accessing sensors and devices from a background task](/previous-versions/windows/apps/dn630194(v=win.10))
