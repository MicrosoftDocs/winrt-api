---
-api-id: P:Windows.Media.Effects.IBasicVideoEffect.SupportedEncodingProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.MediaProperties.VideoEncodingProperties> SupportedEncodingProperties { get; }
-->

# Windows.Media.Effects.IBasicVideoEffect.SupportedEncodingProperties

## -description
Gets the encoding properties supported by the custom video effect.

## -property-value
A list of supported encoding properties.

## -remarks
If you return an empty list of [VideoEncodingProperties](../windows.media.mediaproperties/videoencodingproperties.md) objects from **SupportedEncodingProperties**, the system will default to ARGB32 encoding.

## -examples

## -see-also
