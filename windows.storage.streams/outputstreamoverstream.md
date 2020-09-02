---
-api-id: T:Windows.Storage.Streams.OutputStreamOverStream
-api-type: winrt class
---

<!-- Class syntax.
public class OutputStreamOverStream : Windows.Foundation.IClosable, Windows.Storage.Streams.IOutputStream
-->

# Windows.Storage.Streams.OutputStreamOverStream

## -description
Provides a Windows Runtime output stream for an [IStream](/windows/desktop/api/objidl/nn-objidl-istream) base implementation.

## -remarks
The [InputStreamOverStream](inputstreamoverstream.md), OutputStreamOverStream, and [RandomAccessStreamOverStream](randomaccessstreamoverstream.md) classes are interop helpers to convert between the Windows Runtime stream types, which are natively asynchronous, and the Component Object Model (COM) [IStream](/windows/desktop/api/objidl/nn-objidl-istream) types, which are natively synchronous.

These helper classes make it easier for to reuse legacy code when you transition to the Windows Runtime stream types.

## -examples

## -see-also
[InputStreamOverStream](inputstreamoverstream.md), [RandomAccessStreamOverStream](randomaccessstreamoverstream.md), [IStream](/windows/desktop/api/objidl/nn-objidl-istream)
