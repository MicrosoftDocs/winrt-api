---
-api-id: M:Windows.System.ProcessLauncher.RunToCompletionAsync(System.String,System.String,Windows.System.ProcessLauncherOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.ProcessLauncherResult> RunToCompletionAsync(System.String fileName, System.String args, Windows.System.ProcessLauncherOptions options)
-->

# Windows.System.ProcessLauncher.RunToCompletionAsync

## -description
Launches a new process, including the specified options.

## -parameters
### -param fileName
File name of process to start.

### -param args
Arguments for the specified process.

### -param options
Associated options for running the process.

## -returns
When this method completes, it returns the results of the process.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also
[RunToCompletionAsync(String, String)](processlauncher_runtocompletionasync_1270727801.md)

## -capabilities
systemManagement