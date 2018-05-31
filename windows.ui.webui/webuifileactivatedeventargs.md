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

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **file**. Note that when your app is activated for the file contract you must access the data using the [StorageFile](../windows.storage/storagefile.md) objects passed to your app through the Files property. You should not attempt to access the path of the file since your app may not have permission to the file’s location.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (http://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/en-us/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

The [activated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **file** activation events.

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

[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to handle file activation](http://msdn.microsoft.com/library/cd540a91-5276-4a89-b517-85cea866172c), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Windows.Storage](../windows.storage/windows_storage.md), [WebUIApplication.ActivatedEventHandler](activatedeventhandler.md), [WinJS.Application.onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4), [Association launching sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620490)