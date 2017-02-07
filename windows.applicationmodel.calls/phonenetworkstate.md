---
-api-id: T:Windows.ApplicationModel.Calls.PhoneNetworkState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Calls.PhoneNetworkState : int
-->

# PhoneNetworkState

## -description
Describes the network registration status of a phone line.

## -enum-fields
### -field Unknown:0
The registration status of the phone line is unknown.

### -field NoSignal:1
Could not detect a signal on the phone line, or the phone line is limited to emergency calls only.

### -field Deregistered:2
The phone line has been de-registered.

### -field Denied:3
Could not register the phone line with any available network.

### -field Searching:4
Searching for a network for the phone line.

### -field Home:5
The phone line is registered and is on the carrier's home network.

### -field RoamingInternational:6
The phone line is registered and is roaming internationally on another carrier's network.

### -field RoamingDomestic:7
The phone line is registered and is roaming domestically on another carrier's network.


## -remarks

## -examples

## -see-also