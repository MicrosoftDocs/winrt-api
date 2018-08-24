---
-api-id: M:Windows.Media.Editing.MediaComposition.SaveAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SaveAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Media.Editing.MediaComposition.SaveAsync

## -description
Asynchronously serializes the [MediaComposition](mediacomposition.md) to disk so that it can be loaded and modified in the future.

## -parameters
### -param file
The file to which the [MediaComposition](mediacomposition.md) is saved.

## -returns
An async action which can be used to track the success or failure of the operation.

## -remarks
This method saves the composition as an XML file containing metadata about the composition such as the source media files, arrangement of clips, overlays, and effects applied to the composition. A new media composition can be created from the saved XML file by calling [LoadAsync](mediacomposition_loadasync_1582010589.md).

To render a media composition as a video file so that it can be played back by standard media players, use the [RenderToFileAsync](/uwp/api/windows.media.editing.mediacomposition.rendertofileasync) method.

## -examples

## -see-also
