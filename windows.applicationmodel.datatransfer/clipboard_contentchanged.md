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
The following example shows how to track changes to the [Clipboard](clipboard.md). The first code snippet registers a handler for the [ContentChanged](clipboard_contentchanged.md) event. The second code snippet shows the event handler, which enables the app's paste command if the [Clipboard](clipboard.md) contains a bitmap.



[!code-js[TrackClipboardChanges1](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/js/default.js#SnippetTrackClipboardChanges1)]

[!code-js[TrackClipboardChanges2](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/js/default.js#SnippetTrackClipboardChanges2)]

## -see-also
