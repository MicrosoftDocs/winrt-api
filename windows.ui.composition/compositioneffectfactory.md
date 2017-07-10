---
-api-id: T:Windows.UI.Composition.CompositionEffectFactory
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionEffectFactory : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionEffectFactory
-->

# Windows.UI.Composition.CompositionEffectFactory

## -description
Creates a composition object that contains a [Win2D](http://microsoft.github.io/Win2D/html/Introduction.htm) effect description format in the [Microsoft.Graphics.Canvas.Effects](http://microsoft.github.io/Win2D/html/N_Microsoft_Graphics_Canvas_Effects.htm) namespace.

> [!NOTE]
> Effects that are not supported are marked as [NoComposition] in the [Win2D API Reference](http://microsoft.github.io/Win2D/html/APIReference.htm) for effects namespace.

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
[Composition Brushes Overview](http://msdn.microsoft.com/library/03dd256f-78c0-e1b1-3d9f-7b3afab29b2f), [Composition Effects Overview](http://go.microsoft.com/fwlink/p/?LinkID=692063), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)