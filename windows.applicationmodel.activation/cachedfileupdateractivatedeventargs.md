---
-api-id: T:Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class CachedFileUpdaterActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs

## -description
Provides information about the activated event that fires when the user saves or opens a file that needs updates from the app.

> **JavaScript**
> This type appears as [WebUICachedFileUpdaterActivatedEventArgs](../windows.ui.webui/webuicachedfileupdateractivatedeventargs.md).

## -remarks
Learn more about providing updates for files that your app offers in the [Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

A CachedFileUpdaterActivatedEventArgs object is passed to the app's activated event handler when the user saves a file that requires content management from the app. This type of activation is indicated by the [ActivationKind.CachedFileUpdater](activationkind.md) value returned by the [Kind](cachedfileupdateractivatedeventargs_kind.md) property.

Apps written in JavaScript must listen for and handle [Windows.UI.WebUI.WebUIApplication.activated](../windows.ui.webui/webuiapplication_activated.md) events.

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md), but defining overrides for other activation points such as [OnCachedFileUpdaterActivated](../windows.ui.xaml/application_oncachedfileupdateractivated_383584449.md) is up to your app code.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples
The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a **CachedFileUpdater** activation point.

```csharp

// CachedFileUpdater activated event handler
protected override void OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args)
{
    var CachedFileUpdaterPage = new SDKTemplate.CachedFileUpdaterPage();
    CachedFileUpdaterPage.Activate(args);
}

// Overloaded method to respond to CachedFileUpdater events
public void Activate(CachedFileUpdaterActivatedEventArgs args)
{
            // Get file picker UI
            cachedFileUpdaterUI = args.CachedFileUpdaterUI;

            cachedFileUpdaterUI.FileUpdateRequested += CachedFileUpdaterUI_FileUpdateRequested;
            cachedFileUpdaterUI.UIRequested += CachedFileUpdaterUI_UIRequested;

            switch (cachedFileUpdaterUI.UpdateTarget)
            {
                case CachedFileTarget.Local:
                    scenarios = new List<Scenario> { new Scenario() { Title = "Get latest version", ClassType = typeof(FilePickerContracts.CachedFileUpdater_Local) } };
                    break;
                case CachedFileTarget.Remote:
                    scenarios = new List<Scenario> { new Scenario() { Title = "Remote file update", ClassType = typeof(FilePickerContracts.CachedFileUpdater_Remote) } };
                    break;
            }

            Window.Current.Activate();
        }
```

For C#, `args` for an [OnCachedFileUpdaterActivated](../windows.ui.xaml/application_oncachedfileupdateractivated_383584449.md) override on the [Application](../windows.ui.xaml/application.md) object references a CachedFileUpdaterActivatedEventArgs object. The [OnCachedFileUpdaterActivated](../windows.ui.xaml/application_oncachedfileupdateractivated_383584449.md) override is in the App.xaml.cs file and the `Activate` method is in the CachedFileUpdaterPage.xaml.cs file of the [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts).

## -see-also
[ActivationKind enumeration](activationkind.md), [Windows.Storage.Provider namespace](../windows.storage.provider/windows_storage_provider.md), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts), [Windows.UI.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md), [OnCachedFileUpdaterActivated](../windows.ui.xaml/application_oncachedfileupdateractivated_383584449.md), [Application](../windows.ui.xaml/application.md)
