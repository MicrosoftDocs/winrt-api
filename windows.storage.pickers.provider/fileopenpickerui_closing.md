---
-api-id: E:Windows.Storage.Pickers.Provider.FileOpenPickerUI.Closing
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Closing<Windows.Storage.Pickers.Provider.FileOpenPickerUI,  Windows.Storage.Pickers.Provider.PickerClosingEventArgs>
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.Closing

## -description
Fires when the user closes the file picker.

## -remarks
As a provider of files, you can register for this event so that your app can execute cleanup tasks before it is closed. For example, if the user cancels the file picker, you could respond by cleaning up temporary files that were added to the file picker when the user chose them.

Register for this event by adding an event listener to the [FileOpenPickerUI](fileopenpickerui.md) and assigning a handler function for the event. You can access information about the event from the [PickerClosingEventArgs](pickerclosingeventargs.md) object that is passed to your event handler.

## -examples

## -see-also
