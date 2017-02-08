---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.EnableNotificationsForApplication(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void EnableNotificationsForApplication(System.String appId)
-->

# Windows.Phone.Notification.Management.AccessoryManager.EnableNotificationsForApplication

## -description
Opt into getting toast and app uninstall notifications from the specified app.

## -parameters
### -param appId
The string containing the id of the application to give notifications.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[AccessoryManager.GetApps](accessorymanager_getapps.md)