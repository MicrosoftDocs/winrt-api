---
-api-id: T:Windows.UI.Composition.AmbientLight
-api-type: winrt class
---

<!-- Class syntax.
public class AmbientLight : Windows.UI.Composition.CompositionLight, Windows.UI.Composition.IAmbientLight
-->

# Windows.UI.Composition.AmbientLight

## -description
A light that illuminates every targeted Visual equally .



## -remarks
AmbientLight is one of the four light types derived from [CompositionLight](compositionlight.md).

| Light | Description |
|---|---|
| AmbientLight | A light source that emits non directional light that appears to have been reflected by everything in the scene. |
| [DistantLight](distantlight.md) | An infinitely large distant light source that emits light in a single direction. |
| [PointLight](pointlight.md) | A point source of light that emits light in all directions. |
| [SpotLight](spotlight.md) | A light source that emits inner and outer cones of light. |

> [!NOTE]
> A Visual cannot be targeted by more than two non-ambient lights (PointLight, SpotLight or DistantLight).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Intensity |

## -examples


```csharp
_ambientLight = _compositor.CreateAmbientLight(); 
_ambientLight.Color = Colors.Yellow; 
_ambientLight.Targets.Add(root);         
```

## -see-also
[CompositionLight](compositionlight.md), [CompositionLight.Targets](compositionlight_targets.md), [CreateAmbientLight](compositor_createambientlight_920812985.md)
