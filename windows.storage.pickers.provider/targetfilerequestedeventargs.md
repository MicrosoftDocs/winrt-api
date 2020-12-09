---
-api-id: T:Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TargetFileRequestedEventArgs : Windows.Storage.Pickers.Provider.ITargetFileRequestedEventArgs
-->

# Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs

## -description
Provides information about a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
This object is passed to the event handler for [TargetFileRequested](filesavepickerui_targetfilerequested.md) events.

### Responding to a TargetFileRequested event

If your app participates in the File Save Picker contract and a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event fires, your app should respond by following these steps:

1. Get a [TargetFileRequest](targetfilerequest.md) using the [TargetFileRequestedEventArgs.request](targetfilerequestedeventargs_request.md) property.
1. Create (or retrieve) a [StorageFile](../windows.storage/storagefile.md) to represent the file to save; this [StorageFile](../windows.storage/storagefile.md) is returned to the app that called the file picker to save and used by the calling app to write content to the file.

The file name and extension of the object that represents the file must match the file name and extension specified by the user (and accessible through [FileName](filesavepickerui_filename.md)) or the attempt to save the file will fail. If the attempt fails, the user can try to save the file again.

If your app (as the provider of the save location) can't provide an object for the file to save, set [TargetFileRequest.TargetFile](targetfilerequest_targetfile.md) to **null**.

1. Set [TargetFileRequest.TargetFile](targetfilerequest_targetfile.md) to the [StorageFile](../windows.storage/storagefile.md) object.

### Responding asynchronously

If your app, which is providing the save location, can't finish responding to the [TargetFileRequested](filesavepickerui_targetfilerequested.md) event before it returns from its event handler (for example, if your app calls an asynchronous method), you can complete your response asynchronously by deferring.

Your app, as the provider of the save location, can defer in order to respond to the event asynchronously by following these steps:

1. Get a [TargetFileRequest](targetfilerequest.md) using the [TargetFileRequestedEventArgs.request](targetfilerequestedeventargs_request.md) property.
1. Call [TargetFileRequest.GetDeferral](targetfilerequest_getdeferral_254836512.md) to get a [TargetFileRequestDeferral](targetfilerequestdeferral.md) object.
1. Perform the steps needed to respond to the [TargetFileRequested](filesavepickerui_targetfilerequested.md) event (described in the preceding section).
1. Call [TargetFileRequestDeferral.Complete](targetfilerequestdeferral_complete_1807836922.md) to signal that your app has finished responding to the [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.


## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to respond to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.

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

In the example, `e` contains a TargetFileRequestedEventArgs object.

## -see-also
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [TargetFileRequest class](targetfilerequest.md), [TargetFileRequest.TargetFile  property](targetfilerequest_targetfile.md), [TargetFileRequest.GetDeferral method](targetfilerequest_getdeferral_254836512.md), [TargetFileRequestDeferral class](targetfilerequestdeferral.md), [TargetFileRequestDeferral.Complete method](targetfilerequestdeferral_complete_1807836922.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
