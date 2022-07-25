---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.ConfigureCenterPointYInertiaModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void InteractionTracker.ConfigureCenterPointYInertiaModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ConfigureCenterPointYInertiaModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, while the tracker is in Inertia, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the zoom CenterPointY value the tracker uses with its “.Value”. If none evaluate to true, the CenterPointY is not replaced that frame.



## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

