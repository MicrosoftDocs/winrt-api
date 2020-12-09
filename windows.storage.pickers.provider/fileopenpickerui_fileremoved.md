---
-api-id: E:Windows.Storage.Pickers.Provider.FileOpenPickerUI.FileRemoved
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FileRemoved<Windows.Storage.Pickers.Provider.FileOpenPickerUI,  Windows.Storage.Pickers.Provider.FileRemovedEventArgs>
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.FileRemoved

## -description
> [!NOTE]
> The FileRemoved event is deprecated and should not be used.

Fires when the user removes a file from the list of files that the user has chosen if that file was added by the app that is providing files.

## -remarks
If your app participates in the File Open Picker contract and your app uses the app page that is hosted in the file picker to visually indicate which items the user selects, you should respond to this event. When a FileRemoved event fires you should update your app's file picker page to reflect the change. Learn more about responding to this event in [FileRemovedEventArgs](fileremovedeventargs.md).

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md), [FileRemovedEventArgs class](fileremovedeventargs.md)
