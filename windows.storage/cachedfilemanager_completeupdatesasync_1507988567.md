---
-api-id: M:Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Provider.FileUpdateStatus> CompleteUpdatesAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Storage.CachedFileManager.CompleteUpdatesAsync

## -description
Initiates updates for the specified file. This method contacts the app that provided the file to perform the updates.




## -parameters
### -param file
The file to update.

## -returns
When this method completes, it returns a [FileUpdateStatus](../windows.storage.provider/fileupdatestatus.md) enum value that describes the status of the updates to the file.

## -remarks
Using this method ensures that the updates to the file are completed which may require Windows to ask for user input.  For example, the app that provided the file may be activated to perform updates and that app may display UI through a file picker.



## -examples

## -see-also
