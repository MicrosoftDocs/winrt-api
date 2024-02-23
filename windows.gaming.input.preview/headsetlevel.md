---
-api-id: T:Windows.Gaming.Input.Preview.HeadsetLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Gaming.Input.Preview.HeadsetLevel : int
-->

# HeadsetLevel

## -description

Settings that can be read from or written to a headset that supports them.

## -enum-fields

### -field Off:0

Turns off the volume.

### -field Low:1

Sets the volume level to low.

### -field Medium:2

Sets the volume level to medium.

### -field High:3

Sets the volume level to high.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::
