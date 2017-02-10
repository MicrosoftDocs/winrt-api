---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.MakePhoneCall(System.Guid,System.String,Windows.Phone.Notification.Management.PhoneCallAudioEndpoint)
-api-type: winrt method
---

<!-- Method syntax
public void MakePhoneCall(System.Guid phoneLine, System.String phoneNumber, Windows.Phone.Notification.Management.PhoneCallAudioEndpoint endPoint)
-->

# Windows.Phone.Notification.Management.AccessoryManager.MakePhoneCall

## -description
Makes a phone call.

## -parameters
### -param phoneLine
The identifier of the phone line. Maps to the [LineId](phonelinedetails_lineid.md) property in [PhoneLineDetails](phonelinedetails.md).

### -param phoneNumber
The number to call.

### -param endPoint
The audio end point of the call.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[MakePhoneCall(Guid, String)](accessorymanager_makephonecall_608864226.md)