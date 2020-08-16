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

```javascript
function onTargetFileRequested(e) {
    var deferral;
    deferral = e.request.getDeferral();

    Windows.Storage.ApplicationData.current.localFolder.createFileAsync(fileSavePickerUI.fileName, Windows.Storage.CreationCollisionOption.replaceExisting).done(
        function (file) {
            // Set update info for the file
            Windows.Storage.Provider.CachedFileUpdater.setUpdateInformation(
                file,
                "CachedFile",
                Windows.Storage.Provider.ReadActivationMode.notNeeded,
                Windows.Storage.Provider.WriteActivationMode.afterWrite,
                Windows.Storage.Provider.CachedFileOptions.requireUpdateOnAccess
            );

            // Assign the resulting file to the targetFile property and complete the deferral to indicate success
            e.request.targetFile = file;
            deferral.complete();
        }, function () {
            // Set the targetFile property to null and complete the deferral to indicate failure
            e.request.targetFile = null;
            deferral.complete();
        }
    );
};
```

## -see-also

[File picker provider sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
