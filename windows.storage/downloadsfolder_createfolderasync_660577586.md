---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFolderAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderAsync(System.String desiredName)
-->

# Windows.Storage.DownloadsFolder.CreateFolderAsync

## -description
Creates a new subfolder in the Downloads folder.

## -parameters
### -param desiredName
The desired name of the subfolder to create.

If a subfolder with the specified name already exists, a similar but unique name will be used. For example, if *desiredName* is "MyFolder" and a subfolder by that name already exists in the Downloads folder, the new subfolder will be created with a name like "MyFolder (1)" instead.

## -returns
When this method completes, it returns the new subfolder as a [StorageFolder](storagefolder.md).

## -remarks

## -examples

## -see-also
[CreateFolderAsync(String, CreationCollisionOption)](downloadsfolder_createfolderasync_1043039832.md)