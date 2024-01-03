---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewIncomingCall(System.String,System.String,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,System.String,Windows.Foundation.Uri,Windows.Phone.Networking.Voip.VoipCallMedia,Windows.Foundation.TimeSpan,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.RequestNewIncomingCall(String context, String contactName, String contactNumber, Uri contactImage, String serviceName, Uri brandingImage, String callDetails, Uri ringtone, VoipCallMedia media, TimeSpan ringTimeout, String contactRemoteId)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestNewIncomingCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

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
A string indicating whom the call is on behalf of. The maximum length is 128 characters.

### -param ringtone
The Uri of an audio file containing the ringtone for this call. The file type must be WMA or MP3. The maximum file size is 1MB.

### -param media
The media types used by the call (whether the call is audio/video rather than audio only).

### -param ringTimeout
The time, in seconds, the system should wait for the user to answer or ignore the call before rejecting the call. The allowed range is 5 to 120 seconds. The default value is 30 seconds.

### -param contactRemoteId
The contact remote ID of the caller. The maximum length is 256 characters.

## -returns
The object representing the new incoming call.

## -remarks
Use this method when the user has turned on quiet hours. If the caller's contact remote ID is on the quiet hour breakthrough list, the call will be connected, and an incoming call notification will be shown. If not, the call will not be connected, and no notification will be shown.

## -see-also

## -examples

## -capabilities
ID_CAP_VOIP [Windows Phone]
