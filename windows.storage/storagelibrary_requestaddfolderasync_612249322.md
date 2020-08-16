---
-api-id: M:Windows.Storage.StorageLibrary.RequestAddFolderAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> RequestAddFolderAsync()
-->

# Windows.Storage.StorageLibrary.RequestAddFolderAsync

## -description
Prompts the user to select a folder, and then adds the folder to the library. 

## -returns
When this method completes, it returns the folder that the user picked and added as a [StorageFolder](storagefolder.md). If the user cancels the operation and doesn't pick a folder, the method returns **null**.

## -remarks
The file picker displayed lets user select only library-eligible locations.
If there are pending suggestions a suggestion dialog will be shown instead of a folder picker.

## -examples

## -see-also
[Library management sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LibraryManagement)
