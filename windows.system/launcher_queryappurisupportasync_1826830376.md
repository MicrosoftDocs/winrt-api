---
-api-id: M:Windows.System.Launcher.QueryAppUriSupportAsync(Windows.Foundation.Uri,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchQuerySupportStatus> QueryAppUriSupportAsync(Windows.Foundation.Uri uri, System.String packageFamilyName)
-->

# Windows.System.Launcher.QueryAppUriSupportAsync

## -description
Asynchronously query whether the specified app can handle the specified URI.

## -parameters
### -param uri
The URI of the website.

### -param packageFamilyName
Specifies a specific package that will be used to launch this URI.

## -returns
A value that indicates whether the application is available to launch the URI.

## -remarks
Windows desktop application are not considered.

## -examples

## -see-also
[QueryAppUriSupportAsync(Uri)](launcher_queryappurisupportasync_538916248.md)