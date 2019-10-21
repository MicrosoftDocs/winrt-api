---
-api-id: P:Windows.Media.MediaProperties.AudioEncodingProperties.Subtype
-api-type: winrt property
---

<!-- Property syntax
public string Subtype { get;  set; }
-->

# Windows.Media.MediaProperties.AudioEncodingProperties.Subtype

## -description
Gets or sets the subtype of the format.

## -property-value
The subtype.

## -remarks
The value can be the string representation of a GUID in canonical form, or one of the predefined values listed in the following table.<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>"AAC"</td><td>Advanced Audio Coding (AAC). The stream can contain either raw AAC data or AAC data in an Audio Data Transport Stream (ADTS) stream.</td></tr>
   <tr><td>"AC3"</td><td>Dolby Digital audio (AC-3).</td></tr>
   <tr><td>"AACADTS"</td><td>Advanced Audio Coding (AAC) audio in Audio Data Transport Stream (ADTS) format.</td></tr>
   <tr><td>"AACHDCP"</td><td>AAC in High-Bandwidth Digital Content Protection (HDCP) format.</td></tr>
   <tr><td>"AC3"</td><td>Dolby AC3</td></tr>
   <tr><td>"AC3SPDIF"</td><td>Dolby AC-3 audio over Sony/Philips Digital Interface (S/PDIF).</td></tr>
   <tr><td>"AC3HDCP"</td><td>Dolby AC-3 in High-Bandwidth Digital Content Protection (HDCP) format.</td></tr>
   <tr><td>"ADTS"</td><td>Audio Data Transport Stream</td></tr>
   <tr><td>"ALAC"</td><td>Apple Lossless Audio Codec</td></tr>
   <tr><td>"AMRNB"</td><td>Adaptive Multi-Rate audio codec (AMR-NB)</td></tr>
   <tr><td>"AWRWB"</td><td>Adaptive Multi-Rate Wideband audio codec (AMR-WB)</td></tr>
   <tr><td>"DTS"</td><td>Digital Theater Systems (DTS)</td></tr>
   <tr><td>"EAC3"</td><td>Dolby Digital Plus audio (E-AC-3).</td></tr>
   <tr><td>"FLAC"</td><td>Free Lossless Audio Codec</td></tr>
   <tr><td>"Float"</td><td>Uncompressed 32-bit float PCM audio.</td></tr>
   <tr><td>"MP3"</td><td>MPEG Audio Layer-3 (MP3).</td></tr>
   <tr><td>"MPEG"</td><td>MPEG-1 audio payload.</td></tr>
   <tr><td>"OPUS"</td><td>Opus</td></tr>
   <tr><td>"PCM"</td><td>Uncompressed 16-bit PCM audio.</td></tr>
   <tr><td>"WMA8"</td><td>Windows Media Audio 8 codec, Windows Media Audio 9 codec, or Windows Media Audio 9.1 codec.</td></tr>
   <tr><td>"WMA9"</td><td>Windows Media Audio 9 Professional codec or Windows Media Audio 9.1 Professional codec.</td></tr>
   <tr><td>"Vorbis"</td><td>Vorbis codec</td></tr>
</table>

> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as AudioEncodingProperties.Subtype, [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and [ImageEncodingProperties.Subtype](imageencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

## -examples

## -see-also
