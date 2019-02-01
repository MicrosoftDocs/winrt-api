---
-api-id: E:Windows.UI.Input.EdgeGesture.Canceled
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Canceled<Windows.UI.Input.EdgeGesture,  Windows.UI.Input.EdgeGestureEventArgs>
-->

# Windows.UI.Input.EdgeGesture.Canceled

## -description
Fires when a user cancels a show or hide action for an edge-based UI.

## -remarks
This event occurs only with touch input; the user either moves their finger back to the interaction's starting position and lifts, or continues to drag their finger into the middle of the screen. This event is always preceded by a [Starting](edgegesture_starting.md) event.

Cancelling the action causes the UI that is being summoned or dismissed to animate back to the state that it was in before the [Starting](edgegesture_starting.md) event.

## -examples

## -see-also
[Edge gesture invocation sample](https://go.microsoft.com/fwlink/p/?linkid=242153)
