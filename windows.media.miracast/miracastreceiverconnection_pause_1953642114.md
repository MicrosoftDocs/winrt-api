---
-api-id: M:Windows.Media.Miracast.MiracastReceiverConnection.Pause
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void MiracastReceiverConnection.Pause()
-->

# Windows.Media.Miracast.MiracastReceiverConnection.Pause

## -description

Requests the Miracast Transmitter to pause streaming audio and video data to the Receiver. The connection remains established.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [PauseAsync](miracastreceiverconnection_pauseasync_576113822.md).

Use [Resume](miracastreceiverconnection_resume_406343050.md) or [ResumeAsync](miracastreceiverconnection_resumeasync_801976564.md) to instruct the Miracast Transmitter to resume streaming.

## -see-also

[PauseAsync](miracastreceiverconnection_pauseasync_576113822.md),
[Resume](miracastreceiverconnection_resume_406343050.md),
[ResumeAsync](miracastreceiverconnection_resumeasync_801976564.md)

## -examples

