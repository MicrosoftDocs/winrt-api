---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironment.LaunchFileWithUIAsync(System.String,System.String,System.String,Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IsolatedWindowsEnvironmentLaunchFileResult> IsolatedWindowsEnvironment.LaunchFileWithUIAsync(String appExePath, String argumentsTemplate, String filePath, IsolatedWindowsEnvironmentTelemetryParameters telemetryParameters)
-->

# Windows.Security.Isolation.IsolatedWindowsEnvironment.LaunchFileWithUIAsync

## -description

**Deprecated.** Allows applications to open files in an Isolated Windows Environment with telemetry correlation.

## -parameters

### -param appExePath

String of application execution path.

### -param argumentsTemplate

String to specify the relative position of filepath with respect to other arguments to be passed:
"%1 /foo" will execute the file launch as "appname.exe fileapth /foo" in the container
%1 is replace by filepath
"/foo %1" => "appname.exe /foo filepath"
"/foo %1 /bar" => "appname.exe /foo filepath /bar"

### -param filePath

String for path of file to be opened in Isolated Windows Environment

### -param telemetryParameters

Telemetry parameters defined by [isolatedwindowsenvironmenttelemetryparameters](isolatedwindowsenvironmenttelemetryparameters.md)

## -returns

[IsolatedWindowsEnvironmentLaunchFileResult](isolatedwindowsenvironmentlaunchfileresult.md)

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

## -examples
