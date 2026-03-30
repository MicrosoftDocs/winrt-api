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

This method is not needed for normal usage where haptic feedback is triggered from the thread receiving system input. It is intended for two scenarios:

- **Third-party device interop**: Haptics devices that are not automatically detected by the system but still deliver input can use this method to provide their [SimpleHapticsController](simplehapticscontroller.md) to the [InputHapticsManager](inputhapticsmanager.md) .
- **Background thread marshalling**: A controller and device type obtained on an input thread can be marshalled to a background thread so that the background thread can use the [InputHapticsManager](inputhapticsmanager.md) APIs.

The override takes effect for a short duration after it is set. Callers should clear overrides promptly once their associated input has been processed.

## -see-also

## -examples
