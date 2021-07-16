---
-api-id: E:Windows.Media.Miracast.MiracastReceiverSession.MediaSourceCreated
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
public event TypedEventHandler MediaSourceCreated<MiracastReceiverSession, MiracastReceiverMediaSourceCreatedEventArgs>
-->

# Windows.Media.Miracast.MiracastReceiverSession.MediaSourceCreated

## -description

An event which is raised when the [MediaSource](../windows.media.core/mediasource.md) object for a [MiracastReceiverConnection](miracastreceiverconnection.md) has been created.

## -remarks

The app must subscribe to this event before invoking the [MiracastReceiverSession.Start](miracastreceiversession_start_1587696324.md) or [MiracastReceiverSession.StartAsync](miracastreceiversession_startasync_1931900819.md) method.

## -see-also

[MediaSource](../windows.media.core/mediasource.md),
[MiracastReceiverConnection](miracastreceiverconnection.md)

## -examples

