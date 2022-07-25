---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.NaturalRestingScale
-api-type: winrt property
---

<!-- Property syntax
public float NaturalRestingScale { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.NaturalRestingScale

## -description
Natural resting scale for the [InteractionTracker](interactiontracker.md).

The NaturalRestingScale property is the calculated scale position that [InteractionTracker](interactiontracker.md) will come to a stop at without accounting for boundaries or inertia modifiers. This property is often useful for actions like virtualization in a scrolling experience, where it is important to know the location of where [InteractionTracker](interactiontracker.md) will stop. There are two main use cases for using the NaturalRestingScale property: Retrieving its current value in the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event args or referencing this property in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) when creating things like inertia modifiers.



## -property-value
Natural resting scale for the [InteractionTracker](interactiontracker.md).

## -remarks
The two use cases described in the code snippet are the primary uses of the NaturalRestingScale property. Although you may be tempted to reference this property off [InteractionTracker](interactiontracker.md) like any other object.property relationship, you will not always get the most up-to-date value. It is recommended in this situation that you listen for the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event and grab the latest value from the arguments.

## -examples
```csharp

// Listen for the InertiaStateEntered event
public void InertiaStateEntered(InteractionTracker sender, 	InteractionTrackerInertiaStateEnteredArgs args)
{
  // Grab the NaturalRestingScale out of the args when the event is fired.
  float scaleRest = args.NaturalRestingScale;
}
void CreateBasicScaleSnapPoint(float maxScale, float minScale)
{
  var snappoint = InteractionTrackerInertiaRestingValue.Create(_compositor);

  // Reference the NaturalRestingScale of InteractionTracker in an ExpressionAnimation for conditional portion of an InertiaModifier.
  snappoint.Condition = _compositor.CreateExpressionAnimation("this.target.NaturalRestingScale >= min && this.target.NaturalRestingScale < max ");
       
  snappoint.Condition.SetScalarParameter("min", minScale);
  snappoint.Condition.SetScalarParameter("max", maxScale);

  // Snap to the highbound if condition met
  snappoint.RestingValue = _compositor.CreateExpressionAnimation("max");
  snappoint.RestingValue.SetScalarParameter("max", maxScale);

  scaleInertiaModifier.Add(snappoint);

  _tracker.ConfigureScaleInertiaModifiers(scaleInertiaModifier);
}
         
         
```



## -see-also
