---
-api-id: M:Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager.AddFile(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public string AddFile(Windows.Storage.IStorageFile file)
-->

# Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager.AddFile

## -description
Gets the sharing token that enables an app to share the specified file with another app.

## -parameters
### -param file
The file to share with the target app.

## -returns
The sharing token to provide to the target app .

## -remarks
When a source app shares a file with a target app, the source app calls the [AddFile](sharedstorageaccessmanager_addfile_731286892.md) method to get the sharing token that it passes to the target app.

For a code sample, see [SharedStorageAccessManager](sharedstorageaccessmanager.md).

## -examples

## -see-also
