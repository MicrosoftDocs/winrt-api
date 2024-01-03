---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.ResumeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ResumeRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallStateChangeEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.ResumeRequested

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Raised to indicate that a previously held VoIP call should be made active.

## -remarks
After this event has been raised, the application must call [NotifyCallActive](voipphonecall_notifycallactive_97340177.md) within 5 seconds.

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
