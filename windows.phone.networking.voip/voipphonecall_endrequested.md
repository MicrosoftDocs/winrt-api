---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.EndRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EndRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallStateChangeEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.EndRequested

## -description
Raised to alert the VoIP app that the call should be ended.

## -remarks
After this event has been raised, the application is required to call [NotifyCallEnded](voipphonecall_notifycallended.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
ID_CAP_VOIP [Windows Phone]