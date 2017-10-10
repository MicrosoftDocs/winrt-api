---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.EndPhoneCall(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void EndPhoneCall(System.UInt32 phoneCallId)
-->

# Windows.Phone.Notification.Management.AccessoryManager.EndPhoneCall

## -description
Ends a phone call for the given phone call identifier.

## -parameters
### -param phoneCallId
The identifier of the phone call. Get this value from [PhoneNotificationTriggerDetail.CallDetails.CallID](phonecalldetails_callid.md) property for an active incoming phone call.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also

## -capabilities
accessoryManager
