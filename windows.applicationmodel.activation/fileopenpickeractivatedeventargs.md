---
-api-id: T:Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FileOpenPickerActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs, Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs2
-->

# Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs

## -description

Provides information about an activated event that fires when the user tries to pick files or folders that are provided by the app.

> **JavaScript**
> This type appears as [WebUIFileOpenPickerActivatedEventArgs](../windows.ui.webui/webuifileopenpickeractivatedeventargs.md).

## -remarks

Learn how to provide files for the user to pick from your app in [Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

A FileOpenPickerActivatedEventArgs object is passed to the app's activated event handler when the user wants to pick files or folders that are provided by the app. This type of activation is indicated by the [ActivationKind.FileOpenPicker](activationkind.md) value that is returned by the [Kind](fileopenpickeractivatedeventargs_kind.md) property.

Apps written in JavaScript must listen for and handle [Windows.UI.WebUI.webUIApplication.activated](../windows.ui.webui/webuiapplication_activated.md) events.

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md), but defining overrides for other activation points such as [OnFileOpenPickerActivated](../windows.ui.xaml/application_onfileopenpickeractivated_101387531.md) is up to your app code.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a **FileOpenPicker** activation point.

```csharp

// File open picker activated event handler
protected override void OnFileOpenPickerActivated(FileOpenPickerActivatedEventArgs args)
{
    var FileOpenPickerPage = new SDKTemplate.FileOpenPickerPage();
    FileOpenPickerPage.Activate(args);
}

// Overloaded method to respond to fileOpenPicker events
public void Activate(FileOpenPickerActivatedEventArgs args)
{
    // Perform tasks to prepare your app to display its file picker page

    // Get file picker UI
    fileOpenPickerUI = args.FileOpenPickerUI;

    Window.Current.Content = this;
    this.OnNavigatedTo(null);
    Window.Current.Activate();
}


```

For C#, `args` for an [OnFileOpenPickerActivated](../windows.ui.xaml/application_onfileopenpickeractivated_101387531.md) override references a FileOpenPickerActivatedEventArgs object. The [OnFileOpenPickerActivated](../windows.ui.xaml/application_onfileopenpickeractivated_101387531.md) override is in the App.xaml.cs file and the `Activate` method is in the FileOpenPickerPage.xaml.cs file of the [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts).

## -see-also

[Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts), [OnFileOpenPickerActivated](../windows.ui.xaml/application_onfileopenpickeractivated_101387531.md), [Application](../windows.ui.xaml/application.md), [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md), [Windows.Storage.Pickers.Provider namespace](../windows.storage.pickers.provider/windows_storage_pickers_provider.md), [Windows.UI.WebUI.WebUIApplication.Activated event](../windows.ui.webui/webuiapplication_activated.md), [Windows.UI.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)
