---
-api-id: T:Windows.UI.Composition.CompositionColorSpace
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.CompositionColorSpace : int
-->

# CompositionColorSpace

## -description
Specifies the color space for interpolating color values in [ColorKeyFrameAnimation](colorkeyframeanimation.md).

Equivalent **WinUI 2 API for UWP**: [CompositionColorSpace](/windows/winui/api/microsoft.ui.composition.compositioncolorspace) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field Auto:0
Use the default color space for interpolation.

### -field Hsl:1

Use the HSL color space for interpolation.

### -field Rgb:2

Use the ARGB color space for interpolation.

### -field HslLinear:3

Use the linear HSL color space for interpolation.

### -field RgbLinear:4

Use the linear ARGB color space for interpolation.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | HslLinear |
| 1709 | 16299 | RgbLinear |

## -examples

## -see-also

