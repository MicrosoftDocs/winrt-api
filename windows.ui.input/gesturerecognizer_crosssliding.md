---
-api-id: E:Windows.UI.Input.GestureRecognizer.CrossSliding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CrossSliding<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.CrossSlidingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.CrossSliding

## -description
Occurs when a user performs a [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture (through a single touch contact) within a content area that supports panning along a single axis only. The gesture must occur in a direction that is perpendicular to this panning axis.

> [!NOTE]
> A swipe is a short sliding gesture that results in a selection action while the longer slide gesture crosses a distance threshold and results in a rearrange action. The swipe and slide gestures are demonstrated in the following diagram.
<img src="images/crossslide_mechanism.png" width="534" height="180" alt="Diagram showing the select and drag actions." />


<!--kbridge: Font details: Segoe UI Symbol 11pt RGB: 214/31/126-->

## -remarks
[CrossSlide](gesturesettings.md) must be set in the [GestureSettings](gesturerecognizer_gesturesettings.md) property to support CrossSliding.

CrossSliding distance thresholds are disabled by default. Use [CrossSlideThresholds](gesturerecognizer_crossslidethresholds.md) to set these values.

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [CrossSlidingEventArgs](crossslidingeventargs.md), [Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)