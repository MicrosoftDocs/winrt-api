---
-api-id: M:Windows.Storage.StorageFolder.CreateFolderAsync(System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderAsync(System.String desiredName, Windows.Storage.CreationCollisionOption options)
-->

# Windows.Storage.StorageFolder.CreateFolderAsync

## -description
Creates a new subfolder with the specified name in the current folder. This method also specifies what to do if a subfolder with the same name already exists in the current folder.

## -parameters
### -param desiredName
The name of the new subfolder to create in the current folder.

### -param options
One of the enumeration values that determines how to handle the collision if a subfolder with the specified *desiredName* already exists in the current folder.

## -returns
When this method completes, it returns a [StorageFolder](storagefolder.md) that represents the new subfolder.

## -exceptions
### T:System.IO.FileNotFoundException

The folder name contains invalid characters, or the format of the folder name is incorrect. Check the value of *desiredName*.

### T:System.UnauthorizedAccessException

You don't have permission to create a subfolder in the current folder.

## -remarks
If a folder with the specified *desiredName* already exists in the current folder, the specified [CreationCollisionOption](creationcollisionoption.md) determines how to handle the collision.

## -examples

## -see-also
[CreateFolderAsync(String)](storagefolder_createfolderasync_660577586.md)