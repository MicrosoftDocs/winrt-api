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
MediaEncodingSubtypes provides names for media subtypes which can be used to set [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md).

> [!WARNING]
> The string values returned by the MediaEncodingSubtypes properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

For how-to guidance for setting the encoding properties for media, see [Set media encoding properties for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Alac |
| 1703 | 15063 | D16 |
| 1703 | 15063 | Flac |
| 1703 | 15063 | L16 |
| 1703 | 15063 | L8 |
| 1703 | 15063 | Vp9 |
| 1803 | 17134 | P010 |
| 1809 | 17763 | Heif |
| 2004 | 19041 | Pgs |
| 2004 | 19041 | Srt |
| 2004 | 19041 | Ssa |
| 2004 | 19041 | VobSub |

## -examples

## -see-also
[Set media encoding properties for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties)
