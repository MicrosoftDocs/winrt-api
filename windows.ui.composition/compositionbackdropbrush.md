---
-api-id: T:Windows.UI.Composition.CompositionBackdropBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionBackdropBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionBackdropBrush
-->

# Windows.UI.Composition.CompositionBackdropBrush

## -description
A brush that applies an effect (or a chain of effects) to the region behind a [SpriteVisual](spritevisual.md).



## -remarks
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

blurEffect.Source = new CompositionEffectSourceParameter("source"); 

CompositionEffectFactory blurEffectFactory = _compositor.CreateEffectFactory(blurEffect); 
CompositionEffectBrush blurBrush = blurEffectFactory.CreateBrush(); 

// Create a BackdropBrush and bind it to the EffectSourceParameter “source” 
CompositionBackdropBrush backdropBrush = _compositor.CreateBackdropBrush(); 
blurBrush.SetSourceParameter("source", backdropBrush); 
         
```



## -see-also
[CompositionBrush](compositionbrush.md), [IClosable](../windows.foundation/iclosable.md)
