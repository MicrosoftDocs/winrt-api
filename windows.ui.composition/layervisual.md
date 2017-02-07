---
-api-id: T:Windows.UI.Composition.LayerVisual
-api-type: winrt class
---

<!-- Class syntax.
public class LayerVisual : Windows.UI.Composition.ContainerVisual, Windows.UI.Composition.ILayerVisual
-->

# Windows.UI.Composition.LayerVisual

## -description
A ContainerVisual whose children are flattened into a single layer.

## -remarks
A LayerVisual is a special input type that can be used to select a tree of visuals. The tree input is implicitly specified using the LayerVisual. When an EffectBrush is set to the Effect property of the LayerVisual, the EffectBrush automatically uses the subtree rooted at the LayerVisual as the input. The implicit input for LayerVisual works for effects as follows:


+ If the effect has one input, the EffectBrush uses the subtree rooted at the LayerVisual as the input.
+ If the effect has 2 inputs, the first unbounded input of the EffectBrush uses the subtree rooted at the LayerVisual as the input.
+ The system does not allow an effect with 0 inputs or effects with all inputs bounded to SurfaceBrush to be set as the EffectBrush on LayerVisual’s Effect property. This will throw an exception.


## -examples

## -see-also
[ContainerVisual](containervisual.md), [IClosable](../windows.foundation/iclosable.md)