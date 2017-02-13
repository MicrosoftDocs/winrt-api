---
-api-id: M:Windows.Storage.Streams.InMemoryRandomAccessStream.Seek(System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public void Seek(System.UInt64 position)
-->

# Windows.Storage.Streams.InMemoryRandomAccessStream.Seek

## -description
Sets the position of the stream to the specified value.

## -parameters
### -param position
The new position of the stream.

## -remarks
> [!WARNING]
> This method does not check the position to make sure the value is valid for the stream. If the position is invalid for the stream, the [ReadAsync](iinputstream_readasync.md) and [WriteAsync](ioutputstream_writeasync.md) methods will return an error if you call them.

## -examples

## -see-also
