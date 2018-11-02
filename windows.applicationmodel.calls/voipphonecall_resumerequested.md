---
-api-id: E:Windows.ApplicationModel.Calls.VoipPhoneCall.ResumeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ResumeRequested<Windows.ApplicationModel.Calls.VoipPhoneCall,  Windows.ApplicationModel.Calls.CallStateChangeEventArgs>
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.ResumeRequested

## -description
Raised to indicate that a previously held VoIP call should be made active.

## -remarks
After this event has been raised, the application must call [NotifyCallActive](voipphonecall_notifycallactive_97340177.md) within 5 seconds.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
