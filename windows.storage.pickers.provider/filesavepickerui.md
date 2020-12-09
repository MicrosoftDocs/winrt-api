---
-api-id: T:Windows.Storage.Pickers.Provider.FileSavePickerUI
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileSavePickerUI : Windows.Storage.Pickers.Provider.IFileSavePickerUI
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI

## -description

Used to interact with the file picker when your app provides a save location with the File Save Picker contract.

## -remarks

If your app participates in the File Save Picker contract, you can access this object using a fileSavePickerUI property while you handle a [FileSavePicker](../windows.applicationmodel.activation/activationkind.md) activated event.

Use the [FileSavePickerActivatedEventArgs.FileSavePickerUI](../windows.applicationmodel.activation/filesavepickeractivatedeventargs_filesavepickerui.md) property to retrieve a fileSavePickerUI object.

To learn about creating a good experience for users when they use your app as a save location, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to respond to a [FileSavePicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For C#, `args` contains a [FileSavePickerActivatedEventArgs](../windows.applicationmodel.activation/filesavepickeractivatedeventargs.md) object. Additionally, the `OnFileSavePickerActivated` is in the App.xaml.cs file and the `Activate` method is in the FileSavePickerPage.xaml.cs file of the [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker).

## -see-also

[Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers), [Windows.ApplicationModel.Activation.activationKind](../windows.applicationmodel.activation/activationkind.md), [Windows.UI.WebUI.webUIFileOpenPickerActivatedEventArgs.fileSavePickerUI](../windows.ui.webui/webuifilesavepickeractivatedeventargs_filesavepickerui.md), [Windows.ApplicationModel.Activation.ActivationKind](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs.FileSavePickerUI](../windows.applicationmodel.activation/filesavepickeractivatedeventargs_filesavepickerui.md), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
