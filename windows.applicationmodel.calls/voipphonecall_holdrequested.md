---
-api-id: E:Windows.ApplicationModel.Calls.VoipPhoneCall.HoldRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldRequested<Windows.ApplicationModel.Calls.VoipPhoneCall,  Windows.ApplicationModel.Calls.CallStateChangeEventArgs>
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.HoldRequested

## -description
Raised to alert the VoIP app that the call should be placed on hold.

## -remarks
After this event is raised, the application is required to call [NotifyCallHeld](voipphonecall_notifycallheld.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
phoneCallHistory, phoneCallHistorySystem
voipCall
