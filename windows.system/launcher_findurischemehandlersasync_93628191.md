---
-api-id: M:Windows.System.Launcher.FindUriSchemeHandlersAsync(System.String,Windows.System.LaunchQuerySupportType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppInfo>> FindUriSchemeHandlersAsync(System.String scheme, Windows.System.LaunchQuerySupportType launchQuerySupportType)
-->

# Windows.System.Launcher.FindUriSchemeHandlersAsync

## -description
Enumerate the scheme handlers on the device.

## -parameters
### -param scheme
The scheme name that you find to find handlers for. For example, "ms-lens".

### -param launchQuerySupportType
Filter the list of handlers by whether they can be launched for results or not.

## -returns
A list of [AppInfo](../windows.applicationmodel/appinfo.md)s for each application that handles the specified scheme.

## -remarks
This API may also be called from Windows desktop application but does not return Windows desktop application.

## -examples

## -see-also
[FindUriSchemeHandlersAsync(String)](launcher_findurischemehandlersasync_240771517.md)