---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewOutgoingCall(System.String,System.String,System.String,Windows.Phone.Networking.Voip.VoipCallMedia,Windows.Phone.Networking.Voip.VoipPhoneCall@)
-api-type: winrt method
---

<!-- Method syntax
public void RequestNewOutgoingCall(System.String context, System.String contactName, System.String serviceName, Windows.Phone.Networking.Voip.VoipCallMedia media, Windows.Phone.Networking.Voip.VoipPhoneCall call)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewOutgoingCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Notifies the system of a new outgoing call.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. The maximum length is 128 characters. This parameter must be non-null.

### -param contactName
The name or ID of the caller which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param media
The media types of the new outgoing call.

### -param call
The object representing the new outgoing call.

## -remarks

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
