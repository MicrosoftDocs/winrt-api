---
-api-id: M:Windows.System.Launcher.LaunchUriAsync(Windows.Foundation.Uri,Windows.System.LauncherOptions,Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> LaunchUriAsync(Windows.Foundation.Uri uri, Windows.System.LauncherOptions options, Windows.Foundation.Collections.ValueSet inputData)
-->

# Windows.System.Launcher.LaunchUriAsync

## -description

Starts the default app associated with the URI scheme name for the specified URI, using the specified options and input data.

## -parameters

### -param uri

The URI.

### -param options

The launch options for the app.

> [!IMPORTANT]
> The [TargetApplicationPackageFamilyName](launcheroptions_targetapplicationpackagefamilyname.md) property of the *options* parameter, while sometimes optional, is required for this overload of the **LaunchUriAsync** method.

### -param inputData

The input data for the app.

> [!IMPORTANT]
> The amount of data that can be transferred must not exceed 100 KB.

## -returns

Returns **true** if the default app for the URI scheme was launched; **false** otherwise.

## -remarks

Unless you are calling this API from a Windows desktop application, this API must be called from within an ASTA thread (also known as the UI thread).

This API may also be called from a Windows desktop application.

This API launches the default app for the scheme whether it be a Universal Windows Platform (UWP) app or Windows desktop application.

## -examples

## -see-also

[LaunchUriAsync(Uri)](launcher_launchuriasync_53691900.md), [LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)