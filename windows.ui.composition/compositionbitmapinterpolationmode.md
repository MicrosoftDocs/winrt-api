---
-api-id: T:Windows.UI.Composition.CompositionBitmapInterpolationMode
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.CompositionBitmapInterpolationMode : int
-->

# CompositionBitmapInterpolationMode

## -description
Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on screen.



## -enum-fields

### -field NearestNeighbor:0

Use the exact color of the nearest bitmap pixel to the current rendering pixel.

### -field Linear:1

Interpolate a color from the four bitmap pixels that are the nearest to the current rendering pixel.

### -field MagLinearMinLinearMipLinear:2

Use Linear interpolation for magnification, minification, and mip-level sampling.

### -field MagLinearMinLinearMipNearest:3

Use Linear interpolation for magnification and minification; use NearestNeighbor for mip-level sampling.

### -field MagLinearMinNearestMipLinear:4

Use Linear interpolation for magnification; use NearestNeighbor for minification; use Linear interpolation for mip-level sampling.

### -field MagLinearMinNearestMipNearest:5

Use Linear interpolation for magnification; use NearestNeighbor for minification and mip-level sampling.

### -field MagNearestMinLinearMipLinear:6

Use NearestNeighbor for magnification; use Linear interpolation for minification and mip-level sampling.

### -field MagNearestMinLinearMipNearest:7

Use NearestNeighbor for magnification; use Linear interpolation for minification; use NearestNeighbor for mip-level sampling.

### -field MagNearestMinNearestMipLinear:8

Use NearestNeighbor for magnification and minification; use Linear interpolation for mip-level sampling.

### -field MagNearestMinNearestMipNearest:9

Use NearestNeighbor for magnification, minification, and mip-level sampling.

## -remarks
Interpolating pixels is necessary when the pixels of an [ICompositionSurface](icompositionsurface.md) do not form a one-to-one mapping to the pixels of a [SpriteVisual](spritevisual.md); this can happen under scale, stretch, rotation, skew, or other transformations (such as perspective projection, etc.).

When the bitmap contents of an [ICompositionSurface](icompositionsurface.md) are mapped to a [SpriteVisual](spritevisual.md) whose size is larger than that of the bitmap, each pixel from the surface must be mapped to a group of pixels on screen.

Conversely, when the bitmap contents of an [ICompositionSurface](icompositionsurface.md) are mapped to a [SpriteVisual](spritevisual.md) whose size is smaller than that of the bitmap, multiple pixels from the surface must be mapped to single pixels on screen.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | MagLinearMinLinearMipLinear |
| 1903 | 18362 | MagLinearMinLinearMipNearest |
| 1903 | 18362 | MagLinearMinNearestMipLinear |
| 1903 | 18362 | MagLinearMinNearestMipNearest |
| 1903 | 18362 | MagNearestMinLinearMipLinear |
| 1903 | 18362 | MagNearestMinLinearMipNearest |
| 1903 | 18362 | MagNearestMinNearestMipLinear |
| 1903 | 18362 | MagNearestMinNearestMipNearest |

## -examples

## -see-also







