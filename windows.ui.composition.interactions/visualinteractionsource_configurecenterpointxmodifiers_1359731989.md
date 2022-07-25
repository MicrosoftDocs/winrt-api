---
-api-id: M:Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointXModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureCenterPointXModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointXModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the zoom CenterPointX value the VisualInteractionSource provides with its “.Value”. If none evaluate to true, the CenterPointX is not replaced that frame.


## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

