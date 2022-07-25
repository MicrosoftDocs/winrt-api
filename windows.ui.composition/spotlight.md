---
-api-id: T:Windows.UI.Composition.SpotLight
-api-type: winrt class
---

<!-- Class syntax.
public class SpotLight : Windows.UI.Composition.CompositionLight, Windows.UI.Composition.ISpotLight
-->

# Windows.UI.Composition.SpotLight

## -description
A light source that casts inner and outer cones of light. For example, a flashlight.



## -remarks

SpotLight is one of the four light types derived from [CompositionLight](compositionlight.md).

| Light | Description |
|---|---|
| [AmbientLight](ambientlight.md) | A light source that emits non directional light that appears to have been reflected by everything in the scene. |
| [DistantLight](distantlight.md) | An infinitely large distant light source that emits light in a single direction. |
| [PointLight](pointlight.md) | A point source of light that emits light in all directions. |
| SpotLight | A light source that emits inner and outer cones of light. |

> [!NOTE]
> A Visual cannot be targeted by more than two non-ambient lights (PointLight, SpotLight or DistantLight).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | InnerConeIntensity |
| 1709 | 16299 | OuterConeIntensity |
| 1803 | 17134 | MaxAttenuationCutoff |
| 1803 | 17134 | MinAttenuationCutoff |

## -examples

```csharp
_spotLight = _compositor.CreateSpotLight(); 
_spotLight.CoordinateSpace = root; 
_spotLight.InnerConeAngleInDegrees = 30; 
_spotLight.InnerConeColor = Colors.Red; 
_spotLight.OuterConeAngleInDegrees = 45; 
_spotLight.OuterConeColor = Colors.Yellow; 
_spotLight.Offset = new Vector3(30, 30, 200); 
_spotLight.Targets.Add(root);          
```

## -see-also
[CompositionLight](compositionlight.md), [Targets](compositionlight_targets.md), [CreateSpotLight](compositor_createspotlight_583315408.md)
