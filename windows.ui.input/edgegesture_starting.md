---
-api-id: E:Windows.UI.Input.EdgeGesture.Starting
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Starting<Windows.UI.Input.EdgeGesture,  Windows.UI.Input.EdgeGestureEventArgs>
-->

# Windows.UI.Input.EdgeGesture.Starting

## -description
Fires when a user begins an action to summon or dismiss edge-based UI.
<!-- @WRITER erictill 7/24/2011 : Swipe begins. This must be followed by completed or canceled. Touch only. -->

## -remarks
This event occurs only with a touch interaction. A keyboard invocation of edge-based UI does not include this event. The [Starting](edgegesture_starting.md) event is always followed by either a [Completed](edgegesture_completed.md) or a [Canceled](edgegesture_canceled.md) event.

When the handler for this event is called, an app could be called to do one of two things, barring a cancellation of the operation: show its edge-based UI if that UI isn't currently shown or hide the UI if it is shown.

## -examples

## -see-also
[Edge gesture invocation sample](http://go.microsoft.com/fwlink/p/?linkid=242153)