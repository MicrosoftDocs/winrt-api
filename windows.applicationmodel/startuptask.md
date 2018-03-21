---
-api-id: T:Windows.ApplicationModel.StartupTask
-api-type: winrt class
---

<!-- Class syntax.
public class StartupTask : Windows.ApplicationModel.IStartupTask
-->

# Windows.ApplicationModel.StartupTask

## -description
Represents a UWP app, or a Desktop Bridge background task, that runs at system startup or when the user logs in to their device.

## -remarks
This functionality is only supported on Windows Desktop.

Startup support for Desktop Bridge apps was introduced in the Windows 10 Anniversary Update (version 1607).
Startup support for regular UWP apps was introduced in the Windows 10 Fall Creators Update (version 1709).

An app must add the `windows.startup` extension category to its manifest in order to be activated at startup or when the user logs in. Adding this extension will not, by itself, automatically cause the app start.

Regular UWP apps must first be launched by the user, and they must call [RequestEnableAsync](https://docs.microsoft.com/uwp/api/Windows.ApplicationModel.StartupTask.RequestEnableAsync) from a UI thread to trigger a user-consent dialog. If the user consents, the UWP app will then start on startup or user log in. If **RequestEnableAsync** is called from a Desktop Bridge app, no user-consent dialog is shown.

Desktop Bridge apps can set their startup tasks to **Enabled** in the manifest, in which case they do not need to call [RequestEnableAsync](https://docs.microsoft.com/uwp/api/Windows.ApplicationModel.StartupTask.RequestEnableAsync). However, the user must launch the Desktop Bridge app at least once before it will launch at startup or user login in.

For both Desktop Bridge apps and regular UWP apps, the user is in control, and can change the enabled state of your app at any time via the **Startup** tab in Task Manager.

UWP startup apps start minimized.

The extension declaration is different depending on whether it is for a Desktop Bridge app or a regular UWP app.

### Desktop Bridge App startup task extension

```xml
<Package xmlns:uap5="http://schemas.microsoft.com/appx/manifest/uap/windows10/5"...>
...
<Applications>
    <Application ...>
        ...
        <Extensions>
          <uap5:Extension
            Category="windows.startupTask"
            Executable="MyDesktopBridgeApp.exe"
            EntryPoint="Windows.FullTrustApplication">
            <uap5:StartupTask
              TaskId="MyStartupId"
              Enabled="false"
              DisplayName="My Desktop Bridge App" />
          </uap5:Extension>
        </Extensions>
    </Application>
</Applications>
```

|Attribute|Description|
|---------|-----------|
|**xmlns:uap5** | Specifies the general UAP contract version 5 namespace.<br></br>Note: for the Fall Creators update (Windows version 1703) use the Windows Desktop specific XML namespace instead, `xmlns:desktop="http://schemas.microsoft.com/appx/manifest/desktop/windows10",` and replace occurrences of `uap5:` with `desktop:` in the example above. |
|**Category** | Must have the value `"windows.startupTask"`.|
|**Executable** | The relative path to the .exe to start.|
|**EntryPoint** | Must have the value `"Windows.FullTrustApplication"`.|
|**TaskId** | A unique identifier for your task. Using this identifier, your app can call the APIs in this class to programmatically enable or disable a startup task.
|**Enabled** | May be set to `true` for Desktop Bridge apps to indicate that the app is enabled for startup without first needing to call [RequestEnableAsync](https://docs.microsoft.com/uwp/api/Windows.ApplicationModel.StartupTask.RequestEnableAsync).|
|**DisplayName** | The name of the task that appears in Task Manager.|

For Desktop Bridge apps, multiple **startupTask** extensions are permitted, and each one can specify a different executable.

### UWP App startup task extension

```xml
<Package xmlns:uap5="http://schemas.microsoft.com/appx/manifest/uap/windows10/5" ...>
...
<Applications>
    <Application ...>
        ...
        <Extensions>
          <uap5:Extension Category="windows.startupTask">
            <uap5:StartupTask
              TaskId="MyStartupId"
              Enabled="false"
              DisplayName="Test startup" />
          </uap5:Extension>
      </Extensions>
    </Application>
</Applications>
```

|Attribute|Description|
|---------|-----------|
|**xmlns:uap5** | UWP apps use the general UAP contract version 5 namespace. |
|**Category** | Must have the value `"windows.startupTask"` |
|**TaskId** | The unique identifier for your task. Using this identifier, your app can call the APIs in this class to programmatically enable or disable a startup task. |
|**Enabled** | For regular UWP apps, this attribute is ignored and the feature is implicitly disabled until the user first launches the app and the user confirms the app's request to enable activation at startup. |
|**DisplayName** | The name of the UWP app that appears in Task Manager. |
|**Executable** | Ignored. If provided, it cannot be empty or null. The app this Package.appxmanifest file belongs to is the implied executable.  |
|**EntryPoint** | Ignored. If provided, it cannot be empty or null. The entry point is implied. |

Regular UWP apps should only have one **Executable** entry and **windows.startupTask** extension.  
The **windows.startupTask** extension is only available for UWP apps that run on Windows Desktop.

### Windows Web App (WWA) startup task extension

```xml
<Package xmlns:uap5="http://schemas.microsoft.com/appx/manifest/uap/windows10/5" .m..>
...
<Applications>
    <Application ...>
        ...
        <Extensions>
          <uap5:Extension Category="windows.startupTask" StartPage="EntryPage">
            <uap5:StartupTask
              TaskId="MyStartupId"
              DisplayName="Test startup"/>
          </uap5:Extension>
      </Extensions>
    </Application>
</Applications>
```

|Attribute|Description|
|---------|-----------|
|**xmlns:uap5** | UWP apps use the general UAP contract version 5 namespace. |
|**StartPage** | The name of the page to display when the WWA starts. |
|**Category** | Must have the value `"windows.startupTask"` |
|**TaskId** | The unique identifier for your task. Using this identifier, your app can call the APIs in this class to programmatically enable or disable a startup task. |
|**DisplayName** | The name of the UWP app that appears in Task Manager. |

For WWA apps, **Executable**, **EntryPoint**, and **Enables** are ignored and may be either missing or null.

## Example

The following code creates a **StartupTask**:

```cs
StartupTask startupTask = await StartupTask.GetAsync("MyStartupId"); // Pass the task ID you specified in the appxmanifest file
switch (startupTask.State)
{
    case StartupTaskState.Disabled:
        // Task is disabled but can be enabled.
        StartupTaskState newState = await startupTask.RequestEnableAsync(); // ensure that you are on a UI thread when you call RequestEnableAsync()
        Debug.WriteLine("Request to enable startup, result = {0}", newState);
        break;
    case StartupTaskState.DisabledByUser:
        // Task is disabled and user must enable it manually.
        MessageDialog dialog = new MessageDialog(
            "You have disabled this app's ability to run " +
            "as soon as you sign in, but if you change your mind, " +
            "you can enable this in the Startup tab in Task Manager.",
            "TestStartup");
        await dialog.ShowAsync();
        break;
    case StartupTaskState.DisabledByPolicy:
        Debug.WriteLine("Startup disabled by group policy, or not supported on this device");
        break;
    case StartupTaskState.Enabled:
        Debug.WriteLine("Startup is enabled.");
        break;
}
```

## -see-also

[Startup app code sample](https://github.com/Microsoft/AppModelSamples/tree/master/Samples/TestStartup)  
[Configure your app to start at log-in](https://blogs.windows.com/buildingapps/2017/08/01/configure-app-start-log/#ezTx08j9to6Mc0uy.97)
