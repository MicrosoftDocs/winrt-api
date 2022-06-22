---
-api-id: T:Windows.UI.Composition.Effects.SceneLightingEffect
-api-type: winrt class
---

<!-- Class syntax.
public class SceneLightingEffect : Windows.Graphics.Effects.IGraphicsEffect, Windows.Graphics.Effects.IGraphicsEffectSource, Windows.UI.Composition.Effects.ISceneLightingEffect
-->

# Windows.UI.Composition.Effects.SceneLightingEffect

## -description
Controls the reflective properties of a SpriteVisual. A SceneLightingEffect will overwrite [CompositionLight](../windows.ui.composition/compositionlight.md) defaults. It is used to control the reflective properties of a SpriteVisual. A NormalMap can be used as an input source but is not required.



## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | ReflectanceModel |

## -examples


```csharp

IGraphicsEffect graphicsEffect = new CompositeEffect() 
{ 
  Mode = CanvasComposite.Add, 
  Sources = 
  { 
    new CompositionEffectSourceParameter("ImageSource"), 
    new SceneLightingEffect() 
    { 
      Name = "Material",                                     
      AmbientAmount = 0, 
      DiffuseAmount = .75f, 
      SpecularAmount = 0, 
      SpecularShine = 20, 
      NormalMapSource = new CompositionEffectSourceParameter("NormalMap"), 
    } 
  } 
}; 
       
```



## -see-also
[CompositionLight](../windows.ui.composition/compositionlight.md), [CompositionLight.Targets](../windows.ui.composition/compositionlight_targets.md), [Compositor.CreateAmbientLight](../windows.ui.composition/compositor_createambientlight_920812985.md), [Compositor.CreateDistantLight](../windows.ui.composition/compositor_createdistantlight_2124441775.md), [Compositor.CreatePointLight](../windows.ui.composition/compositor_createpointlight_53515673.md)
