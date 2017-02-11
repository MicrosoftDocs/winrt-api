---
-api-id: P:Windows.Storage.Streams.IRandomAccessStream.Position
-api-type: winrt property
---

<!-- Property syntax
public ulong Position { get; }
-->

# Windows.Storage.Streams.IRandomAccessStream.Position

## -description
Gets the byte offset of the stream.

## -property-value
The number of bytes from the start of the stream.

## -remarks
The initial offset of a [IRandomAccessStream](irandomaccessstream.md) is 0.

This offset is affected by both [IInputStream](iinputstream.md) and [IOutputStream](ioutputstream.md) operations.

## -examples

## -see-also
