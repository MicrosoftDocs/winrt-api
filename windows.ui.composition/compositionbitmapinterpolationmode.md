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


### -field MagLinearMinLinearMipNearest:3


### -field MagLinearMinNearestMipLinear:4


### -field MagLinearMinNearestMipNearest:5


### -field MagNearestMinLinearMipLinear:6


### -field MagNearestMinLinearMipNearest:7


### -field MagNearestMinNearestMipLinear:8


### -field MagNearestMinNearestMipNearest:9


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







