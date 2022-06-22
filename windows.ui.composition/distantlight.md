---
-api-id: T:Windows.UI.Composition.DistantLight
-api-type: winrt class
---

<!-- Class syntax.
public class DistantLight : Windows.UI.Composition.CompositionLight, Windows.UI.Composition.IDistantLight
-->

# Windows.UI.Composition.DistantLight

## -description
An infinitely large distant light source that emits light in a single direction. For example, a distant light could be used to represent sunlight.



## -remarks

**DistantLight**s and [SpotLight](spotlight.md)s support direction.

DistantLight is one of the four light types derived from [CompositionLight](compositionlight.md).

| Light | Description |
|---|---|
| [AmbientLight](ambientlight.md) | A light source that emits non directional light that appears to have been reflected by everything in the scene. |
| DistantLight | An infinitely large distant light source that emits light in a single direction. |
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
_distantLight = _compositor.CreateDistantLight(); 
_distantLight.Color = Colors.Yellow; 
_distantLight.Direction = new Vector3(0,-1, 0); 
_distantLight.CoordinateSpace = root; 
_distantLight.Targets.Add(root);          
```

## -see-also
[CompositionLight](compositionlight.md), [CompositionLight.Targets](compositionlight_targets.md), [Compositor.CreateDistantLight](compositor_createdistantlight_2124441775.md)
