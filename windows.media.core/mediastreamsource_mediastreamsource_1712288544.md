---
-api-id: M:Windows.Media.Core.MediaStreamSource.#ctor(Windows.Media.Core.IMediaStreamDescriptor)
-api-type: winrt method
---

<!-- Method syntax
public MediaStreamSource(Windows.Media.Core.IMediaStreamDescriptor descriptor)
-->

# Windows.Media.Core.MediaStreamSource.MediaStreamSource

## -description
Creates an instance of [MediaStreamSource](mediastreamsource.md) from the specified [IMediaStreamDescriptor](imediastreamdescriptor.md).

## -parameters
### -param descriptor
The [AudioStreamDescriptor](audiostreamdescriptor.md) or [VideoStreamDescriptor](videostreamdescriptor.md) to create the [MediaStreamSource](mediastreamsource.md) from.

## -remarks
This constructor creates a [MediaStreamSource](mediastreamsource.md) using a single [AudioStreamDescriptor](audiostreamdescriptor.md) or [VideoStreamDescriptor](videostreamdescriptor.md) object. If the [MediaStreamSource](mediastreamsource.md) needs descriptors, the [MediaStreamSource](mediastreamsource_mediastreamsource_998833464.md) constructor overload which takes two descriptor can be used.

It is possible to add additional descriptors to a [MediaStreamSource](mediastreamsource.md) after it has been created, by invoking the [AddStreamDescriptor](mediastreamsource_addstreamdescriptor_503977765.md) method.

## -examples

## -see-also
[MediaStreamSource(IMediaStreamDescriptor, IMediaStreamDescriptor)](mediastreamsource_mediastreamsource_998833464.md)