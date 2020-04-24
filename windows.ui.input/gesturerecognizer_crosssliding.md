---
-api-id: E:Windows.UI.Input.GestureRecognizer.CrossSliding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CrossSliding<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.CrossSlidingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.CrossSliding

## -description
Occurs when a user performs a [slide](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture (through a single touch contact) within a content area that supports panning along a single axis only. The gesture must occur in a direction that is perpendicular to this panning axis.

> [!NOTE]
> A swipe is a short sliding gesture that results in a selection action while the longer slide gesture crosses a distance threshold and results in a rearrange action. The swipe and slide gestures are demonstrated in the following diagram.
<img src="images/crossslide_mechanism.png" width="534" height="180" alt="Diagram showing the select and drag actions." />


<!--kbridge: Font details: Segoe UI Symbol 11pt RGB: 214/31/126-->

## -remarks
[CrossSlide](gesturesettings.md) must be set in the [GestureSettings](gesturerecognizer_gesturesettings.md) property to support CrossSliding.

CrossSliding distance thresholds are disabled by default. Use [CrossSlideThresholds](gesturerecognizer_crossslidethresholds.md) to set these values.

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [CrossSlidingEventArgs](crossslidingeventargs.md), [Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
