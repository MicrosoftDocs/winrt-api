---
-api-id: P:Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription.IsAbsolute
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsAbsolute { get; }
-->

# Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription.IsAbsolute

## -description
Gets a value indicating whether the given boolean control values are absolute or relative.

## -property-value
True if the values are absolute; false if the values are relative.

## -remarks
This property is useful when an app provides similar functionality as the system and needs to keep the corresponding in-app control synchronized with the system setting. For example, an in-app (relative) mute button that doesn't affect the system volume, but which must correspond to any changes made to the system setting (absolute).

## -examples

## -see-also
