---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetAllEmailAccounts
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Phone.Notification.Management.EmailAccountInfo> GetAllEmailAccounts()
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetAllEmailAccounts

## -description
Gets the email accounts on the device.

## -returns
The collection of EmailAccountInfo objects containing the data about the email accounts on the device.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

An accessory may want to allow filtering for email accounts defined on the phone. This could limit the number of new email notifications that are sent to the accessory. A common use of account filtering would be where a user has both a work and private email account on their phone, but only wants to see notifications on their accessory for incoming emails to their private account.

## -examples

## -see-also

## -capabilities
accessoryManager
