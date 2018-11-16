---
-api-id: P:Windows.Devices.Lights.LampArray.IsEnabled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsEnabled { get;  set; }
-->

# Windows.Devices.Lights.LampArray.IsEnabled

## -description
Gets or sets the enabled state.

## -property-value
True if the device is enabled; otherwise false.

## -remarks
When disabled, state for a lamp index can be set internally, but will not be sent to the device. When set back to enabled, modified state is flushed to the device.

By default, LampArray is always enabled.

## -see-also

## -examples

