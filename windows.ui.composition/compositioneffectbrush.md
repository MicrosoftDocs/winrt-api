---
-api-id: T:Windows.UI.Composition.CompositionEffectBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionEffectBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionEffectBrush
-->

# Windows.UI.Composition.CompositionEffectBrush

## -description
A brush contianing an effect created with the [CompositionEffectFactory.CreateBrush](compositioneffectfactory_createbrush.md) method.

## -remarks
The effect APIs enable developers to customize how their UI is rendered. This can be something as simple as adjusting saturation levels on an image or something more complex like chaining numerous effects together and animating the effect properties to create interesting application transitions and user experiences. A composition effect is a graph of operations that define how to produce graphical content based on composition surfaces. For example, the pixel content of images. Effects are applied to visuals in the tree and can reference existing surfaces.

An instance of [CompositionEffectBrush](compositioneffectbrush.md) is created using a [CompositionEffectFactory](compositioneffectfactory.md) based on a specified effect description. [CompositionEffectFactory](compositioneffectfactory.md) uses the [Win2D](http://microsoft.github.io/Win2D/html/Introduction.htm) effect description format in the [Microsoft.Graphics.Canvas.Effects](http://microsoft.github.io/Win2D/html/N_Microsoft_Graphics_Canvas_Effects.htm) namespace. 

> [!NOTE]
> Effects that are not supported are marked as **[NoComposition]** in the [Win2D API Reference](http://microsoft.github.io/Win2D/html/APIReference.htm) for effects namespace.

A [CompositionEffectBrush](compositioneffectbrush.md) is applied to a [SpriteVisual](spritevisual.md) in the composition tree.

Sources to [CompositionEffectBrush](compositioneffectbrush.md) can be an existing surface or texture, or another effect enabling effect chaining.

CompositionEffectBrush.Properties (inherited from CompositionObject.Properties) allows setting or animating the animatable properties that were specified in the call to Compositor.[CreateEffectFactory](compositor_createeffectfactory.md) using their full 'EffectName.PropertyName' name.

Effect sources can be set independently from other CompositionEffectBrush instances, and properties can be animated independently from other CompositionEffectBrush instances.

Once an effect graph is declared, the system compiles the effect using built-in shaders. Custom shaders cannot be specified.

### Creating a CompositionEffect

To create and apply an effect you need to perform the following steps:

+ 1. Create an effect description. See the [Win2D](http://microsoft.github.io/Win2D/html/Introduction.htm) namespace, [Microsoft.Graphics.Canvas.Effects](http://microsoft.github.io/Win2D/html/N_Microsoft_Graphics_Canvas_Effects.htm), for valid effect types.
+ 2. Set any effect sources with either an instance of [CompositionEffectSourceParameter](compositioneffectsourceparameter.md) or another effect. Specifying another effect creates an effect chain.
+ 3. Create a CompositionEffectFactory with Compositor.[CreateEffectFactory](compositor_createeffectfactory.md) using the effect description as input.
+ 4. Create an instance of the effect using CompositorEffectFactory.[CreateBrush](compositioneffectfactory_createbrush.md).
+ 5. Set any CompositionEffectSourceParameter using CompositionEffectBrush.[SetSourceParameter](compositioneffectbrush_setsourceparameter.md) and the name of the source parameter as previously specified using a [CompositionEffectSourceParameter](compositioneffectsourceparameter.md).
+ 6. Create an instance of [SpriteVisual](spritevisual.md) using Compositor.[CreateSpriteVisual](compositor_createspritevisual.md).
+ 7. Set the [Brush](spritevisual_brush.md) property of the [SpriteVisual](spritevisual.md) to the created effect.
+ 8. Add the [SpriteVisual](spritevisual.md) to the composition tree by using the [Children](containervisual_children.md) property of a [ContainerVisual](containervisual.md).


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

// The SpriteVisual to apply the blur BackdropBrush to 
// This will cause everything behind this SpriteVisual to be blurred 
SpriteVisual blurSprite = _compositor.CreateSpriteVisual(); 
blurSprite.Brush = blurBrush; 

// Set blurSprite as a child visual of a XAML element 
ElementCompositionPreview.SetElementChildVisual(blurArea, blurSprite); 
          
```



## -see-also
[Composition Brushes Overview](http://msdn.microsoft.com/library/03dd256f-78c0-e1b1-3d9f-7b3afab29b2f), [Composition Effects Overview](http://go.microsoft.com/fwlink/p/?LinkID=692063), [CompositionBrush](compositionbrush.md), [IClosable](../windows.foundation/iclosable.md)