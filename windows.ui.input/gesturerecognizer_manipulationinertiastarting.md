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

<!--{annotation author="kbridge" time="7/5/2011 10:25:35 AM"}TODO: sample, how-to, snippet would be useful.-->

## -examples

## -see-also
[ManipulationInertiaStartingEventArgs](manipulationinertiastartingeventargs.md)