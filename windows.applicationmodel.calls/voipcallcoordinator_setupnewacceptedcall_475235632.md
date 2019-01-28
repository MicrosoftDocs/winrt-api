---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCall(System.String,System.String,System.String,System.String,Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.SetupNewAcceptedCall(String context, String contactName, String contactNumber, String serviceName, VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCall

## -description
Sets up a newly accepted call.

## -parameters
### -param context
Information that is passed to the VoIP app's foreground UI process. This might be the contact name, or other data that helps the UI display more quickly.

### -param contactName
The name or ID of the caller.

### -param contactNumber
The phone number (if applicable) of the caller.

### -param serviceName
The name of the service or application.

### -param media
The media types of the new incoming call (either audio and video or audio only). Pass **Audio|Video** if the call should be answered with outgoing video. This assumes that the user's device has a camera available for the app to use at the time the call is answered. If this is not the case, or the user should only use audio, pass **Audio**.

## -returns
Returns the call as a VoipPhoneCall object.

## -remarks
Use this method instead of **RequestNewIncomingCall** in auto-accept scenarios, where an incoming call is automatically accepted and connected with video. Possible applications include a home surveillance camera, or helping elderly or disabled users accept calls.

All string parameters have a maximum allowed length of 128 characters (including the terminator).

## -see-also

## -examples


## -capabilities
backgroundVoIP, phoneCallHistory, phoneCallHistorySystem, voipCall
