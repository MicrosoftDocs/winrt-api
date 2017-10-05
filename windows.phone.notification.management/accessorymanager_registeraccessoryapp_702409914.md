---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.RegisterAccessoryApp
-api-type: winrt method
---

<!-- Method syntax
public string RegisterAccessoryApp()
-->

# Windows.Phone.Notification.Management.AccessoryManager.RegisterAccessoryApp

## -description
Registers the accessory application with the [AccessoryManager](accessorymanager.md) and returns the trigger identifier.

## -returns
The trigger identifier for this accessory app. This trigger identifier is used to build a **DeviceManufacturerNotificationTrigger**.

## -remarks
This API displays a consent dialog box to the use in the following cases:


+ The app is not registered as an accessory app
+ The user has disabled the app via control panel


Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also

## -capabilities
accessoryManager
