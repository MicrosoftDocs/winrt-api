---
-api-id: T:Windows.Graphics.Display.AdvancedColorInfo
-api-type: winrt class
---

<!-- Class syntax.
public class AdvancedColorInfo 
-->

# Windows.Graphics.Display.AdvancedColorInfo

## -description

Contains a snapshot of the Advanced Color-related information of a monitor or display driver.

## -remarks

Advanced color is a Windows developer term indicating support for high dynamic range (HDR), wide color gamut (WCG), and high precision (bit depth) visual content such as videos, games and photos. To use advanced color, your computer must have an advanced color-capable GPU and display; further, the composition and display stack must enter a new advanced color mode that uses FP16 rendering and composition. 

To exploit advanced color, applications must be updated with enhanced rendering pipelines (e.g. DirectX) and they must detect and adapt to the specific capabilities of the current display. In terms of API design, advanced color has similarities to features such as high DPI and stereoscopic 3D. 

* Apps need to understand the current feature state, such as if HDR active, and what kind of HDR is active. Apps mus also understand the quantitative display characteristics (e.g. peak luminance, color primaries) and underlying capabilities of the hardware (e.g. can HDR be enabled at all). 

* User action or OS policy can change the feature state and display characteristics at any time. 




## -see-also

## -examples

