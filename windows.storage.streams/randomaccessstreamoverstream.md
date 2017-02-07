---
-api-id: T:Windows.Storage.Streams.RandomAccessStreamOverStream
-api-type: winrt class
---

<!-- Class syntax.
public class RandomAccessStreamOverStream : Windows.Foundation.IClosable, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream
-->

# Windows.Storage.Streams.RandomAccessStreamOverStream

## -description
Provides a Windows Runtime random access stream for an [IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531) base implementation.

## -remarks
The [InputStreamOverStream](inputstreamoverstream.md), [OutputStreamOverStream](outputstreamoverstream.md), and [RandomAccessStreamOverStream](randomaccessstreamoverstream.md) classes are interop helpers to convert between the Windows Runtime stream types, which are natively asynchronous, and the Component Object Model (COM)[IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531) types, which are natively synchronous.

These helper classes make it easier for to reuse legacy code when you transition to the Windows Runtime stream types.

## -examples

## -see-also
[RandomAccessStream](randomaccessstream.md), [RandomAccessStreamReference](randomaccessstreamreference.md), [InputStreamOverStream](inputstreamoverstream.md), [OutputStreamOverStream](outputstreamoverstream.md), [IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531)