---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetDeviceFirmwareCorruptionState()
-api-type: winrt method
---

<!-- Method syntax.
public GameControllerFirmwareCorruptReason LegacyGipGameControllerProvider.GetDeviceFirmwareCorruptionState()
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetDeviceFirmwareCorruptionState

## -description

Gets the state of whether the device's firmware is corrupted and if so, in what way. See [GameControllerFirmwareCorruptReason](gamecontrollerfirmwarecorruptreason.md) for details.

## -parameters

## -returns

The state of whether the device's firmware is corrupted and if so, in what way.

## -remarks

This should be used rather than ```IsFirmwareCorrupted``` for most devices as it is supported by most devices. ```IsFirmwareCorrupted``` is only supported by older devices and should only be used if ```GetDeviceFirmwareCorruptionState``` is not supported.

> [!CAUTION]
> To avoid damaging devices, the firmware corruption and update APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::

## -see-also
