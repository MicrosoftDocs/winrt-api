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
If your app participates in the Cached File Updater contract, and you can't finish responding to the update before returning from your [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler, call the [FileUpdaterRequestDeferral.Complete](fileupdaterequestdeferral_complete.md) method to complete the update asynchronously.

> [!NOTE]
> The file picker UI is disabled until the app has finished responding to all [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events that were fired.

To learn about responding to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, see [FileUpdateRequestedEventArgs](fileupdaterequestedeventargs.md).

## -examples
The [File picker contracts sample](http://go.microsoft.com/fwlink/p/?linkid=231536) demonstrates how to respond to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event, including how to get a deferral.

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