---
-api-id: P:Windows.Graphics.Holographic.HolographicViewConfiguration.NativeRenderTargetSize
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public Size NativeRenderTargetSize { get; }
-->

# Windows.Graphics.Holographic.HolographicViewConfiguration.NativeRenderTargetSize

## -description
Gets the native render target size for this HolographicViewConfiguration.

## -property-value
A [Size](../windows.foundation/size.md) representing the native render target size for the HolographicViewConfiguration.

## -remarks

For [HolographicViewConfiguration](holographicviewconfiguration.md) objects which are of kind [Display](holographicviewconfigurationkind.md), this represents the width and height of the display mode.

For [HolographicViewConfiguration](holographicviewconfiguration.md) objects which are of kind [PhotoVideoCamera](holographicviewconfigurationkind.md), this represents the native capture resolution for the rendered portion of the image.

## -see-also
[Size](../windows.foundation/size.md), [HolographicViewConfiguration](holographicviewconfiguration.md, [HolographicViewConfigurationKind](holographicviewconfigurationkind.md)

## -examples
