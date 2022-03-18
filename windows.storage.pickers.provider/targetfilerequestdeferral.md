---
-api-id: T:Windows.Storage.Pickers.Provider.TargetFileRequestDeferral
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TargetFileRequestDeferral : Windows.Storage.Pickers.Provider.ITargetFileRequestDeferral
-->

# Windows.Storage.Pickers.Provider.TargetFileRequestDeferral

## -description
Used by an app that provides a save location to indicate asynchronously that the app is finished responding to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
If your app participates in the File Save Picker contract and a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event fires, your app should create a new [StorageFile](../windows.storage/storagefile.md) that represents the file the user wants to save. The name of the [StorageFile](../windows.storage/storagefile.md) you create must match the name of the file specified by the [FileName](filesavepickerui_filename.md) property. The [StorageFile](../windows.storage/storagefile.md) you create is returned to the app that called the file picker (the calling app) so that the calling app can write content to the file. Learn more about responding to this event in [targetFileRequestedEventArgs](targetfilerequestedeventargs.md).

Your app, as the provider of a save location, can signal that it has finished its asynchronous response to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event by calling [targetFileRequestDeferral.complete](targetfilerequestdeferral_complete_1807836922.md). Learn more about responding asynchronously to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event in [TargetFileRequestedEventArgs](targetfilerequestedeventargs.md).

## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to respond to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event handler, including how to get a deferral.

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

In the example, `e` contains a [TargetFileRequestedEventArgs](targetfilerequestedeventargs.md) object.

## -see-also
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [TargetFileRequest class](targetfilerequest.md), [TargetFileRequestDeferral class, [TargetFileRequestDeferral.Complete method](targetfilerequestdeferral_complete_1807836922.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
