---
-api-id: P:Windows.Devices.Haptics.InputHapticsManager.CurrentHapticsControllerDeviceType
-api-type: winrt property
---

# Windows.Devices.Haptics.InputHapticsManager.CurrentHapticsControllerDeviceType

<!--
public Windows.Devices.Haptics.HapticDeviceType CurrentHapticsControllerDeviceType { get; }
-->

## -description

Gets the type of haptic device for the input device from which input was most recently received by the thread (or the device type set by [SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md) if an override is active).

## -property-value

The [HapticDeviceType](hapticdevicetype.md) of the most recent input device, or **None** if the device does not support haptics, no input has been received recently, or no override has been set.

## -remarks

## -see-also

[InputHapticsManager.CurrentHapticsController](inputhapticsmanager_currenthapticscontroller.md)

## -examples
