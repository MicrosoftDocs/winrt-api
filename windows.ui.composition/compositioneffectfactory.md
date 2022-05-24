---
-api-id: T:Windows.UI.Composition.CompositionEffectFactory
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionEffectFactory : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionEffectFactory
-->

# Windows.UI.Composition.CompositionEffectFactory

## -description
Creates a composition object that contains a [Win2D](https://microsoft.github.io/Win2D/WinUI2/html/Introduction.htm) effect description format in the [Microsoft.Graphics.Canvas.Effects](https://microsoft.github.io/Win2D/WinUI2/html/N_Microsoft_Graphics_Canvas_Effects.htm) namespace.

> [!NOTE]
> Effects that are not supported are marked as [NoComposition] in the [Win2D API Reference](https://microsoft.github.io/Win2D/WinUI2/html/APIReference.htm) for effects namespace.


## -remarks

A composition effect is a graph of operations that define how to produce graphical content based on composition surfaces; for example, the pixel content of images. Effects are applied to visuals in the tree and can reference existing surfaces.

See the remarks section of [CompositionEffectBrush](compositioneffectbrush.md) for information on creating and using effects.

## -examples


```csharp

// Create an effect description 
GaussianBlurEffect blurEffect = new GaussianBlurEffect() 
{ 
    Name = "Blur", 
    BlurAmount = 1.0f, 
    BorderMode = EffectBorderMode.Hard, 
    Optimization = EffectOptimization.Balanced 
}; 

CompositionEffectFactory blurEffectFactory = _compositor.CreateEffectFactory(blurEffect); 
         
```



## -see-also
[Composition Brushes Overview](/windows/uwp/graphics/composition-brushes), [Composition Effects Overview](/windows/uwp/composition/composition-effects), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
