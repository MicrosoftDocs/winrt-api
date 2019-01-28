---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewIncomingCall(System.String,System.String,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,Windows.ApplicationModel.Calls.VoipPhoneCallMedia,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestNewIncomingCall(System.String context, System.String contactName, System.String contactNumber, Windows.Foundation.Uri contactImage, System.String serviceName, Windows.Foundation.Uri brandingImage, System.String callDetails, Windows.Foundation.Uri ringtone, Windows.ApplicationModel.Calls.VoipPhoneCallMedia media, Windows.Foundation.TimeSpan ringTimeout)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewIncomingCall

## -description
Makes a request to the system for a new incoming call.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. The maximum length is 128 characters. This parameter must be non-null.

### -param contactName
The contact name of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactNumber
The phone number of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactImage
The Uri of an image file associated with the caller to be displayed on the incoming call UI. The file type must be PNG or JPG. The maximum file size is 1MB.

### -param serviceName
The name of the VoIP service or application. The maximum length is 128 characters.

### -param brandingImage
The Uri of an image file that is a logo or icon of the VoIP service or application to be displayed on the incoming call UI. The file type must be PNG or JPG. The maximum file size is 128KB.

### -param callDetails
A string indicating who the call is on behalf of. The maximum length is 128 characters.

### -param ringtone
The Uri of an audio file containing the ringtone for this call. The file type must be WMA or MP3. The maximum file size is 1MB.

### -param media
The media types of the new incoming call (either audio and video or audio only). Pass **Audio|Video** if the user should have the option of answering the call with outgoing video. This assumes that the user's device has a camera available for the app to use at the time the call arrives. If this is not the case, or the user should only use audio, pass **Audio**.

### -param ringTimeout
The time, in seconds, the system should wait for the user to answer or ignore the call before rejecting the call. The allowed range is 5 to 120 seconds. The default value is 30 seconds.

## -returns
The object representing the new incoming call.

## -remarks

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
