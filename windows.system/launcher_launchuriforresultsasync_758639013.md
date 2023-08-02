---
-api-id: M:Windows.System.Launcher.LaunchUriForResultsAsync(Windows.Foundation.Uri,Windows.System.LauncherOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchUriResult> LaunchUriForResultsAsync(Windows.Foundation.Uri uri, Windows.System.LauncherOptions options)
-->

# Windows.System.Launcher.LaunchUriForResultsAsync

## -description

Asynchronously starts the default app associated with the URI scheme name for the specified URI, using the specified options.

## -parameters

### -param uri

The Uri to launch.

### -param options

The launch options.

## -returns

When this method completes, it returns the results of the launch.

## -remarks

Launching an app for results allows you to launch an app from another app and exchange data between the two.

This API must be called from within an ASTA thread (also known as a UI thread).

When calling this method, the *options* parameter must contain a valid value for [LauncherOptions.TargetApplicationPackageFamilyName](launcheroptions_targetapplicationpackagefamilyname.md).

## -examples

## -see-also

[LaunchUriForResultsAsync(Uri, LauncherOptions, ValueSet)](launcher_launchuriforresultsasync_148601521.md), [Launch an app for results](/windows/uwp/launch-resume/how-to-launch-an-app-for-results), [LauncherOptions](launcheroptions.md)
