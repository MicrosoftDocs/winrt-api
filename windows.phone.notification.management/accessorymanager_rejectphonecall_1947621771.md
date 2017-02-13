---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.RejectPhoneCall(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void RejectPhoneCall(System.UInt32 phoneCallId, System.UInt32 textResponseID)
-->

# Windows.Phone.Notification.Management.AccessoryManager.RejectPhoneCall

## -description
Rejects a phone call with the given identifier and sends a SMS response.

## -parameters
### -param phoneCallId
The phone call identifier.

### -param textResponseID
The identifier for the [TextResponse](textresponse.md).

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[RejectPhoneCall(UInt32)](accessorymanager_rejectphonecall_1944142969.md)