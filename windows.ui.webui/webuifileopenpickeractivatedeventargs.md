---
-api-id: T:Windows.UI.WebUI.WebUIFileOpenPickerActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIFileOpenPickerActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs, Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs2, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIFileOpenPickerActivatedEventArgs

## -description

Provides information about an activated event that fires when the user tries to pick files or folders that are provided by the app.

> **C#/C++/VB**
> This type appears as [FileOpenPickerActivatedEventArgs](../windows.applicationmodel.activation/fileopenpickeractivatedeventargs.md).

## -remarks

Learn how to offer files for the user to pick from your app in [Quickstart: Providing file services through ](http://msdn.microsoft.com/library/3a348fea-c4b3-4847-a350-a41a69441c00) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **fileOpenPicker**.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (http://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to respond to a [fileOpenPicker](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For JavaScript, `eventObject` contains a [webUIFileOpenPickerActivatedEventArgs](webuifileopenpickeractivatedeventargs.md) object.

## -see-also

[Quickstart: Providing file services through ](http://msdn.microsoft.com/library/3a348fea-c4b3-4847-a350-a41a69441c00), [File picker provider sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620543)