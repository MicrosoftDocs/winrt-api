---
-api-id: P:Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger.CanMaintainConnection
-api-type: winrt property
---

<!-- Property syntax
public bool CanMaintainConnection { get; }
-->

# Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger.CanMaintainConnection

## -description
Gets whether the system can maintain a connection to the specified device.

## -property-value
True if the system can maintain a connection to the specified device; Otherwise, false. If false, an attempt to register a trigger with [MaintainConnection](deviceconnectionchangetrigger_maintainconnection.md) = true will throw an exception. The default value of this property is true for Bluetooth LE devices and false for all other device types.

## -remarks

## -examples

## -see-also
