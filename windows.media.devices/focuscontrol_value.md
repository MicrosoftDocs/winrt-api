---
-api-id: P:Windows.Media.Devices.FocusControl.Value
-api-type: winrt property
---

<!-- Property syntax
public uint Value { get; }
-->

# Windows.Media.Devices.FocusControl.Value

## -description
Gets the current value that the focus is set to.

## -property-value
The value that the focus is set to. The minimum and maximum values for the focus are specified by [Min](focuscontrol_min.md) and [Max](focuscontrol_max.md).

## -remarks
To set a focus value, call [SetValueAsync](focuscontrol_setvalueasync.md) specifying a value between the [Min](focuscontrol_min.md) and [Max](focuscontrol_max.md) focus values.

## -examples

## -see-also
[FocusControl.Value](exposurecontrol_value.md), [Min](focuscontrol_min.md), [Max](focuscontrol_max.md)