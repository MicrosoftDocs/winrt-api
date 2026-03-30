---
-api-id: T:Windows.Devices.Haptics.HapticDeviceType
-api-type: winrt enum
---

# Windows.Devices.Haptics.HapticDeviceType

<!--
public enum HapticDeviceType
-->

## -description

Specifies the types of haptic devices that can be identified by an [InputHapticsManager](inputhapticsmanager.md).

## -enum-fields

### -field None: 0

No haptic device is currently identified.

### -field Generic: 1

A device has been identified, but it does not match any of the other enum values.

### -field Pen: 2

Pen/stylus device.

### -field Touchpad: 3

Touchpad device.

### -field Mouse: 4

Mouse device.

## -remarks

Future SDK versions may expand the set of identifiable device types. Application code that checks this value should map any unknown values to **Generic**.

## -see-also

[InputHapticsManager.CurrentHapticsControllerDeviceType](inputhapticsmanager_currenthapticscontrollerdevicetype.md), [InputHapticsManager.SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md)

## -examples
