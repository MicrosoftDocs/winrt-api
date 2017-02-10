---
-api-id: M:Windows.System.Launcher.LaunchUriForUserAsync(Windows.System.User,Windows.Foundation.Uri,Windows.System.LauncherOptions,Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.LaunchUriStatus> LaunchUriForUserAsync(Windows.System.User user, Windows.Foundation.Uri uri, Windows.System.LauncherOptions options, Windows.Foundation.Collections.ValueSet inputData)
-->

# Windows.System.Launcher.LaunchUriForUserAsync

## -description
Starts the default multi-user app associated with the URI scheme name for the specified URI, using the specified options and input data, and provides a specific [User](user.md) as context.

## -parameters
### -param user
The user context to pass to the launched app.

### -param uri
The URI scheme.

### -param options
The launch options for the app.

### -param inputData
The input data for the app.

## -returns
The status of the launch attempt.

## -remarks

## -examples

## -see-also
[LaunchUriForUserAsync(User, Uri)](launcher_launchuriforuserasync_1320100664.md), [LaunchUriForUserAsync(User, Uri, LauncherOptions)](launcher_launchuriforuserasync_1090504760.md)