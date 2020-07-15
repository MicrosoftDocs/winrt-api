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

## -remarks
This event occurs as a result of either touch or keyboard input. In the case of keyboard input (Win+Z), this is the only event that fires. In the case of touch input, it occurs when the user lifts his or her finger at the end of the swipe and is preceded by the [Starting](edgegesture_starting.md) event.

When the handler for this event is called, an app can do one of two things: show its edge-based UI if that UI isn't currently shown, or hide the UI if it is shown.

## -examples

## -see-also
[Edge gesture invocation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/Edge%20gesture%20invocation%20sample%20(Windows%208))
