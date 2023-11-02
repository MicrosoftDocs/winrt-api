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

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Defines values used to indicate the mechanism used in authentication operations.

## -enum-fields
### -field None:0
No mechanism used.

### -field SrpAnonymous:1
Secure Remote Password (SRP) anonymous has been deprecated and should no longer be used.

### -field SrpLogon:2
Secure Remote Password (SRP) logon (for example, username and password) has been deprecated and should no longer be used.

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

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | EcdheSpeke |

## -examples

## -see-also


## -capabilities
allJoyn
