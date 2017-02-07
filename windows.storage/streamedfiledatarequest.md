---
-api-id: T:Windows.Storage.StreamedFileDataRequest
-api-type: winrt class
---

<!-- Class syntax.
public class StreamedFileDataRequest : Windows.Foundation.IClosable, Windows.Storage.IStreamedFileDataRequest, Windows.Storage.Streams.IOutputStream
-->

# Windows.Storage.StreamedFileDataRequest

## -description
Represents a sequential-access output stream that indicates a request for the data stream of a [StorageFile](storagefile.md) that was created by calling [CreateStreamedFileAsync](storagefile_createstreamedfileasync.md) or [ReplaceWithStreamedFileAsync](storagefile_replacewithstreamedfileasync.md).

## -remarks
This object is passed to the app's [StreamedFileDataRequestedHandler](streamedfiledatarequestedhandler.md) function when a stream that is represented by a [StorageFile](storagefile.md) is accessed. Define the [StreamedFileDataRequestedHandler](streamedfiledatarequestedhandler.md) function if you use [CreateStreamedFileAsync](storagefile_createstreamedfileasync.md) or [ReplaceWithStreamedFileAsync](storagefile_replacewithstreamedfileasync.md) to get a [StorageFile](storagefile.md) that represents the stream.

## -examples


## -see-also