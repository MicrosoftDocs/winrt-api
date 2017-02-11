---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFolderForUserAsync(Windows.System.User,System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderForUserAsync(Windows.System.User user, System.String desiredName, Windows.Storage.CreationCollisionOption option)
-->

# Windows.Storage.DownloadsFolder.CreateFolderForUserAsync

## -description
Creates a new subfolder in the Downloads folder of a specific [User](../windows.system/user.md), and specifies what to do if a subfolder with the same name already exists in the Downloads folder.

## -parameters
### -param user
The [User](../windows.system/user.md) for which the folder is created.

### -param desiredName
The desired name of the subfolder to create.

If there is an existing subfolder in the Downloads folder that already has the specified *desiredName*, the specified [CreationCollisionOption](creationcollisionoption.md) determines how Windows responds to the conflict.

### -param option
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing subfolder in the Downloads folder.

Because the app can only access folders in the Downloads folder of the specified [User](../windows.system/user.md), you can't specify [OpenIfExists](creationcollisionoption.md) or [ReplaceExisting](creationcollisionoption.md) for this parameter.

## -returns
When this method completes, it returns the new subfolder as a [StorageFolder](storagefolder.md).

## -remarks

## -examples

## -see-also
[CreateFolderForUserAsync(User, String)](downloadsfolder_createfolderforuserasync_1347111441.md), [StorageFolder](storagefolder.md)