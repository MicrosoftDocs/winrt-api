---
-api-id: M:Windows.System.Launcher.QueryFileSupportAsync(Windows.Storage.StorageFile)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchQuerySupportStatus> QueryFileSupportAsync(Windows.Storage.StorageFile file)
-->

# Windows.System.Launcher.QueryFileSupportAsync

## -description
Asynchronously query whether an app can be activated for the specified file.

## -parameters
### -param file
The file for which to query support.

## -returns
A value that indicates whether an application can be activated for the file.

## -remarks
This API may also be called from Windows desktop application.

Both Windows desktop application and Universal Windows Platform (UWP) app are considered.

## -examples

## -see-also
[QueryFileSupportAsync(StorageFile, String)](launcher_queryfilesupportasync_274102192.md)