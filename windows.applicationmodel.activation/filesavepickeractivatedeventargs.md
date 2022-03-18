---
-api-id: T:Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FileSavePickerActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs, Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs2
-->

# Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs

## -description

Provides information about an activated event that fires when the user saves a file through the file picker and selects the app as the location.

> **JavaScript**
> This type appears as [WebUIFileSavePickerActivatedEventArgs](../windows.ui.webui/webuifilesavepickeractivatedeventargs.md).

## -remarks

Learn more about providing your app as a location where the user can save files in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

A FileSavePickerActivatedEventArgs object is passed to the app's activation point handler when the user saves a file through the file picker and selects the app as the location. This type of activation is indicated by the [ActivationKind.FileSavePicker](activationkind.md) value returned by the [Kind](filesavepickeractivatedeventargs_kind.md) property.

Apps written in JavaScript must listen for and handle [Windows.UI.WebUI.webUIApplication.activated](../windows.ui.webui/webuiapplication_activated.md) events.

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md), but defining overrides for other activation points such as [OnFileSavePickerActivated](../windows.ui.xaml/application_onfilesavepickeractivated_425940653.md) is up to your app code.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a **FileSavePicker** activation point.

```csharp

// fileSavePicker activated event handler
protected override void OnFileSavePickerActivated(FileSavePickerActivatedEventArgs args)
{
    var FileSavePickerPage = new SDKTemplate.FileSavePickerPage();
    FileSavePickerPage.Activate(args);
}

// Overloaded method to respond to fileSavePicker events
internal void Activate(FileSavePickerActivatedEventArgs args)
{
    // Perform tasks to prepare your app to display its file picker page

    // Get file picker UI
    fileSavePickerUI = args.FileSavePickerUI;

    Window.Current.Content = this;
    this.OnNavigatedTo(null);
    Window.Current.Activate();
}
```

For C#, `args` for an [OnFileSavePickerActivated](../windows.ui.xaml/application_onfilesavepickeractivated_425940653.md) override on the [Application](../windows.ui.xaml/application.md) object references a FileSavePickerActivatedEventArgs object. The [OnFileSavePickerActivated](../windows.ui.xaml/application_onfilesavepickeractivated_425940653.md) override is in the App.xaml.cs file and the `Activate` method is in the FileSavePickerPage.xaml.cs file of the [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts).

## -see-also

[Windows.Storage.Pickers.Provider namespace](../windows.storage.pickers.provider/windows_storage_pickers_provider.md), [Windows.UI.WebUI.WebUIApplication.Activated event](../windows.ui.webui/webuiapplication_activated.md), [Windows.UI.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md), [OnFileSavePickerActivated](../windows.ui.xaml/application_onfilesavepickeractivated_425940653.md), [Application](../windows.ui.xaml/application.md), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
