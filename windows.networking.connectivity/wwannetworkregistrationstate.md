---
-api-id: T:Windows.Networking.Connectivity.WwanNetworkRegistrationState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.WwanNetworkRegistrationState : int
-->

# WwanNetworkRegistrationState

## -description
Defines the network registration states for a WWAN connection.

## -enum-fields
### -field None:0
No networks found for this connection.

### -field Deregistered:1
The connection is not registered with a network.

### -field Searching:2
Searching for available networks.

### -field Home:3
The connection is registered with a home network.

### -field Roaming:4
The connection is registered with a roaming network.

### -field Partner:5
The connection is registered with a roaming network partner.

### -field Denied:6
Registration of the connection with all available networks is denied. However, emergency voice calls may still be made. This value applies only to voice connections, and not to data connections.


## -remarks

## -examples

## -see-also