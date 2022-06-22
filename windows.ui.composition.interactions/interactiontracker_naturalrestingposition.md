---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.NaturalRestingPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 NaturalRestingPosition { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.NaturalRestingPosition

## -description
Natural resting position for the [InteractionTracker](interactiontracker.md).

The NaturalRestingPosition property is the calculated position that [InteractionTracker](interactiontracker.md) will come to a stop at without accounting for boundaries or inertia modifiers. This property is often useful for actions like virtualization in a scrolling experience, where it is important to know the location of where [InteractionTracker](interactiontracker.md) will stop. There are two main use cases for using the NaturalRestingPosition property: Retrieving its current value in the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event args or referencing this property in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) when creating things like inertia modifiers.



## -property-value
Natural resting position for the [InteractionTracker](interactiontracker.md).

## -remarks
The two use cases described in the code snippet above are the primary uses of the NaturalRestingPosition property. Although you may be tempted to reference this property off [InteractionTracker](interactiontracker.md) like any other object.property relationship, you will not always get the most up-to-date value. It is recommended in this situation that you listen for the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event and grab the latest value from the arguments.

## -examples
```csharp

// Listen for the InertiaStateEntered event, so can grab NaturalRestingPosition value.
public void InertiaStateEntered(InteractionTracker sender, InteractionTrackerInertiaStateEnteredArgs args)
{
  // Grab the NaturalRestingPosition out of the args when the event is fired. Now have access to calculated Natural Rest spot
  Vector3 naturalRest = args.NaturalRestingPosition;
}

// Reference the NaturalRestingPosition property in an expression for things like 	SnapPoints
void CreateBasicSnapPoint(float highBound, float lowBound)
{
  var snappoint = InteractionTrackerInertiaRestingValue.Create(_compositor);

  // Reference the NaturalRestingPosition of InteractionTracker in an ExpressionAnimation for conditional portion of an InertiaModifier.
  snappoint.Condition = _compositor.CreateExpressionAnimation("this.target.NaturalRestingPosition.Y >= 	lowBound && this.target.NaturalRestingPosition.Y < highBound ");
            
  snappoint.Condition.SetScalarParameter("lowBound", lowBound);
  snappoint.Condition.SetScalarParameter("highBound", highBound);

  // Snap to the highbound if condition met
  snappoint.RestingValue = _compositor.CreateExpressionAnimation("highBound");
  snappoint.RestingValue.SetScalarParameter("highBound", highBound);

  yInertiaModifier.Add(snappoint);

  _tracker.ConfigurePositionYInertiaModifiers(yInertiaModifier);
}
          
          
```



## -see-also
