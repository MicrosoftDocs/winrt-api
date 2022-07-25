---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.ScaleVelocityInPercentPerSecond
-api-type: winrt property
---

<!-- Property syntax
public float ScaleVelocityInPercentPerSecond { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.ScaleVelocityInPercentPerSecond

## -description
The rate of change for scale.

The ScaleVelocityInPercentPerSecond property represents the current scale velocity of [InteractionTracker](interactiontracker.md) while in Inertia. Grabbing the position velocity of [InteractionTracker](interactiontracker.md) right after an Interaction has occurred or reference the most current velocity of [InteractionTracker](interactiontracker.md) in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md).



## -property-value
The rate of change for scale.

## -remarks
When accessing the ScaleVelocityInPercentPerSecond property off the [InertiaStateEntered](iinteractiontrackerowner_inertiastateentered_615555038.md) event, you will be retrieving a snapshot of the calculated velocity based on the Interaction. This event will only fire once after the interaction has occurred.

## -examples
```csharp

// Listen for the InertiaStateEntered event
public void InertiaStateEntered(InteractionTracker sender, 	InteractionTrackerInertiaStateEnteredArgs args)
{
  // Grab the Scale velocity out of the args when the event is fired. 
  float scaleVelocity = args.ScaleVelocityInPercentPerSecond;
}

void CustomSpringMotion(float springCoefficient, float dampingCoefficient, float 	maxScale)
{
  // Create the InertiaModifier that will be a custom motion emulating a spring
  InteractionTrackerInertiaMotion modifier = InteractionTrackerInertiaMotion.Create(_compositor);
  modifier.Condition = _compositor.CreateExpressionAnimation("this.Target.NaturalRestingPosition.X > maxScale");
  modifier.Condition.SetScalarParameter("maxScale", maxScale);

  // Utilize the current Velocity of InteractionTracker in the Expression defining 	the custom spring motion
  modifier.Motion = _compositor.CreateExpressionAnimation("(-springStiffnessCoefficient * (this.Target.Position.X – maxScale)) + " +
    "(-dampingCoefficient * this.target.ScaleVelocityInPercentPerSecond");
  modifier.Motion.SetScalarParameter("springStiffnessCoefficient", springCoefficient);
  modifier.Motion.SetScalarParameter("dampingCoefficient", dampingCoefficient);
  modifier.Motion.SetScalarParameter("maxScale", maxScale);
}
         
```



## -see-also
