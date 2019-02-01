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

If your app participates in the File Save Picker contract, you can access this object using a fileSavePickerUI property while you handle a [filesavepicker](../windows.applicationmodel.activation/activationkind.md) activated event.

Use one of the following properties to retrieve a [fileSavePickerUI](filesavepickerui.md) object:

+ > **JavaScript**
> [webUIFileSavePickerActivatedEventArgs.fileSavePickerUI](../windows.ui.webui/webuifilesavepickeractivatedeventargs_filesavepickerui.md)
+ > **C#/C++/VB**
> [FileSavePickerActivatedEventArgs.FileSavePickerUI](../windows.applicationmodel.activation/filesavepickeractivatedeventargs_filesavepickerui.md)

To learn about creating a good experience for users when they use your app as a save location, see [Open files and folders with a picker](https://docs.microsoft.com/windows/uwp/files/quickstart-using-file-and-folder-pickers).

## -examples

The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to respond to a [filesavepicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

```javascript

// fileSavePicker activated event handler
function activated(eventObject) {
    // Identify whether app is launched for fileSavePicker
    if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.fileOpenPicker) {
        // Perform tasks to prepare your app to display its file picker page

        // Get file picker UI
        fileOpenPickerUI = eventObject.detail.fileOpenPickerUI;

        eventObject.setPromise(WinJS.UI.processAll().then(function () {
            // Navigate to either the first scenario or to the last running scenario
            // before suspension or termination.
            var url = scenarios[0].url;
            return WinJS.Navigation.navigate(url, fileOpenPickerUI);
        }));
    }
}

// Register the activated event handler
WinJS.Application.addEventListener("activated", activated, false);
```

For JavaScript, `eventObject` contains a [webUIFileSavePickerActivatedEventArgs](../windows.ui.webui/webuifilesavepickeractivatedeventargs.md) object.

For C#, `args` contains a [FileSavePickerActivatedEventArgs](../windows.applicationmodel.activation/filesavepickeractivatedeventargs.md) object. Additionally, the `OnFileSavePickerActivated` is in the App.xaml.cs file and the `Activate` method is in the FileSavePickerPage.xaml.cs file of the [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890).

## -see-also

[Open files and folders with a picker](https://docs.microsoft.com/windows/uwp/files/quickstart-using-file-and-folder-pickers), [Windows.ApplicationModel.Activation.activationKind](../windows.applicationmodel.activation/activationkind.md), [Windows.UI.WebUI.webUIFileOpenPickerActivatedEventArgs.fileSavePickerUI](../windows.ui.webui/webuifilesavepickeractivatedeventargs_filesavepickerui.md), [Windows.ApplicationModel.Activation.ActivationKind](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs.FileSavePickerUI](../windows.applicationmodel.activation/filesavepickeractivatedeventargs_filesavepickerui.md), [File picker provider sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620543)
