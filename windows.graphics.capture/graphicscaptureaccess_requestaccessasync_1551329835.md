---
-api-id: M:Windows.Graphics.Capture.GraphicsCaptureAccess.RequestAccessAsync(Windows.Graphics.Capture.GraphicsCaptureAccessKind)
-api-type: winrt method
---

# Windows.Graphics.Capture.GraphicsCaptureAccess.RequestAccessAsync(Windows.Graphics.Capture.GraphicsCaptureAccessKind)

<!--
public static Windows.Foundation.IAsyncOperation<Windows.Security.Authorization.AppCapabilityAccess.AppCapabilityAccessStatus> RequestAccessAsync (Windows.Graphics.Capture.GraphicsCaptureAccessKind request);
-->


## -description

Requests access for graphics capture features that require user consent.

## -parameters

### -param request

A member of the [GraphicsCaptureAccessKind](graphicscaptureaccesskind.md) enumeration specifying the type of access being requested.

## -returns

An asynchronous operation that returns an [AppCapabilityAccessStatus](/uwp/api/windows.security.authorization.appcapabilityaccess.appcapabilityaccessstatus) upon completion.

## -remarks

To call **RequestAccessAsync** with the value **GraphicsCaptureAccessKind.Borderless**, you must declare the **graphicsCaptureWithoutBorder** capability in your app's package manifest. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -see-also

## -examples


