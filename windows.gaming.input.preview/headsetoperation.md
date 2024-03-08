---
-api-id: T:Windows.Gaming.Input.Preview.HeadsetOperation
-api-type: winrt enum
---

# Windows.Gaming.Input.Preview.HeadsetOperation

<!--
public enum HeadsetOperation
-->

## -description

Settings that can be read from or written to a headset that supports them.

## -enum-fields

### -field Geq:0

Controls the equalizer. Buffers must be a byte array with the same layout as the [HeadsetGeqGains](headsetgeqgains.md) struct.

### -field BassBoostGain:1

Controls bass boost. The buffer must be a little-endian 4-byte signed integer between 0 and 12 decibels inclusive.

### -field SmartMute:2

Controls the smart mute feature. The buffer must be an unsigned 1-byte integer set to one of the values of the [HeadsetLevel](headsetlevel.md) enum.

### -field SideTone:3

Controls the side tone feature. The buffer must be an unsigned 1-byte integer set to one of the values of the [HeadsetLevel](headsetlevel.md) enum.

### -field MuteLedBrightness:4

Controls the mute LED brightness. The buffer must be an unsigned 1-byte integer set to HeadsetLevel.Low, HeadsetLevel.Medium, or HeadsetLevel.High.

### -field SwapMixAndVolumeDials:5

Controls whether the mix and volume dials are in-place or swapped. The buffer must be a one-byte boolean, false if the dials are in-place and true if they are swapped.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::

## -see-also

[GetHeadsetOperation](legacygipgamecontrollerprovider_GetHeadsetOperation.md)
[SetHeadsetOperation](legacygipgamecontrollerprovider_SetHeadsetOperation.md)
