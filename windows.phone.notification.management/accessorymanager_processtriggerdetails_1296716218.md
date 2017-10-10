---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.ProcessTriggerDetails(Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails)
-api-type: winrt method
---

<!-- Method syntax
public void ProcessTriggerDetails(Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails pDetails)
-->

# Windows.Phone.Notification.Management.AccessoryManager.ProcessTriggerDetails

## -description
Indicates to the [AccessoryManager](accessorymanager.md) that the specified trigger details has been processed by the accessory. This will remove it from the [AccessoryManager](accessorymanager.md) trigger details queue.

## -parameters
### -param pDetails
The trigger details that should be marked as processed by the accessory.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also

## -capabilities
accessoryManager
