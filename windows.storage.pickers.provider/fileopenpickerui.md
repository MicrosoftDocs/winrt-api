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

If your app participates in the File Open Picker contract, you can retrieve this object using a FileOpenPickerUI property while you handle a [fileOpenPicker](../windows.applicationmodel.activation/activationkind.md) activated event.

Use one of the following properties to access a FileOpenPickerUI:

+ > **JavaScript**
> [Windows.UI.WebUI.webUIFileOpenPickerActivatedEventArgs.fileOpenPickerUI](../windows.ui.webui/webuifileopenpickeractivatedeventargs_fileopenpickerui.md)
+ > **C#/C++/VB**
> [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs.FileOpenPickerUI](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs_fileopenpickerui.md)

Learn about creating a good experience for users when they access your files through the file picker by reading the UX guidelines for providing files in [Open files and folders with a picker](https://docs.microsoft.com/windows/uwp/files/quickstart-using-file-and-folder-pickers).

## -examples

The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to respond to a [fileOpenPicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

```javascript

// File open picker activated event handler
function activated(eventObject) {
    // Identify whether app is launched for fileOpenPicker
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

For JavaScript, `eventObject` contains a [webUIFileOpenPickerActivatedEventArgs](../windows.ui.webui/webuifileopenpickeractivatedeventargs.md) object.

For C#, `args` contains a [FileOpenPickerActivatedEventArgs](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs.md) object. Additionally, the `OnFileOpenPickerActivated` is in the App.xaml.cs file and the `Activate` method is in the FileOpenPickerPage.xaml.cs file of the [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890).

## -see-also

[Open files and folders with a picker](https://docs.microsoft.com/windows/uwp/files/quickstart-using-file-and-folder-pickers), [Windows.ApplicationModel.Activation.activationKind enumeration](../windows.applicationmodel.activation/activationkind.md), [Windows.UI.WebUI.webUIFileOpenPickerActivatedEventArgs class](../windows.ui.webui/webuifileopenpickeractivatedeventargs.md), [Windows.ApplicationModel.Activation.ActivationKind enumeration](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs class](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs.md), [File picker provider sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620543)
