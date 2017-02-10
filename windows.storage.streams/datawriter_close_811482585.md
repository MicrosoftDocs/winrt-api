---
-api-id: M:Windows.Storage.Streams.DataWriter.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Storage.Streams.DataWriter.Close

## -description
Closes the current stream and releases system resources.

## -remarks
[DataWriter](datawriter.md) takes ownership of the stream that is passed to its constructor. Calling this method also calls  on the associated stream. After calling this method, calls to most other [DataWriter](datawriter.md) methods will fail.

If you do not want the associated stream to be closed when the reader closes, call [DataWriter.DetachStream](datawriter_detachstream.md) before calling this method.

## -examples

## -see-also
