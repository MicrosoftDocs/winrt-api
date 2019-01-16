---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewOutgoingCall(System.String,System.String,System.String,Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestNewOutgoingCall(System.String context, System.String contactName, System.String serviceName, Windows.ApplicationModel.Calls.VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewOutgoingCall

## -description
Makes a request to the system for a new outgoing call.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. The maximum length is 128 characters. This parameter must be non-null.

### -param contactName
The name or ID of the caller which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param media
The media type of the new outgoing call (either audio and video or audio only). Pass **Audio|Video** if the user chose to start the call with outgoing video. This assumes that the user's device has a camera available for the app to use at the time the call is made. If this is not the case, or the user should only use audio, pass **Audio**.

## -returns
The object representing the new outgoing call.

## -remarks

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
