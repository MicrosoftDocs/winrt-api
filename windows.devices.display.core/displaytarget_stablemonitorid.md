---
-api-id: P:Windows.Devices.Display.Core.DisplayTarget.StableMonitorId
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string StableMonitorId { get; }
-->

# Windows.Devices.Display.Core.DisplayTarget.StableMonitorId

## -description
Gets a value representing a stable identifier string for this monitor which persists no matter which adapter or connector on the adapter the monitor is attached to (see Remarks for exceptions). This string should be treated as an opaque identifier and not parsed. It is not suitable for display to a user but is intended to be used to persist monitor-specific settings.

## -property-value
A string containing the identifier.

## -remarks
Note that [DeviceInterfacePath](displaytarget_deviceinterfacepath.md) does not have this same stability guarantee. Reconnecting the same monitor to a different GPU or a different output on the same GPU can result in the monitor having a different DeviceInterfacePath, but the StableMonitorId should be maintained.

In cases where the system detects two completely identical monitors connected at the same time, the stable identifier will be regenerated to include a reference to its connector to ensure that both monitors have a unique identifier.

Some monitors may expose different hardware identifier information for each input port on the monitor. In this case, the StableMonitorId may vary depending on which input port on the monitor is used.

## -see-also

## -examples

