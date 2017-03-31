---
-api-id: M:Windows.System.Launcher.FindFileHandlersAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppInfo>> FindFileHandlersAsync(System.String extension)
-->

# Windows.System.Launcher.FindFileHandlersAsync

## -description
Enumerate the file handlers on the device.

## -parameters
### -param extension
The file extension that you want to find handlers for. For example, ".bat". Include the leading period '.'.

## -returns
A list of [AppInfo](../windows.applicationmodel/appinfo.md) s for each application that handles the specified file extension.

## -remarks
This API may also be called from Windows desktop application but does not return Windows desktop application.

## -examples

## -see-also
