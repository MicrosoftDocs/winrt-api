---
-api-id: E:Windows.ApplicationModel.DataTransfer.Clipboard.ContentChanged
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler ContentChanged<object>
-->

# Windows.ApplicationModel.DataTransfer.Clipboard.ContentChanged

## -description

Occurs when the data stored in the Clipboard changes.

## -remarks

This event is helpful in situations when your app contains logic that varies depending on the contents on the clipboard. For example, your app might include a **Paste** button, which is disabled unless the Clipboard contains content.

## -examples

The following example shows how to track changes to the [Clipboard](clipboard.md). The first code snippet registers a handler for the ContentChanged event. The second code snippet shows the event handler, which displays the text contents of the [Clipboard](clipboard.md) in a **TextBlock** control.

[!code-csharp[AddContentChangedHandler](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/cs/BlankPage.xaml.cs#Snippetcs_AddContentChangedHandler)]

[!code-csharp[TrackClipboardChanges](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/cs/BlankPage.xaml.cs#Snippetcs_TrackClipboardChanges)]

## -see-also
