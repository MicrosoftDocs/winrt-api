---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallEnded
-api-type: winrt method
---

<!-- Method syntax
public void NotifyCallEnded()
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallEnded

## -description
Notifies the system that the call has ended.

## -remarks
The system raises the [RejectRequested](voipphonecall_rejectrequested.md) event to signal to your VoIP application that the call has been rejected. After this event is raised, your VoIP application must call **NotifyCallEnded** within 5 seconds. See [VoipPhoneCall](voipphonecall.md) for more info.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
