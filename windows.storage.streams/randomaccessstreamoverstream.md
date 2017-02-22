---
-api-id: T:Windows.Storage.Streams.RandomAccessStreamOverStream
-api-type: winrt class
---

<!-- Class syntax.
public class RandomAccessStreamOverStream : Windows.Foundation.IClosable, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream
-->

# Windows.Storage.Streams.RandomAccessStreamOverStream

## -description
Provides a Windows Runtime random access stream for an [IStream](https://msdn.microsoft.com/library/windows/desktop/aa380034.aspx) base implementation.

## -remarks
The [InputStreamOverStream](inputstreamoverstream.md), [OutputStreamOverStream](outputstreamoverstream.md), and [RandomAccessStreamOverStream](randomaccessstreamoverstream.md) classes are interop helpers to convert between the Windows Runtime stream types, which are natively asynchronous, and the Component Object Model (COM) [IStream](https://msdn.microsoft.com/library/windows/desktop/aa380034.aspx) types, which are natively synchronous.

These helper classes make it easier for to reuse legacy code when you transition to the Windows Runtime stream types.

## -examples

## -see-also
[RandomAccessStream](randomaccessstream.md), [RandomAccessStreamReference](randomaccessstreamreference.md), [InputStreamOverStream](inputstreamoverstream.md), [OutputStreamOverStream](outputstreamoverstream.md), [IStream](https://msdn.microsoft.com/library/windows/desktop/aa380034.aspx)

