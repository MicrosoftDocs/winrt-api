---
-api-id: M:Windows.Media.Core.MediaStreamSource.AddStreamDescriptor(Windows.Media.Core.IMediaStreamDescriptor)
-api-type: winrt method
---

<!-- Method syntax
public void AddStreamDescriptor(Windows.Media.Core.IMediaStreamDescriptor descriptor)
-->

# Windows.Media.Core.MediaStreamSource.AddStreamDescriptor

## -description
Adds a new stream descriptor to the [MediaStreamSource](mediastreamsource.md).

## -parameters
### -param descriptor
The descriptor to add.

## -remarks
This method can only be invoked when the [MediaStreamSource](mediastreamsource.md) is not yet in use by the media pipeline, for example by a [video](https://msdn.microsoft.com/en-us/library/ff975073(v=vs.85).aspx) object, a [MediaElement](../windows.ui.xaml.controls/mediaelement.md), or a [MediaTranscoder](../windows.media.transcoding/mediatranscoder.md).

It is possible to invoke this method multiple times.

## -examples

## -see-also
