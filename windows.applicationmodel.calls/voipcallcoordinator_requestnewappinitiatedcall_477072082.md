---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewAppInitiatedCall(System.String,System.String,System.String,System.String,Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.RequestNewAppInitiatedCall(String context, String contactName, String contactNumber, String serviceName, VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewAppInitiatedCall

## -description
Requests a new call object from the system. Call this method from your VoIP app to tell the system that there's a new incoming call, and that you want to host an incoming call notification for that new call.

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
The media types of the new incoming call (either audio and video or audio only). Pass **Audio|Video** if the user should have the option of answering the call with outgoing video. This assumes that the user's device has a camera available for the app to use at the time the call arrives. If this is not the case, or the user should only use audio, pass **Audio**.

## -returns
The object representing the new initiated call.

## -remarks
Use this method to create a new [VoipPhoneCall](voipphonecall.md) object. You can use a **VoipPhoneCall** object to send in-app call notifications, and to handle events that the **VoipPhoneCall** raises. See [VoipPhoneCall](voipphonecall.md) for more info about how to work with these notifications and events.

## -see-also
[VoipPhoneCall](voipphonecall.md)

## -examples

## -capabilities
backgroundVoIP, voipCall
