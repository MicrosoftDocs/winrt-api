---
-api-id: T:Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ShareOperation : Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation, Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation2, Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation3
-->

# Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation

## -description

Handles the bulk of the work during a share operation. This includes the data that the user wants to share, setting or removing QuickLinks, and informing the system about the status of the operation.

## -remarks

When a user selects your app as the target of a share action, an [activated](../windows.applicationmodel.core/coreapplicationview_activated.md) event fires. The object that this event sends to your app contains the instance of the **ShareOperation** class.

An app currently open as a Share target cannot initiate an additional ShareOperation, or launch a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) or [FileSavePicker](../windows.storage.pickers/filesavepicker.md).

All ShareOperation APIs should only be called after the CoreWindow for the Share target has been [activated](../windows.ui.core/corewindow_activated.md). The Share platform creates an entry for share operation only after the window has been activated.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Contacts |

## -examples

The following example shows how to work with the ShareOperation object.

[!code-js[HowToReceiveSharedText](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceivedShardText.js#SnippetHowToReceiveSharedText)]

## -see-also

[Quickstart: Sharing content ](/previous-versions/windows/apps/hh465261(v=win.10)), [Share data](/windows/uwp/app-to-app/share-data), [Quickstart: Receiving shared content ](/previous-versions/windows/apps/hh465255(v=win.10)), [Receive data](/windows/uwp/app-to-app/receive-data), [Sharing content target app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620597), [Sharing content source app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620596), [App package information sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620581)