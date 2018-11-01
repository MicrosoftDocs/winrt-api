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
[Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)