---
-api-id: T:Windows.Media.Capture.AppBroadcastMicrophoneCaptureState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AppBroadcastMicrophoneCaptureState : int {
	Failed = 2
	Started = 1
	Stopped = 0
}
-->

# Windows.Media.Capture.AppBroadcastMicrophoneCaptureState

## -description
Specifies the state of app broadcast microphone capture.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields

## -field Stopped:0
Microphone capture is stopped.

## -field Started:1
Microphone capture has been started.

## -field Failed:2
Microphone capture has failed.

## -remarks

## -see-also

## -examples



## -capabilities
appBroadcast, appBroadcastSettings
