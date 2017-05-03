---
-api-id: M:Windows.System.Launcher.QueryUriSupportAsync(Windows.Foundation.Uri,Windows.System.LaunchQuerySupportType,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchQuerySupportStatus> QueryUriSupportAsync(Windows.Foundation.Uri uri, Windows.System.LaunchQuerySupportType launchQuerySupportType, System.String packageFamilyName)
-->

# Windows.System.Launcher.QueryUriSupportAsync

## -description
Asynchronously query whether an app can be activated for the specified URI, launch type, and package name.

## -parameters
### -param uri
The URI for which to query support.

### -param launchQuerySupportType
The type of launch for which to query support.

### -param packageFamilyName
Specifies a specific package that will be used to launch this URI.

## -returns
A value that indicates whether the application is available to launch the URI.

## -remarks
This API may also be called from Windows desktop application.

Both Windows desktop application and Universal Windows Platform (UWP) app are considered.

## -examples

## -see-also
[QueryUriSupportAsync(Uri, LaunchQuerySupportType)](launcher_queryurisupportasync_1636475956.md)