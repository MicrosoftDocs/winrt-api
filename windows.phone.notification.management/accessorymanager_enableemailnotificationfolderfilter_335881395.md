---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.EnableEmailNotificationFolderFilter(System.String,Windows.Foundation.Collections.IVectorView{System.String})
-api-type: winrt method
---

<!-- Method syntax
public void EnableEmailNotificationFolderFilter(System.String emailAccount, Windows.Foundation.Collections.IVectorView<System.String> folders)
-->

# Windows.Phone.Notification.Management.AccessoryManager.EnableEmailNotificationFolderFilter

## -description
Enables email notifications for specified folders in specified account.

## -parameters
### -param emailAccount
The email account to enable email notifications for.

### -param folders
The folders in the email account that the user wants to monitor.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
