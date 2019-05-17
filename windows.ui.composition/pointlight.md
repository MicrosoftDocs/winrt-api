---
-api-id: T:Windows.UI.Composition.PointLight
-api-type: winrt class
---

<!-- Class syntax.
public class PointLight : Windows.UI.Composition.CompositionLight, Windows.UI.Composition.IPointLight
-->

# Windows.UI.Composition.PointLight

## -description
A point source of light that emanates light in all directions.

## -remarks
A PointLight gives off light equally in all directions.

PointLight is one of the four light types derived from [CompositionLight](compositionlight.md).

<table>
   <tr><th>Light</th><th>Description</th></tr>
   <tr><td>[AmbientLight](ambientlight.md)</td><td>A light source that emits non directional light that appears to have been reflected by everything in the scene.</td></tr>
   <tr><td>[DistantLight](distantlight.md)</td><td>An infinitely large distant light source that emits light in a single direction.</td></tr>
   <tr><td>PointLight</td><td>A point source of light that emits light in all directions.</td></tr>
   <tr><td>[SpotLight](spotlight.md)</td><td>A light source that emits inner and outer cones of light.</td></tr>
</table>

> [!NOTE]
> A Visual cannot be targeted by more than two non-ambient lights (PointLight, SpotLight or DistantLight).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Intensity |
| 1803 | 17134 | MaxAttenuationCutoff |
| 1803 | 17134 | MinAttenuationCutoff |

## -examples

## -see-also
[CompositionLight](compositionlight.md), [IClosable](../windows.foundation/iclosable.md)
