---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.RejectRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RejectRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallRejectEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.RejectRequested

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Raised when a call has been rejected.

## -remarks
After this event is raised, the application must call [NotifyCallEnded](voipphonecall_notifycallended_1962259325.md) within 5 seconds.

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
