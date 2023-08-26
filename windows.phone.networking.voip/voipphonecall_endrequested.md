---
-api-id: E:Windows.Phone.Networking.Voip.VoipPhoneCall.EndRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EndRequested<Windows.Phone.Networking.Voip.VoipPhoneCall,  Windows.Phone.Networking.Voip.CallStateChangeEventArgs>
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.EndRequested

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Raised to alert the VoIP app that the call should be ended.

## -remarks
After this event has been raised, the application is required to call [NotifyCallEnded](voipphonecall_notifycallended_1962259325.md) within 5 seconds.

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
