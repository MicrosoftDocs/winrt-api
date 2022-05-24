---
-api-id: M:Windows.UI.Composition.Compositor.CreateEffectFactory(Windows.Graphics.Effects.IGraphicsEffect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionEffectFactory CreateEffectFactory(Windows.Graphics.Effects.IGraphicsEffect graphicsEffect)
-->

# Windows.UI.Composition.Compositor.CreateEffectFactory

## -description
Creates an instance of [CompositionEffectFactory](compositioneffectfactory.md).


## -parameters
### -param graphicsEffect
The type of effect to create.

## -returns
Returns the created [CompositionEffectFactory](compositioneffectfactory.md) object.

## -remarks
Creating an effect factory compiles an effect and allows instances of that effect to be created.

See the remarks section of [CompositionEffectBrush](compositioneffectbrush.md) for information on creating and using effects.

Currently supported effects types are:

| Effect Name | Description |
| - | -|
| [ArithmeticCompositeEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_ArithmeticCompositeEffect.htm) | Combines two images using a weighted sum of pixels from the source images. |
| [CompositeEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_CompositeEffect.htm) | Combines two or more images based on their alpha channel. This effect has 13 different composite modes. The composite effect accepts 2 or more inputs. When you specify 2 images, destination is the first input (index 0) and the source is the second input (index 1). If you specify more than 2 inputs the images are composited starting with the first input and the second and so on. |
| [BlendEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_BlendEffect.htm) (21 of 26 modes) | Combines 2 images. This effect has 26 blend modes with 21 of the modes currently supported by the Compositon API. The 5 blend modes that are currently not implemented are dissolve, hue, saturation, color, and luminosity. |
| [ColorSourceEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_ColorSourceEffect.htm) | The color source effect generates a specified solid color. It is useful as a source to other effects, such as tinting an image using a blend with a color source. |
| [SaturationEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_SaturationEffect.htm) | Alters the saturation of an image. If you set it to 1 the output image is fully saturated. If you set it to 0 the output image is monochrome. |
| [Transform2DEffect](https://microsoft.github.io/Win2D/WinUI2/html/T_Microsoft_Graphics_Canvas_Effects_Transform2DEffect.htm) | The 2D affine transform effect applies a spatial transform to an image based on a 3X2 matrix. This effect can be used to rotate, scale, skew, or translate an image. Or, you can combine these operations. Affine transfers preserve parallel lines and the ratio of distances between any three points in an image. |

See the [Win2D](https://microsoft.github.io/Win2D/WinUI2/html/Introduction.htm) namespace, [Microsoft.Graphics.Canvas.Effects](https://microsoft.github.io/Win2D/WinUI2/html/N_Microsoft_Graphics_Canvas_Effects.htm), for more information on the effect types.

## -examples

## -see-also
[CreateEffectFactory(IGraphicsEffect, IIterable(String))](compositor_createeffectfactory_931436618.md)
