---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.SetBindingMode(Windows.UI.Composition.Interactions.InteractionTracker,Windows.UI.Composition.Interactions.InteractionTracker,Windows.UI.Composition.Interactions.InteractionBindingAxisModes)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void InteractionTracker.SetBindingMode(InteractionTracker boundTracker1, InteractionTracker boundTracker2, InteractionBindingAxisModes axisMode)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.SetBindingMode

## -description

Sets the binding axis mode between two interaction trackers.



## -parameters
### -param boundTracker1

The first interaction tracker in the binding.

### -param boundTracker2

The second interaction tracker in the binding.

### -param axisMode

The axis that is being bound.

## -remarks

Both interaction trackers (_boundTracker1_, _boundTracker2_) must come from the same Compositor.

Pass **None** as the _axisMode_ parameter to remove an existing binding mode.
 
## -see-also

## -examples

