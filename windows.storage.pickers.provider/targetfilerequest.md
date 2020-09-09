---
-api-id: T:Windows.Storage.Pickers.Provider.TargetFileRequest
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TargetFileRequest : Windows.Storage.Pickers.Provider.ITargetFileRequest
-->

# Windows.Storage.Pickers.Provider.TargetFileRequest

## -description
Lets an app that provides a save location specify the [storageFile](../windows.storage/storagefile.md) that represents the file to save and get a deferral so the app can respond asynchronously to a [targetFileRequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
If your app participates in the File Save Picker contract and a [targetfilerequested](filesavepickerui_targetfilerequested.md) event fires, your app should create a new [storageFile](../windows.storage/storagefile.md) that represents the file the user wants to save. The name of the [storageFile](../windows.storage/storagefile.md) you create must match the name of the file specified by the [fileName](filesavepickerui_filename.md) property. The [storageFile](../windows.storage/storagefile.md) you create is returned to the app that called the file picker (the calling app) so that the calling app can write content to the file. Learn more about responding to this event in [targetFileRequestedEventArgs](targetfilerequestedeventargs.md).

## -examples
The [File picker sample](/samples/browse/) demonstrates how to respond to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event handler, including how to use the [Request](targetfilerequestedeventargs_request.md) property to get the TargetFileRequest.

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
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [TargetFileRequest class, [TargetFileRequest.TargetFile  property](targetfilerequest_targetfile.md), [TargetFileRequest.GetDeferral method](targetfilerequest_getdeferral_254836512.md), [TargetFileRequestDeferral class](targetfilerequestdeferral.md), [TargetFileRequestDeferral.Complete method](targetfilerequestdeferral_complete_1807836922.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md), [TargetFileRequestedEventArgs.Request property](targetfilerequestedeventargs_request.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
