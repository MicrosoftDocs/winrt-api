---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.ConfigurePositionYInertiaModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier})
-api-type: winrt method
---

<!-- Method syntax
public void ConfigurePositionYInertiaModifiers(Windows.Foundation.Collections.IIterable<Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier> modifiers)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ConfigurePositionYInertiaModifiers

## -description
Applies a collection of InteractionTrackerInertiaModifier objects to the y inertia of an InteractionTracker.

The ConfigurePositionYInertiaModifiers method applies an individual or a collection of [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)s to the y component of [InteractionTracker](interactiontracker.md). The system will evaluate each of Y modifier’s condition property in the order they were added to [InteractionTracker](interactiontracker.md). Thus, the order that the [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md) have in the collection will be the same order that the system will evaluate with.



## -parameters
### -param modifiers
The collection of InteractionTrackerInertiaModifier objects to apply to the y inertia of an InteractionTracker.

## -remarks

## -examples
```csharp

void SimpleYModifer(CompositionPropertySet shared)
{
  // Create the Inertia Modifier for Y Direction.
  var yModifier = InteractionTrackerInertiaRestingValue.Create(_compositor);
       
  // For sample purpose, always true condition
  yModifier.Condition = _compositor.CreateExpressionAnimation("5 > 3");
  yModifier.RestingValue = _compositor.CreateExpressionAnimation("this.Target.Position.Y - shared.snapRangeY");
  yModifier.RestingValue.SetReferenceParameter("shared", shared);
  var yModifierList = new InteractionTrackerInertiaRestingValue[] { yModifier };
 
  // Add modifier list to InteractionTracker.
  _tracker.ConfigurePositionYInertiaModifiers(yModifierList); 
}
         
         
```



## -see-also
