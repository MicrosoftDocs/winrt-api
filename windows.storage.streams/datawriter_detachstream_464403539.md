---
-api-id: M:Windows.Storage.Streams.DataWriter.DetachStream
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IOutputStream DetachStream()
-->

# Windows.Storage.Streams.DataWriter.DetachStream

## -description
Detaches the stream that is associated with the data writer.

## -returns
The detached stream.

## -remarks
If a write operation is in progress when an application attempts to detach the stream, the call will fail with the error HRESULT_FROM_WIN32(ERROR_INVALID_OPERATION).

## -examples

## -see-also
