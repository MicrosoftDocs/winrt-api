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
> The [fileremoved](fileopenpickerui_fileremoved.md) event is deprecated and should not be used.

Fires when the user removes a file from the list of files that the user has chosen if that file was added by the app that is providing files.

## -remarks
If your app participates in the File Open Picker contract and your app uses the app page that is hosted in the file picker to visually indicate which items the user selects, you should respond to this event. When a [fileremoved](fileopenpickerui_fileremoved.md) event fires you should update your app's file picker page to reflect the change. Learn more about responding to this event in [fileRemovedEventArgs](fileremovedeventargs.md).

## -examples
The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to respond to a [fileremoved](fileopenpickerui_fileremoved.md) event handler.

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
[FileOpenPickerUI class](fileopenpickerui.md), [FileRemovedEventArgs class](fileremovedeventargs.md)