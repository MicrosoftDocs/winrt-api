---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallAccepted(Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public void VoipPhoneCall.NotifyCallAccepted(VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallAccepted

## -description
Notifies the system that the VoIP call has been accepted.

## -parameters
### -param media
The media types used by the call.

## -remarks
The system will raise the **AnswerRequested** event on the **VoipPhoneCall** object to signal to the VoIP App that the call has been accepted by the system. After the event is raised, the VoIP App must call **NotifyCallActive** within 5 seconds.

## -see-also

## -examples

