---
-api-id: T:Windows.Storage.Provider.FileUpdateRequestedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileUpdateRequestedEventArgs : Windows.Storage.Provider.IFileUpdateRequestedEventArgs
-->

# Windows.Storage.Provider.FileUpdateRequestedEventArgs

## -description
Provides information about a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event.

## -remarks
If your app participates in the Cached File Updater contract, a FileUpdateRequestedEventArgs is passed to your app's [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler when the event fires. Use the [FileUpdateRequestedEventArgs.Request](fileupdaterequestedeventargs_request.md) property to get details about the requested update.

## -examples
The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event.

```csharp
// Event handler
void CachedFileUpdaterUI_FileUpdateRequested(CachedFileUpdaterUI sender, FileUpdateRequestedEventArgs args)
{
    fileUpdateRequest = args.Request;
    fileUpdateRequestDeferral = fileUpdateRequest.GetDeferral();
    switch (cachedFileUpdaterUI.UIStatus)
    {
        case UIStatus.Hidden:
            fileUpdateRequest.Status = FileUpdateStatus.UserInputNeeded;
            fileUpdateRequestDeferral.Complete();
            break;
        case UIStatus.Visible:
            break;
        case UIStatus.Unavailable:
            fileUpdateRequest.Status = FileUpdateStatus.Failed;
            fileUpdateRequestDeferral.Complete();
            break;
    }
}

// Register for the event
cachedFileUpdaterUI.FileUpdateRequested += CachedFileUpdaterUI_FileUpdateRequested;
```

`args` contains a [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md) object.

## -see-also
