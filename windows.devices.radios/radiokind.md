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
A Wi-Fi radio. 802.11 wireless networking radios for local area network connectivity.

### -field MobileBroadband:2
A mobile broadband radio. Cellular radios for wide-area network connectivity (3G, 4G, 5G). This value became available in Windows 10 version 1703.

### -field Bluetooth:3
A Bluetooth radio. Short-range wireless communication for device pairing and data transfer.

### -field FM:4
An FM radio. Radio reception hardware for future use - not currently available.

> [!NOTE]
> This value is defined for future use, and is not currently available.

## -remarks
[RadioKind](radiokind.md) identifies the technology type of radio devices, enabling applications to filter and manage 
specific radio types appropriately.

### Control and policy implications

Different radio kinds may have varying control restrictions:
- **System policies** may limit which radio types can be controlled by applications
- **Hardware switches** can force any radio type into an uncontrollable disabled state

> [!IMPORTANT]
> MobileBroadband radios require the **cellularDeviceControl** restricted capability to change state.  
> Applications without this capability can enumerate and monitor these radios but cannot control their state.

> [!NOTE]
> The presence of a specific [RadioKind](radiokind.md) does not guarantee that its state can be changed. Always check 
> [RadioAccessStatus](radioaccessstatus.md) before attempting state modifications.

## -examples

## -see-also
[Radio](radio.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioState](radiostate.md)
