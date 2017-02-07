---
-api-id: T:Windows.UI.Composition.CompositionEffectSourceParameter
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionEffectSourceParameter : Windows.Graphics.Effects.IGraphicsEffectSource, Windows.UI.Composition.ICompositionEffectSourceParameter
-->

# Windows.UI.Composition.CompositionEffectSourceParameter

## -description
Used to declare an arbitrary name (a String) to be associated with a CompositionBrush (the “effect source”). The association of the given name and the effect source occurs when the [SetSourceParameter](compositioneffectbrush_setsourceparameter.md) method of a [CompositionEffectBrush](compositioneffectbrush.md) is called.

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
         
```



## -see-also
[Composition Brushes Overview](http://msdn.microsoft.com/library/03dd256f-78c0-e1b1-3d9f-7b3afab29b2f), [Composition Effects Overview](http://go.microsoft.com/fwlink/p/?LinkID=692063)