---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewIncomingCall(System.String,System.String,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,Windows.Phone.Networking.Voip.VoipCallMedia,Windows.Foundation.TimeSpan,Windows.Phone.Networking.Voip.VoipPhoneCall@)
-api-type: winrt method
---

<!-- Method syntax
public void RequestNewIncomingCall(System.String context, System.String contactName, System.String contactNumber, Windows.Foundation.Uri contactImage, System.String serviceName, Windows.Foundation.Uri brandingImage, System.String callDetails, Windows.Foundation.Uri ringtone, Windows.Phone.Networking.Voip.VoipCallMedia media, Windows.Foundation.TimeSpan ringTimeout, Windows.Phone.Networking.Voip.VoipPhoneCall call)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewIncomingCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Notifies the system of a new incoming call.

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
A string indicating whom the call is on behalf of. The maximum length is 128 characters.

### -param ringtone
The Uri of an audio file containing the ringtone for this call. The file type must be WMA or MP3. The maximum file size is 1MB.

### -param media
The media types used by the call (whether the call is audio/video rather than audio only).

### -param ringTimeout
The time, in seconds, the system should wait for the user to answer or ignore the call before rejecting the call. The allowed range is 5 to 120 seconds. The default value is 30 seconds.

### -param call
The object representing the new incoming call.

## -remarks

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
