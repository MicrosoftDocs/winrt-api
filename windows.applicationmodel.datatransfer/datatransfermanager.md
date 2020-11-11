---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataTransferManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class DataTransferManager : Windows.ApplicationModel.DataTransfer.IDataTransferManager, Windows.ApplicationModel.DataTransfer.IDataTransferManager2
-->

# Windows.ApplicationModel.DataTransfer.DataTransferManager

## -description
Programmatically initiates an exchange of content with other apps.

## -remarks
The **DataTransferManager** class is a static class that you use to initiate sharing operations. To use the class, first call the [GetForCurrentView](datatransfermanager_getforcurrentview_1363600702.md) method. This method returns the **DataTransferManager** object that is specific to the active window. Next, you need to add an event listener for the [datarequested](datatransfermanager_datarequested.md) event to the object. This event is fired when a sharing operation starts— typically when the user taps the Share charm, although it is also fired if your app starts a share operation programmatically.

The **DataTransferManager** class includes a [ShowShareUI](datatransfermanager_showshareui_1578854276.md) method, which you can use to programmatically start a share operation.

The **DataTransferManager** class also has a [TargetApplicationChosen](datatransfermanager_targetapplicationchosen.md) event. Use this event when you want to capture what applications a user selects when sharing content from your app.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

### Windows Phone 8

This API is supported in native apps only.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsSupported |
| 1703 | 15063 | ShareProvidersRequested |
| 1709 | 16299 | ShowShareUI(ShareUIOptions) |

## -examples
This example shows a typical way of using the **DataTransferManager** object.



[!code-js[DataTransferManager_1](../windows.applicationmodel.datatransfer/code/DataTransferManagerSample/javascript/DataTransferClassSample/js/default.js#SnippetDataTransferManager_1)]

## -see-also
[Sharing content source app sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ShareSource)