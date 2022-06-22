---
-api-id: T:Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion
-api-type: winrt class
---

<!-- Class syntax.
public class InteractionTrackerInertiaMotion : Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier, Windows.UI.Composition.Interactions.IInteractionTrackerInertiaMotion
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion

## -description
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that defines motion of InteractionTracker during its inertia state.

The InteractionTrackerMotion class contains two [ExpressionAnimation](../windows.ui.composition/expressionanimation.md)s representing a second derivative equation of position [InteractionTracker](interactiontracker.md) will use to define the motion from the start to end of inertia when a particular condition is met. The InteractionTrackerMotion class is defined as two parts: The conditional statement to define when the motion will take place and the equation that describes the motion for how [InteractionTracker](interactiontracker.md) will reach its final resting position. Utilize the InteractionTrackerInertiaMotion class when you need to define a customized motion (such as a spring motion) for [InteractionTracker](interactiontracker.md) to use when in its inertia state.



## -remarks
When building out the [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) for the motion component of InteractionTrackerInertiaMotion, the expression is described as a second derivative equation. For example, In the code snippet above, we utilize the basic equation for Spring Force motion with damping.

When attaching the InteractionTrackerInertiaMotion modifier to the [InteractionTracker](interactiontracker.md), you configure it to either the X/Y Position or Scale.

The [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) defining the condition property only gets evaluated once when [InteractionTracker](interactiontracker.md) enters Inertia (aka when the interaction completes such as finger released). If the condition evaluates to true, the InertiaMotion Expression gets evaluated every frame for the remainder of Inertia, even if the condition expression technically is no longer true.

InteractionTrackerInertiaMotion modifiers change the equation InteractionTracker uses to calculate its position. Thus, the final resting position is determined by the nature of the equation itself. If you need InteractionTracker to stop at a specific location, utilize the [InteractionTrackerInertiaRestingValue](interactiontrackerinertiarestingvalue.md) modifier.

## -examples


```csharp

void CustomSpringInertiaMotion(float dampingCoefficient, 	float springStiffnessCoefficient)
{
  //
  // Set up our inertia modifiers to use our custom motion
  //
  InteractionTrackerInertiaMotion[] modifiers = 
  new InteractionTrackerInertiaMotion[1];
 
  var modifier1 = InteractionTrackerInertiaMotion.Create(_compositor);
 
  /*
  We create a custom spring motion for when the InteractionTracker passes the
  maximum boundary. 
  When we hit the boundary, the amount of oscillation is determined by the 	distance to the far end point, the spring stiffness and damping rate.
  */ 
 
  // Define the condition that the spring motion gets applied – when we pass the
  // maximum boundary
  modifier1.Condition = _compositor.CreateExpressionAnimation(
  "this.Target.NaturalRestingPosition.X > this.Target.MaxPosition.X");
 
  // Define the second derivative equation as a custom spring force motion
  // Equation = kx–cv where (k is spring constant, c is damping, x is displacement)
  modifier1.Motion = _compositor.CreateExpressionAnimation(
    "(-springStiffnessCoefficient * (this.Target.Position.X – this.Target.MaxPosition.X)) + " +
    "(-dampingCoefficient * target.PositionVelocityInPixelsPerSecond.X");
 
  modifier1.Motion.SetScalarParameter("springStiffnessCoefficient", springStiffnessCoefficient);
  modifier1.Motion.SetScalarParameter("dampingCoefficient", dampingCoefficient);
 
  modifiers[0] = modifier1;
 
  // Attach InertiaModifiers to the Y position component of InteractionTracker
  _tracker.ConfigurePositionYInertiaModifiers(modifiers);
}
         
         
```



## -see-also
[InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md), [IClosable](../windows.foundation/iclosable.md)
