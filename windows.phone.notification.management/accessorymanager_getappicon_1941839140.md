---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetAppIcon(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IRandomAccessStreamReference GetAppIcon(System.String appId)
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetAppIcon

## -description
Gets an icon for the given application identifier.

## -parameters
### -param appId
The identifier associated with the application.

## -returns
The stream containing the app's icon.

## -remarks
Accessories can display a list of apps that it can receive notifications from; the accessory can use this method to get icons for the apps.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also

## -capabilities
accessoryManager
