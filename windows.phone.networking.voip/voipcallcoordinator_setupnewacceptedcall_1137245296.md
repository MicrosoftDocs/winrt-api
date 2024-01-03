---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.SetupNewAcceptedCall(System.String,System.String,System.String,System.String,Windows.Phone.Networking.Voip.VoipCallMedia,Windows.Phone.Networking.Voip.VoipPhoneCall@)
-api-type: winrt method
---

<!-- Method syntax.
public void VoipCallCoordinator.SetupNewAcceptedCall(String context, String contactName, String contactNumber, String serviceName, VoipCallMedia media, VoipPhoneCall call)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.SetupNewAcceptedCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Prepares to receive a new incoming call, with the intent that the call will be accepted.

## -parameters

### -param context
The context for the incoming call.

### -param contactName
The name of the incoming caller.

### -param contactNumber
The phone number of the incoming caller.

### -param serviceName
The name of the service that the caller is using.

### -param media
Specifies the type of media used by the call; audio, video, or none.

### -param call
The object that represents the VoIP call.

## -remarks

## -see-also

## -examples

## -capabilities
voipCall
