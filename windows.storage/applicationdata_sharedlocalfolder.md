---
-api-id: P:Windows.Storage.ApplicationData.SharedLocalFolder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder SharedLocalFolder { get; }
-->

# Windows.Storage.ApplicationData.SharedLocalFolder

## -description
Gets the root folder in the shared app data store.

## -property-value
The file system folder that contains files.

## -remarks
### Accessing SharedLocalFolder

SharedLocalFolder is only available if the device has the appropriate group policy. If the group policy is not enabled, the device administrator must enable it. From Local Group Policy Editor, navigate to Computer Configuration\Administrative Templates\Windows Components\App Package Deployment, then change the setting "Allow a Windows app to share application data between users" to "Enabled."

After the group policy is enabled, SharedLocalFolder can be accessed.

## -examples

## -see-also
