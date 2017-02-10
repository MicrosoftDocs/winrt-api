---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetApps
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Phone.Notification.Management.AppNotificationInfo> GetApps()
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetApps

## -description
Gets a dictionary containing the name and id of the toast capable apps on the device.

## -returns
A dictionary containing the name and id of the apps. The value may be an empty string if the associated application is currently being updated.

## -remarks
It is possible for multiple applications to be updating and there is no guarantee how long it will take for the updates to complete. Depending on the requirements of the application, this indication can be used to


+ Take no special action if the apps are not needed by the accessory application.
+ Offer the user an option to refresh and discover more applications that may be available.
+ Automatically present additional apps as they become available.
+ Show a wait indicator and call GetApps periodically until all apps are finished updating.
+ Cache the app list and use the last known name until the update is completed.


Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
