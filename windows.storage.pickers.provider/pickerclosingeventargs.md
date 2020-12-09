---
-api-id: T:Windows.Storage.Pickers.Provider.PickerClosingEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PickerClosingEventArgs : Windows.Storage.Pickers.Provider.IPickerClosingEventArgs
-->

# Windows.Storage.Pickers.Provider.PickerClosingEventArgs

## -description
Provides information about a [Closing](fileopenpickerui_closing.md) event.

## -remarks
This object is passed to the event handler for [Closing](fileopenpickerui_closing.md) events.

If your app participates in the File Open Picker contract and a [Closing](fileopenpickerui_closing.md) event fires, your app should respond by performing cleanup tasks before your app is closed. For example, if the user cancels the file picker, you could respond to this event by cleaning up temporary files that were added to the file picker when the user chose them.

## -examples


## -see-also
