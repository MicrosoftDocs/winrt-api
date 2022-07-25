---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.ConfigureCenterPointXInertiaModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void InteractionTracker.ConfigureCenterPointXInertiaModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ConfigureCenterPointXInertiaModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, while the tracker is in Inertia, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the zoom CenterPointX value the tracker uses with its “.Value”. If none evaluate to true, the CenterPointX is not replaced that frame.



## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

