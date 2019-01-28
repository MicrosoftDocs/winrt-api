---
-api-id: E:Windows.ApplicationModel.Calls.VoipPhoneCall.RejectRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RejectRequested<Windows.ApplicationModel.Calls.VoipPhoneCall,  Windows.ApplicationModel.Calls.CallRejectEventArgs>
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.RejectRequested

## -description
Raised when a call has been rejected.

## -remarks
The system raises the **RejectRequested** event to signal to your VoIP application that the call has been rejected. After this event is raised, your VoIP application must call [NotifyCallEnded](voipphonecall_notifycallended_1962259325.md) within 5 seconds. See [VoipPhoneCall](voipphonecall.md) for more info.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
