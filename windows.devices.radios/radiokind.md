---
-api-id: T:Windows.Devices.Radios.RadioKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Radios.RadioKind : int
-->

# RadioKind

## -description
Enumeration that represents the kinds of radio devices.

## -enum-fields
### -field Other:0
An unspecified kind of radio device.

### -field WiFi:1
A Wi-Fi radio.

### -field MobileBroadband:2
A mobile broadband radio. This value became available in Windows 10 version 1703.

### -field Bluetooth:3
A Bluetooth radio.

### -field FM:4
An FM radio.

> [!NOTE]
> This value is defined for future use, and is not currently available.

## -remarks
Presence of a given kind does not guarantee that its state can be changed. Some kinds (for example MobileBroadband) can
require additional capabilities or policy allowance to be user-controllable. A radio that is not controllable still
reports its current state.

## -examples

## -see-also