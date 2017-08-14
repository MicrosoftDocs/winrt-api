---
-api-id: T:Windows.Media.Capture.AppBroadcastTerminationReason
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AppBroadcastTerminationReason : int {
	BackgroundTaskTerminated = 8
	BackgroundTaskUnresponsive = 9
	InternalError = 6
	LostConnectionToService = 1
	NoNetworkConnectivity = 2
	NormalTermination = 0
	ServiceAbort = 3
	ServiceError = 4
	ServiceUnavailable = 5
	UnsupportedFormat = 7
}
-->

# Windows.Media.Capture.AppBroadcastTerminationReason

## -description
Specifies the reason that an app broadcast was terminated.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields

## -field UnsupportedFormat:7
The app broadcast was terminated because it uses an unsupported format.

## -field ServiceUnavailable:5
The app broadcast was terminated because the service was unavailable.

## -field ServiceError:4
The app broadcast was terminated because there was a service error.

## -field ServiceAbort:3
The app broadcast was terminated because the service aborted the broadcast.

## -field NormalTermination:0
The app broadcast was terminated because it was terminated normally.

## -field NoNetworkConnectivity:2
The app broadcast was terminated because there is no network connectivity.

## -field LostConnectionToService:1
The app broadcast was terminated because the connection to the service was lost.

## -field InternalError:6
The app broadcast was terminated because of an internal error.

## -field BackgroundTaskUnresponsive:9
The app broadcast was terminated because the app broadcast background task was unresponsive.

## -field BackgroundTaskTerminated:8
The app broadcast was terminated because the app broadcast background task was terminated.

## -remarks

## -see-also

## -examples



## -capabilities
appBroadcast, appBroadcastSettings
