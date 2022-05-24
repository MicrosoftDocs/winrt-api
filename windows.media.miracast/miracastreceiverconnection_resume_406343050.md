---
-api-id: M:Windows.Media.Miracast.MiracastReceiverConnection.Resume
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void MiracastReceiverConnection.Resume()
-->

# Windows.Media.Miracast.MiracastReceiverConnection.Resume

## -description

Requests the Miracast Transmitter to resume streaming audio and video data to the [MiracastReceiver](miracastreceiver.md).

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [ResumeAsync](miracastreceiverconnection_resumeasync_801976564.md).

## -see-also

[ResumeAsync](miracastreceiverconnection_resumeasync_801976564.md)

## -examples

