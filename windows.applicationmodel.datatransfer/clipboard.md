---
-api-id: T:Windows.ApplicationModel.DataTransfer.Clipboard
-api-type: winrt class
---

<!-- Class syntax.
public class Clipboard
-->

# Windows.ApplicationModel.DataTransfer.Clipboard

## -description

Gets and sets information from the clipboard object.

## -remarks

Because the [Clipboard](clipboard.md) class is a static class, you don't need to create an instance of it to access its methods.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

You can only access the clipboard when the calling application is in focus on the UI thread (e.g., when it's [CoreWindow](../windows.ui.core/corewindow.md) is active). Use the [CoreWindow.Activated](../windows.ui.core/corewindow_activated.md) event to track the state of the calling app.

## -examples

The following sample shows how to track changes to the [Clipboard](clipboard.md). If the [Clipboard](clipboard.md) has text, the code adds the text to an HTML page.

[!code-js[TrackClipboardChanges](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/js/default.js#SnippetTrackClipboardChanges)]

## -see-also

[Clipboard sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620520)
