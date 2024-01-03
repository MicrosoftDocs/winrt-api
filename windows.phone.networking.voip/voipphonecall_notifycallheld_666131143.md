---
-api-id: M:Windows.Phone.Networking.Voip.VoipPhoneCall.NotifyCallHeld
-api-type: winrt method
---

<!-- Method syntax
public void NotifyCallHeld()
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.NotifyCallHeld

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Notifies the system that the call is currently on hold.

## -remarks
Apps must call this method before calling [NotifyCallActive](voipphonecall_notifycallactive_97340177.md) on another VoIP call. Only one call can be active at a time.

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
