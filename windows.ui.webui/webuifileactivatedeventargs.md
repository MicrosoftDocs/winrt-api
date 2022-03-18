---
-api-id: T:Windows.UI.WebUI.WebUIFileActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIFileActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.IFileActivatedEventArgs, Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithNeighboringFiles, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIFileActivatedEventArgs

## -description

Provides data when an app is activated because it is the app associated with a file.

## -remarks

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **file**. Note that when your app is activated for the file contract you must access the data using the [StorageFile](../windows.storage/storagefile.md) objects passed to your app through the Files property. You should not attempt to access the path of the file since your app may not have permission to the file’s location.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [activated](/previous-versions/windows/apps/br212679(v=win.10)) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **file** activation events.

```javascript
function onActivatedHandler(eventArgs) {
   if (eventArgs.detail.kind == Windows.ApplicationModel.Activation.ActivationKind.file) 
   {
       // TODO: Handle file activation.

       // The number of files received is eventArgs.detail.files.size
       // The first file is eventArgs.detail.files[0].name
   }
}
```

## -see-also

[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Association%20launching%20sample), [How to handle file activation](/previous-versions/windows/apps/hh452684(v=win.10)), [Guidelines for file types and URIs](/windows/uwp/files/index), [Windows.Storage](../windows.storage/windows_storage.md), [WebUIApplication.ActivatedEventHandler](activatedeventhandler.md), [WinJS.Application.onactivated](/previous-versions/windows/apps/br212679(v=win.10)), [Association launching sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620490)
