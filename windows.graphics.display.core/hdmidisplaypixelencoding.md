---
-api-id: T:Windows.Graphics.Display.Core.HdmiDisplayPixelEncoding
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum HdmiDisplayPixelEncoding : int 
-->

# Windows.Graphics.Display.Core.HdmiDisplayPixelEncoding

## -description

Describes the types of pixel encoding format.

## -enum-fields
### -field Ycc444:1

Video signal is separated into the chroma (Cb and Cr) and luma (Y) components, with no chroma sub-sampling.

### -field Ycc422:2

Chroma sub-sampling is done at 4:2:2. The two chroma components are sampled at half the sample rate of the luma component.

### -field Ycc420:3

Chroma sub-sampling is done at 4:2:0. Only one chroma component is sampled on per line. This means that the two chroma components take turns to be sampled, so they are sampled on alternate lines at half the sample rate of the luma component.

### -field Rgb444:0

Video signal is separated into the red, green, blue (RGB) components, with no color sub-sampling.

## -remarks

## -see-also

## -examples

