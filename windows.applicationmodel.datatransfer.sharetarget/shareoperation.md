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

An app currently open as a Share target cannot initiate an additional [ShareOperation](shareoperation.md), or launch a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) or [FileSavePicker](../windows.storage.pickers/filesavepicker.md).

All ShareOperation APIs should only be called after the CoreWindow for the Share target has been [activated](../windows.ui.core/corewindow_activated.md). The Share platform creates an entry for share operation only after the window has been activated.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following example shows how to work with the [ShareOperation](shareoperation.md) object.



[!code-js[HowToReceiveSharedText](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceivedShardText.js#SnippetHowToReceiveSharedText)]

## -see-also
[Sharing content source app sample](http://go.microsoft.com/fwlink/p/?linkid=231511), [Sharing content target app sample](http://go.microsoft.com/fwlink/p/?linkid=231519), [Quickstart: Sharing content ](http://msdn.microsoft.com/library/594cd09c-19d4-4f7e-996a-e8e2489170dd), [Share data](http://msdn.microsoft.com/library/32287f5e-eb86-4b98-97ff-8f6228d06782), [Quickstart: Receiving shared content ](http://msdn.microsoft.com/library/84d45bb6-2784-4b5f-8b13-debf786a0304), [Receive data](http://msdn.microsoft.com/library/0aff9e0d-dff4-4018-b393-a26b11afdb41), [Sharing content target app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620597), [Sharing content source app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620596), [App package information sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620581)
