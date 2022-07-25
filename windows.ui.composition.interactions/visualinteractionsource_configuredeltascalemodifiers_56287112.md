---
-api-id: M:Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaScaleModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaScaleModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaScaleModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the DeltaScale value the VisualInteractionSource provides with its “.Value”. If none evaluate to true, the DeltaScale is not replaced that frame.



## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

