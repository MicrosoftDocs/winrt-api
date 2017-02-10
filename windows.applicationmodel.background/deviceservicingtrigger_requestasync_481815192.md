---
-api-id: M:Windows.ApplicationModel.Background.DeviceServicingTrigger.RequestAsync(System.String,Windows.Foundation.TimeSpan,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.DeviceTriggerResult> RequestAsync(System.String deviceId, Windows.Foundation.TimeSpan expectedDuration, System.String arguments)
-->

# Windows.ApplicationModel.Background.DeviceServicingTrigger.RequestAsync

## -description
Triggers the background task (settings or firmware update) and returns a [DeviceTriggerResult](devicetriggerresult.md) indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* string, an optional estimated time the background task will run, and an optional app-specific string passed to the background task identifying which device operation to perform. If your app cannot determine an appropriate time estimate, provide zero as the estimated time.

## -parameters
### -param deviceId
The *DeviceInformation.ID* of the device the background task will access. The device path must match the device that will perform the background operation and is used by Windows to ensure that policy requirements are met.

### -param expectedDuration
Optional value. The expected duration of the background settings update or background firmware update. If provided, it will be displayed to the user in the system consent dialog when the task is triggered by your app. Set this value to zero if an appropriate time estimate cannot be determined.

### -param arguments
Optional value. An app-specific string passed to the background task identifying which device operation to perform.

## -returns
This method returns a [DeviceTriggerResult](devicetriggerresult.md) when it completes asynchronously.

## -remarks

## -examples

## -see-also
[RequestAsync(String, TimeSpan)](deviceservicingtrigger_requestasync_2058358296.md)