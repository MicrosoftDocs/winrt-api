---
-api-id: T:Windows.Devices.Display.Core.DisplayPathScaling
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayPathScaling : int 
-->

# Windows.Devices.Display.Core.DisplayPathScaling

## -description
Defines constants that specify how to scale content from a frame buffer to a target.

## -enum-fields

### -field AspectRatioStretched:3
Indicates that content should be stretched to fit within the target resolution, but without changing the source aspect ratio. Any unoccupied space is rendered as black pixels.

### -field Identity:0
Indicates that content should not be stretched at all. This is only applicable if the source and target resolutions are identical.

### -field Centered:1
Indicates that content should be centered within the target resolution, with no scaling. Any unoccupied space is rendered as black pixels.

### -field Custom:4
Reserved for future use.

### -field DriverPreferred:5
Indicates that the driver should determine how to scale the content.

### -field Stretched:2
Indicates that content should be stretched to the exact target resolution.

## -remarks

## -see-also

## -examples
