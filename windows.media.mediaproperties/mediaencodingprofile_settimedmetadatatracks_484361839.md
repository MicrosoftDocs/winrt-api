---
-api-id: M:Windows.Media.MediaProperties.MediaEncodingProfile.SetTimedMetadataTracks(Windows.Foundation.Collections.IIterable{Windows.Media.Core.TimedMetadataStreamDescriptor})
-api-type: winrt method
---

<!-- Method syntax.
public void MediaEncodingProfile.SetTimedMetadataTracks(IIterable<TimedMetadataStreamDescriptor> value)
-->

# Windows.Media.MediaProperties.MediaEncodingProfile.SetTimedMetadataTracks

## -description
Sets the list of [TimedMetadataStreamDescriptor](../windows.media.core/timedmetadatastreamdescriptor.md) objects describing the timed metadata streams included in the **MediaEncodingProfile**.

## -parameters
### -param value
A collection of TimedMetadataStreamDescriptor objects.

## -remarks
The  [Label](/uwp/api/windows.media.core.videostreamdescriptor.Label) field for each [VideoStreamDescriptor](/uwp/api/windows.media.core.videostreamdescriptor) in the collection must be unique. If you attempt to add more than one stream descriptor with the same label, an invalid argument error will occur.

## -see-also

## -examples

