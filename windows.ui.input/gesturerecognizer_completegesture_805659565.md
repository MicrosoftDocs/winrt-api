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
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)