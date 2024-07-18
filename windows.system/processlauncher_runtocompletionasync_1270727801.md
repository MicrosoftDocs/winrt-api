---
-api-id: M:Windows.System.ProcessLauncher.RunToCompletionAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.ProcessLauncherResult> RunToCompletionAsync(System.String fileName, System.String args)
-->

# Windows.System.ProcessLauncher.RunToCompletionAsync

## -description

Launches a new process. This asynchronous function completes when the launched process terminates.

## -parameters

### -param fileName

The name of the process to launch.

### -param args

Arguments for running the process.

## -returns

When the asynchronous operation completes, it contains the exit code from the launched process.

## -remarks

This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

To launch a process the .exe must either be contained in the .appx package or be registered in the allow list for this API. To add an .exe to the allow list modify **HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\EmbeddedMode\ProcessLauncher:AllowedExecutableFilesList** and add your executable to the REG_MULTI_SZ formatted string.

For example:

```cmd
    reg ADD "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\EmbeddedMode\ProcessLauncher" /f /v AllowedExecutableFilesList /t REG_MULTI_SZ /d "c:\windows\system32\cmd.exe\0"
```

## -examples

## -see-also

[RunToCompletionAsync(String, String, ProcessLauncherOptions)](processlauncher_runtocompletionasync_1909636529.md)

## -capabilities

systemManagement
