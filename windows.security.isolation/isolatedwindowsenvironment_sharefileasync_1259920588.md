---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironment.ShareFileAsync(System.String,Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions,Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters)
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironment.ShareFileAsync(System.String,Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions,Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileResult> ShareFileAsync (string filePath, Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions options, Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters telemetryParameters);
-->

## -description

**Deprecated.** Share host file with Isolated Windows Environment with telemetry correlation.

## -parameters

### -param filePath

String of host file path.

### -param options

[IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md)

### -param telemetryParameters

Telemetry parameters defined by [IsolatedWindowsEnvironmentTelemetryParameters](isolatedwindowsenvironmenttelemetryparameters.md)

## -returns

[IsolatedWindowsEnvironmentShareFileResult](isolatedwindowsenvironmentsharefileresult.md)

## -remarks

> [!WARNING]
> This is a deprecated API.

The shared file shall appear in a folder with a randomly generated file path in the Isolated Windows Environment that will be provided in the [IsolatedWindowsEnvironmentShareFileResult](isolatedwindowsenvironmentsharefileresult.md). Any data written to this folder will be copied back to the host. It is recommended to set the AllowWrite flag to false in [isolatedwindowsenvironmentsharefilerequestoptions](isolatedwindowsenvironmentsharefilerequestoptions.md) to prevent this.

## -see-also

## -examples
