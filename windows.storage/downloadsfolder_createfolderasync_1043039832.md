---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFolderAsync(System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderAsync(System.String desiredName, Windows.Storage.CreationCollisionOption option)
-->

# Windows.Storage.DownloadsFolder.CreateFolderAsync

## -description
Creates a new subfolder in the Downloads folder, and specifies what to do if a subfolder with the same name already exists in the Downloads folder.

## -parameters
### -param desiredName
The desired name of the subfolder to create.

If there is an existing subfolder in the Downloads folder that already has the specified *desiredName*, the specified [CreationCollisionOption](creationcollisionoption.md) determines how Windows responds to the conflict.

### -param option
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing subfolder in the Downloads folder.

Because the app can only access folders in the Downloads folder that it created, you can't specify [OpenIfExists](creationcollisionoption.md) or [ReplaceExisting](creationcollisionoption.md) for this parameter.

## -returns
When this method completes, it returns the new subfolder as a [StorageFolder](storagefolder.md).

## -remarks

## -examples

## -see-also
[CreateFolderAsync(String)](downloadsfolder_createfolderasync_660577586.md)