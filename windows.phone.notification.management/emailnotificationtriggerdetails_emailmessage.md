---
-api-id: P:Windows.Phone.Notification.Management.EmailNotificationTriggerDetails.EmailMessage
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Email.EmailMessage EmailMessage { get; }
-->

# Windows.Phone.Notification.Management.EmailNotificationTriggerDetails.EmailMessage

## -description
An [EmailMessage](../windows.applicationmodel.email/emailmessage.md) object that contains additional details about the email.

## -property-value
The interface for [Windows.ApplicationModel.Email.EmailMessage](../windows.applicationmodel.email/emailmessage_emailmessage.md).

## -remarks
The attachment data object for the [Windows.ApplicationModel.Email.EmailMessage](../windows.applicationmodel.email/emailmessage_emailmessage.md) object associated with [EmailNotificationTriggerDetails](emailnotificationtriggerdetails.md) will always be null. The [AccessoryManager](accessorymanager.md) APIs only provide a list of attachment files by name only.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[Windows.ApplicationModel.Email.EmailMessage](../windows.applicationmodel.email/emailmessage_emailmessage.md)