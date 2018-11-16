---
-api-id: M:Windows.System.Launcher.LaunchFolderPathAsync(System.String,Windows.System.FolderLauncherOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> Launcher.LaunchFolderPathAsync(String path, FolderLauncherOptions options)
-->

# Windows.System.Launcher.LaunchFolderPathAsync

## -description
Launches File Explorer with the specified options and displays the contents of the specified folder.

## -parameters
### -param path
A filepath to the folder to open.

### -param options
Options that specify the amount of screen space that File Explorer fills, and the list of items to select in the specified folder.

## -returns
The result of the operation.

## -remarks
This API must be called from within an ASTA thread (also known as a UI thread).
This API does not require the calling app to have access to the folder being launched.
This API will fail if the path does not point to a folder, or the user does not have access to that folder.

## -see-also
[LaunchFolderPathAsync(String)](launcher_launchfolderpathasync_359695985.md)

## -examples

