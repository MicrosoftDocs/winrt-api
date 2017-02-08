---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFolderForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderForUserAsync(Windows.System.User user, System.String desiredName)
-->

# Windows.Storage.DownloadsFolder.CreateFolderForUserAsync

## -description
Creates a new subfolder inside the Downloads folder of a specific [User](../windows.system/user.md).

## -parameters
### -param user
The [User](../windows.system/user.md) for which the folder is created.

### -param desiredName
The desired name of the subfolder to create.

If a subfolder with the specified name already exists, a similar but unique name will be used. For example, if *desiredName* is "MyFolder" and a subfolder by that name already exists in the Downloads folder, the new subfolder will be created with a name like "MyFolder (1)" instead.

## -returns
When this method completes, it returns the new subfolder as a [StorageFolder](storagefolder.md).

## -remarks

## -examples

## -see-also
[CreateFolderForUserAsync(User, String, CreationCollisionOption)](downloadsfolder_createfolderforuserasync_1654881475.md), [StorageFolder](storagefolder.md)