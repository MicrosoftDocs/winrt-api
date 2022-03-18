---
-api-id: T:Windows.Storage.Provider.FileUpdateRequest
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FileUpdateRequest : Windows.Storage.Provider.IFileUpdateRequest, Windows.Storage.Provider.IFileUpdateRequest2
-->

# Windows.Storage.Provider.FileUpdateRequest

## -description
Provides information about a requested file update so that the app can complete the request.

## -remarks
If your app participates in the Cached File Updater contract, use this class to respond when Windows fires [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events to request file updates. You can access this class from your event handler using the [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md).[Request](fileupdaterequestedeventargs_request.md) property. As a part of your response to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, you must set the [Status](fileupdaterequest_status.md) property of this class to indicate the status of the update.

Learn more about responding to update requests in [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) and [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md).

If your app can't complete the update before returning from its [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler, you can use the [GetDeferral](fileupdaterequest_getdeferral_254836512.md) property to finish the update asynchronously.

## -examples
The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, including how to use [Request](fileupdaterequestedeventargs_request.md) to get the FileUpdateRequest.

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
