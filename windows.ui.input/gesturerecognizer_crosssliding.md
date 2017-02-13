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
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [CrossSlidingEventArgs](crossslidingeventargs.md)