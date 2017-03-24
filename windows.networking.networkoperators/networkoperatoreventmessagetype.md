---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorEventMessageType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.NetworkOperatorEventMessageType : int
-->

# NetworkOperatorEventMessageType

## -description
Describes the type of a network operator notification message.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -enum-fields
### -field Gsm:0
The message type is GSM.

### -field Cdma:1
The message type is CDMA.

### -field Ussd:2
The message type is USSD.

### -field DataPlanThresholdReached:3
Data plan data threshold has been reached.

### -field DataPlanReset:4
Data plan has been reset.

### -field DataPlanDeleted:5
Data plan has been deleted.

### -field ProfileConnected:6
Profile connected to mobile operator.

### -field ProfileDisconnected:7
Profile disconnected from mobile operator.

### -field RegisteredRoaming:8
Mobile broadband device registered as roaming.

### -field RegisteredHome:9
Mobile broadband device registered as home.

### -field TetheringEntitlementCheck:10
Mobile broadband device can be used for tethering.

### -field TetheringOperationalStateChanged:11
Operational state of the device's tethering capability has changed.

### -field TetheringNumberOfClientsChanged:12
Number of clients currently using the tethering network has changed.


## -remarks

## -examples

## -see-also