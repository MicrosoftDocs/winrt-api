---
-api-id: T:Windows.UI.Input.CrossSlidingState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.CrossSlidingState : int
-->

# CrossSlidingState

## -description

Specifies the possible states of the [CrossSliding](gesturerecognizer_crosssliding.md) event.

## -enum-fields

### -field Started:0

A [CrossSliding](gesturerecognizer_crosssliding.md) interaction has been detected.

### -field Dragging:1

A [CrossSliding](gesturerecognizer_crosssliding.md) interaction has started but the [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has not crossed the minimum distance threshold for a selection action. (See the Remarks section for a diagram showing the [CrossSliding](gesturerecognizer_crosssliding.md) distance thresholds.)

> [!NOTE]
> There is no correlation between **Dragging** in CrossSlidingState (touch) and [DraggingState](draggingstate.md) (mouse or pen/stylus).

### -field Selecting:2

The [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has crossed the minimum distance threshold for a selection action but has not crossed the minimum distance threshold of the rearrange action. This state is valid only when [SpeedBumpStart](crossslidethresholds.md) is disabled in a [GestureRecognizer](gesturerecognizer.md).

### -field SelectSpeedBumping:3

The [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has crossed the minimum distance threshold for a selection action (and the selection speed bump) but has not crossed the maximum distance threshold of the selection speed bump. This state is valid only when both [SpeedBumpStart](crossslidethresholds.md) and [SelectionStart](crossslidethresholds.md) are enabled in a [GestureRecognizer](gesturerecognizer.md).

### -field SpeedBumping:4

The [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has crossed the minimum distance threshold for a selection action (and the selection speed bump) but has not crossed the maximum distance threshold of the selection speed bump. This state is valid only when [SpeedBumpStart](crossslidethresholds.md) is enabled and [SelectionStart](crossslidethresholds.md) is disabled in a [GestureRecognizer](gesturerecognizer.md).

### -field Rearranging:5

The [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has crossed the minimum distance threshold of the rearrange action. This state is valid only when [RearrangeStart](crossslidethresholds.md) is enabled in a [GestureRecognizer](gesturerecognizer.md).

### -field Completed:6

The [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture has stopped, the [CrossSliding](gesturerecognizer_crosssliding.md) interaction has been completed, and the touch contact lifted.


## -remarks

The [CrossSlidingState](crossslidingeventargs_crossslidingstate.md) property is set based on the distance thresholds specified by the [CrossSlideThresholds](gesturerecognizer_crossslidethresholds.md) property of a [GestureRecognizer](gesturerecognizer.md).

These distance thresholds are used to determine whether the [CrossSliding](gesturerecognizer_crosssliding.md) interaction results in a select action or a rearrange action. The following diagram shows the [CrossSliding](gesturerecognizer_crosssliding.md) regions and thresholds. The areas highlighted in blue are the selection/speed bump regions. (The region on the left shows the distance the tile must travel while the region on the right shows the equivalent distance that the touch contact must travel due to the speed bump behavior).

> [!NOTE]
> A speed bump is a [CrossSliding](gesturerecognizer_crosssliding.md) region in which the user experiences a slight drag (or friction) during the [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture.

<img src="images/crossslide_threshold2.png" width="592" height="282" alt="Screen shot showing CrossSlide regions and distance thresholds." />

Selection, rearrange, and speed-bumps can be enabled or disabled in any combination through the [CrossSlideThresholds](gesturerecognizer_crossslidethresholds.md) property of a [GestureRecognizer](gesturerecognizer.md).

If **SelectionStart** and **SpeedBumpStart** are both enabled then **SpeedBumpStart** is ignored (friction is still experienced) and **SelectSpeedBumping** is returned when the [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture is detected within the selection/speed bumping region.

If **SelectionStart** is enabled and **SpeedBumpStart** is disabled then **Selecting** is returned when the [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture is detected within the selection/speed bump region.

If **SpeedBumpStart** and **RearrangeStart** are both enabled then **SpeedBumpEnd** is ignored and friction continues until the **RearrangeStart** threshold is reached.

If **RearrangeStart** is enabled then **Rearranging** is returned when the [swipe](/windows/uwp/input-and-devices/guidelines-for-cross-slide) or [slide](/windows/uwp/input-and-devices/guidelines-for-cross-slide) gesture is detected outside the selection/speed bumping region.

## -examples

## -see-also

[CrossSlidingEventArgs.CrossSlidingState property](crossslidingeventargs_crossslidingstate.md), [CrossSliding event](gesturerecognizer_crosssliding.md), [CrossSlideThresholds property](gesturerecognizer_crossslidethresholds.md)
