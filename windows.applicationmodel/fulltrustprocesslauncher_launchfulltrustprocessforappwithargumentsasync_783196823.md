---
-api-id: M:Windows.ApplicationModel.FullTrustProcessLauncher.LaunchFullTrustProcessForAppWithArgumentsAsync(System.String,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.FullTrustProcessLauncher.LaunchFullTrustProcessForAppWithArgumentsAsync(System.String,System.String)

<!--
public static Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.FullTrustProcessLaunchResult> LaunchFullTrustProcessForAppWithArgumentsAsync (string fullTrustPackageRelativeAppId, string commandLine);
-->


## -description

Launch the full-trust process for the specified application ID with the specified command line parameters.

## -parameters

### -param fullTrustPackageRelativeAppId

The process-relative application identifier of the app whose full trust process component the caller wants to launch. The full-trust process can parse this to determine which app invoked it.

### -param commandLine

The command line arguments with which to launch the process.

## -returns

An asynchronous operation that returns a [FullTrustProcessLaunchResult](fulltrustprocesslaunchresult.md) on completion.

## -remarks

## -see-also

## -examples


