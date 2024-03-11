---
-api-id: M:Windows.System.Launcher.FindUriSchemeHandlersAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppInfo>> FindUriSchemeHandlersAsync(System.String scheme)
-->

# Windows.System.Launcher.FindUriSchemeHandlersAsync

## -description
Enumerate the scheme handlers on the device.

## -parameters
### -param scheme
The scheme name that you want to find handlers for. For example, "ms-lens".

## -returns
A list of [AppInfo](../windows.applicationmodel/appinfo.md)s for each application that handles the specified scheme.

## -remarks
This API may also be called from Windows desktop application but does not return Windows desktop application.

## -examples

## -see-also
[FindUriSchemeHandlersAsync(String, LaunchQuerySupportType)](launcher_findurischemehandlersasync_93628191.md)
