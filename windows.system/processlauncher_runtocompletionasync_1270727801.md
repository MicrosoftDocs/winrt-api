---
-api-id: M:Windows.System.ProcessLauncher.RunToCompletionAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.ProcessLauncherResult> RunToCompletionAsync(System.String fileName, System.String args)
-->

# Windows.System.ProcessLauncher.RunToCompletionAsync

## -description
Launches a new process.

## -parameters
### -param fileName
The name of the process to launch.

### -param args
Arguments for running the process.

## -returns
When this method completes, it returns the results of the process.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also
[RunToCompletionAsync(String, String, ProcessLauncherOptions)](processlauncher_runtocompletionasync_1909636529.md)

## -capabilities
systemManagement