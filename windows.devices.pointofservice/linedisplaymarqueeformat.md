---
-api-id: T:Windows.Devices.PointOfService.LineDisplayMarqueeFormat
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LineDisplayMarqueeFormat : int 
-->

# Windows.Devices.PointOfService.LineDisplayMarqueeFormat

## -description
Defines the constants that indicate the marquee format for the current window. 

## -enum-fields
### -field Walk:1
The display is populated by walking data from the opposite end of the display as the scrolling direction. For example, if the scrolling direction is Left, then the viewport is filled by bringing characters in from the the right side and scrolling them to the left.

### -field Place:2
The display is populated by placing data. For example, if the scrolling direction is left, then the viewport is filled by placing characters starting at the left side, and beginning scrolling only after the viewport is full.

### -field None:0
Marquee scrolling is disabled.

## -remarks

## -see-also

## -examples

