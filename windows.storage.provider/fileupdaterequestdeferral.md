---
-api-id: T:Windows.Storage.Provider.FileUpdateRequestDeferral
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileUpdateRequestDeferral : Windows.Storage.Provider.IFileUpdateRequestDeferral
-->

# Windows.Storage.Provider.FileUpdateRequestDeferral

## -description
Use to complete an update asynchronously.

## -remarks
If your app participates in the Cached File Updater contract, and you can't finish responding to the update before returning from your [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler, call the [FileUpdaterRequestDeferral.Complete](fileupdaterequestdeferral_complete_1807836922.md) method to complete the update asynchronously.

> [!NOTE]
> The file picker UI is disabled until the app has finished responding to all [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events that were fired.

To learn about responding to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, see [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md).

## -examples
The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, including how to get a deferral.

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
