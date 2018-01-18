---
-api-id: T:Windows.Graphics.Display.AdvancedColorKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AdvancedColorKind : int 
-->

# Windows.Graphics.Display.AdvancedColorKind



## -description
Describes what kind of Advanced Color the display supports.



## -enum-fields
### -field WideColorGamut:1

The display supports Wide Color Gamut. In this case, it is safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signalling is usually done using sRGB.


### -field StandardDynamicRange:0

The display only supports standard dynamic range. In this case, it is safe to assume that OS composition is being done using an RGB:8 surface encoded as sRGB gamma. The actual wire signalling is usually done using sRGB.


### -field HighDynamicRange:2

The display supports high dynamic range. In this case, it is safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signalling is usually done using ST2084. 


## -remarks

## -see-also

## -examples

