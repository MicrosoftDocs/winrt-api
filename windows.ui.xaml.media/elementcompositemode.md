---
-api-id: T:Windows.UI.Xaml.Media.ElementCompositeMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.ElementCompositeMode : int
-->

# ElementCompositeMode

## -description
Declares alternate composition and blending modes for elements in mixed XAML / Microsoft DirectX UI.

## -enum-fields
### -field Inherit:0
Uses values from successive parents in the visual tree. This is the default.

### -field SourceOver:1
Uses standard XAML source-over-destination mode. This corresponds to [D2D1_PRIMITIVE_BLEND_SOURCE_OVER](/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_primitive_blend).

### -field MinBlend:2
Uses the minimum of the source and destination value for each pixel. This corresponds to [D2D1_PRIMITIVE_BLEND_MIN](/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_primitive_blend).

### -field (not named):3
Uses destination invert behavior. This corresponds to [D2D1_COMPOSITE_MODE_MASK_INVERT](/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_composite_mode).


## -remarks
The destination-invert blend mode is not included in the Windows Runtime metadata definition of the enumeration, which is why *(not named)* appears as the name. You can set a value that enables the mode by casting the value `3` as the enumeration, for example: `var compositeMode = (ElementCompositeMode)3;`

## -examples

## -see-also
[UIElement.CompositeMode property](../windows.ui.xaml/uielement_compositemode.md), [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md)