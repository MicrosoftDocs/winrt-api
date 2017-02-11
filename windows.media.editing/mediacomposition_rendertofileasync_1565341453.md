---
-api-id: M:Windows.Media.Editing.MediaComposition.RenderToFileAsync(Windows.Storage.IStorageFile,Windows.Media.Editing.MediaTrimmingPreference,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Media.Transcoding.TranscodeFailureReason, double> RenderToFileAsync(Windows.Storage.IStorageFile destination, Windows.Media.Editing.MediaTrimmingPreference trimmingPreference, Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile)
-->

# Windows.Media.Editing.MediaComposition.RenderToFileAsync

## -description
Asynchronously renders the [MediaComposition](mediacomposition.md) to a specified file using the indicated media trimming preference and encoding profile.

## -parameters
### -param destination
The file to which this [MediaComposition](mediacomposition.md) is rendered.

### -param trimmingPreference
Specifies whether to be fast or precise when trimming the media.

### -param encodingProfile
Specifies the encoding profile to use for rendering the media.

## -returns
An async operation which can be used to track the success or failure of the operation.

## -remarks
This method saves the composition to a video file that can be played back with standard media players. If you want to save the composition as an XML file that can be loaded and modified in the future, use [SaveAsync](mediacomposition_saveasync.md).

## -examples

## -see-also
[RenderToFileAsync(IStorageFile)](mediacomposition_rendertofileasync_1970129585.md), [RenderToFileAsync(IStorageFile, MediaTrimmingPreference)](mediacomposition_rendertofileasync_1125216263.md)