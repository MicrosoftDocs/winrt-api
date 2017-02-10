---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFileForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileForUserAsync(Windows.System.User user, System.String desiredName)
-->

# Windows.Storage.DownloadsFolder.CreateFileForUserAsync

## -description
Creates a new file inside the Downloads folder of a specific [User](../windows.system/user.md).

## -parameters
### -param user
The [User](../windows.system/user.md) for which the file is created.

### -param desiredName
The desired name of the file to create.

If a file with the specified name already exists, a similar but unique name will be used. For example, if *desiredName* is "MyFileName.jpg" and a file by that name already exists in the Downloads folder, the new file will be created with a name like "MyFileName (1).jpg" instead.

## -returns
When this method completes, it returns the new file as a [StorageFile](storagefile.md) object.

## -remarks

## -examples

## -see-also
[CreateFileForUserAsync(User, String, CreationCollisionOption)](downloadsfolder_createfileforuserasync_1659689414.md), [StorageFile](storagefile.md)