---
-api-id: M:Windows.Storage.Streams.DataReader.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Storage.Streams.DataReader.Close

## -description
Closes the current stream and releases system resources.

## -remarks
[DataReader](datareader.md) takes ownership of the stream that is passed to its constructor. Calling this method also calls  on the associated stream. After calling this method, calls to most other [DataReader](datareader.md) methods will fail.

If you do not want the associated stream to be closed when the reader closes, call [DataReader.DetachStream](datareader_detachstream.md) before calling this method.

## -examples

## -see-also
