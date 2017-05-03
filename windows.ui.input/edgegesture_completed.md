---
-api-id: E:Windows.UI.Input.EdgeGesture.Completed
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Completed<Windows.UI.Input.EdgeGesture,  Windows.UI.Input.EdgeGestureEventArgs>
-->

# Windows.UI.Input.EdgeGesture.Completed

## -description
Fires to indicate that the user has successfully summoned or dismissed the edge-based UI. This occurs either when the user lifts his or her finger from a touch-enabled screen or when the user presses Win+Z on the keyboard.
<!-- @WRITER erictill 12/15/2011 : So it doesn't trigger with a mouse?  -->

## -remarks
This event occurs as a result of either touch or keyboard input. In the case of keyboard input (Win+Z), this is the only event that fires. In the case of touch input, it occurs when the user lifts his or her finger at the end of the swipe and is preceded by the [Starting](edgegesture_starting.md) event.

<!-- @WRITER erictill 7/24/2011 : there's a lot of talk in the original of "could" do this. Maybe there's a third option - it can do nothing. -->
When the handler for this event is called, an app can do one of two things: show its edge-based UI if that UI isn't currently shown, or hide the UI if it is shown.
<!-- @WRITER erictill 12/15/2011 : This same comment is in the Starting event. With keyboard input, this would be true here. With touch, I would think you do that in response to Starting, and then I don't know what in response to Completed. -->

## -examples

## -see-also
[Edge gesture invocation sample](http://go.microsoft.com/fwlink/p/?linkid=242153)