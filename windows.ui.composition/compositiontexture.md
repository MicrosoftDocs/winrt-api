---
-api-id: T:Windows.UI.Composition.CompositionTexture
-api-type: winrt class
---

# Windows.UI.Composition.CompositionTexture

<!--
public class CompositionTexture : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionSurface
-->

## -description

Represents a raw Direct3D texture that can be bound to a composition visual as content. The object can be used anywhere that a generic composition surface can be used in those APIs today&mdash;for example, as the content of a sprite visual or a surface brush. The object exposes an available fence, which can be used to synchronize application rendering and composition work. Can also accept various attributes, such as an alpha mode, source rect, and color space, to more precisely define the content being displayed.

The composition textures API supports Direct3D 11 only.

## -remarks

## -see-also

## -examples
