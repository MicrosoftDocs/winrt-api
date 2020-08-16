---
-api-id: T:Windows.UI.Input.GestureSettings
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.GestureSettings : uint
-->

# GestureSettings

## -description
Specifies the interactions that are supported by an application.

## -enum-fields
### -field None:0
Disable support for gestures and manipulations.

### -field Tap:1
Enable support for the tap gesture.
+ Touch: tap
+ Mouse: left button click
+ Pen/stylus: tap


### -field DoubleTap:2
Enable support for the double-tap gesture.
+ Touch: double tap
+ Mouse: left button double click
+ Pen/stylus: double tap
This gesture can be used to select a word or open a file or folder.

### -field Hold:4
Enable support for the press and hold gesture (from a single touch or pen/stylus contact). The [Holding](gesturerecognizer_holding.md) event is raised if a time threshold is crossed before the contact is lifted, an additional contact is detected, or a gesture is started.
+ Touch: press and hold
+ Pen/stylus: press and hold
This gesture can be used to display a context menu.

### -field HoldWithMouse:8
Enable support for the press and hold gesture through the left button on a mouse. The [Holding](gesturerecognizer_holding.md) event is raised if a time threshold is crossed before the left button is released or a gesture is started.This gesture can be used to display a context menu.

### -field RightTap:16
Enable support for a right-tap interaction. The [RightTapped](gesturerecognizer_righttapped.md) event is raised when the contact is lifted or the mouse button released.
+ Touch: press and hold
+ Mouse: press and hold, right button click
+ Pen/stylus: press and hold, tap with barrel button pressed
This gesture can be used to display a context menu.

### -field Drag:32
Enable support for the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture with a mouse or pen/stylus (single contact). The [Dragging](gesturerecognizer_dragging.md) event is raised when either gesture is detected.This gesture can be used for text selection, selecting or rearranging objects, or scrolling and panning.

> [!NOTE]
> Mouse and pen/stylus input does not raise manipulation events ([ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md)) during the course of this interaction.

Specifying support for **Drag** and one or more of the manipulation settings enables a single device to perform multiple actions. For example, the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture can be performed with the left mouse button to select text while the wheel button can be rolled to scroll content.






### -field ManipulationTranslateX:64
Enable support for the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the horizontal axis. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateY:128
Enable support for the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the vertical axis. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateRailsX:256
Enable support for the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the horizontal axis using rails (guides). The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateRailsY:512
Enable support for the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the vertical axis using rails (guides). The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationRotate:1024
Enable support for the rotation gesture through pointer input. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.

### -field ManipulationScale:2048
Enable support for the pinch or stretch gesture through pointer input.These gestures can be used for optical or semantic zoom and resizing an object. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.

### -field ManipulationTranslateInertia:4096
Enable support for translation inertia after the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field ManipulationRotateInertia:8192
Enable support for rotation inertia after the rotate gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field ManipulationScaleInertia:16384
Enable support for scaling inertia after the pinch or stretch gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field CrossSlide:32768
Enable support for the [CrossSliding](gesturerecognizer_crosssliding.md) interaction when using the [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through a single touch contact.This gesture can be used for selecting or rearranging objects.

### -field ManipulationMultipleFingerPanning:65536
Enable panning and disable zoom when two or more touch contacts are detected.Prevents unintentional zoom interactions when panning with multiple fingers.


## -remarks

## -examples

## -see-also
[Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
