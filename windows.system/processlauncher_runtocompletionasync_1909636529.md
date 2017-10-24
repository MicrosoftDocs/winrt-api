
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

To launch a process the .exe must either be contained in the .appx package or be registered in the whitelist for this API. To add an .exe to the whitelist modify **HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\EmbeddedMode\ProcessLauncher:AllowedExecutableFilesList** and add your executable to the REG_MULTI_SZ formatted string.

For example:
```
    reg ADD "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\EmbeddedMode\ProcessLauncher" /f /v AllowedExecutableFilesList /t REG_MULTI_SZ /d "c:\windows\system32\cmd.exe\0"
```

Alternatively, click or tap the button below to enter your Administrator account's password and attempt to enable the command line processor.

## -examples

## -see-also
[RunToCompletionAsync(String, String)](processlauncher_runtocompletionasync_1270727801.md)

## -capabilities
systemManagement
