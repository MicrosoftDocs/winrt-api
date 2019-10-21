---
-api-id: P:Windows.Media.MediaProperties.VideoEncodingProperties.Subtype
-api-type: winrt property
---

<!-- Property syntax
public string Subtype { get;  set; }
-->

# Windows.Media.MediaProperties.VideoEncodingProperties.Subtype

## -description
Gets or sets the subtype of the format.

## -property-value
The subtype.

## -remarks
The value can be the string representation of a GUID in canonical form, or one of the predefined values listed in the following table.<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>"ARGB32"</td><td>RGB, 32 bpp with alpha channel.</td></tr>
   <tr><td>"BGRA8"</td><td>BGRA, 32 bpp with alpha channel.</td></tr>
   <tr><td>"D16"</td><td>16-bit z-buffer depth</td></tr>
   <tr><td>"H263"</td><td>H.263 video</td></tr>
   <tr><td>"H264"</td><td>H.264 video</td></tr>
   <tr><td>"H264ES"</td><td>H.264 elementary stream</td></tr>
   <tr><td>"HEVC"</td><td>HEVC video</td></tr>
   <tr><td>"HEVCES"</td><td>HEVT elementary stream</td></tr>
   <tr><td>"IYUV"</td><td>YUV 8 bpp 4:2:0</td></tr>
   <tr><td>"L8"</td><td>8-bit luminance only.</td></tr>
   <tr><td>"L16"</td><td>16-bit luminance only.</td></tr>
   <tr><td>"MJPG"</td><td>Motion jpeg</td></tr>
   <tr><td>"NV12"</td><td>YUV 8 bpp 4:2:0</td></tr>
   <tr><td>"MPEG1"</td><td>MPEG-1 video</td></tr>
   <tr><td>"MPEG2"</td><td>MPEG-2 video</td></tr>
   <tr><td>"RGB24"</td><td>RGB, 24 bpp</td></tr>
   <tr><td>"RGB32"</td><td>RGB, 32 bpp</td></tr>
   <tr><td>"WMV3"</td><td>Windows Media Video 9 codec</td></tr>
   <tr><td>"WVC1"</td><td>SMPTE 421M ("VC-1") codec</td></tr>
   <tr><td>"VP9"</td><td>VP9 video</td></tr>
   <tr><td>"YUY2"</td><td>YUV 8 bpp 4:2:2</td></tr>
   <tr><td>"YV12"</td><td>YUV 8 bpp 4:2:0</td></tr>
</table>

> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), VideoEncodingProperties.Subtype, [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imageencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

## -examples

## -see-also
