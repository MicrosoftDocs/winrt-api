---
-api-id: M:Windows.ApplicationModel.Background.DeviceUseTrigger.RequestAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.DeviceTriggerResult> RequestAsync(System.String deviceId, System.String arguments)
-->

# Windows.ApplicationModel.Background.DeviceUseTrigger.RequestAsync

## -description
Triggers the background task and returns a [DeviceTriggerResult](devicetriggerresult.md) indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* of the device or sensor that the background task will access, and an optional app-specific string passed to the background task identifying which operation to perform.

## -parameters
### -param deviceId
The *DeviceInformation.ID* of the device or sensor that the background task will access. It must match the device or sensor that will perform the background operation. It is used by Windows to ensure that policy requirements are met.

### -param arguments
Optional value. A string specified by your app and passed to the background task, identifying which operation to perform.

## -returns
This method returns a [DeviceTriggerResult](devicetriggerresult.md) when it completes asynchronously.

## -remarks

## -examples

## -see-also
[RequestAsync(String)](deviceusetrigger_requestasync_269780240.md), [Accessing sensors and devices from a background task](/previous-versions/windows/apps/dn630194(v=win.10))
