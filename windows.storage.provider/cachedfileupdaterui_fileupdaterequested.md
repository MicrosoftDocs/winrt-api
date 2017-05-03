---
-api-id: E:Windows.Storage.Provider.CachedFileUpdaterUI.FileUpdateRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FileUpdateRequested<Windows.Storage.Provider.CachedFileUpdaterUI,  Windows.Storage.Provider.FileUpdateRequestedEventArgs>
-->

# Windows.Storage.Provider.CachedFileUpdaterUI.FileUpdateRequested

## -description
Fires when the Windows requests a file update. This event fires once for each requested update.

## -remarks
If your app participates in the Cached File Updater contract, you must register for this event in your app's activated event handler where you check for [ActivationKind.CachedFileUpdater](../windows.applicationmodel.activation/activationkind.md). You must respond to this [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event by updating the file and setting the [FileUpdateRequest.Status](fileupdaterequest_status.md) of the request. Use the [CachedFileUpdaterUI](cachedfileupdaterui.md).[UpdateTarget](cachedfileupdaterui_updatetarget.md) property to determine whether your app should update the version file in its repository or the locally cached copy of the file in response to the request.

You can access information about the requested update by using the [FileUpdateRequestedEventArgs.Request](fileupdaterequestedeventargs_request.md) property on the object that is passed to your [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler. 

If you need user input to complete the update, set the [FileUpdateRequest.Status](fileupdaterequest_status.md) to [FileUpdateStatus.UserInputNeeded](fileupdatestatus.md) and complete the request. If user interaction is available, another [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) will fire and your app can obtain user input and complete the request.

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
