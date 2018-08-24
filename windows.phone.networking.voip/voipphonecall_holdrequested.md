---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.HoldRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallStateChangeEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.HoldRequested

## -description
Raised to alert the VoIP app that the call should be placed on hold.

## -remarks
After this event is raised, the application is required to call [NotifyCallHeld](voipphonecall_notifycallheld_666131143.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
ID_CAP_VOIP [Windows Phone]
