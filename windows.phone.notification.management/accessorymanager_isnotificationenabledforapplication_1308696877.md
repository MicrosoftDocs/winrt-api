---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.IsNotificationEnabledForApplication(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsNotificationEnabledForApplication(System.String appId)
-->

# Windows.Phone.Notification.Management.AccessoryManager.IsNotificationEnabledForApplication

## -description
Gets a value indicating whether the calling accessory application will receive toast notifications from the specified application.

## -parameters
### -param appId
The identifier of the application.

## -returns
Returns true if the application supports notifications, otherwise false.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
