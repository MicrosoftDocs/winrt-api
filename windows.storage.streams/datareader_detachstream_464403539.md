---
-api-id: M:Windows.Storage.Streams.DataReader.DetachStream
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IInputStream DetachStream()
-->

# Windows.Storage.Streams.DataReader.DetachStream

## -description
Detaches the stream that is associated with the data reader.

## -returns
The detached stream.

## -remarks
If a read operation is in progress when an application attempts to detach the stream, the call will fail with the error HRESULT_FROM_WIN32(ERROR_INVALID_OPERATION).

## -examples

## -see-also
