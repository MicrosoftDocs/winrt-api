---
-api-id: M:Windows.System.Launcher.LaunchFolderPathAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> Launcher.LaunchFolderPathAsync(String path)
-->

# Windows.System.Launcher.LaunchFolderPathAsync

## -description
Launches File Explorer and displays the contents of the specified folder.

## -parameters
### -param path
A filepath to the folder to open.

## -returns
The result of the operation.

## -remarks
This API must be called from within an ASTA thread (also known as a UI thread).
This API does not require the calling app to have access to the folder being launched.
This API will fail if the path does not point to a folder, or the user does not have access to that folder.

## -see-also
[LaunchFolderPathAsync(String, FolderLauncherOptions)](launcher_launchfolderpathasync_610775859.md)

## -examples

