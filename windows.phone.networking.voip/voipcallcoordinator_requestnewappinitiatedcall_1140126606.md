---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewAppInitiatedCall(System.String,System.String,System.String,System.String,Windows.Phone.Networking.Voip.VoipCallMedia,Windows.Phone.Networking.Voip.VoipPhoneCall@)
-api-type: winrt method
---

<!-- Method syntax.
public void VoipCallCoordinator.RequestNewAppInitiatedCall(String context, String contactName, String contactNumber, String serviceName, VoipCallMedia media, VoipPhoneCall call)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewAppInitiatedCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Makes a request to the system for a new call object.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. The maximum length is 128 characters. This parameter must be non-null.

### -param contactName
The contact name of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactNumber
The phone number of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service or application. The maximum length is 128 characters.

### -param media
The media types used by the call (whether the call is audio/video rather than audio only).

### -param call
The object representing the new initiated call.

## -remarks
Use this method to create a new [VoipPhoneCall](voipphonecall.md) object, which can be used to set up a new in-app call notification and attach event handlers.

Your application should call [VoipPhoneCall.NotifyCallAccepted](voipphonecall_notifycallaccepted_984675139.md) if the user accepts the call. If the call is rejected or unanswered, use [VoipPhoneCall.NotifyCallEnded](voipphonecall_notifycallended_1962259325.md). Alternatively, the system can raise the **AnswerRequested** or **RejectRequested** events on the **VoipPhoneCall** object to tell the VoIP app whether the user accepts or rejects the incoming call via a HID device.

## -see-also

## -examples

## -capabilities
ID_CAP_VOIP [Windows Phone]
