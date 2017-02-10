---
-api-id: E:Windows.ApplicationModel.Calls.VoipPhoneCall.EndRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EndRequested<Windows.ApplicationModel.Calls.VoipPhoneCall,  Windows.ApplicationModel.Calls.CallStateChangeEventArgs>
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.EndRequested

## -description
Raised to alert the VoIP app that the call should be ended.

## -remarks
After this event has been raised, the application is required to call [NotifyCallEnded](voipphonecall_notifycallended.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
voipCall