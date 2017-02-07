---
-api-id: T:Windows.UI.Composition.AmbientLight
-api-type: winrt class
---

<!-- Class syntax.
public class AmbientLight : Windows.UI.Composition.CompositionLight, Windows.UI.Composition.IAmbientLight
-->

# Windows.UI.Composition.AmbientLight

## -description
A light that illuminates every targeted Visual equally.

## -remarks
[AmbientLight](ambientlight.md) is one of the four light types derived from [CompositionLight](compositionlight.md).

<table>
   <tr><th>Light</th><th>Description</th></tr>
   <tr><td>[AmbientLight](ambientlight.md)</td><td>A light source that emits non directional light that appears to have been reflected by everything in the scene.</td></tr>
   <tr><td>[DistantLight](distantlight.md)</td><td>An infinitely large distant light source that emits light in a single direction.</td></tr>
   <tr><td>[PointLight](pointlight.md)</td><td>A point source of light that emits light in all directions.</td></tr>
   <tr><td>[SpotLight](spotlight.md)</td><td>A light source that emits inner and outer cones of light.</td></tr>
</table>

> [!NOTE]
> A Visual cannot be targeted by more than two non-ambient lights (PointLight, SpotLight or DistantLight).

## -examples


```csharp

            _ambientLight = _compositor.CreateAmbientLight(); 
            _ambientLight.Color = Colors.Yellow; 
            _ambientLight.Targets.Add(root); 
         
```



## -see-also
[CompositionLight](compositionlight.md), [CompositionLight.Targets](compositionlight_targets.md), [CreateAmbientLight](compositor_createambientlight.md)