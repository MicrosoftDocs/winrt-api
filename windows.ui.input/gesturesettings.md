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
Enable support for the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture with a mouse or pen/stylus (single contact). The [Dragging](gesturerecognizer_dragging.md) event is raised when either gesture is detected.This gesture can be used for text selection, selecting or rearranging objects, or scrolling and panning.

> [!NOTE]
> Mouse and pen/stylus input does not raise manipulation events ([ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md)) during the course of this interaction.

Specifying support for **Drag** and one or more of the manipulation settings enables a single device to perform multiple actions. For example, the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture can be performed with the left mouse button to select text while the wheel button can be rolled to scroll content.






### -field ManipulationTranslateX:64
Enable support for the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the horizontal axis. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateY:128
Enable support for the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the vertical axis. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateRailsX:256
Enable support for the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the horizontal axis using rails (guides). The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationTranslateRailsY:512
Enable support for the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through pointer input, on the vertical axis using rails (guides). The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.This gesture can be used for rearranging objects.

### -field ManipulationRotate:1024
Enable support for the rotation gesture through pointer input. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.

### -field ManipulationScale:2048
Enable support for the pinch or stretch gesture through pointer input.These gestures can be used for optical or semantic zoom and resizing an object. The [ManipulationStarted](gesturerecognizer_manipulationstarted.md), [ManipulationUpdated](gesturerecognizer_manipulationupdated.md), and [ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) events are all raised during the course of this interaction.

### -field ManipulationTranslateInertia:4096
Enable support for translation inertia after the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field ManipulationRotateInertia:8192
Enable support for rotation inertia after the rotate gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field ManipulationScaleInertia:16384
Enable support for scaling inertia after the pinch or stretch gesture (through pointer input) is complete. The [ManipulationInertiaStarting](gesturerecognizer_manipulationinertiastarting.md) event is raised if inertia is enabled.

### -field CrossSlide:32768
Enable support for the [CrossSliding](gesturerecognizer_crosssliding.md) interaction when using the [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture through a single touch contact.This gesture can be used for selecting or rearranging objects.

### -field ManipulationMultipleFingerPanning:65536
Enable panning and disable zoom when two or more touch contacts are detected.Prevents unintentional zoom interactions when panning with multiple fingers.


## -remarks

## -examples

## -see-also
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample), [Input: Simplified ink  sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Simplified%20ink%20sample), [Input: Windows 8 gestures sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/Input%20Windows%208%20gestures%20sample%20(Windows%208)/C%23), [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample), [XAML scrolling, panning, and zooming sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/XAML%20scrolling%2C%20panning%2C%20and%20zooming%20sample), [DirectX touch input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/DirectX%20touch%20input%20sample%20(Windows%208)/C%2B%2B), [Input: Manipulations and gestures (C++) sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Manipulations%20and%20gestures%20(C%2B%2B)%20sample%20(Windows%208)/C%2B%2B), [Input: Touch hit testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B), [Input source identification sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20desktop%20samples/%5BC%2B%2B%5D-Windows%208%20desktop%20samples/C%2B%2B/Windows%208%20desktop%20samples/Input%20Source%20identification%20sample/C%2B%2B), [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample), [Win32 touch hit-testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B)