---
-api-id: M:Windows.Storage.StorageLibrary.RequestRemoveFolderAsync(Windows.Storage.StorageFolder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestRemoveFolderAsync(Windows.Storage.StorageFolder folder)
-->

# Windows.Storage.StorageLibrary.RequestRemoveFolderAsync

## -description
Prompts the user to confirm removal of the specified folder from the current library, and then removes the folder.

## -parameters
### -param folder
The folder to remove.

## -returns
Returns true if the folder was removed; otherwise false.

## -remarks
> [!IMPORTANT]
> This method must be called from a UI thread.

## -examples

## -see-also
[Library management sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LibraryManagement)
