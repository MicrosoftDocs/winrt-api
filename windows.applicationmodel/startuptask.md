---
-api-id: T:Windows.ApplicationModel.StartupTask
-api-type: winrt class
---

<!-- Class syntax.
public class StartupTask : Windows.ApplicationModel.IStartupTask
-->

# Windows.ApplicationModel.StartupTask

## -description
Represents a background task that runs automatically whenever the user logs in to their device.

## -remarks
This functionality is only supported on Windows Desktop.

An app must register for the "windows.startup" extension category in its manifest to be activated at startup or when a user logs in. Although this does not automatically make the app activatable at startup. The user must first launch the app, and the app must request to be enabled for startup activation, which will trigger a user-consent prompt.

```xml
desktop:Extension
    Category="windows.startupTask"
    Executable="bin\MyStartupTask.exe"
    EntryPoint="Windows.FullTrustApplication">
    <desktop:StartupTask
        TaskId="MyStartupTask"
        Enabled="true"
        DisplayName="Some Arbitrary Name" />
</desktop:Extension>
```

**Extension Category** must have the value "windows.startupTask"
**Extension Executable** is the relative path to the .exe to start
**Extension EntryPoint** must have the value "Windows.FullTrustApplication"
**StartupTask TaskId** is a unique identifier for your task. Using this identifier, your app can call the APIs in the Windows.ApplicationModel.StartupTask class to programmatically enable or disable a startup task.
**StartupTask Enabled** indicates whether the task first starts enabled or disabled. Enabled tasks will run the next time the user logs on (unless the user disables it).
**StartupTask DisplayName** is the name of the task that appears in Task Manager.

## -examples

## -see-also
