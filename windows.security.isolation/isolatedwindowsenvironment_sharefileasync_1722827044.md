---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironment.ShareFileAsync(System.String,Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions)
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironment.ShareFileAsync(System.String,Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileResult> ShareFileAsync (string filePath, Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileRequestOptions options);
-->

## -description

**Deprecated.** Share host file with Isolated Windows Environment.

## -parameters

### -param filePath

String of host file path.

### -param options

[IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md)

## -returns

[IsolatedWindowsEnvironmentShareFileResult](isolatedwindowsenvironmentsharefileresult.md)

## -remarks

> [!WARNING]
> This is a deprecated API.

The shared file shall appear in a folder with a randomly generated file path in the Isolated Windows Environment that will be provided in the [IsolatedWindowsEnvironmentShareFileResult](isolatedwindowsenvironmentsharefileresult.md). Any data written to this folder will be copied back to the host. It is recommended to set the AllowWrite flag to false in [IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md) to prevent this.

## -examples
