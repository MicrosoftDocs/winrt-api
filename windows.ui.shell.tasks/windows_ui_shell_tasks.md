---
-api-id: N:Windows.UI.Shell.Tasks
-api-type: winrt namespace
---

# Windows.UI.Shell.Tasks



## -description

Provides APIs that allow apps to represent long-running tasks in the Windows Shell, such as the taskbar. Apps can create, update, and remove task representations that users can monitor and interact with.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

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


