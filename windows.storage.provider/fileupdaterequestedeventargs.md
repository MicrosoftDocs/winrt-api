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
If your app participates in the Cached File Updater contract, a [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md) is passed to your app's [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler when the event fires. Use the [FileUpdateRequestedEventArgs.Request](fileupdaterequestedeventargs_request.md) property to get details about the requested update.

## -examples
The [File picker contracts sample](http://go.microsoft.com/fwlink/p/?linkid=231536) demonstrates how to respond to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event.

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

```javascript

// Event handler
function onFileUpdateRequest(e) {
    fileUpdateRequest = e.request;
    fileUpdateRequestDeferral = fileUpdateRequest.getDeferral();

    switch (cachedFileUpdaterUI.uiStatus) {
        case Windows.Storage.Provider.UIStatus.hidden:
            fileUpdateRequest.status = Windows.Storage.Provider.FileUpdateStatus.userInputNeeded;
            fileUpdateRequestDeferral.complete();
            break;
        case Windows.Storage.Provider.UIStatus.visible:
            var url = scenarios[0].url;
            WinJS.Navigation.navigate(url, cachedFileUpdaterUI);
            break;
        case Windows.Storage.Provider.UIStatus.unavailable:
            fileUpdateRequest.status = Windows.Storage.Provider.FileUpdateStatus.failed;
            fileUpdateRequestDeferral.complete();
            break;
    }
}

// Register for the event
cachedFileUpdaterUI.addEventListener("fileupdaterequested", onFileUpdateRequest);
```

Both `args` and `e` (in C# and JS respectively) contain a [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md) object.

## -see-also