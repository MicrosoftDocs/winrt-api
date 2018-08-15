---
-api-id: T:Windows.UI.Input.HoldingState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.HoldingState : int
-->

# HoldingState

## -description
Specifies the state of the [Holding](gesturerecognizer_holding.md) event.

## -enum-fields
### -field Started:0
A single contact has been detected and a time threshold is crossed without the contact being lifted, another contact detected, or another gesture started.

> [!NOTE]
> The press and hold time threshold can be set in the **Hardware and Sound** control panel.

### -field Completed:1
The single contact is lifted.

### -field Canceled:2
An additional contact is detected, a subsequent gesture (such as a slide) is detected, or the [CompleteGesture](gesturerecognizer_completegesture_805659565.md) method is called.


## -remarks
To support [Holding](gesturerecognizer_holding.md) with touch and pen/stylus input, specify [Hold](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

To support [Holding](gesturerecognizer_holding.md) with mouse input, specify [HoldWithMouse](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

The [Holding](gesturerecognizer_holding.md) event is fired twice: Once when holding starts ([started](holdingstate.md)) and again when holding ends ([completed](holdingstate.md) or [canceled](holdingstate.md)).

## -examples

## -see-also
[HoldingEventArgs.HoldingState property](holdingeventargs_holdingstate.md), [Holding](gesturerecognizer_holding.md)