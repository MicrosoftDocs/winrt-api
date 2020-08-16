---
-api-id: P:Windows.Media.MediaProperties.ImageEncodingProperties.Subtype
-api-type: winrt property
---

<!-- Property syntax
public string Subtype { get;  set; }
-->

# Windows.Media.MediaProperties.ImageEncodingProperties.Subtype

## -description
Gets or sets the subtype of the format.

## -property-value
The subtype.

## -remarks
The value can be the string representation of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in canonical form, or one of the predefined values listed in the following table.<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>"BMP"</td><td>Bitmap image.</td></tr>
   <tr><td>"ICO"</td><td>ICO image.</td></tr>
   <tr><td>"GIF"</td><td>GIF image.</td></tr>
   <tr><td>"JPEG"</td><td>JPEG image.</td></tr>
   <tr><td>"PNG"</td><td>PNG image.</td></tr>
   <tr><td>"TIFF"</td><td>TIFF image.</td></tr>
   <tr><td>"WMP"</td><td>JPEG-XR or HD Photo image.</td></tr>
</table>

> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), [ContainerEncodingProperties.Subtype](containerencodingproperties_subtype.md), and ImageEncodingProperties.Subtype. For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

## -examples

## -see-also
