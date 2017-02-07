---
-api-id: T:Windows.Storage.Streams.InputStreamOverStream
-api-type: winrt class
---

<!-- Class syntax.
public class InputStreamOverStream : Windows.Foundation.IClosable, Windows.Storage.Streams.IInputStream
-->

# Windows.Storage.Streams.InputStreamOverStream

## -description
Provides a Windows Runtime input stream for an [IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531) base implementation.

## -remarks
The [InputStreamOverStream](inputstreamoverstream.md), [OutputStreamOverStream](outputstreamoverstream.md), and [RandomAccessStreamOverStream](randomaccessstreamoverstream.md) classes are interop helpers to convert between the Windows Runtime stream types, which are natively asynchronous, and the Component Object Model (COM)[IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531) types, which are natively synchronous.

These helper classes make it easier for to reuse legacy code when you transition to the Windows Runtime stream types.

## -examples

## -see-also
[OutputStreamOverStream](outputstreamoverstream.md), [RandomAccessStreamOverStream](randomaccessstreamoverstream.md), [IStream](http://msdn.microsoft.com/library/c6f60e37-eadc-46a1-94f6-cacc23613531)