---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewIncomingCall(System.String,System.String,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,Windows.ApplicationModel.Calls.VoipPhoneCallMedia,Windows.Foundation.TimeSpan,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.RequestNewIncomingCall(String context, String contactName, String contactNumber, Uri contactImage, String serviceName, Uri brandingImage, String callDetails, Uri ringtone, VoipPhoneCallMedia media, TimeSpan ringTimeout, String contactRemoteId)
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
The media types of the new incoming call.

### -param ringTimeout
The time, in seconds, the system should wait for the user to answer or ignore the call before rejecting the call. The allowed range is 5 to 120 seconds. The default value is 30 seconds.

### -param contactRemoteId
The contact remote ID of the caller. The maximum length is 256 characters.

## -returns
The object representing the new incoming call.

## -remarks
Use this method when the user has turned on quiet hours. If caller's contact remote ID is on the quiet hour breakthrough list, the call will be connected, and an incoming call notification will be shown. If not, the call will not be connected, and no notification will be shown.

## -see-also

## -examples

