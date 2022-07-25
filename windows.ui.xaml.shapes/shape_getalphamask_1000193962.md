---
-api-id: M:Windows.UI.Xaml.Shapes.Shape.GetAlphaMask
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionBrush GetAlphaMask()
-->

# Windows.UI.Xaml.Shapes.Shape.GetAlphaMask

## -description
Returns a mask that represents the alpha channel of a XAML shape as a [CompositionBrush](../windows.ui.composition/compositionbrush.md).



## -returns
A mask that represents the alpha channel of a XAML shape.

## -remarks
This method gets an alpha mask from a XAML shape as a [CompositionBrush](../windows.ui.composition/compositionbrush.md) that you can use as an input to composition shadows and effects. The alpha mask [CompositionBrush](../windows.ui.composition/compositionbrush.md) has the same alignment and stretch property values that the source XAML shape applies to its rendered content so that you can use those values to correctly position shadows or effects relative to the XAML element.

## -examples

## -see-also
