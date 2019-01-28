---
-api-id: E:Windows.UI.Input.GestureRecognizer.CrossSliding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CrossSliding<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.CrossSlidingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.CrossSliding

## -description
Occurs when a user performs a [slide](http://msdn.microsoft.com/library/897555e2-c567-4bbe-b600-553daeb223d5) or [swipe](http://msdn.microsoft.com/library/897555e2-c567-4bbe-b600-553daeb223d5) gesture (through a single touch contact) within a content area that supports panning along a single axis only. The gesture must occur in a direction that is perpendicular to this panning axis.

> [!NOTE]
> A swipe is a short sliding gesture that results in a selection action while the longer slide gesture crosses a distance threshold and results in a rearrange action. The swipe and slide gestures are demonstrated in the following diagram.
<img src="images/crossslide_mechanism.png" width="534" height="180" alt="Diagram showing the select and drag actions." />


<!--kbridge: Font details: Segoe UI Symbol 11pt RGB: 214/31/126-->

## -remarks
[CrossSlide](gesturesettings.md) must be set in the [GestureSettings](gesturerecognizer_gesturesettings.md) property to support [CrossSliding](gesturerecognizer_crosssliding.md).

[CrossSliding](gesturerecognizer_crosssliding.md) distance thresholds are disabled by default. Use [CrossSlideThresholds](gesturerecognizer_crossslidethresholds.md) to set these values.

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [CrossSlidingEventArgs](crossslidingeventargs.md), [Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)