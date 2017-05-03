---
-api-id: M:Windows.System.Launcher.QueryUriSupportAsync(Windows.Foundation.Uri,Windows.System.LaunchQuerySupportType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchQuerySupportStatus> QueryUriSupportAsync(Windows.Foundation.Uri uri, Windows.System.LaunchQuerySupportType launchQuerySupportType)
-->

# Windows.System.Launcher.QueryUriSupportAsync

## -description
Asynchronously query whether an app can be activated for the specified URI and launch type.

## -parameters
### -param uri
The URI for which to query support.

### -param launchQuerySupportType
The type of launch for which to query support.

## -returns
A value that indicates whether an application is available to launch the URI.

## -remarks
This API may also be called from Windows desktop application.

Both Windows desktop application and Universal Windows Platform (UWP) app are considered.

## -examples

## -see-also
[QueryUriSupportAsync(Uri, LaunchQuerySupportType, String)](launcher_queryurisupportasync_126697652.md)