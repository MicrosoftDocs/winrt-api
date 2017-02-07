---
-api-id: T:Windows.Graphics.DirectX.DirectXAlphaMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.DirectX.DirectXAlphaMode : int
-->

# DirectXAlphaMode

## -description
Identifies the alpha value, transparency behavior, of a surface. This is a managed version of the [DXGI_APLAHA_MODE](http://msdn.microsoft.com/library/dd3d1e49-06d2-4fb9-a41b-86453d8e566f) enumeration.

## -enum-fields
### -field Unspecified:0
Indicates that the transparency behavior is not specified.

### -field Premultiplied:1
Indicates that the transparency behavior is premultiplied. Each color is first scaled by the alpha value. The alpha value itself is the same in both straight and premultiplied alpha. Typically, no color channel value is greater than the alpha channel value. If a color channel value in a premultiplied format is greater than the alpha channel, the standard source-over blending math results in an additive blend.

### -field Straight:2
Indicates that the transparency behavior is not premultiplied. The alpha channel indicates the transparency of the color.

### -field Ignore:3
Indicates to ignore the transparency behavior.


## -remarks

## -examples

## -see-also