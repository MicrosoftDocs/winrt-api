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
[Edge gesture invocation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/Edge%20gesture%20invocation%20sample%20(Windows%208))
