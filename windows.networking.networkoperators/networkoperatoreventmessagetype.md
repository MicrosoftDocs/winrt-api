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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

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
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
