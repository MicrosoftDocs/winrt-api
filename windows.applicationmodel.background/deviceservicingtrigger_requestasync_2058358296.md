---
-api-id: M:Windows.ApplicationModel.Background.DeviceServicingTrigger.RequestAsync(System.String,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.DeviceTriggerResult> RequestAsync(System.String deviceId, Windows.Foundation.TimeSpan expectedDuration)
-->

# Windows.ApplicationModel.Background.DeviceServicingTrigger.RequestAsync

## -description
Triggers the background task (settings or firmware update) and returns a [DeviceTriggerResult](devicetriggerresult.md) indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* string and an optional estimated time the background task will run. If your app cannot determine an appropriate time estimate, provide zero as the estimated time.

## -parameters
### -param deviceId
The *DeviceInformation.ID* of the device the background task will access. The device path must match the device that will perform the background operation and is used by Windows to ensure that policy requirements are met.

### -param expectedDuration
Optional value. The expected duration of the background settings update or background firmware update. If provided, it will be displayed to the user in the system consent dialog when the task is triggered by your app. Set this value to zero if an appropriate time estimate cannot be determined.

## -returns
This method returns a [DeviceTriggerResult](devicetriggerresult.md) when it completes asynchronously.

## -remarks

## -examples

## -see-also
[RequestAsync(String, TimeSpan, String)](deviceservicingtrigger_requestasync_481815192.md)