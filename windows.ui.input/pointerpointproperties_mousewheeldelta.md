---
-api-id: P:Windows.UI.Input.PointerPointProperties.MouseWheelDelta
-api-type: winrt property
---

<!-- Property syntax
public int MouseWheelDelta { get; }
-->

# Windows.UI.Input.PointerPointProperties.MouseWheelDelta

## -description
Gets a value (the raw value reported by the device) that indicates the change in wheel button input from the last pointer event.

## -property-value
The number of notches or distance thresholds crossed since the last pointer event. The default value is 0.

## -remarks
The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

The windows constant, WHEEL_DELTA (defined as a value of 120), describes one detent. Each detent marks the threshold for a single increment of an associated action (for example, scrolling a line or page).

A positive value indicates that the wheel was rotated forward (away from the user) or tilted to the right; a negative value indicates that the wheel was rotated backward (toward the user) or tilted to the left.

Wheel button input is oriented along the vertical axis (rotate forward or backward) or the horizontal axis (tilt left or right). Check [IsHorizontalMouseWheel](pointerpointproperties_ishorizontalmousewheel.md) to identify whether the input is along the horizontal axis.

> [!NOTE]
> The delta was set to 120 to enable finer-resolution wheels (such as freely-rotating wheels with no notches) that send more messages per rotation, but with smaller values per message.

## -examples

## -see-also
[IsHorizontalMouseWheel](pointerpointproperties_ishorizontalmousewheel.md)