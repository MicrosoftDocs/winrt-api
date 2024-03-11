---
-api-id: T:Windows.Gaming.Input.Preview.GameControllerFirmwareCorruptReason
-api-type: winrt enum
---

# Windows.Gaming.Input.Preview.GameControllerFirmwareCorruptReason

<!--
public enum GameControllerFirmwareCorruptReason
-->

## -description

The state of firmware corruption for a device.

## -enum-fields

### -field Unknown:0

It is not known whether firmware is corrupt.

### -field NotCorrupt:1

The firmware is not corrupt.

### -field TwoUpCorrupt:2

The 2Up firmware is corrupt.

### -field AppCorrupt:3

The app firmware is corrupt.

### -field RadioCorrupt:4

The radio firmware is corrupt.

### -field EepromCorrupt:5

The EEPROM is corrupt.

### -field SafeToUpdate:6

The firmware can be safely updated to recover from corruption.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the firmware corruption and update APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::

## -see-also
