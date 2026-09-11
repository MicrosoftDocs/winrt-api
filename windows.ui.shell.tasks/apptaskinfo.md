---
-api-id: T:Windows.UI.Shell.Tasks.AppTaskInfo
-api-type: winrt class
---

# Windows.UI.Shell.Tasks.AppTaskInfo

<!--
public sealed class AppTaskInfo
-->


## -description

Represents an app task that can be displayed in the Windows Shell.

## -remarks

This class supports creating, updating, and removing task representations. Tasks are persisted across app sessions and system reboots.

For each task, create a new `AppTaskInfo` instance and modify it to represent the task state. When a task is no longer relevant, call [Remove](apptaskinfo_remove_13687727.md) to remove it from the Shell.

Use [IsSupported](apptaskinfo_issupported_930300905.md) to check if the feature is available before attempting to create or enumerate tasks. Use [FindAll](apptaskinfo_findall_1149612203.md) to enumerate existing tasks that were created previously.

Tasks can be hidden by users through the taskbar interface. Hiding a task does not affect the task running in the app; its representation is simply removed from the taskbar. The [HiddenByUser](apptaskinfo_hiddenbyuser.md) property indicates whether a task has been hidden by the user.

### Using shell tasks APIs

Apps that use these APIs need to be packaged. See [Packaging overview](/windows/apps/package-and-deploy/packaging/) for more info.

You also need to add the `com.microsoft.apptaskprovider` [AppExtension](/uwp/api/windows.applicationmodel.appextensions.appextension) to your app manifest like this:

```xml
<Package
  xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10"
  xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"
  xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10"
  xmlns:uap3="http://schemas.microsoft.com/appx/manifest/uap/windows10/3"
  IgnorableNamespaces="rescap uap uap3">
...

<Application>
  ...
  <Extensions>
    <uap3:Extension Category="windows.appExtension">
        <uap3:AppExtension
            Name="com.microsoft.apptaskprovider"
            PublicFolder="Public"
            Id="MyApp.AppTaskProvider"
            DisplayName="AppTaskProvider for MyApp"/>
    </uap3:Extension>
  </Extensions>
  ...
</Application>

...
</Package>
```

## -see-also

## -examples


