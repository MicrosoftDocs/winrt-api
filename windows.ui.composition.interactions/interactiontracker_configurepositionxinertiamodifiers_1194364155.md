---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.ConfigurePositionXInertiaModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier})
-api-type: winrt method
---

<!-- Method syntax
public void ConfigurePositionXInertiaModifiers(Windows.Foundation.Collections.IIterable<Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier> modifiers)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ConfigurePositionXInertiaModifiers

## -description
Applies a collection of InteractionTrackerInertiaModifier objects to the x inertia of an InteractionTracker.

The ConfigurePositionXInertiaModifiers method applies an individual or a collection of [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)s to the x component of [InteractionTracker](interactiontracker.md). The system will evaluate each of X modifier's condition property in the order they were added to [InteractionTracker](interactiontracker.md). Thus, the order that the [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md) have in the collection will be the same order that the system will evaluate with.



## -parameters
### -param modifiers
The collection of InteractionTrackerInertiaModifier objects to apply to the x inertia of an InteractionTracker.

## -remarks
If you have a dependency on the system evaluating the inertia modifiers in a particular order, ensure that they are inserted into the list (if multiple) or into [InteractionTracker](interactiontracker.md) directly (if single) in the order you want them evaluated. The system will evaluate the conditions of the inertia modifiers in the order they are inserted.

## -examples
```csharp

void SimpleXModifer(CompositionPropertySet shared)
{
  // Create the Inertia Modifier for X Direction.
  var xModifier = InteractionTrackerInertiaRestingValue.Create(_compositor);
       
  // For sample purpose, always true condition
  xModifier.Condition = _compositor.CreateExpressionAnimation("5 > 3");
  xModifier.RestingValue = _compositor.CreateExpressionAnimation("this.Target.Position.X - shared.snapRangeX");
  xModifier.RestingValue.SetReferenceParameter("shared", _sharedDelta);
  var xModifierList = new InteractionTrackerInertiaRestingValue[] { xModifier };
 
  // Add modifier list to InteractionTracker.
  _tracker.ConfigurePositionXInertiaModifiers(xModifierList); 
}
         
```



## -see-also
