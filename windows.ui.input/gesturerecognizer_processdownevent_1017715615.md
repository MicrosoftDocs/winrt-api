---
-api-id: M:Windows.UI.Input.GestureRecognizer.ProcessDownEvent(Windows.UI.Input.PointerPoint)
-api-type: winrt method
---

<!-- Method syntax
public void ProcessDownEvent(Windows.UI.Input.PointerPoint value)
-->

# Windows.UI.Input.GestureRecognizer.ProcessDownEvent

## -description
Processes pointer input and raises the [GestureRecognizer](gesturerecognizer.md) events appropriate to a pointer down action for the gestures and manipulations specified by the [GestureSettings](gesturerecognizer_gesturesettings.md) property.




<!--Performs gesture detection and manipulation calculations based on pointer input, and raises various gesture/manipulation events.-->

<!--GestureRecognizer – The ProcessMoveEvents description sounds like it will raise pointer events.  You might want to word it “and raises the various GestureRecognizer events based on the pointer moved events”.  Same thing goes for the other Process* methods.-->

<!--GestureRecognizer.ProcessFoo() -  For all of the process methods, we should say something like, “processes the given input and raises gesture events as appropriate.”  The current wording is a little confusing – we don’t really have “pointer detected events” (on GR at least) or “pointer removed events”.-->



<!--This method is used to send PointerPoint input to the GestureRecognizer.  This is used with the ProcessMoves, ProcessUp and ProcessMouseWheel methods to send input to the GestureRecognizer to be recognized and triggered the various gesture events that have been configured via the GestureSettings flags.-->

## -parameters
### -param value
The input point.

## -remarks

## -examples

## -see-also
[Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)