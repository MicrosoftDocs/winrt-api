---
-api-id: P:Windows.UI.Composition.Visual.Opacity
-api-type: winrt property
---

<!-- Property syntax
public float Opacity { get;  set; }
-->

# Windows.UI.Composition.Visual.Opacity

## -description
The opacity of the visual. Animatable.

The opacity property determines the transparency, if any, of the Visual and is a value from 0 to 1. 0 is fully transparent and 1 is full opaque. A Visual with an Opacity property of 0 is still present in the tree. Like other properties on the Visual, Opacity can be animated using the Windows,UI.Composition animation system.



## -property-value
The opacity of the visual.

## -remarks

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

## -examples

## -see-also
