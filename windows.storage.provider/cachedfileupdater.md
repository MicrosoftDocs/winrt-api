---
-api-id: T:Windows.Storage.Provider.CachedFileUpdater
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CachedFileUpdater 
-->

# Windows.Storage.Provider.CachedFileUpdater

## -description

Manages files so that they can be updated in real-time by an app that participates in the Cached File Updater contract.

## -remarks

Access methods in this class statically.

## -examples

The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to set update information for a file in its [TargetFileRequested](../windows.storage.pickers.provider/filesavepickerui_targetfilerequested.md) event handler.

```csharp

private async void OnTargetFileRequested(FileSavePickerUI sender, TargetFileRequestedEventArgs e)
{
    // Handle the TargetFileRequested event on the background thread on which it was raised

    // Requesting a deferral allows the app to call another asynchronous method and complete the request at a later time
    var deferral = e.Request.GetDeferral();

    StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(sender.FileName, CreationCollisionOption.ReplaceExisting);

    // Set update info for the file
    CachedFileUpdater.SetUpdateInformation(file, "CachedFile", ReadActivationMode.NotNeeded, WriteActivationMode.AfterWrite, CachedFileOptions.RequireUpdateOnAccess);

    // Assign the resulting file to the targetFile property and complete the deferral to indicate success  
    e.Request.TargetFile = file;
    deferral.Complete();
}
```

## -see-also

[File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
