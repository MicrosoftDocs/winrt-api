---
-api-id: M:Windows.Storage.DownloadsFolder.CreateFileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileAsync(System.String desiredName)
-->

# Windows.Storage.DownloadsFolder.CreateFileAsync

## -description
Creates a new file inside the Downloads folder.

## -parameters
### -param desiredName
The desired name of the file to create.

If a file with the specified name already exists, a similar but unique name will be used. For example, if *desiredName* is "MyFileName.jpg" and a file by that name already exists in the Downloads folder, the new file will be created with a name like "MyFileName (1).jpg" instead.

## -returns
When this method completes, it returns the new file as a [StorageFile](storagefile.md) object.

## -remarks

## -examples

## -see-also
[CreateFileAsync(String, CreationCollisionOption)](downloadsfolder_createfileasync_1058061470.md)