---
-api-id: M:Windows.Media.Editing.MediaComposition.LoadAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Editing.MediaComposition> LoadAsync(Windows.Storage.StorageFile file)
-->

# Windows.Media.Editing.MediaComposition.LoadAsync

## -description
Asynchronously loads a [MediaComposition](mediacomposition.md) from a [StorageFile](../windows.storage/storagefile.md).

## -parameters
### -param file
The file from which to load the [MediaComposition](mediacomposition.md).

## -returns
An async operation which can be used to track the success or failure of the operation.

## -remarks
This method allows you to load a composition from an XML file you saved with a previous call to [SaveAsync](mediacomposition_saveasync_389603876.md). Once you have loaded the composition, you can make changes to the composition and either save it again or render it to a video file by calling [RenderToFileAsync](/uwp/api/windows.media.editing.mediacomposition.rendertofileasync).

## -examples

## -see-also
