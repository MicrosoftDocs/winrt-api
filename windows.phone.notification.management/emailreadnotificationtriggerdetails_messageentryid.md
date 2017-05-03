---
-api-id: P:Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.MessageEntryId
-api-type: winrt property
---

<!-- Property syntax
public Windows.Phone.Notification.Management.BinaryId MessageEntryId { get; }
-->

# Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.MessageEntryId

## -description
Represents a unique identifier for an individual email in phone MAPI store.

## -property-value
The identifier for the email.

## -remarks
To set the right context, the app will get this as part of a new email trigger as well as email read status change trigger. The [messageEntryId](emailnotificationtriggerdetails_messageentryid.md) can be used by [AccessoryManager.UpdateEmailReadStatus](accessorymanager_updateemailreadstatus.md) API to update the read status of an email identified by the entry id.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.



## -examples

## -see-also
