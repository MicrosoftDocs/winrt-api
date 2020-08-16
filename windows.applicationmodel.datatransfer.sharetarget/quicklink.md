---
-api-id: T:Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class QuickLink : Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink
-->

# Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink

## -description
Represents shortcuts that help users share content with the apps they use most.

## -remarks


> Quicklinks are not supported on Windows Phone 8.1. Apps running on Windows Phone 8.1 can still receive Quicklinks as part of a share operation, but they will be automatically ignored.


<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following function creates and returns a QuickLink.



[!code-js[HowToCreateQuickLink](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceivedSharedFiles.js#SnippetHowToCreateQuickLink)]

## -see-also
