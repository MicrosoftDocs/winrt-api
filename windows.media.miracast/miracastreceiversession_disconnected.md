---
-api-id: E:Windows.Media.Miracast.MiracastReceiverSession.Disconnected
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
public event TypedEventHandler Disconnected<MiracastReceiverSession, MiracastReceiverDisconnectedEventArgs>
-->

# Windows.Media.Miracast.MiracastReceiverSession.Disconnected

## -description

An event which is raised when a [MiracastReceiverConnection](miracastreceiverconnection.md) has been disconnected by the Miracast Transmitter.

## -remarks

The app must subscribe to this event before invoking the [MiracastReceiverSession.Start](miracastreceiversession_start_1587696324.md) or [MiracastReceiverSession.StartAsync](miracastreceiversession_startasync_1931900819.md) method.

The event is not raised if the app itself requested the connection to be disconnected, for example, by invoking the Disconnect method.

Apps should check the [MiracastReceiverDisconnectedEventArgs.Connection](miracastreceiverdisconnectedeventargs_connection.md) property to determine which connection was disconnected as a MiracastReceiverSession can handle multiple connections.

## -see-also

[MiracastReceiverConnection](miracastreceiverconnection.md)

## -examples

