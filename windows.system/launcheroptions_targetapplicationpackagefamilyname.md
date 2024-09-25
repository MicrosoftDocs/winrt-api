---
-api-id: P:Windows.System.LauncherOptions.TargetApplicationPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string TargetApplicationPackageFamilyName { get;  set; }
-->

# Windows.System.LauncherOptions.TargetApplicationPackageFamilyName

## -description

The package family name of the target package that should be used to launch a file or URI. This property is optional in some cases. See **Remarks**.

## -property-value

The package family name of the target package that should be used to launch a file or URI. This property is optional in some cases. See **Remarks**.

## -remarks

An application's PackageFamilyName can be obtained via the [PackageID class](/en-us/uwp/api/Windows.ApplicationModel.PackageId#Windows_ApplicationModel_PackageId_FamilyName)

A PackageFamilyName can vary depending on how an application has been published, but it will generally follow the form of `[package name]_[publisher_id]`. For example, an unpublished app has a family name similar to `c04742a8-1c87-41c1-b951-cc6e6f353400_g3nsfcgfwzqga`

In some cases, when you call [Launcher](launcher.md) static methods to launch an app associated with a file type or URI protocol, you must specify exactly which app you want to be launched by passing a [LauncherOptions](launcheroptions.md) parameter with the **TargetApplicationPackageFamilyName** property set to the package family name for the app package containing that app.

Two such cases are as follows:

1. You want to launch an app with a URI and pass extra input data to the launched app, using [Launcher.LaunchUriAsync(Uri, LauncherOptions, ValueSet)](launcher_launchuriasync_569877360.md).
1. You want to launch an app with a URI and wait for the app to send output data back to your app, using any overload of [Launcher.LaunchUriForResultsAsync](launcher_launchuriforresultsasync_148601521.md).

In these cases, both the calling app and launched app need to agree on how to interpret the extra data passed from one app to the other. The calling app cannot launch any app that happens to be the default for that URI protocol.

## -examples

## -see-also
