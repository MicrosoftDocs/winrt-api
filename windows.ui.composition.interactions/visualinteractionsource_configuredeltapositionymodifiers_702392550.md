---
-api-id: M:Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionYModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaPositionYModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionYModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the DeltaPositionY value the VisualInteractionSource provides with its “.Value”. If none evaluate to true, the DeltaPositionY is not replaced that frame.



## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

