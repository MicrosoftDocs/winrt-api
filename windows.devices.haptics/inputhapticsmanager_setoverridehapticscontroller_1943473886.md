---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.SetOverrideHapticsController(Windows.Devices.Haptics.HapticDeviceType,Windows.Devices.Haptics.SimpleHapticsController)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.SetOverrideHapticsController(Windows.Devices.Haptics.HapticDeviceType,Windows.Devices.Haptics.SimpleHapticsController)

<!--
public Windows.Devices.Haptics.HapticsControllerOverrideToken SetOverrideHapticsController (Windows.Devices.Haptics.HapticDeviceType deviceType, Windows.Devices.Haptics.SimpleHapticsController controller);
-->


## -description

Sets the [SimpleHapticsController](simplehapticscontroller.md) and [HapticDeviceType](hapticdevicetype.md) that the manager should use for its methods and properties. Multiple overrides can be active simultaneously, with the manager using the one most recently provided.

## -parameters

### -param deviceType

The type of haptic device. Must be a value other than **None**.

### -param controller

The [SimpleHapticsController](simplehapticscontroller.md) to use. Must not be **null**.

## -returns

A [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md) that can be passed to [ClearOverrideHapticsController](inputhapticsmanager_clearoverridehapticscontroller_456612938.md) to remove the override.

## -remarks

## -see-also

[InputHapticsManager.ClearOverrideHapticsController](inputhapticsmanager_clearoverridehapticscontroller_456612938.md), [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md), [HapticDeviceType](hapticdevicetype.md), [SimpleHapticsController](simplehapticscontroller.md)

## -examples


