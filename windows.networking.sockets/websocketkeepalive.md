---
-api-id: T:Windows.Networking.Sockets.WebSocketKeepAlive
-api-type: winrt class
---

<!-- Class syntax.
public class WebSocketKeepAlive : Windows.ApplicationModel.Background.IBackgroundTask
-->

# Windows.Networking.Sockets.WebSocketKeepAlive

## -description
Provides the ability to send a WebSocket protocol keep-alive on a connected WebSocket.

## -remarks
The WebSocketKeepAlive class is used in conjunction with the [ControlChannelTrigger](controlchanneltrigger.md) class and related interfaces to enable real-time network status and triggers for the [StreamWebSocket](streamwebsocket.md) and [MessageWebSocket](messagewebsocket.md) classes. Control channel triggers are used by long-running network apps to minimize network and system resource usage. Network triggers allow an app to drop to a low-power mode for periods of time while still keeping established network connections intact but in a low-power state. An app can set a keep-alive trigger used by the system for when the app should wake up and send a WebSocket keep-alive packet.

A UWP app is normally suspended when it is no longer in the foreground. There are some exceptions where an app should not be suspended (actively printing, accessing an audio stream, and transferring files in the background, for example). The [ControlChannelTrigger](controlchanneltrigger.md) class allows a network app that has established a WebSocket connection to notify the system that the network connection should be kept operational and that the system should wake up the suspended app when network data is received for the app or to send a WebSocket keep-alive packet.

WebSocketKeepAlive is used as the [TaskEntryPoint](../windows.applicationmodel.background/backgroundtaskbuilder_taskentrypoint.md) for a keep-alive in [ControlChannelTrigger](controlchanneltrigger.md). A developer will need to write code to handle receiving data.

For more information about suspending and waking up an app, [How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)).

For more information on the WebSocket keep-alive control frames, see the [WebSocket Protocol](https://tools.ietf.org/html/rfc6455#section-5.5.2).

## -examples

## -see-also
