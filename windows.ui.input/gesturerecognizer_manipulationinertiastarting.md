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
[ManipulationInertiaStartingEventArgs](manipulationinertiastartingeventargs.md), [Touch interactions - Manipulation events](/windows/uwp/design/input/touch-interactions#manipulation-events), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
