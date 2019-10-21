---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectPairingProcedure
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.WiFiDirect.WiFiDirectPairingProcedure : int
-->

# WiFiDirectPairingProcedure

## -description
Specifies a direct pairing procedure.

## -enum-fields
### -field GroupOwnerNegotiation:0
Group Owner Negotiation. The connecting device chooses the configuration method.

### -field Invitation:1
P2P Invitation. The accepting device chooses the configuration method.

## -remarks
Wi-Fi Direct supports two different pairing procedures. In the Group Owner Negotiation procedure, the connecting device chooses the configuration method (PIN entry, PIN display, or push-button pairing.) In the P2P Invitation procedure, the accepting device chooses the configuration method. Use the values in this enumeration to identify a pairing procedure.

## -examples

## -see-also