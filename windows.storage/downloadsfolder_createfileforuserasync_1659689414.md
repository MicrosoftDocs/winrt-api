---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFileForUserAsync(Windows.System.User,System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileForUserAsync(Windows.System.User user, System.String desiredName, Windows.Storage.CreationCollisionOption option)
-->

# Windows.Storage.DownloadsFolder.CreateFileForUserAsync

## -description
Creates a new file in the Downloads folder of a specific [User](../windows.system/user.md), and specifies what to do if a file with the same name already exists in the Downloads folder.

## -parameters
### -param user
The [User](../windows.system/user.md) for which the file is created.

### -param desiredName
The desired name of the file to create.

If there is an existing file in the current folder that already has the specified *desiredName*, the specified [CreationCollisionOption](creationcollisionoption.md) determines how Windows responds to the conflict.

### -param option
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing file in the current folder.

Because the app can only access files in the Downloads folder of the specified [User](../windows.system/user.md), you can't specify [OpenIfExists](creationcollisionoption.md) or [ReplaceExisting](creationcollisionoption.md) for this parameter.

## -returns
When this method completes, it returns the new file as a [StorageFile](storagefile.md) object.

## -remarks

## -examples

## -see-also
[CreateFileForUserAsync(User, String)](downloadsfolder_createfileforuserasync_1342500630.md), [StorageFile](storagefile.md)