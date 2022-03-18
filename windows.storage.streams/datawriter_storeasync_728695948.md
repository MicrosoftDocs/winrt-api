---
-api-id: M:Windows.Storage.Streams.DataWriter.StoreAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.DataWriterStoreOperation StoreAsync()
-->

# Windows.Storage.Streams.DataWriter.StoreAsync

## -description
Commits data in the buffer to the output stream. This method should only be called when the DataWriter is writing into a stream; it will fail when the underlying store is a buffer.

## -returns

The asynchronous store data operation in the form of a [DataWriterStoreOperation](/uwp/api/windows.storage.streams.datawriterstoreoperation) object which, when it completes, contains an unsigned integer.

## -remarks

## -examples

## -see-also
