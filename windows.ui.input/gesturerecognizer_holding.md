---
-api-id: E:Windows.UI.Input.GestureRecognizer.Holding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Holding<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.HoldingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.Holding

## -description
Occurs when a user performs a press and hold gesture (with a single touch, mouse, or pen/stylus contact).

## -remarks
To support [Holding](gesturerecognizer_holding.md) with touch and pen/stylus input, specify [Hold](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

To support [Holding](gesturerecognizer_holding.md) with mouse input, specify [HoldWithMouse](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

The [Holding](gesturerecognizer_holding.md) event is fired twice: Once when holding starts ([started](holdingstate.md)) and again when holding ends ([completed](holdingstate.md) or [canceled](holdingstate.md)).

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [HoldingEventArgs](holdingeventargs.md)