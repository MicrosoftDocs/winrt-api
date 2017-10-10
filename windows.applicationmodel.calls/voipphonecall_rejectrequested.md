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
After this event is raised, the application must call [NotifyCallEnded](voipphonecall_notifycallended.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
phoneCallHistory, phoneCallHistorySystem
voipCall
