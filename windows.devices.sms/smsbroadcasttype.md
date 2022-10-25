---
-api-id: T:Windows.Devices.Sms.SmsBroadcastType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsBroadcastType : int
-->

# SmsBroadcastType

## -description
Values that describe the type of a broadcast (emergency alert) message.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field Other:0
An unknown broadcast type.

### -field CmasPresidential:1
A Commercial Mobile Alert System (CMAS) Presidential alert message.

### -field CmasExtreme:2
A CMAS Extreme alert message.

### -field CmasSevere:3
A CMAS Severe alert message.

### -field CmasAmber:4
A CMAS Amber alert message.

### -field CmasTest:5
A CMAS Test message.

### -field EUAlert1:6
An EU Alert 1 message.

### -field EUAlert2:7
An EU Alert 2 message.

### -field EUAlert3:8
An EU Alert 3 message.

### -field EUAlertAmber:9
An EU Amber Alert message.

### -field EUAlertInfo:10
An EU informational message.

### -field EtwsEarthquake:11
An Earthquake and Tsunami Warning System (ETWS) earthquake alert message.

### -field EtwsTsunami:12
An ETWS tsunami alert message.

### -field EtwsTsunamiAndEarthquake:13
An ETWS tsunami and earthquake alert message.

### -field LatAlertLocal:14
A local LAT alert broadcast message.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
