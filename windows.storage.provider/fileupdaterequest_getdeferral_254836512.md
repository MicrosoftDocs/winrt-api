---
-api-id: M:Windows.Storage.Provider.FileUpdateRequest.GetDeferral
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Storage.Provider.FileUpdateRequestDeferral GetDeferral()
-->

# Windows.Storage.Provider.FileUpdateRequest.GetDeferral

## -description
Gets an object used to complete an update asynchronously.

## -returns
The object that the app uses to indicate, asynchronously, that it has finished responding to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event and that the [Request](fileupdaterequestedeventargs_request.md) is complete.

## -remarks
If you don't call this method, a request is considered complete as soon as the [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event handler returns— regardless of outstanding asynchronous operations.

## -examples

## -see-also
