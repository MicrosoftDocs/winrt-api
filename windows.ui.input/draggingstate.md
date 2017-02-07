---
-api-id: T:Windows.UI.Input.DraggingState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.DraggingState : int
-->

# DraggingState

## -description
Specifies the possible states of the [Dragging](gesturerecognizer_dragging.md) event.

## -enum-fields
### -field Started:0
A dragging interaction has been detected.

### -field Continuing:1
The dragging interaction is in progress.

### -field Completed:2
The mouse or pen/stylus contact is lifted and inertia has concluded.


## -remarks
[Drag](gesturesettings.md) must be set in the [GestureSettings](gesturerecognizer_gesturesettings.md) property to support [Dragging](gesturerecognizer_dragging.md) with mouse and pen/stylus input.



> [!NOTE]
> There is no correlation between **Dragging** in [CrossSlidingState](crossslidingstate.md) (touch) and [DraggingState](draggingstate.md) (mouse or pen/stylus).

## -examples

## -see-also
[DraggingEventArgs.DraggingState property](draggingeventargs_draggingstate.md), [Dragging event](gesturerecognizer_dragging.md)