---
-api-id: P:Windows.Media.MediaProperties.IMediaEncodingProperties.Type
-api-type: winrt property
---

<!-- Property syntax
public string Type { get; }
-->

# Windows.Media.MediaProperties.IMediaEncodingProperties.Type

## -description
Gets the format type.

## -property-value
The format type. The value can be the string representation of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in canonical form, or one of the predefined values listed in the following table.

| Value | Description |
|---|---|
| "Audio" | Audio stream. To get details of the audio format, use [AudioEncodingProperties](audioencodingproperties.md). |
| "Container" | Media container. |
| "Image" | Still image data. To get details of the image format, use [ImageEncodingProperties](imageencodingproperties.md). |
| "Video" | Video stream. To get details of the video format, use [VideoEncodingProperties](videoencodingproperties.md). |

## -remarks

## -examples

## -see-also
