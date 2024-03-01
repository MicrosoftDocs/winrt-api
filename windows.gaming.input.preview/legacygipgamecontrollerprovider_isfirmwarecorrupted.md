---
-api-id: P:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsFirmwareCorrupted
-api-type: winrt property
---

<!-- Property syntax.
public bool IsFirmwareCorrupted { get; }
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsFirmwareCorrupted

## -description

Returns whether the controller firmware is corrupted.

## -property-value

Battery charging state of the controller.

```GetDeviceFirmwareCorruptionState``` should be used rather than ```IsFirmwareCorrupted``` for most devices as it is supported by most devices. ```IsFirmwareCorrupted``` is only supported by older devices and should only be used if ```GetDeviceFirmwareCorruptionState``` is not supported.

> [!CAUTION]
> To avoid damaging devices, the firmware corruption and update APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::

## -see-also
[GetDeviceFirmwareCorruptionState](legacygipgamecontrollerprovider_getdevicefirmwarecorruptionstate.md)
