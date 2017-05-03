---
-api-id: M:Windows.System.Launcher.QueryFileSupportAsync(Windows.Storage.StorageFile,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchQuerySupportStatus> QueryFileSupportAsync(Windows.Storage.StorageFile file, System.String packageFamilyName)
-->

# Windows.System.Launcher.QueryFileSupportAsync

## -description
Asynchronously query whether an app with the specified package name can be activated for the specified file.

## -parameters
### -param file
The file for which to query support.

### -param packageFamilyName
The package for which to query support.

## -returns
A value that indicates whether an application can be activated for the file.

## -remarks
This API may also be called from Windows desktop application.

Both Windows desktop application and Universal Windows Platform (UWP) app are considered.

## -examples

## -see-also
[QueryFileSupportAsync(StorageFile)](launcher_queryfilesupportasync_1554676240.md)