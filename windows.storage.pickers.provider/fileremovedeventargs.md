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
Provides information about a [fileremoved](fileopenpickerui_fileremoved.md) event.

## -remarks
This object is passed to the event handler for [fileremoved](fileopenpickerui_fileremoved.md) events.

If your app participates in the File Open Picker contract and a [fileremoved](fileopenpickerui_fileremoved.md) event fires, you should respond by updating its file picker app page to reflect the change in the list of chosen files.

Register for this event by adding an event listener to the [fileOpenPickerUI](fileopenpickerui.md) and assigning a handler function for the event. You can access information about the event from the [fileRemovedEventArgs](fileremovedeventargs.md) object that is passed to your event handler.

## -examples
The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to respond to a [fileremoved](fileopenpickerui_fileremoved.md) event.

```csharp

// Event handler
private async void OnFileRemoved(FileOpenPickerUI sender, FileRemovedEventArgs args)
{
    // Perform tasks when an item is removed from the file picker, like updating buttons or notifying the user

    // Make sure that the item was removed from the file picker matches the one we added.
    if (args.Id == id)
    {
        // The event handler may be invoked on a background thread,
        // so use the Dispatcher to run the UI-related code on the UI thread.
        await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        {
            OutputTextBlock.Text = Status.FileRemoved;
            UpdateButtonState(false);
        });
     }
}

// Register for the event
fileOpenPickerUI.FileRemoved += new TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs>(OnFileRemoved);
```

```javascript

// Event handler
function onFileRemovedFromBasket(e) {
    // Perform tasks when an item is removed from the file picker, like updating buttons or notifying the user

    // Add any code to be called when an item is removed from the basket by the user
    WinJS.log && WinJS.log(SdkSample.fileRemoved, "sample", "status");

    // Adjust the add/remove buttons based on removal
    updateSelectionState(e.id, false);
};

// Register for the event
fileOpenPickerUI.addEventListener("fileremoved", onFileRemovedFromBasket, false);
```

Both `args` and `e` (in C# and JS respectively) contain a [FileRemovedEventArgs](fileremovedeventargs.md) object.

For JavaScript, `SdkSample.fileRemoved` is an app variable that contains a string that used to used to notify the user.

For C#, `id` is an app variable that gets an identifier for the file and `UpdateButtonState` is one of the app's helper methods.

## -see-also
[fileOpenPickerUI class](fileopenpickerui.md), [fileOpenPickerUI.fileremoved event](fileopenpickerui_fileremoved.md)