---
-api-id: T:Windows.UI.Shell.Tasks.AppTaskContent
-api-type: winrt class
---

# Windows.UI.Shell.Tasks.AppTaskContent

<!--
public sealed class AppTaskContent
-->


## -description

Represents the content displayed for an app task in the Windows Shell UI. Use this class to create different visual representations of task progress and results.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

`AppTaskContent` can be constructed for different supported representations:

- **Sequence of steps**: Shows step-by-step progress of task execution. Use [CreateSequenceOfSteps](apptaskcontent_createsequenceofsteps_2102567378.md).
- **Preview thumbnail**: Displays a preview thumbnail of task output. Use [CreatePreviewThumbnail](apptaskcontent_createpreviewthumbnail_1460480113.md).
- **Text summary result**: Displays a summary of the task result with a short text description. Use [CreateTextSummaryResult](apptaskcontent_createtextsummaryresult_779573599.md).
- **Generated assets result**: Displays a summary of the task result with generated assets. Use [CreateGeneratedAssetsResult](apptaskcontent_creategeneratedassetsresult_836752552.md).

When a task needs user attention, additional elements can be added using [SetQuestion](apptaskcontent_setquestion_1132443299.md), [AddButton](apptaskcontent_addbutton_519639533.md), or [SetTextInput](apptaskcontent_settextinput_1945138728.md).

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


