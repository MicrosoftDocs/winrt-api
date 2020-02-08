---
-api-id: T:Windows.Devices.SmartCards.SmartCardEmulationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardEmulationType : int
-->

# SmartCardEmulationType

## -description
Defines the mechanism by which the device emulates a smart card.

## -enum-fields
### -field Host:0
The device emulates a smart card by forwarding application protocol data unit (APDU) commands to the host application, which responds back.

### -field Uicc:1
The device emulates a smart card by forwarding the application protocol data unit (APDU) commands directly to the physical UICC card. The UICC card is more commonly referred to as the SIM card.

### -field EmbeddedSE:2
The device emulates a smart card by forwarding the application protocol data unit (APDU) commands to an embedded SE reader.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | EmbeddedSE |

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
