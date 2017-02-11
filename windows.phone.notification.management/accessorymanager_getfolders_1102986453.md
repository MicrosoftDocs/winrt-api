---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetFolders(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Phone.Notification.Management.EmailFolderInfo> GetFolders(System.String emailAccount)
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetFolders

## -description
Gets a list of email folders that are defined on the phone.

## -parameters
### -param emailAccount
The email account where the folders are defined.

## -returns
A collection of EmailFolderInfo objects.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
