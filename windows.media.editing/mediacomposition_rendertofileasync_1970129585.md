---
-api-id: M:Windows.Media.Editing.MediaComposition.RenderToFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Media.Transcoding.TranscodeFailureReason, double> RenderToFileAsync(Windows.Storage.IStorageFile destination)
-->

# Windows.Media.Editing.MediaComposition.RenderToFileAsync

## -description
Asynchronously renders the [MediaComposition](mediacomposition.md) to the specified file.

## -parameters
### -param destination
The file to which this [MediaComposition](mediacomposition.md) is rendered.

## -returns
An async operation which can be used to track the success or failure of the operation.

## -remarks
This method saves the composition to a video file that can be played back with standard media players. If you want to save the composition as an XML file that can be loaded and modified in the future, use [SaveAsync](mediacomposition_saveasync_389603876.md).

## -examples

## -see-also
[RenderToFileAsync(IStorageFile, MediaTrimmingPreference)](mediacomposition_rendertofileasync_1125216263.md), [RenderToFileAsync(IStorageFile, MediaTrimmingPreference, MediaEncodingProfile)](mediacomposition_rendertofileasync_1565341453.md)