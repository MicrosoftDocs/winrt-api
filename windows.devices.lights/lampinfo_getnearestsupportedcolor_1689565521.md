---
-api-id: M:Windows.Devices.Lights.LampInfo.GetNearestSupportedColor(Windows.UI.Color)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public Color LampInfo.GetNearestSupportedColor(Color desiredColor)
-->

# Windows.Devices.Lights.LampInfo.GetNearestSupportedColor

## -description
Finds the nearest/closest matching color to the desired color, supported by this lamp.  Call this to know whether a specific color will be applied during (e.g.) [LampArray.SetColor](lamparray_setcolor_1486217082.md)

## -parameters
### -param desiredColor
The color to find the nearest/closest.

## -returns
The nearest/closest color supported by this lamp.

## -remarks
Not every lamp on a LampArray is guaranteed to support true 24-bit RGB color (is dependent on device capabilities). Based on the available color levels the nearest color is determined, assuming that each channel is linearly scaled over the available levels.

## -see-also

## -examples

