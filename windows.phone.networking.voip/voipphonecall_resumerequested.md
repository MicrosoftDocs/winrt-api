---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.ResumeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ResumeRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallStateChangeEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.ResumeRequested

## -description
Raised to indicate that a previously held VoIP call should be made active.

## -remarks
After this event has been raised, the application must call [NotifyCallActive](voipphonecall_notifycallactive.md) within 5 seconds.

## -examples

## -see-also


## -capabilities
ID_CAP_VOIP [Windows Phone]
