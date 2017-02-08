---
-api-id: M:Windows.UI.Input.GestureRecognizer.CompleteGesture
-api-type: winrt method
---

<!-- Method syntax
public void CompleteGesture()
-->

# Windows.UI.Input.GestureRecognizer.CompleteGesture

## -description
Causes the gesture recognizer to finalize an interaction.

## -remarks
This method sets [IsActive](gesturerecognizer_isactive.md) and [IsInertial](gesturerecognizer_isinertial.md) to false, based on the current state of the interaction. Depending on the interaction one of the following events is raised:
+ A [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) event.
+ A [CrossSliding](gesturerecognizer_crosssliding.md) event with a [CrossSlidingState](crossslidingeventargs_crossslidingstate.md) of [Completed](crossslidingstate.md).
+ A [Holding](gesturerecognizer_holding.md) event with a [HoldingState](holdingeventargs_holdingstate.md) of [Completed](holdingstate.md).
+ A [Dragging](gesturerecognizer_dragging.md) event with a [DraggingState](draggingeventargs_draggingstate.md) of [Completed](draggingstate.md).


## -examples

## -see-also
