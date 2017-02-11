---
-api-id: P:Windows.ApplicationModel.Background.SocketActivityTrigger.IsWakeFromLowPowerSupported
-api-type: winrt property
---

<!-- Property syntax
public bool IsWakeFromLowPowerSupported { get; }
-->

# Windows.ApplicationModel.Background.SocketActivityTrigger.IsWakeFromLowPowerSupported

## -description
Gets whether a [SocketActivityTrigger](socketactivitytrigger.md) can wake the machine from a low power state.

## -property-value
**True** indicates that this trigger can wake the machine from a low power state; **false** otherwise.

## -remarks
This trigger is registered such that when there is new data available on the socket it will wake the device and activate the background task. On devices that don't support always on, always connected (AOAC), the device will not be awakened to trigger the background task.

Devices that support AOAC can be put into standby mode without fully powering down. In this mode it can maintain network connectivity. On these devices, a trigger can wake up the device.

## -examples

## -see-also
