---
-api-id: T:Windows.Storage.Streams.IRandomAccessStreamReference
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IRandomAccessStreamReference : 
-->

# Windows.Storage.Streams.IRandomAccessStreamReference

## -description
Enables a Windows Runtime component to provide access to an encapsulated stream.

## -remarks
Implement the IRandomAccessStreamReference interface when your Windows Runtime component exposes a random access stream to callers. For a sequential read-only stream, implement the [IInputStreamReference](iinputstreamreference.md) interface.

For example, a [StorageFile](../windows.storage/storagefile.md) provides an [IRandomAccessStream](irandomaccessstream.md) for the contents of a file, so it implements the IRandomAccessStreamReference interface. Usually, providing a stream requires accessing the hard disk, so stream operations are asynchronous. Components that consume file content receive an IRandomAccessStreamReference instead of a [StorageFile](../windows.storage/storagefile.md) reference, because this interface is the more minimal requirement for the input parameter.

> [!IMPORTANT]
> Not all sources can provide random access streams efficiently. If a component requires only sequential read access, consider implementing the [IInputStreamReference](iinputstreamreference.md) interface instead of the IRandomAccessStreamReference interface.

## -examples

## -see-also
[IInputStreamReference](iinputstreamreference.md)
