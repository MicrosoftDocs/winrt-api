---
-api-id: M:Windows.Media.Core.MediaStreamSource.#ctor(Windows.Media.Core.IMediaStreamDescriptor,Windows.Media.Core.IMediaStreamDescriptor)
-api-type: winrt method
---

<!-- Method syntax
public MediaStreamSource(Windows.Media.Core.IMediaStreamDescriptor descriptor, Windows.Media.Core.IMediaStreamDescriptor descriptor2)
-->

# Windows.Media.Core.MediaStreamSource.MediaStreamSource

## -description
Creates an instance of [MediaStreamSource](mediastreamsource.md) from two [IMediaStreamDescriptor](imediastreamdescriptor.md) objects.

## -parameters
### -param descriptor
The first [AudioStreamDescriptor](audiostreamdescriptor.md) or [VideoStreamDescriptor](videostreamdescriptor.md) to create the [MediaStreamSource](mediastreamsource.md) from.

### -param descriptor2
The second [AudioStreamDescriptor](audiostreamdescriptor.md) or [VideoStreamDescriptor](videostreamdescriptor.md) to create the [MediaStreamSource](mediastreamsource.md) from.

## -remarks
This constructor creates a [MediaStreamSource](mediastreamsource.md) using a two [AudioStreamDescriptor](audiostreamdescriptor.md) or [VideoStreamDescriptor](videostreamdescriptor.md) objects. If the [MediaStreamSource](mediastreamsource.md) needs only on descriptor, the [MediaStreamSource](mediastreamsource_mediastreamsource_1712288544.md) constructor overload which takes two descriptor can be used.

It is possible to add additional descriptors to a [MediaStreamSource](mediastreamsource.md) after it has been created, by invoking the [AddStreamDescriptor](mediastreamsource_addstreamdescriptor_503977765.md) method.

## -examples

## -see-also
[MediaStreamSource(IMediaStreamDescriptor)](mediastreamsource_mediastreamsource_1712288544.md)