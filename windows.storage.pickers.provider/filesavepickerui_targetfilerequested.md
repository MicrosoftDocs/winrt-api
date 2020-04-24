---
-api-id: E:Windows.Storage.Pickers.Provider.FileSavePickerUI.TargetFileRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TargetFileRequested<Windows.Storage.Pickers.Provider.FileSavePickerUI,  Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs>
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI.TargetFileRequested

## -description
Fires when the user commits a file to be saved in the file picker.

## -remarks
If your app participates in the File Save Picker contract and a targetfilerequested event fires, your app should create a new [storageFile](../windows.storage/storagefile.md) that represents the file the user wants to save. The name of the [storageFile](../windows.storage/storagefile.md) you create must match the name of the file specified by the [fileName](filesavepickerui_filename.md) property. The [storageFile](../windows.storage/storagefile.md) you create is returned to the app that called the file picker (the calling app) so that the calling app can write content to the file. Learn more about responding to this event in [targetFileRequestedEventArgs](targetfilerequestedeventargs.md).

> [!NOTE]
> file picker UI is disabled until the providing app has finished responding to this event.

## -examples
The [File picker sample](http://code.msdn.microsoft.com/windowsapps/File-picker-sample-9f294cba) demonstrates how to respond to a targetfilerequested event handler.

```csharp

// Event handler
private async void OnTargetFileRequested(FileSavePickerUI sender, TargetFileRequestedEventArgs e)
{
    // Respond to TargetFileRequested event on the background thread on which it was raised

    // Requesting a deferral allows the app to call another asynchronous method and complete the request at a later time
    var deferral = e.Request.GetDeferral();

    // Create file and assign to TargetFile property
    e.Request.TargetFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(sender.FileName, CreationCollisionOption.GenerateUniqueName);

    // Complete the deferral to let the Picker know the request is finished
    deferral.Complete();
}

// Register for the event
fileSavePickerUI.TargetFileRequested += new TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs>(OnTargetFileRequested);
```

```javascript

// Event handler
function onTargetFileRequested(e) {
    var deferral;
    deferral = e.request.getDeferral();

    // Create a file to pass to the file picker which then gives it to the calling app
    Windows.Storage.ApplicationData.current.localFolder.createFileAsync(fileSavePickerUI.fileName).done(function (file) {
            // Assign the resulting file to the targetFile property and complete the deferral to indicate success
        e.request.targetFile = file;
        deferral.complete();
    }, function () {
        // Set the targetFile property to null and complete the deferral to indicate failure
        e.request.targetFile = null;
        deferral.complete();
    });
};

// Register for the event
fileSavePickerUI.addEventListener("targetfilerequested", onTargetFileRequested, false);
```

In the example, `e` contains a [TargetFileRequestedEventArgs](targetfilerequestedeventargs.md) object.

## -see-also
[FileSavePickerUI class](filesavepickerui.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
