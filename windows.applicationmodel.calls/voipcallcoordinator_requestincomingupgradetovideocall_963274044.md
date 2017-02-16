---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestIncomingUpgradeToVideoCall(System.String,System.String,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestIncomingUpgradeToVideoCall(System.String context, System.String contactName, System.String contactNumber, Windows.Foundation.Uri contactImage, System.String serviceName, Windows.Foundation.Uri brandingImage, System.String callDetails, Windows.Foundation.Uri ringtone, Windows.Foundation.TimeSpan ringTimeout)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestIncomingUpgradeToVideoCall

## -description
Makes a request to the system for an incoming video call that will replace an existing call.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. This might be a contact name or other data that can be used to populate the app's UI more quickly. The maximum length is 128 characters. This parameter must be non-null and must refer to a task defined in the app's manifest file.

### -param contactName
The contact name of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactNumber
The phone number of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactImage
The Uri of an image file associated with the caller to be displayed on the incoming call UI. The file type must be PNG or JPG. The maximum file size is 1 MB.

### -param serviceName
The name of the VoIP service or application. The maximum length is 128 characters.

### -param brandingImage
The Uri of an image file that is a logo or icon of the VoIP service or application to be displayed on the incoming call UI. The file type must be PNG or JPG. The maximum file size is 128 KB.

### -param callDetails
A string indicating who the call is on behalf of. The maximum length is 128 characters.

### -param ringtone
The Uri of an audio file containing the ringtone for this call. The file type must be WMA or MP3. The maximum file size is 1 MB.

### -param ringTimeout
The time, in seconds, the system should wait for the user to answer or ignore the call before rejecting the call. The allowed range is 5 to 120 seconds. The default value is 30 seconds.

## -returns
The object representing the new incoming call.

## -remarks

## -examples

## -see-also


## -capabilities
voipCall