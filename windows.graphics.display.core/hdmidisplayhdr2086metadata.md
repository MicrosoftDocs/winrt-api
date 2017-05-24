---
-api-id: T:Windows.Graphics.Display.Core.HdmiDisplayHdr2086Metadata
-api-type: winrt struct
---

<!-- Structure syntax.
public struct HdmiDisplayHdr2086Metadata  {
	public ushort BluePrimaryX 
	public ushort BluePrimaryY 
	public ushort GreenPrimaryX 
	public ushort GreenPrimaryY 
	public ushort MaxContentLightLevel 
	public ushort MaxFrameAverageLightLevel 
	public ushort MaxMasteringLuminance 
	public ushort MinMasteringLuminance 
	public ushort RedPrimaryX 
	public ushort RedPrimaryY 
	public ushort WhitePointX 
	public ushort WhitePointY 
}
-->

# Windows.Graphics.Display.Core.HdmiDisplayHdr2086Metadata

## -description

Describes the 10 bit display metadata which is usually used for video. This is used to adjust the output to best match a display's capabilities.

## -struct-fields

### -field BluePrimaryX

The X chromaticity coordinate of the blue value.

### -field BluePrimaryY

The Y chromaticity coordinate of the blue value.

### -field GreenPrimaryX

The X chromaticity coordinate of the green value.

### -field GreenPrimaryY

The Y chromaticity coordinate of the green value.

### -field MaxContentLightLevel

The maximum nit value (in units of 0.00001 nit) used anywhere in the content.

### -field MaxFrameAverageLightLevel

The per-frame average of the maximum nit values (in units of 0.00001 nit).

### -field MaxMasteringLuminance

The maximum number of nits of the display used to master the content. Units are 0.0001 nit, so if the value is 1 nit, the value should be 10,000. 

### -field MinMasteringLuminance

The minimum number of nits (in units of 0.00001 nit) of the display used to master the content.

### -field RedPrimaryX

The X chromaticity coordinate of the red value.

### -field RedPrimaryY

The Y chromaticity coordinate of the red value.

### -field WhitePointX

The X chromaticity coordinate of the white point.

### -field WhitePointY

The Y chromaticity coordinate of the white point.

## -remarks

## -see-also

## -examples

