---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.PositionVelocityInPixelsPerSecond
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 PositionVelocityInPixelsPerSecond { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.PositionVelocityInPixelsPerSecond

## -description
The velocity currently applied to position.

The PositionVelocityInPixelsPerSecond property represents the current position velocity of [InteractionTracker](interactiontracker.md) while in Inertia. There are two main use cases for this property: Retrieving the position velocity of [InteractionTracker](interactiontracker.md) right after an interaction has occurred or reference the most current velocity of [InteractionTracker](interactiontracker.md) in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md).



## -property-value
The velocity currently applied to position.

## -remarks
When accessing the PositionVelocityInPixelsPerSecond property from the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event, you will be retrieving a snapshot of the calculated velocity based on the interaction. This event will only fire once after the interaction has occurred.

## -examples
```csharp

// Listen for the InertiaStateEntered event, so we can grab PositionVelocityInPixelsPerSecond value.
public void InertiaStateEntered(InteractionTracker sender, InteractionTrackerInertiaStateEnteredArgs args)
{
  // Grab the current velocity of InteractionTracker after interaction occurs out of the args when the event is fired.
  Vector3 interactionVelocity = args.PositionVelocityInPixelsPerSecond;}
}

void CustomSpringMotion(float springCoefficient, float dampingCoefficient, float maxPosition)
{
  // Create the InertiaModifier that will be a custom motion emulating a spring
  InteractionTrackerInertiaMotion modifier = InteractionTrackerInertiaMotion.Create(_compositor);
       
  modifier.Condition = _compositor.CreateExpressionAnimation("this.Target.NaturalRestingPosition.X > maxPosition");
  modifier.Condition.SetScalarParameter("maxPosition", maxPosition);

  // Utilize the current Velocity of InteractionTracker in the Expression defining 	the custom spring motion
  modifier.Motion = _compositor.CreateExpressionAnimation("(-springStiffnessCoefficient * (this.Target.Position.X – maxPosition)) + (-dampingCoefficient * this.target.PositionVelocityInPixelsPerSecond.X");
  modifier.Motion.SetScalarParameter("springStiffnessCoefficient", 	springCoefficient);
  modifier.Motion.SetScalarParameter("dampingCoefficient", dampingCoefficient);
  modifier.Motion.SetScalarParameter("maxPosition", maxPosition); 
}
          
          
```



## -see-also
