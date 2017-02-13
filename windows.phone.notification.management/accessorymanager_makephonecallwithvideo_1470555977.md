---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.MakePhoneCallWithVideo(System.Guid,System.String,Windows.Phone.Notification.Management.PhoneCallAudioEndpoint)
-api-type: winrt method
---

<!-- Method syntax
public void MakePhoneCallWithVideo(System.Guid phoneLine, System.String phoneNumber, Windows.Phone.Notification.Management.PhoneCallAudioEndpoint endPoint)
-->

# Windows.Phone.Notification.Management.AccessoryManager.MakePhoneCallWithVideo

## -description
Makes a video phone call.

## -parameters
### -param phoneLine
The identifier of the phone line.

### -param phoneNumber
The number to call.

### -param endPoint
The audio end point; one of the possible values of default, speaker, or hands-free.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[MakePhoneCallWithVideo(Guid, String)](accessorymanager_makephonecallwithvideo_104177371.md)