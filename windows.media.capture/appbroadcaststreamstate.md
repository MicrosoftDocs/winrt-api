---
-api-id: T:Windows.Media.Capture.AppBroadcastStreamState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AppBroadcastStreamState : int {
	Initializing = 0
	Paused = 3
	Started = 2
	StreamReady = 1
	Terminated = 4
}
-->

# Windows.Media.Capture.AppBroadcastStreamState

## -description
Specifies the state of an app broadcast stream.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields

## -field Terminated:4
The app broadcast stream was terminated.

## -field StreamReady:1
The app broadcast stream is ready.

## -field Started:2
The app broadast stream has been started.

## -field Paused:3
The app broadcast stream has been paused.

## -field Initializing:0
The app broadcast stream is initializing.

## -remarks

## -see-also

## -examples



## -capabilities
appBroadcast
appBroadcastSettings