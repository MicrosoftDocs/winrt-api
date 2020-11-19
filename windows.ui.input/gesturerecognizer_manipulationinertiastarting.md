---
-api-id: E:Windows.UI.Input.GestureRecognizer.ManipulationInertiaStarting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ManipulationInertiaStarting<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.ManipulationInertiaStartingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.ManipulationInertiaStarting

## -description
Occurs when all contact points are lifted during a manipulation and the velocity of the manipulation is significant enough to initiate inertia behavior (translation, expansion, or rotation continue after the input pointers are lifted).

## -remarks
Inertia is the tendency of an object to resist any change in its state of rest or its velocity.

This event is raised before inertia processing.

Inertia behavior for this manipulation can be customized in the handler for this event. For example, inertia can be set to end after a specific distance or UI is displayed.

> [!NOTE]
> These settings cannot be customized after the event.



## -examples

## -see-also
[ManipulationInertiaStartingEventArgs](manipulationinertiastartingeventargs.md), [Touch interactions - Manipulation events](/windows/uwp/design/input/touch-interactions#manipulation-events), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)