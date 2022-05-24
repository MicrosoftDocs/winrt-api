---
-api-id: E:Windows.Media.Miracast.MiracastReceiverSession.ConnectionCreated
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
public event TypedEventHandler ConnectionCreated<MiracastReceiverSession, MiracastReceiverConnectionCreatedEventArgs>
-->

# Windows.Media.Miracast.MiracastReceiverSession.ConnectionCreated

## -description

An event which is raised when a new incoming [MiracastReceiverConnection](miracastreceiverconnection.md) is received.

## -remarks

The app must subscribe to this event before invoking the [MiracastReceiverSession.Start](miracastreceiversession_start_1587696324.md) or [MiracastReceiverSession.StartAsync](miracastreceiversession_startasync_1931900819.md) method.

## -see-also

[MiracastReceiverConnection](miracastreceiverconnection.md)

## -examples

