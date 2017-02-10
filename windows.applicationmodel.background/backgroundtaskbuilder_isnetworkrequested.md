---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested
-api-type: winrt property
---

<!-- Property syntax
public bool IsNetworkRequested { get;  set; }
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested

## -description
Indicates whether the background task requires network connectivity in order to run.

[SocketActivityTrigger](socketactivitytrigger.md) and [ControlChannelTrigger](../windows.networking.sockets/controlchanneltrigger.md) are designed for apps that maintain long-lived network connections, even when they run in the background. Apps requiring short-lived network interactions as part of their background task’s logic (for example, sending out one HTTP request) may call directly into the core networking APIs ( [HttpClient](../windows.web.http/httpclient.md), [StreamSocket](../windows.networking.sockets/streamsocket.md), [DatagramSocket](../windows.networking.sockets/datagramsocket.md), etc.) as long as they use the **InternetAvailable** condition with their background task or use the **IsNetworkRequested** flag on their background task registration. This tells the Background Tasks infrastructure to keep the network up while the task is executing, even if the device has entered Connected Standby mode.

If your background task does not use **InternetAvailable** or **IsNetworkRequested** as described here, then your background task will not be able to access the network when in Connected Standby mode (for example, when a phone's screen is turned off.)

## -property-value
A value indicating whether network connectivity is requested.

## -remarks

## -examples

## -see-also
