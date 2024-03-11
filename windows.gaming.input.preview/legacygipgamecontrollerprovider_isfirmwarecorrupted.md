---
-api-id: P:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsFirmwareCorrupted
-api-type: winrt property
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.IsFirmwareCorrupted

<!--
public bool IsFirmwareCorrupted { get; }
-->

## -description

Returns whether the controller firmware is corrupted.

## -property-value

Battery charging state of the controller.

`GetDeviceFirmwareCorruptionState` should be used rather than `IsFirmwareCorrupted` as it is supported by most devices. `IsFirmwareCorrupted` is only supported by older devices and should only be used if `GetDeviceFirmwareCorruptionState` is not supported.

> [!CAUTION]
> To avoid damaging devices, the firmware corruption and update APIs should only be used with hardware you have developed.

## -remarks

## -see-also

[GetDeviceFirmwareCorruptionState](legacygipgamecontrollerprovider_getdevicefirmwarecorruptionstate.md)

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::
