---
-api-id: M:Windows.Phone.Networking.Voip.VoipPhoneCall.NotifyCallAccepted(Windows.Phone.Networking.Voip.VoipCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public void VoipPhoneCall.NotifyCallAccepted(VoipCallMedia media)
-->

# Windows.Phone.Networking.Voip.VoipPhoneCall.NotifyCallAccepted

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Notifies the system that the VoIP call has been accepted.

## -parameters

### -param media
The media types used by the call (whether the call is audio/video rather than audio only).

## -remarks
The system will raise [VoipPhoneCall.AnswerRequested](voipphonecall_answerrequested.md) to signal to the VoIP App that the call has been accepted by the system. After the event is raised, the VoIP App must call [VoipPhoneCall.NotifyCallActive](voipphonecall_notifycallactive_97340177.md) within 5 seconds.

## -see-also

## -examples

## -capabilities
ID_CAP_VOIP [Windows Phone]
