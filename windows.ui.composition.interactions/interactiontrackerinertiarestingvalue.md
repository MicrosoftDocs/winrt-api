---
-api-id: T:Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue
-api-type: winrt class
---

<!-- Class syntax.
public class InteractionTrackerInertiaRestingValue : Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier, Windows.UI.Composition.Interactions.IInteractionTrackerInertiaRestingValue
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue

## -description
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that defines the rest position after an interaction.

The InteractionTrackerInertiaRestingValue class defines two [ExpressionAnimation](../windows.ui.composition/expressionanimation.md)s that calculate an explicit resting position for [InteractionTracker](interactiontracker.md) when a particular condition is met. The InteractionTrackerInertiaRestingValue is defined as two parts: The conditional statement in which the [InteractionTracker](interactiontracker.md) ’s specific resting location needs to be explicitly defined if true and the equation that describes a mathematical relationship that outputs the location. Utilize the InteractionTrackerInertiaRestingValue class when needing to ensure InteractionTracker lands on a specific location after an interaction occurs.



## -remarks
When attaching the InteractionTrackerInertiaRestingValue modifier to the [InteractionTracker](interactiontracker.md), you configure it to either the X/Y Position or Scale.

The [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) defining the condition property only gets run once, when the interaction completes (finger released), while the RestingValue Expression gets run every frame.

InteractionTrackerInertiaRestingValue modifiers explicitly defines the resting position of [InteractionTracker](interactiontracker.md) when the condition is met. It does not however define the motion to this explicit location – the system will handle that. Thus, if you need [InteractionTracker](interactiontracker.md) to take a particular motion, but do not require it to land at an exact spot, utilize the [InteractionTrackerInertiaMotion](interactiontrackerinertiamotion.md) modifier.

## -examples


```

void MandatorySingleSnapPoints(ContainerVisual containerVisual, Visual contentVisual)
{
  //
  // Set up our inertia modifiers to behave as dmanip's "single mandatory" snap-points, at a
  // regular interval of 50px.
  //
 
  const float snapPointRange = 50.0f;
 
  //
  // Configure a "snap-point" to handle upward direction (to previous item).
  //
    
  var modifier1 = InteractionTrackerInertiaRestingValue.Create(_compositor);
     
  // Add a condition for when this upward “snap-point” applies.
  modifier1.Condition = _compositor.CreateExpressionAnimation(
    "this.Target.NaturalRestingPosition.y < " + 
    "(this.StartingValue - mod(this.StartingValue, snapPointRange) + snapPointRange / 2)");
 
  modifier1.Condition.SetScalarParameter("snapPointRange", snapPointRange);
 
  // Configure the resting spot when the condition is met 
  modifier1.EndPoint = _compositor.CreateExpressionAnimation(
    "this.StartingValue - mod(this.StartingValue, snapPointRange)");
 
  modifier1.EndPoint.SetScalarParameter("snapPointRange", snapPointRange);
 
  //
  // Configure a "snap-point" to handle downward direction (to next item).
  //
 
  var modifier2 = InteractionTrackerInertiaRestingValue.Create(_compositor);
 
  // Add a condition for when this downward “snap-point” applies.
  modifier2.Condition = _compositor.CreateExpressionAnimation(
    "this.Target.NaturalRestingPosition.y >= " + 
    "(this.StartingValue - mod(this.StartingValue, snapPointRange) + snapPointRange / 2)");
 
  modifier2.Condition.SetScalarParameter("snapPointRange", snapPointRange);
 
  // Configure the resting spot when the condition is met.
  modifier2.EndPoint = _compositor.CreateExpressionAnimation(
    "this.StartingValue + snapPointRange - mod(this.StartingValue, snapPointRange)");
 
  modifier2.EndPoint.SetScalarParameter("snapPointRange", snapPointRange);
 
  var modifiers = new InteractionTrackerInertiaRestingValue[] { modifier1, modifier2 };

  //
  // Add our "snap-point" inertia modifiers to the Y position of the InteractionTracker.
  //
 
  _tracker.ConfigurePositionYInertiaModifiers(modifiers);
}
    
      
```



## -see-also
[InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md), [IClosable](../windows.foundation/iclosable.md)
