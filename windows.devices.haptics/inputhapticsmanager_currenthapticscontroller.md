---
-api-id: P:Windows.Devices.Haptics.InputHapticsManager.CurrentHapticsController
-api-type: winrt property
---

# Windows.Devices.Haptics.InputHapticsManager.CurrentHapticsController

<!--
public Windows.Devices.Haptics.SimpleHapticsController CurrentHapticsController { get; }
-->


## -description

Gets the [SimpleHapticsController](simplehapticscontroller.md) object for the input device that most recently delivered input to the thread, or the controller set by [SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md) if an override is active.

## -property-value

The [SimpleHapticsController](simplehapticscontroller.md) for the most recent input device, or **null** if the device does not support haptics or no input has been received recently and no override has been set recently.

## -remarks

## -see-also

[InputHapticsManager.CurrentHapticsControllerDeviceType](inputhapticsmanager_currenthapticscontrollerdevicetype.md), [SimpleHapticsController](simplehapticscontroller.md)

## -examples
