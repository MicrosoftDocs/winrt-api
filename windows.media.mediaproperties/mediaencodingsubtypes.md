---
-api-id: T:Windows.Media.MediaProperties.MediaEncodingSubtypes
-api-type: winrt class
---

<!-- Class syntax.
public class MediaEncodingSubtypes 
-->

# Windows.Media.MediaProperties.MediaEncodingSubtypes

## -description
Provides properties for getting the standard names for media subtypes.

## -remarks
[MediaEncodingSubtypes](mediaencodingsubtypes.md) provides names for media subtypes which can be used to set [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md).

> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

For how-to guidance for setting the encoding properties for media, see [Set media encoding properties for MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/set-media-encoding-properties).

## -examples

## -see-also
[Set media encoding properties for MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/set-media-encoding-properties)