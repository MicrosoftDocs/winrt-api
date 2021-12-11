---
-api-id: T:Windows.Storage.Pickers.Provider.FileOpenPickerUI
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileOpenPickerUI : Windows.Storage.Pickers.Provider.IFileOpenPickerUI
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI

## -description

Used to interact with the file picker if your app provides files with the File Open Picker contract.

## -remarks

If your app participates in the File Open Picker contract, you can retrieve this object using a FileOpenPickerUI property while you handle a [FileOpenPicker](../windows.applicationmodel.activation/activationkind.md) activated event.

Use the [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs.FileOpenPickerUI](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs_fileopenpickerui.md) property to access a FileOpenPickerUI.

Learn about creating a good experience for users when they access your files through the file picker by reading the UX guidelines for providing files in [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

## -examples

The [File picker provider sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a [FileOpenPicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For C#, `args` contains a [FileOpenPickerActivatedEventArgs](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs.md) object. Additionally, the `OnFileOpenPickerActivated` is in the App.xaml.cs file and the `Activate` method is in the FileOpenPickerPage.xaml.cs file of the [File picker provider sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts).

## -see-also

[Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers), [Windows.ApplicationModel.Activation.activationKind enumeration](../windows.applicationmodel.activation/activationkind.md), [Windows.UI.WebUI.webUIFileOpenPickerActivatedEventArgs class](../windows.ui.webui/webuifileopenpickeractivatedeventargs.md), [Windows.ApplicationModel.Activation.ActivationKind enumeration](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs class](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs.md), [File picker provider sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
