---
-api-id: T:Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism : int
-->

# AllJoynAuthenticationMechanism

## -description
Defines values used to indicate the mechanism used in authentication operations.

## -enum-fields
### -field None:0
No mechanism used.

### -field SrpAnonymous:1
Secure Remote Password (SRP) anonymous has been deprecated and should no longer be used.

### -field SrpLogon:2
Secure Remote Password (SRP) logon (e.g. username and password) has been deprecated and should no longer be used.

### -field EcdheNull:3
ECDHE_NULL key exchange.

### -field EcdhePsk:4
ECDHE_PSK has been deprecated and should no longer be used.

### -field EcdheEcdsa:5
ECDHE_ECDSA key exchange.

### -field EcdheSpeke:6
ECDHE_SPEKE key exchange.

## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | EcdheSpeke |

## -examples

## -see-also


## -capabilities
allJoyn
