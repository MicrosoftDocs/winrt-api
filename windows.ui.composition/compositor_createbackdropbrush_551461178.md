---
-api-id: M:Windows.UI.Composition.Compositor.CreateBackdropBrush
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionBackdropBrush CreateBackdropBrush()
-->

# Windows.UI.Composition.Compositor.CreateBackdropBrush

## -description
Creates an instance of [CompositionBackdropBrush](compositionbackdropbrush.md).



## -returns
Returns the created [CompositionBackdropBrush](compositionbackdropbrush.md) object.

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

// Create a BackdropBrush and bind it to the EffectSourceParameter "source" 
CompositionBackdropBrush backdropBrush = _compositor.CreateBackdropBrush(); 

blurBrush.SetSourceParameter("source", backdropBrush); 
          
          
```



## -see-also
