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


<!--{annotation author="kbridge" time="10/18/2011 5:39:35 PM"}Following are from tech reviews. -->

<!--Performs gesture detection and manipulation calculations based on pointer input, and raises various gesture/manipulation events.-->

<!--GestureRecognizer – The ProcessMoveEvents description sounds like it will raise pointer events.  You might want to word it “and raises the various GestureRecognizer events based on the pointer moved events”.  Same thing goes for the other Process* methods.-->

<!--GestureRecognizer.ProcessFoo() -  For all of the process methods, we should say something like, “processes the given input and raises gesture events as appropriate.”  The current wording is a little confusing – we don’t really have “pointer detected events” (on GR at least) or “pointer removed events”.-->

<!--{annotation author="kbridge" time="10/18/2011 5:39:02 PM"}Following is from spec.-->

<!--This method is used to send PointerPoint input to the GestureRecognizer.  This is used with the ProcessMoves, ProcessUp and ProcessMouseWheel methods to send input to the GestureRecognizer to be recognized and triggered the various gesture events that have been configured via the GestureSettings flags.-->

## -parameters
### -param value
The input point.

## -remarks

## -examples

## -see-also
