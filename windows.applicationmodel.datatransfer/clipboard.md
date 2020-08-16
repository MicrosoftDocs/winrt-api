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

Because the Clipboard class is a static class, you don't need to create an instance of it to access its methods.

You can only access the clipboard when the calling application is in focus on the UI thread (for example, when its [CoreWindow](../windows.ui.core/corewindow.md) is active). Use the [CoreWindow.Activated](../windows.ui.core/corewindow_activated.md) event to track the state of the calling app.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ClearHistory |
| 1809 | 17763 | DeleteItemFromHistory |
| 1809 | 17763 | GetHistoryItemsAsync |
| 1809 | 17763 | HistoryChanged |
| 1809 | 17763 | HistoryEnabledChanged |
| 1809 | 17763 | IsHistoryEnabled |
| 1809 | 17763 | IsRoamingEnabled |
| 1809 | 17763 | RoamingEnabledChanged |
| 1809 | 17763 | SetContentWithOptions |
| 1809 | 17763 | SetHistoryItemAsContent |

## -examples

The following sample shows how to track changes to the Clipboard. If the Clipboard has text, the code adds the text to an HTML page.

[!code-js[TrackClipboardChanges](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/js/default.js#SnippetTrackClipboardChanges)]

## -see-also

[Clipboard sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Clipboard)
