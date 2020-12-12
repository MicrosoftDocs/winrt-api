---
-api-id: T:Windows.UI.WebUI.WebUIFileSavePickerActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIFileSavePickerActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs, Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs2, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIFileSavePickerActivatedEventArgs

## -description

Provides information about an activated event that fires when the user saves a file through the file picker and selects the app as the location.

> **C#/C++/VB**
> This type appears as [FileSavePickerActivatedEventArgs](../windows.applicationmodel.activation/filesavepickeractivatedeventargs.md).

## -remarks

Learn more about providing your app as a location where the user can save files in the [Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is [fileSavePicker](../windows.applicationmodel.activation/activationkind.md).

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to respond to a [fileSavePicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For JavaScript, `eventObject` contains a webUIFileSavePickerActivatedEventArgs object.

## -see-also

[Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
