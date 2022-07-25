---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.ConfigureScaleInertiaModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier})
-api-type: winrt method
---

<!-- Method syntax
public void ConfigureScaleInertiaModifiers(Windows.Foundation.Collections.IIterable<Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier> modifiers)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ConfigureScaleInertiaModifiers

## -description
Applies a collection of InteractionTrackerInertiaModifier objects to the scale of an InteractionTracker.

The ConfigureScaleInertiaModifiers method applies an individual or a collection of [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)s to the scale component of [InteractionTracker](interactiontracker.md). The system will evaluate each of Scale modifier’s condition property in the order they were added to [InteractionTracker](interactiontracker.md). Thus, the order that the [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md) have in the collection will be the same order that the system will evaluate with.



## -parameters
### -param modifiers
The collection of InteractionTrackerInertiaModifier objects to apply to the scale of an InteractionTracker.

## -remarks

## -examples
```csharp

void SimpleScaleModifer(CompositionPropertySet shared)
{
  // Create the Inertia Modifier for Scale.
  var scaleModifier = InteractionTrackerInertiaRestingValue.Create(_compositor);

  // For sample purpose, always true condition
  scaleModifier.Condition = _compositor.CreateExpressionAnimation("5 > 3");
  
  scaleModifier.RestingValue = _compositor.CreateExpressionAnimation("this.Target.Scale - shared.scaleRange");
  scaleModifier.RestingValue.SetReferenceParameter("shared", shared);
  var scaleModifierList = new InteractionTrackerInertiaRestingValue[] { scaleModifier };
  
  // Add modifier list to InteractionTracker.
  _tracker.ConfigureScaleInertiaModifiers(scaleModifierList); 
}
         
```



## -see-also
