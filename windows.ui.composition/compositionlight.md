---
-api-id: T:Windows.UI.Composition.CompositionLight
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionLight : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionLight
-->

# Windows.UI.Composition.CompositionLight

## -description
Base class for a light source that can target a UI scene.

The [CompositionLight.Targets](compositionlight_targets.md) property determines which Visuals are lit.

## -remarks
CompositionLight is the base class for four light types.

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

## -see-also
[CompositionObject](compositionobject.md), [CompositionLight.Targets](compositionlight_targets.md), [Compositor.CreateAmbientLight](compositor_createambientlight_920812985.md), [Compositor.CreatePointLight](compositor_createpointlight_53515673.md), [Compositor.CreateSpotLight](compositor_createspotlight_583315408.md), [Compositor.CreateDistantLight](compositor_createdistantlight_2124441775.md)