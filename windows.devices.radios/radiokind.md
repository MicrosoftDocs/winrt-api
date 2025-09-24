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
Defines the kinds of radio devices.

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
[RadioKind](radiokind.md) identifies the technology type of radio devices, enabling applications to filter and manage 
specific radio types appropriately.

### Radio technology characteristics

**Common radio types:**
- **WiFi**: 802.11 wireless networking radios for local area network connectivity
- **Bluetooth**: Short-range wireless communication for device pairing and data transfer
- **MobileBroadband**: Cellular radios for wide-area network connectivity (3G, 4G, 5G)

**Special considerations:**
- **Other**: Includes specialized radios not covered by specific categories
- **FM**: Radio reception hardware (future use - not currently available)

### Control and policy implications

Different radio kinds may have varying control restrictions:
- **System policies** may limit which radio types can be controlled by applications
- **MobileBroadband** radios require the **cellularDeviceControl** restricted capability for state control
- **Hardware switches** can force any radio type into an uncontrollable disabled state

> [!IMPORTANT]
> MobileBroadband radios require the **cellularDeviceControl** restricted capability to change state.  
> Applications without this capability can enumerate and monitor these radios but cannot control their state.

> [!NOTE]
> The presence of a specific [RadioKind](radiokind.md) does not guarantee that its state can be changed. Always check 
> [RadioAccessStatus](radioaccessstatus.md) before attempting state modifications.

## -examples

For comprehensive radio management examples including capability-aware control patterns, see [Radio class documentation](radio.md).

## -see-also
[Radio](radio.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioState](radiostate.md)
