---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallActive
-api-type: winrt method
---

<!-- Method syntax
public void NotifyCallActive()
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallActive

## -description
Notifies the system that the VoIP call is active.

## -remarks
The system raises the [AnswerRequested](voipphonecall_answerrequested.md) event to signal to your VoIP application that the call has been accepted by the system. After the event is raised, your VoIP application must call **NotifyCallActive** within 5 seconds. See [VoipPhoneCall](voipphonecall.md) for more info.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall, voipCall
