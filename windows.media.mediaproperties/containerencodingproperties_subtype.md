---
-api-id: P:Windows.Media.MediaProperties.ContainerEncodingProperties.Subtype
-api-type: winrt property
---

<!-- Property syntax
public string Subtype { get;  set; }
-->

# Windows.Media.MediaProperties.ContainerEncodingProperties.Subtype

## -description
Gets or sets the subtype of the media container.

## -property-value
The subtype.

## -remarks
The value can be the string representation of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in canonical form, or one of the predefined values listed in the following table.<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>"3GP"</td><td>3GP file.</td></tr>
   <tr><td>"AC3"</td><td>AC-3 audio.</td></tr>
   <tr><td>"ADTS"</td><td>Audio Data Transport Stream (ADTS) stream.</td></tr>
   <tr><td>"MP3"</td><td>MPEG Audio Layer-3 (MP3).</td></tr>
   <tr><td>"MPEG2PS"</td><td>MPEG-2 program stream.</td></tr>
   <tr><td>"MPEG2TS"</td><td>MPEG-2 transport stream.</td></tr>
   <tr><td>"MPEG4"</td><td>MP4 file container.</td></tr>
</table>

> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), ContainerEncodingProperties.Subtype, and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

## -examples

## -see-also
