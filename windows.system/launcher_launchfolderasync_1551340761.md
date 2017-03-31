---
-api-id: M:Windows.System.Launcher.LaunchFolderAsync(Windows.Storage.IStorageFolder,Windows.System.FolderLauncherOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> LaunchFolderAsync(Windows.Storage.IStorageFolder folder, Windows.System.FolderLauncherOptions options)
-->

# Windows.System.Launcher.LaunchFolderAsync

## -description
Launches File Explorer with the specified options and displays the contents of the specified folder.

## -parameters
### -param folder
The folder to display in File Explorer.

### -param options
Options that specify the amount of screen space that File Explorer fills, and the list of items to select in the specified folder.

## -returns
The result of the operation.

## -remarks
This API must be called from within an ASTA thread (also known as a UI thread).

## -examples

## -see-also
[LaunchFolderAsync(IStorageFolder)](launcher_launchfolderasync_1835049371.md)