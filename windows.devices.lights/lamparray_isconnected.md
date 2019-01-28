---
-api-id: P:Windows.Devices.Lights.LampArray.IsConnected
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsConnected { get; }
-->

# Windows.Devices.Lights.LampArray.IsConnected

## -description
Gets a value indicating whether the LampArray device is connected to the system.

## -property-value
True if the LampArray is connected; otherwise, false.

## -remarks
Once disconnected, further calls to the object are null-ops and the object should be thrown away.  [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md) should be used to determine if the device is reconnected, and then a new LampArray instance should be created [FromIdAsync](lamparray_fromidasync_1322863552.md).

## -see-also

## -examples

