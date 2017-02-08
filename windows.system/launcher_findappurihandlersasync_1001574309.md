---
-api-id: M:Windows.System.Launcher.FindAppUriHandlersAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppInfo>> FindAppUriHandlersAsync(Windows.Foundation.Uri uri)
-->

# Windows.System.Launcher.FindAppUriHandlersAsync

## -description
Enumerate the Uniform Resource Identifiers (URI) handlers on the device.

## -parameters
### -param uri
The Uri that you want to find handlers for.

## -returns
A list of [AppInfo](../windows.applicationmodel/appinfo.md) objects representing each application that handles the specified http(s) URI.

## -remarks
This API may also be called from Windows desktop application but does not return Windows desktop application.

## -examples

## -see-also
