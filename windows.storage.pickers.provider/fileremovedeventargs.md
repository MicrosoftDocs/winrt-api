---
-api-id: T:Windows.Storage.Pickers.Provider.FileRemovedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileRemovedEventArgs : Windows.Storage.Pickers.Provider.IFileRemovedEventArgs
-->

# Windows.Storage.Pickers.Provider.FileRemovedEventArgs

## -description
Provides information about a [FileRemoved](fileopenpickerui_fileremoved.md) event.

## -remarks

> [!NOTE]
> The FileRemoved event is deprecated and should not be used.

This object is passed to the event handler for [FileRemoved](fileopenpickerui_fileremoved.md) events.

If your app participates in the File Open Picker contract and a [FileRemoved](fileopenpickerui_fileremoved.md) event fires, you should respond by updating its file picker app page to reflect the change in the list of chosen files.

Register for this event by adding an event listener to the [FileOpenPickerUI](fileopenpickerui.md) and assigning a handler function for the event. You can access information about the event from the fileRemovedEventArgs object that is passed to your event handler.

## -examples

## -see-also
[fileOpenPickerUI class](fileopenpickerui.md), [fileOpenPickerUI.fileremoved event](fileopenpickerui_fileremoved.md)
