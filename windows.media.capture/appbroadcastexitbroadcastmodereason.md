---
-api-id: T:Windows.Media.Capture.AppBroadcastExitBroadcastModeReason
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AppBroadcastExitBroadcastModeReason : int {
	AuthorizationFail = 2
	ForegroundAppActivated = 3
	NormalExit = 0
	UserCanceled = 1
}
-->

# Windows.Media.Capture.AppBroadcastExitBroadcastModeReason

## -description
Gets a value that specifies the reason that broadcast mode was exited.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields

## -field UserCanceled:1
The user canceled the broadcast.

## -field NormalExit:0
The broadcast was exited normally.

## -field ForegroundAppActivated:3
The broadcast was exited because a foreground app was activated.

## -field AuthorizationFail:2
The broadcast was exited because of an authentication failure.

## -remarks

## -see-also

## -examples



## -capabilities
appBroadcast
appBroadcastSettings